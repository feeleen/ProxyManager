using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace ProxyManager
{
	public class SaveProfileDialog : Form
	{
		private ComboBox nameComboBox;
		private Button okButton;
		private Button cancelButton;
		private Label label;

		public string ProfileName => nameComboBox.Text;

		public SaveProfileDialog()
		{
			InitializeComponent();
			LoadExistingProfiles();
		}

		private void LoadExistingProfiles()
		{
			var profiles = ProfileManager.LoadProfiles();
			foreach (var profile in profiles.OrderBy(p => p.Name))
			{
				nameComboBox.Items.Add(profile.Name);
			}
		}

		private void InitializeComponent()
		{
			this.Text = "Save Profile";
			this.Size = new Size(350, 150);
			this.FormBorderStyle = FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.StartPosition = FormStartPosition.CenterParent;
			this.ShowInTaskbar = false;
			this.Load += SaveProfileDialog_Load;

			label = new Label
			{
				Text = "Profile name:",
				Location = new Point(15, 15),
				Size = new Size(300, 20),
				AutoSize = true
			};
			this.Controls.Add(label);

			nameComboBox = new ComboBox
			{
				Location = new Point(15, 40),
				Size = new Size(300, 25),
				DropDownStyle = ComboBoxStyle.DropDown,
				MaxLength = 50
			};
			nameComboBox.KeyDown += (s, e) =>
			{
				if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(nameComboBox.Text))
				{
					DialogResult = DialogResult.OK;
					Close();
				}
				else if (e.KeyCode == Keys.Escape)
				{
					DialogResult = DialogResult.Cancel;
					Close();
				}
			};
			this.Controls.Add(nameComboBox);

			okButton = new Button
			{
				Text = "OK",
				DialogResult = DialogResult.OK,
				Location = new Point(140, 75),
				Size = new Size(80, 28),
				FlatStyle = FlatStyle.Flat
			};
			okButton.Click += OkButton_Click;
			this.Controls.Add(okButton);

			cancelButton = new Button
			{
				Text = "Cancel",
				DialogResult = DialogResult.Cancel,
				Location = new Point(230, 75),
				Size = new Size(80, 28),
				FlatStyle = FlatStyle.Flat
			};
			cancelButton.Click += (s, e) => Close();
			this.Controls.Add(cancelButton);

			this.AcceptButton = okButton;
			this.CancelButton = cancelButton;
		}

		private void SaveProfileDialog_Load(object sender, EventArgs e)
		{
			nameComboBox.Focus();
		}

		private void OkButton_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(nameComboBox.Text))
			{
				MessageBox.Show(this, "Please enter a profile name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				nameComboBox.Focus();
				return;
			}

			if (ProfileManager.ProfileExists(nameComboBox.Text))
			{
				var result = MessageBox.Show(
					this,
					$"Profile \"{nameComboBox.Text}\" already exists. Overwrite?",
					"Confirm",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question);

				if (result != DialogResult.Yes)
				{
					nameComboBox.Focus();
					nameComboBox.SelectAll();
					return;
				}
			}

			DialogResult = DialogResult.OK;
			Close();
		}
	}
}
