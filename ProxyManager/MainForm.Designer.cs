namespace ProxyManager
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		#region Windows Form Designer generated code
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			tabControl = new TabControl();
			proxySettingsPage = new TabPage();
			proxySettingsLayoutPanel = new TableLayoutPanel();
			autoDetectBox = new CheckBox();
			useScriptBox = new CheckBox();
			scriptUrlBox = new TextBox();
			useProxyBox = new CheckBox();
			proxyAddressBox = new TextBox();
			bypassLabel = new Label();
			bypassBox = new TextBox();
			proxyLabel = new Label();
			scriptLabel = new Label();
			saveProfileButton = new Button();
			imageList1 = new ImageList(components);
			applyButton = new Button();
			refreshButton = new Button();
			testTabPage = new TabPage();
			testUrlBox = new TextBox();
			testButton = new Button();
			logBox = new TextBox();
			profilesTabPage = new TabPage();
			profilesListBox = new CheckedListBox();
			deleteProfilesButton = new Button();
			profilesLabel = new Label();
			menuStrip = new MenuStrip();
			fileMenuItem = new ToolStripMenuItem();
			openMenuItem = new ToolStripMenuItem();
			exitMenuItem = new ToolStripMenuItem();
			proxyMenuItem = new ToolStripMenuItem();
			useProxyMenuItem = new ToolStripMenuItem();
			profilesMenuItem = new ToolStripMenuItem();
			settingsMenuItem = new ToolStripMenuItem();
			runAtStartupMenuItem = new ToolStripMenuItem();
			helpMenuItem = new ToolStripMenuItem();
			notifyIcon = new NotifyIcon(components);
			trayMenu = new ContextMenuStrip(components);
			tabControl.SuspendLayout();
			proxySettingsPage.SuspendLayout();
			proxySettingsLayoutPanel.SuspendLayout();
			testTabPage.SuspendLayout();
			profilesTabPage.SuspendLayout();
			menuStrip.SuspendLayout();
			SuspendLayout();
			// 
			// tabControl
			// 
			tabControl.Controls.Add(proxySettingsPage);
			tabControl.Controls.Add(testTabPage);
			tabControl.Controls.Add(profilesTabPage);
			tabControl.Dock = DockStyle.Fill;
			tabControl.Location = new Point(0, 24);
			tabControl.Name = "tabControl";
			tabControl.SelectedIndex = 0;
			tabControl.Size = new Size(600, 456);
			tabControl.TabIndex = 0;
			// 
			// proxySettingsPage
			// 
			proxySettingsPage.Controls.Add(proxySettingsLayoutPanel);
			proxySettingsPage.Location = new Point(4, 24);
			proxySettingsPage.Name = "proxySettingsPage";
			proxySettingsPage.Padding = new Padding(15);
			proxySettingsPage.Size = new Size(592, 428);
			proxySettingsPage.TabIndex = 0;
			proxySettingsPage.Text = "Proxy Settings";
			proxySettingsPage.UseVisualStyleBackColor = true;
			// 
			// proxySettingsLayoutPanel
			// 
			proxySettingsLayoutPanel.AutoSize = true;
			proxySettingsLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			proxySettingsLayoutPanel.ColumnCount = 2;
			proxySettingsLayoutPanel.ColumnStyles.Add(new ColumnStyle());
			proxySettingsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			proxySettingsLayoutPanel.Controls.Add(autoDetectBox, 0, 0);
			proxySettingsLayoutPanel.Controls.Add(useScriptBox, 0, 1);
			proxySettingsLayoutPanel.Controls.Add(scriptUrlBox, 1, 2);
			proxySettingsLayoutPanel.Controls.Add(useProxyBox, 0, 3);
			proxySettingsLayoutPanel.Controls.Add(proxyAddressBox, 1, 4);
			proxySettingsLayoutPanel.Controls.Add(bypassLabel, 0, 5);
			proxySettingsLayoutPanel.Controls.Add(bypassBox, 1, 5);
			proxySettingsLayoutPanel.Controls.Add(proxyLabel, 0, 4);
			proxySettingsLayoutPanel.Controls.Add(scriptLabel, 0, 2);
			proxySettingsLayoutPanel.Controls.Add(saveProfileButton, 1, 7);
			proxySettingsLayoutPanel.Controls.Add(applyButton, 1, 6);
			proxySettingsLayoutPanel.Controls.Add(refreshButton, 1, 8);
			proxySettingsLayoutPanel.Dock = DockStyle.Fill;
			proxySettingsLayoutPanel.Location = new Point(15, 15);
			proxySettingsLayoutPanel.Name = "proxySettingsLayoutPanel";
			proxySettingsLayoutPanel.RowCount = 10;
			proxySettingsLayoutPanel.RowStyles.Add(new RowStyle());
			proxySettingsLayoutPanel.RowStyles.Add(new RowStyle());
			proxySettingsLayoutPanel.RowStyles.Add(new RowStyle());
			proxySettingsLayoutPanel.RowStyles.Add(new RowStyle());
			proxySettingsLayoutPanel.RowStyles.Add(new RowStyle());
			proxySettingsLayoutPanel.RowStyles.Add(new RowStyle());
			proxySettingsLayoutPanel.RowStyles.Add(new RowStyle());
			proxySettingsLayoutPanel.RowStyles.Add(new RowStyle());
			proxySettingsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			proxySettingsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 137F));
			proxySettingsLayoutPanel.Size = new Size(562, 398);
			proxySettingsLayoutPanel.TabIndex = 0;
			// 
			// autoDetectBox
			// 
			autoDetectBox.AutoSize = true;
			autoDetectBox.FlatStyle = FlatStyle.Flat;
			autoDetectBox.Location = new Point(3, 3);
			autoDetectBox.Name = "autoDetectBox";
			autoDetectBox.Size = new Size(177, 19);
			autoDetectBox.TabIndex = 0;
			autoDetectBox.Text = "Automatically detect settings";
			autoDetectBox.UseVisualStyleBackColor = true;
			// 
			// useScriptBox
			// 
			useScriptBox.AutoSize = true;
			useScriptBox.FlatStyle = FlatStyle.Flat;
			useScriptBox.Location = new Point(3, 28);
			useScriptBox.Name = "useScriptBox";
			useScriptBox.Size = new Size(239, 19);
			useScriptBox.TabIndex = 1;
			useScriptBox.Text = "Use automatic configuration script (PAC)";
			useScriptBox.UseVisualStyleBackColor = true;
			// 
			// scriptUrlBox
			// 
			scriptUrlBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			scriptUrlBox.BorderStyle = BorderStyle.FixedSingle;
			scriptUrlBox.Location = new Point(248, 53);
			scriptUrlBox.Name = "scriptUrlBox";
			scriptUrlBox.Size = new Size(311, 23);
			scriptUrlBox.TabIndex = 3;
			// 
			// useProxyBox
			// 
			useProxyBox.AutoSize = true;
			useProxyBox.FlatStyle = FlatStyle.Flat;
			useProxyBox.Location = new Point(3, 82);
			useProxyBox.Name = "useProxyBox";
			useProxyBox.Size = new Size(188, 19);
			useProxyBox.TabIndex = 4;
			useProxyBox.Text = "Use a proxy server for your LAN";
			useProxyBox.UseVisualStyleBackColor = true;
			// 
			// proxyAddressBox
			// 
			proxyAddressBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			proxyAddressBox.BorderStyle = BorderStyle.FixedSingle;
			proxyAddressBox.Location = new Point(248, 107);
			proxyAddressBox.Name = "proxyAddressBox";
			proxyAddressBox.Size = new Size(311, 23);
			proxyAddressBox.TabIndex = 6;
			// 
			// bypassLabel
			// 
			bypassLabel.AutoSize = true;
			bypassLabel.Dock = DockStyle.Fill;
			bypassLabel.Location = new Point(20, 133);
			bypassLabel.Margin = new Padding(20, 0, 0, 0);
			bypassLabel.Name = "bypassLabel";
			bypassLabel.Size = new Size(225, 29);
			bypassLabel.TabIndex = 7;
			bypassLabel.Text = "Bypass proxy for:";
			bypassLabel.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// bypassBox
			// 
			bypassBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			bypassBox.BorderStyle = BorderStyle.FixedSingle;
			bypassBox.Location = new Point(248, 136);
			bypassBox.Name = "bypassBox";
			bypassBox.Size = new Size(311, 23);
			bypassBox.TabIndex = 8;
			// 
			// proxyLabel
			// 
			proxyLabel.AutoSize = true;
			proxyLabel.Dock = DockStyle.Fill;
			proxyLabel.Location = new Point(20, 104);
			proxyLabel.Margin = new Padding(20, 0, 0, 0);
			proxyLabel.Name = "proxyLabel";
			proxyLabel.Size = new Size(225, 29);
			proxyLabel.TabIndex = 5;
			proxyLabel.Text = "Address:";
			proxyLabel.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// scriptLabel
			// 
			scriptLabel.AutoSize = true;
			scriptLabel.Dock = DockStyle.Fill;
			scriptLabel.Location = new Point(20, 50);
			scriptLabel.Margin = new Padding(20, 0, 0, 0);
			scriptLabel.Name = "scriptLabel";
			scriptLabel.Size = new Size(225, 29);
			scriptLabel.TabIndex = 2;
			scriptLabel.Text = "Script address:";
			scriptLabel.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// saveProfileButton
			// 
			saveProfileButton.Dock = DockStyle.Fill;
			saveProfileButton.FlatStyle = FlatStyle.Flat;
			saveProfileButton.ImageAlign = ContentAlignment.MiddleLeft;
			saveProfileButton.ImageIndex = 1;
			saveProfileButton.ImageList = imageList1;
			saveProfileButton.Location = new Point(248, 197);
			saveProfileButton.Name = "saveProfileButton";
			saveProfileButton.Size = new Size(311, 26);
			saveProfileButton.TabIndex = 11;
			saveProfileButton.Text = "Save Profile";
			saveProfileButton.UseVisualStyleBackColor = true;
			saveProfileButton.Click += SaveProfileButton_Click;
			// 
			// imageList1
			// 
			imageList1.ColorDepth = ColorDepth.Depth32Bit;
			imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
			imageList1.TransparentColor = Color.Transparent;
			imageList1.Images.SetKeyName(0, "Refresh.png");
			imageList1.Images.SetKeyName(1, "Save.png");
			imageList1.Images.SetKeyName(2, "SaveProfile.png");
			// 
			// applyButton
			// 
			applyButton.Dock = DockStyle.Fill;
			applyButton.FlatStyle = FlatStyle.Flat;
			applyButton.ImageAlign = ContentAlignment.MiddleLeft;
			applyButton.ImageKey = "SaveProfile.png";
			applyButton.ImageList = imageList1;
			applyButton.Location = new Point(248, 165);
			applyButton.Name = "applyButton";
			applyButton.Size = new Size(311, 26);
			applyButton.TabIndex = 9;
			applyButton.Text = "Apply";
			applyButton.UseVisualStyleBackColor = true;
			applyButton.Click += ApplyButton_Click;
			// 
			// refreshButton
			// 
			refreshButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			refreshButton.FlatStyle = FlatStyle.Flat;
			refreshButton.ImageAlign = ContentAlignment.MiddleLeft;
			refreshButton.ImageIndex = 0;
			refreshButton.ImageList = imageList1;
			refreshButton.Location = new Point(248, 229);
			refreshButton.Name = "refreshButton";
			refreshButton.Size = new Size(311, 29);
			refreshButton.TabIndex = 10;
			refreshButton.Text = "Refresh";
			refreshButton.UseVisualStyleBackColor = true;
			refreshButton.Click += RefreshButton_Click;
			// 
			// testTabPage
			// 
			testTabPage.Controls.Add(testUrlBox);
			testTabPage.Controls.Add(testButton);
			testTabPage.Controls.Add(logBox);
			testTabPage.Location = new Point(4, 24);
			testTabPage.Name = "testTabPage";
			testTabPage.Padding = new Padding(15);
			testTabPage.Size = new Size(592, 428);
			testTabPage.TabIndex = 1;
			testTabPage.Text = "Test Proxy";
			testTabPage.UseVisualStyleBackColor = true;
			// 
			// testUrlBox
			// 
			testUrlBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			testUrlBox.BorderStyle = BorderStyle.FixedSingle;
			testUrlBox.Location = new Point(18, 18);
			testUrlBox.Name = "testUrlBox";
			testUrlBox.Size = new Size(458, 23);
			testUrlBox.TabIndex = 0;
			testUrlBox.Text = "https://httpbin.org/get";
			// 
			// testButton
			// 
			testButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			testButton.FlatStyle = FlatStyle.Flat;
			testButton.Location = new Point(482, 17);
			testButton.Name = "testButton";
			testButton.Size = new Size(102, 26);
			testButton.TabIndex = 1;
			testButton.Text = "Test";
			testButton.UseVisualStyleBackColor = true;
			testButton.Click += TestButton_Click;
			// 
			// logBox
			// 
			logBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			logBox.BorderStyle = BorderStyle.FixedSingle;
			logBox.Font = new Font("Courier New", 8F);
			logBox.Location = new Point(18, 53);
			logBox.Multiline = true;
			logBox.Name = "logBox";
			logBox.ReadOnly = true;
			logBox.ScrollBars = ScrollBars.Both;
			logBox.Size = new Size(566, 367);
			logBox.TabIndex = 2;
			// 
			// profilesTabPage
			// 
			profilesTabPage.Controls.Add(profilesListBox);
			profilesTabPage.Controls.Add(deleteProfilesButton);
			profilesTabPage.Controls.Add(profilesLabel);
			profilesTabPage.Location = new Point(4, 24);
			profilesTabPage.Name = "profilesTabPage";
			profilesTabPage.Padding = new Padding(15);
			profilesTabPage.Size = new Size(592, 428);
			profilesTabPage.TabIndex = 2;
			profilesTabPage.Text = "Profiles";
			profilesTabPage.UseVisualStyleBackColor = true;
			// 
			// profilesListBox
			// 
			profilesListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			profilesListBox.CheckOnClick = true;
			profilesListBox.Font = new Font("Segoe UI", 9F);
			profilesListBox.FormattingEnabled = true;
			profilesListBox.Location = new Point(18, 50);
			profilesListBox.Name = "profilesListBox";
			profilesListBox.Size = new Size(556, 328);
			profilesListBox.TabIndex = 0;
			// 
			// deleteProfilesButton
			// 
			deleteProfilesButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			deleteProfilesButton.FlatStyle = FlatStyle.Flat;
			deleteProfilesButton.Location = new Point(474, 386);
			deleteProfilesButton.Name = "deleteProfilesButton";
			deleteProfilesButton.Size = new Size(100, 28);
			deleteProfilesButton.TabIndex = 2;
			deleteProfilesButton.Text = "Delete";
			deleteProfilesButton.UseVisualStyleBackColor = true;
			deleteProfilesButton.Click += DeleteProfilesButton_Click;
			// 
			// profilesLabel
			// 
			profilesLabel.AutoSize = true;
			profilesLabel.Location = new Point(18, 20);
			profilesLabel.Name = "profilesLabel";
			profilesLabel.Size = new Size(132, 15);
			profilesLabel.TabIndex = 1;
			profilesLabel.Text = "Select profiles to delete:";
			// 
			// menuStrip
			// 
			menuStrip.Items.AddRange(new ToolStripItem[] { fileMenuItem, proxyMenuItem, profilesMenuItem, settingsMenuItem, helpMenuItem });
			menuStrip.Location = new Point(0, 0);
			menuStrip.Name = "menuStrip";
			menuStrip.Size = new Size(600, 24);
			menuStrip.TabIndex = 1;
			menuStrip.Text = "menuStrip";
			// 
			// fileMenuItem
			// 
			fileMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openMenuItem, exitMenuItem });
			fileMenuItem.Name = "fileMenuItem";
			fileMenuItem.Size = new Size(37, 20);
			fileMenuItem.Text = "File";
			// 
			// openMenuItem
			// 
			openMenuItem.Name = "openMenuItem";
			openMenuItem.Size = new Size(103, 22);
			openMenuItem.Text = "Open";
			openMenuItem.Click += OpenMenuItem_Click;
			// 
			// exitMenuItem
			// 
			exitMenuItem.Name = "exitMenuItem";
			exitMenuItem.Size = new Size(103, 22);
			exitMenuItem.Text = "Exit";
			exitMenuItem.Click += ExitMenuItem_Click;
			// 
			// proxyMenuItem
			// 
			proxyMenuItem.DropDownItems.AddRange(new ToolStripItem[] { useProxyMenuItem });
			proxyMenuItem.Name = "proxyMenuItem";
			proxyMenuItem.Size = new Size(48, 20);
			proxyMenuItem.Text = "Proxy";
			// 
			// useProxyMenuItem
			// 
			useProxyMenuItem.CheckOnClick = true;
			useProxyMenuItem.Name = "useProxyMenuItem";
			useProxyMenuItem.Size = new Size(159, 22);
			useProxyMenuItem.Text = "Use proxy server";
			useProxyMenuItem.Click += UseProxyMenuItem_Click;
			// 
			// profilesMenuItem
			// 
			profilesMenuItem.Name = "profilesMenuItem";
			profilesMenuItem.Size = new Size(58, 20);
			profilesMenuItem.Text = "Profiles";
			// 
			// settingsMenuItem
			// 
			settingsMenuItem.DropDownItems.AddRange(new ToolStripItem[] { runAtStartupMenuItem });
			settingsMenuItem.Name = "settingsMenuItem";
			settingsMenuItem.Size = new Size(61, 20);
			settingsMenuItem.Text = "Settings";
			// 
			// runAtStartupMenuItem
			// 
			runAtStartupMenuItem.CheckOnClick = true;
			runAtStartupMenuItem.Name = "runAtStartupMenuItem";
			runAtStartupMenuItem.Size = new Size(148, 22);
			runAtStartupMenuItem.Text = "Run at startup";
			runAtStartupMenuItem.Click += RunAtStartupMenuItem_Click;
			// 
			// helpMenuItem
			// 
			helpMenuItem.Name = "helpMenuItem";
			helpMenuItem.Size = new Size(44, 20);
			helpMenuItem.Text = "Help";
			// 
			// notifyIcon
			// 
			notifyIcon.ContextMenuStrip = trayMenu;
			notifyIcon.Icon = Properties.Resources.globe;
			notifyIcon.Text = "Proxy Manager";
			notifyIcon.Visible = true;
			notifyIcon.DoubleClick += NotifyIcon_DoubleClick;
			// 
			// trayMenu
			// 
			trayMenu.ImageScalingSize = new Size(20, 20);
			trayMenu.Name = "trayMenu";
			trayMenu.Size = new Size(61, 4);
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Control;
			ClientSize = new Size(600, 480);
			Controls.Add(tabControl);
			Controls.Add(menuStrip);
			Icon = Properties.Resources.globe;
			MainMenuStrip = menuStrip;
			MinimumSize = new Size(400, 350);
			Name = "MainForm";
			SizeGripStyle = SizeGripStyle.Show;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Proxy Manager";
			FormClosing += MainForm_FormClosing;
			tabControl.ResumeLayout(false);
			proxySettingsPage.ResumeLayout(false);
			proxySettingsPage.PerformLayout();
			proxySettingsLayoutPanel.ResumeLayout(false);
			proxySettingsLayoutPanel.PerformLayout();
			testTabPage.ResumeLayout(false);
			testTabPage.PerformLayout();
			profilesTabPage.ResumeLayout(false);
			profilesTabPage.PerformLayout();
			menuStrip.ResumeLayout(false);
			menuStrip.PerformLayout();
			ResumeLayout(false);
			PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage proxySettingsPage;
		private System.Windows.Forms.TabPage testTabPage;
		private System.Windows.Forms.CheckBox autoDetectBox;
		private System.Windows.Forms.CheckBox useScriptBox;
		private System.Windows.Forms.TextBox scriptUrlBox;
		private System.Windows.Forms.CheckBox useProxyBox;
		private System.Windows.Forms.TextBox proxyAddressBox;
		private System.Windows.Forms.TextBox bypassBox;
		private System.Windows.Forms.Button applyButton;
		private System.Windows.Forms.Button refreshButton;
		private System.Windows.Forms.Button saveProfileButton;
		private System.Windows.Forms.TextBox testUrlBox;
		private System.Windows.Forms.Button testButton;
		private System.Windows.Forms.TextBox logBox;
		private System.Windows.Forms.Label scriptLabel;
		private System.Windows.Forms.Label proxyLabel;
		private System.Windows.Forms.Label bypassLabel;
		private System.Windows.Forms.TableLayoutPanel proxySettingsLayoutPanel;
		private System.Windows.Forms.TabPage profilesTabPage;
		private System.Windows.Forms.CheckedListBox profilesListBox;
		private System.Windows.Forms.Button deleteProfilesButton;
		private System.Windows.Forms.Label profilesLabel;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
		private System.Windows.Forms.ToolStripMenuItem proxyMenuItem;
		private System.Windows.Forms.ToolStripMenuItem useProxyMenuItem;
		private System.Windows.Forms.ToolStripMenuItem profilesMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsMenuItem;
		private System.Windows.Forms.ToolStripMenuItem runAtStartupMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.ContextMenuStrip trayMenu;
		private System.Windows.Forms.ToolStripMenuItem trayProxyToggleItem;
		private System.Windows.Forms.ToolStripMenuItem trayProfilesMenuItem;
		private ImageList imageList1;
	}
}
