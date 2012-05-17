using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1 {
	public partial class yAvGrabber : Form {
		string ID = "";
		string pth = Application.StartupPath;

		public yAvGrabber() {
			InitializeComponent();
		}
		
		private void btnGrab_Click(object sender, EventArgs e) {
			ID = IDBox.Text;
			ID = ID.ToLower();
			if (Regex.IsMatch(ID, @"^[a-z][a-z0-9_]*(([_]*)|[\.]{0,1})[a-z0-9]*$") && ID.Length >= 4 && ID.Length <= 32) {//@"^[a-z][a-z0-9]*(([_]*)|[\.]{0,1})[a-z0-9]*$"
				try {
					WebClient Client = new WebClient();
					Stream stream = Client.OpenRead("http://img.msg.yahoo.com/avatar.php?yids=" + ID);
					avBox.Image = new Bitmap(stream);

					stsLabel.Text = ID + "'s avatar was grabbed!";
					this.Width = 328;
					this.Text = "Yahoo AvGrabber";
					btnSave.Enabled = true;
				}
				catch (Exception ex) {
					MessageBox.Show(ex.Message);
				}
			}
			else {
				stsLabel.Text = "ID entered must be valid!";
			}	

		}

		private void btnSave_Click(object sender, EventArgs e) {
			try {
				avBox.Image.Save(ID + ".png", System.Drawing.Imaging.ImageFormat.Png);

				stsLabel.Text = ID + "'s avatar was saved in\ncurrent directory with ID's name.";
				this.Width = 198;
				this.Text = "AvGrabber";
				btnSave.Enabled = false;
			}
			catch (Exception save) {
				MessageBox.Show(save.Message);
			}
		}

		private void yAvGrabber_Load(object sender, EventArgs e) {
			btnSave.Enabled = false;
			stsLabel.Text = "";
			IDBox.Focus();
		}

		private void IDBox_KeyDown(object sender, KeyPressEventArgs e) {
			if (e.KeyChar == '\r') {
				ID = IDBox.Text;
				btnGrab_Click(sender, e);
			}
		}

		private void crightInfo_Clicked(object sender, LinkLabelLinkClickedEventArgs e) {
		}

		private void av_Click(object sender, EventArgs e) {
			this.Width = 198;
			this.Text = "AvGrabber";
			btnSave.Enabled = false;
			IDBox.Text = "";
			stsLabel.Text = "";
		}
	}
}
