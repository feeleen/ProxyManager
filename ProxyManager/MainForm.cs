namespace ProxyManager
{
	using Microsoft.Win32;
	using System;
	using System.Drawing;
	using System.Net;
	using System.Net.Http;
	using System.Threading.Tasks;
	using System.Windows.Forms;

	public partial class MainForm : Form
	{
		private HttpClient httpClient;

		public MainForm()
		{
			InitializeComponent();
			InitializeTray();
			LoadProxySettings();
			SetupHttpClient();
			LoadProfilesList();
			UpdateRunAtStartupMenu();
		}

		private void ApplyButton_Click(object sender, EventArgs e)
		{
			ApplyProxySettings();
			MessageBox.Show("Settings applied.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void ApplyProxySettings()
		{
			try
			{
				var reg = Registry.CurrentUser.OpenSubKey(
					@"Software\Microsoft\Windows\CurrentVersion\Internet Settings", true);
				reg.SetValue("AutoDetect", autoDetectBox.Checked ? 1 : 0, RegistryValueKind.DWord);
				reg.SetValue("AutoConfigURL", useScriptBox.Checked ? scriptUrlBox.Text : "", RegistryValueKind.String);
				reg.SetValue("ProxyEnable", useProxyBox.Checked ? 1 : 0, RegistryValueKind.DWord);
				reg.SetValue("ProxyServer", proxyAddressBox.Text, RegistryValueKind.String);
				reg.SetValue("ProxyOverride", bypassBox.Text, RegistryValueKind.String);

				InternetSetOption(IntPtr.Zero, 39, IntPtr.Zero, 0);
				InternetSetOption(IntPtr.Zero, 37, IntPtr.Zero, 0);
				ResetSettingsPageVisibility();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public static void ResetSettingsPageVisibility()
		{
			using (var key = Registry.LocalMachine.OpenSubKey(
				@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer",
				writable: true))
			{
				key?.SetValue("SettingsPageVisibility", "", RegistryValueKind.String);
			}

			using (var key = Registry.CurrentUser.OpenSubKey(
				@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer",
				writable: true))
			{
				key?.SetValue("SettingsPageVisibility", "", RegistryValueKind.String);
			}
		}

		private void RefreshButton_Click(object sender, EventArgs e)
		{
			LoadProxySettings();
		}

		private void SaveProfileButton_Click(object sender, EventArgs e)
		{
			using (var dialog = new SaveProfileDialog())
			{
				if (dialog.ShowDialog(this) == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.ProfileName))
				{
					var profile = new ProxyProfile(dialog.ProfileName)
					{
						AutoDetect = autoDetectBox.Checked,
						UseScript = useScriptBox.Checked,
						ScriptUrl = scriptUrlBox.Text,
						UseProxy = useProxyBox.Checked,
						ProxyAddress = proxyAddressBox.Text,
						BypassList = bypassBox.Text
					};

					ProfileManager.SaveProfile(profile);
					LoadProfilesList();
					UpdateTrayProfilesMenu();
					MessageBox.Show($"Profile \"{dialog.ProfileName}\" saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}

		private async void TestButton_Click(object sender, EventArgs e)
		{
			logBox.Clear();
			logBox.AppendText("→ Sending request...\r\n");
			try
			{
				var response = await httpClient.GetAsync(testUrlBox.Text);
				var content = await response.Content.ReadAsStringAsync();
				logBox.AppendText($"✓ Success! Status: {response.StatusCode}\r\n");
				logBox.AppendText("Response:\r\n");
				logBox.AppendText(content);
			}
			catch (Exception ex)
			{
				logBox.AppendText($"✗ Error: {ex.Message}\r\n");
			}
		}

		private void LoadProxySettings()
		{
			try
			{
				var reg = Registry.CurrentUser.OpenSubKey(
					@"Software\Microsoft\Windows\CurrentVersion\Internet Settings");
				if (reg == null) return;

				autoDetectBox.Checked = (reg.GetValue("AutoDetect") as int?) == 1;
				var script = reg.GetValue("AutoConfigURL") as string;
				useScriptBox.Checked = !string.IsNullOrEmpty(script);
				scriptUrlBox.Text = script ?? "";
				useProxyBox.Checked = (reg.GetValue("ProxyEnable") as int?) == 1;
				proxyAddressBox.Text = reg.GetValue("ProxyServer") as string ?? "";
				bypassBox.Text = reg.GetValue("ProxyOverride") as string ?? "";

				UpdateTrayProxyToggle();
			}
			catch { }
		}

		private void SetupHttpClient()
		{
			var handler = new HttpClientHandler
			{
				UseProxy = true,
				Proxy = WebRequest.GetSystemWebProxy()
			};
			httpClient = new HttpClient(handler);
		}

		private void InitializeTray()
		{
			var openItem = new ToolStripMenuItem("Open", null, (s, e) => ShowAndActivate());

			// Proxy toggle
			trayProxyToggleItem = new ToolStripMenuItem("Use proxy server", null, TrayProxyToggle_Click);
			trayProxyToggleItem.CheckOnClick = true;

			// Profiles menu
			trayProfilesMenuItem = new ToolStripMenuItem("Profiles");

			var exitItem = new ToolStripMenuItem("Exit", null, (s, e) => Application.Exit());

			trayMenu.Items.Add(openItem);
			trayMenu.Items.Add(trayProxyToggleItem);
			trayMenu.Items.Add(trayProfilesMenuItem);
			trayMenu.Items.Add(exitItem);

			notifyIcon.Icon = Properties.Resources.globe;
			notifyIcon.Text = "Proxy Manager";
			notifyIcon.Visible = true;
			notifyIcon.ContextMenuStrip = trayMenu;
			notifyIcon.DoubleClick += (s, e) => ShowAndActivate();

			UpdateTrayProfilesMenu();
		}

		private void TrayProxyToggle_Click(object sender, EventArgs e)
		{
			useProxyBox.Checked = trayProxyToggleItem.Checked;
			useProxyMenuItem.Checked = trayProxyToggleItem.Checked;
			ApplyProxySettings();
		}

		private void UseProxyMenuItem_Click(object sender, EventArgs e)
		{
			useProxyBox.Checked = useProxyMenuItem.Checked;
			trayProxyToggleItem.Checked = useProxyMenuItem.Checked;
			ApplyProxySettings();
		}

		private void UpdateTrayProxyToggle()
		{
			if (trayProxyToggleItem != null)
			{
				trayProxyToggleItem.Checked = useProxyBox.Checked;
			}
			if (useProxyMenuItem != null)
			{
				useProxyMenuItem.Checked = useProxyBox.Checked;
			}
		}

		private void UpdateTrayProfilesMenu()
		{
			// Update tray profiles menu
			trayProfilesMenuItem.DropDownItems.Clear();
			var profiles = ProfileManager.LoadProfiles();

			if (profiles.Count == 0)
			{
				var emptyItem = new ToolStripMenuItem("(no profiles)");
				emptyItem.Enabled = false;
				trayProfilesMenuItem.DropDownItems.Add(emptyItem);
				return;
			}

			foreach (var profile in profiles)
			{
				var item = new ToolStripMenuItem(profile.Name);
				item.Click += (s, e) => LoadProfile(profile.Name);
				trayProfilesMenuItem.DropDownItems.Add(item);
			}

			// Update main menu profiles
			profilesMenuItem.DropDownItems.Clear();
			foreach (var profile in profiles)
			{
				var item = new ToolStripMenuItem(profile.Name);
				item.Click += (s, e) => LoadProfile(profile.Name);
				profilesMenuItem.DropDownItems.Add(item);
			}
		}

		private void LoadProfile(string name)
		{
			var profiles = ProfileManager.LoadProfiles();
			var profile = profiles.Find(p => p.Name == name);
			if (profile == null)
			{
				MessageBox.Show($"Profile \"{name}\" not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			autoDetectBox.Checked = profile.AutoDetect;
			useScriptBox.Checked = profile.UseScript;
			scriptUrlBox.Text = profile.ScriptUrl;
			useProxyBox.Checked = profile.UseProxy;
			proxyAddressBox.Text = profile.ProxyAddress;
			bypassBox.Text = profile.BypassList;

			ApplyProxySettings();
			MessageBox.Show($"Profile \"{name}\" loaded and applied.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void LoadProfilesList()
		{
			profilesListBox.Items.Clear();
			var profiles = ProfileManager.LoadProfiles();
			foreach (var profile in profiles)
			{
				profilesListBox.Items.Add(profile.Name, false);
			}
		}

		private void DeleteProfilesButton_Click(object sender, EventArgs e)
		{
			var selectedNames = new System.Collections.Generic.List<string>();
			foreach (var item in profilesListBox.CheckedItems)
			{
				selectedNames.Add(item.ToString() ?? string.Empty);
			}

			if (selectedNames.Count == 0)
			{
				MessageBox.Show("Select profiles to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			var result = MessageBox.Show(
				$"Delete selected profiles ({selectedNames.Count})?",
				"Confirm",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				ProfileManager.DeleteProfiles(selectedNames);
				LoadProfilesList();
				UpdateTrayProfilesMenu();
				MessageBox.Show("Profiles deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void RunAtStartupMenuItem_Click(object sender, EventArgs e)
		{
			SetRunAtStartup(runAtStartupMenuItem.Checked);
		}

		private void SetRunAtStartup(bool enable)
		{
			try
			{
				var key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
				if (key == null) return;

				if (enable)
				{
					key.SetValue("ProxyManager", Application.ExecutablePath);
				}
				else
				{
					key.DeleteValue("ProxyManager", false);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				runAtStartupMenuItem.Checked = !runAtStartupMenuItem.Checked;
			}
		}

		private void UpdateRunAtStartupMenu()
		{
			try
			{
				var key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", false);
				if (key == null) return;

				var value = key.GetValue("ProxyManager") as string;
				runAtStartupMenuItem.Checked = value != null && value == Application.ExecutablePath;
			}
			catch
			{
				runAtStartupMenuItem.Checked = false;
			}
		}

		private void ShowAndActivate()
		{
			this.Show();
			this.WindowState = FormWindowState.Normal;
			this.Activate();
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				e.Cancel = true;
				this.Hide();
			}
		}

		private void NotifyIcon_DoubleClick(object sender, EventArgs e)
		{
			ShowAndActivate();
		}

		private void OpenMenuItem_Click(object sender, EventArgs e)
		{
			ShowAndActivate();
		}

		private void ExitMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				notifyIcon?.Dispose();
				httpClient?.Dispose();
			}
			base.Dispose(disposing);
		}

		[System.Runtime.InteropServices.DllImport("wininet.dll")]
		private static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int lpdwBufferLength);
	}
}
