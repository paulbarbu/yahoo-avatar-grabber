namespace WindowsFormsApplication1 {
	partial class yAvGrabber {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yAvGrabber));
			this.btnSave = new System.Windows.Forms.Button();
			this.avBox = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.copyright = new System.Windows.Forms.LinkLabel();
			this.id = new System.Windows.Forms.Label();
			this.IDBox = new System.Windows.Forms.TextBox();
			this.stsLabel = new System.Windows.Forms.Label();
			this.resetTip = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.avBox)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(102, 90);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(68, 34);
			this.btnSave.TabIndex = 0;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// avBox
			// 
			this.avBox.BackColor = System.Drawing.SystemColors.Control;
			this.avBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("avBox.BackgroundImage")));
			this.avBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("avBox.ErrorImage")));
			this.avBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("avBox.InitialImage")));
			this.avBox.Location = new System.Drawing.Point(205, 16);
			this.avBox.Name = "avBox";
			this.avBox.Size = new System.Drawing.Size(95, 95);
			this.avBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.avBox.TabIndex = 1;
			this.avBox.TabStop = false;
			this.resetTip.SetToolTip(this.avBox, "Reset");
			this.avBox.Click += new System.EventHandler(this.av_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 90);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(68, 34);
			this.button1.TabIndex = 0;
			this.button1.Text = "Grab";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.btnGrab_Click);
			// 
			// copyright
			// 
			this.copyright.ActiveLinkColor = System.Drawing.Color.SlateGray;
			this.copyright.AutoSize = true;
			this.copyright.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.copyright.Location = new System.Drawing.Point(12, 127);
			this.copyright.Name = "copyright";
			this.copyright.Size = new System.Drawing.Size(155, 13);
			this.copyright.TabIndex = 2;
			this.copyright.TabStop = true;
			this.copyright.Text = "";
			this.copyright.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.copyright.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.crightInfo_Clicked);
			// 
			// id
			// 
			this.id.AutoSize = true;
			this.id.Location = new System.Drawing.Point(9, 9);
			this.id.Name = "id";
			this.id.Size = new System.Drawing.Size(108, 13);
			this.id.TabIndex = 3;
			this.id.Text = "Enter ID for grabbing:";
			// 
			// IDBox
			// 
			this.IDBox.Location = new System.Drawing.Point(12, 24);
			this.IDBox.Name = "IDBox";
			this.IDBox.Size = new System.Drawing.Size(158, 20);
			this.IDBox.TabIndex = 6;
			this.IDBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDBox_KeyDown);
			// 
			// stsLabel
			// 
			this.stsLabel.AutoSize = true;
			this.stsLabel.Location = new System.Drawing.Point(12, 47);
			this.stsLabel.Name = "stsLabel";
			this.stsLabel.Size = new System.Drawing.Size(35, 13);
			this.stsLabel.TabIndex = 7;
			this.stsLabel.Text = "label1";
			// 
			// yAvGrabber
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(188, 139);
			this.Controls.Add(this.stsLabel);
			this.Controls.Add(this.IDBox);
			this.Controls.Add(this.id);
			this.Controls.Add(this.copyright);
			this.Controls.Add(this.avBox);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnSave);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "yAvGrabber";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AvGrabber";
			this.Load += new System.EventHandler(this.yAvGrabber_Load);
			((System.ComponentModel.ISupportInitialize)(this.avBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.PictureBox avBox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.LinkLabel copyright;
		private System.Windows.Forms.Label id;
		private System.Windows.Forms.TextBox IDBox;
		private System.Windows.Forms.Label stsLabel;
		private System.Windows.Forms.ToolTip resetTip;
	}
}

