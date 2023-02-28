namespace ModPubg
{
	// Token: 0x02000017 RID: 23
	public partial class mainForm : global::System.Windows.Forms.Form
	{
		// Token: 0x060000A8 RID: 168 RVA: 0x00004E5C File Offset: 0x0000305C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00004E8C File Offset: 0x0000308C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ModPubg.mainForm));
			this.guna2Panel1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.otherPanelButton = new global::Guna.UI2.WinForms.Guna2Button();
			this.infoModbyHaNguyen = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.guna2PictureBox1 = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.backpackPanelButton = new global::Guna.UI2.WinForms.Guna2Button();
			this.weaponPanelButton = new global::Guna.UI2.WinForms.Guna2Button();
			this.setPanelButton = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2DragControl4 = new global::Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.guna2DragControl5 = new global::Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.weaponPanel1 = new global::ModPubg.Controls.weaponPanel();
			this.guna2Elipse1 = new global::Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.guna2DragControl1 = new global::Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.guna2DragControl2 = new global::Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.backpackPanel1 = new global::ModPubg.Controls.backpackPanel();
			this.guna2DragControl3 = new global::Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.setPanel1 = new global::ModPubg.List_Panel.setPanel();
			this.others1 = new global::ModPubg.fControls.others();
			this.guna2ControlBox1 = new global::Guna.UI2.WinForms.Guna2ControlBox();
			this.guna2ControlBox2 = new global::Guna.UI2.WinForms.Guna2ControlBox();
			this.showKeyLabel = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.guna2DragControl6 = new global::Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.guna2Panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.guna2PictureBox1).BeginInit();
			base.SuspendLayout();
			this.guna2Panel1.BackColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.guna2Panel1.Controls.Add(this.otherPanelButton);
			this.guna2Panel1.Controls.Add(this.infoModbyHaNguyen);
			this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
			this.guna2Panel1.Controls.Add(this.backpackPanelButton);
			this.guna2Panel1.Controls.Add(this.weaponPanelButton);
			this.guna2Panel1.Controls.Add(this.setPanelButton);
			this.guna2Panel1.Location = new global::System.Drawing.Point(-5, -4);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new global::System.Drawing.Size(150, 456);
			this.guna2Panel1.TabIndex = 0;
			this.otherPanelButton.BackColor = global::System.Drawing.Color.Transparent;
			this.otherPanelButton.ButtonMode = global::Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
			this.otherPanelButton.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.otherPanelButton.CheckedState.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.otherPanelButton.CheckedState.ForeColor = global::System.Drawing.Color.Black;
			this.otherPanelButton.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.otherPanelButton.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.otherPanelButton.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.otherPanelButton.DisabledState.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.otherPanelButton.DisabledState.ForeColor = global::System.Drawing.Color.Black;
			this.otherPanelButton.FillColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.otherPanelButton.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.otherPanelButton.ForeColor = global::System.Drawing.Color.White;
			this.otherPanelButton.HoverState.FillColor = global::System.Drawing.Color.White;
			this.otherPanelButton.HoverState.Font = new global::System.Drawing.Font("Segoe UI Black", 12f, global::System.Drawing.FontStyle.Bold);
			this.otherPanelButton.HoverState.ForeColor = global::System.Drawing.Color.Black;
			this.otherPanelButton.Image = global::ModPubg.Properties.Resources.gorilla;
			this.otherPanelButton.ImageAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.otherPanelButton.Location = new global::System.Drawing.Point(3, 305);
			this.otherPanelButton.Name = "otherPanelButton";
			this.otherPanelButton.Size = new global::System.Drawing.Size(150, 45);
			this.otherPanelButton.TabIndex = 5;
			this.otherPanelButton.Text = "Other";
			this.otherPanelButton.UseTransparentBackground = true;
			this.otherPanelButton.Click += new global::System.EventHandler(this.otherPanelButton_Click);
			this.infoModbyHaNguyen.BackColor = global::System.Drawing.Color.Transparent;
			this.infoModbyHaNguyen.Font = new global::System.Drawing.Font("UTM Impact", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.infoModbyHaNguyen.ForeColor = global::System.Drawing.Color.Black;
			this.infoModbyHaNguyen.Location = new global::System.Drawing.Point(15, 76);
			this.infoModbyHaNguyen.Name = "infoModbyHaNguyen";
			this.infoModbyHaNguyen.Size = new global::System.Drawing.Size(122, 23);
			this.infoModbyHaNguyen.TabIndex = 4;
			this.infoModbyHaNguyen.Text = "Gorilla Mod Skin";
			this.guna2PictureBox1.FillColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.guna2PictureBox1.Image = global::ModPubg.Properties.Resources.gorilla1;
			this.guna2PictureBox1.ImageRotate = 0f;
			this.guna2PictureBox1.Location = new global::System.Drawing.Point(44, 20);
			this.guna2PictureBox1.Name = "guna2PictureBox1";
			this.guna2PictureBox1.Size = new global::System.Drawing.Size(53, 56);
			this.guna2PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.guna2PictureBox1.TabIndex = 4;
			this.guna2PictureBox1.TabStop = false;
			this.backpackPanelButton.Animated = true;
			this.backpackPanelButton.BackColor = global::System.Drawing.Color.Transparent;
			this.backpackPanelButton.ButtonMode = global::Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
			this.backpackPanelButton.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.backpackPanelButton.CheckedState.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.backpackPanelButton.CheckedState.ForeColor = global::System.Drawing.Color.Black;
			this.backpackPanelButton.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.backpackPanelButton.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.backpackPanelButton.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.backpackPanelButton.DisabledState.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.backpackPanelButton.DisabledState.ForeColor = global::System.Drawing.Color.Black;
			this.backpackPanelButton.FillColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.backpackPanelButton.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.backpackPanelButton.ForeColor = global::System.Drawing.Color.White;
			this.backpackPanelButton.HoverState.FillColor = global::System.Drawing.Color.White;
			this.backpackPanelButton.HoverState.Font = new global::System.Drawing.Font("Segoe UI Black", 12f, global::System.Drawing.FontStyle.Bold);
			this.backpackPanelButton.HoverState.ForeColor = global::System.Drawing.Color.Black;
			this.backpackPanelButton.Image = global::ModPubg.Properties.Resources.backpack_100px;
			this.backpackPanelButton.ImageAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.backpackPanelButton.Location = new global::System.Drawing.Point(3, 203);
			this.backpackPanelButton.Name = "backpackPanelButton";
			this.backpackPanelButton.Size = new global::System.Drawing.Size(150, 45);
			this.backpackPanelButton.TabIndex = 4;
			this.backpackPanelButton.Text = "Backpack";
			this.backpackPanelButton.UseTransparentBackground = true;
			this.backpackPanelButton.Click += new global::System.EventHandler(this.backpackPanelButton_Click);
			this.weaponPanelButton.BackColor = global::System.Drawing.Color.Transparent;
			this.weaponPanelButton.ButtonMode = global::Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
			this.weaponPanelButton.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.weaponPanelButton.CheckedState.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.weaponPanelButton.CheckedState.ForeColor = global::System.Drawing.Color.Black;
			this.weaponPanelButton.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.weaponPanelButton.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.weaponPanelButton.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.weaponPanelButton.DisabledState.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.weaponPanelButton.DisabledState.ForeColor = global::System.Drawing.Color.Black;
			this.weaponPanelButton.FillColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.weaponPanelButton.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.weaponPanelButton.ForeColor = global::System.Drawing.Color.White;
			this.weaponPanelButton.HoverState.FillColor = global::System.Drawing.Color.White;
			this.weaponPanelButton.HoverState.Font = new global::System.Drawing.Font("Segoe UI Black", 12f, global::System.Drawing.FontStyle.Bold);
			this.weaponPanelButton.HoverState.ForeColor = global::System.Drawing.Color.Black;
			this.weaponPanelButton.Image = global::ModPubg.Properties.Resources.assault_rifle_64px;
			this.weaponPanelButton.ImageAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.weaponPanelButton.Location = new global::System.Drawing.Point(3, 254);
			this.weaponPanelButton.Name = "weaponPanelButton";
			this.weaponPanelButton.Size = new global::System.Drawing.Size(150, 45);
			this.weaponPanelButton.TabIndex = 3;
			this.weaponPanelButton.Text = "Weapon";
			this.weaponPanelButton.UseTransparentBackground = true;
			this.weaponPanelButton.Click += new global::System.EventHandler(this.weaponPanelButton_Click);
			this.setPanelButton.Animated = true;
			this.setPanelButton.BackColor = global::System.Drawing.Color.Transparent;
			this.setPanelButton.ButtonMode = global::Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
			this.setPanelButton.Checked = true;
			this.setPanelButton.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.setPanelButton.CheckedState.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.setPanelButton.CheckedState.ForeColor = global::System.Drawing.Color.Black;
			this.setPanelButton.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.setPanelButton.DisabledState.CustomBorderColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.setPanelButton.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.setPanelButton.DisabledState.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.setPanelButton.DisabledState.ForeColor = global::System.Drawing.Color.Black;
			this.setPanelButton.FillColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.setPanelButton.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Bold);
			this.setPanelButton.ForeColor = global::System.Drawing.Color.White;
			this.setPanelButton.HoverState.FillColor = global::System.Drawing.Color.White;
			this.setPanelButton.HoverState.Font = new global::System.Drawing.Font("Segoe UI Black", 12f, global::System.Drawing.FontStyle.Bold);
			this.setPanelButton.HoverState.ForeColor = global::System.Drawing.Color.Black;
			this.setPanelButton.Image = global::ModPubg.Properties.Resources.t_shirt_52px;
			this.setPanelButton.ImageAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.setPanelButton.Location = new global::System.Drawing.Point(3, 152);
			this.setPanelButton.Name = "setPanelButton";
			this.setPanelButton.Size = new global::System.Drawing.Size(150, 45);
			this.setPanelButton.TabIndex = 0;
			this.setPanelButton.Text = "Set";
			this.setPanelButton.UseTransparentBackground = true;
			this.setPanelButton.Click += new global::System.EventHandler(this.setPanelButton_Click);
			this.guna2DragControl4.DockIndicatorTransparencyValue = 0.6;
			this.guna2DragControl4.TargetControl = this.guna2Panel1;
			this.guna2DragControl4.UseTransparentDrag = true;
			this.guna2DragControl5.DockIndicatorTransparencyValue = 0.6;
			this.guna2DragControl5.TargetControl = this.weaponPanel1;
			this.guna2DragControl5.UseTransparentDrag = true;
			this.weaponPanel1.BackColor = global::System.Drawing.Color.White;
			this.weaponPanel1.Location = new global::System.Drawing.Point(151, 12);
			this.weaponPanel1.Name = "weaponPanel1";
			this.weaponPanel1.Size = new global::System.Drawing.Size(528, 436);
			this.weaponPanel1.TabIndex = 2;
			this.guna2Elipse1.BorderRadius = 20;
			this.guna2Elipse1.TargetControl = this;
			this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6;
			this.guna2DragControl1.TargetControl = this;
			this.guna2DragControl1.UseTransparentDrag = true;
			this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6;
			this.guna2DragControl2.TargetControl = this.backpackPanel1;
			this.guna2DragControl2.UseTransparentDrag = true;
			this.backpackPanel1.BackColor = global::System.Drawing.Color.White;
			this.backpackPanel1.Location = new global::System.Drawing.Point(151, 12);
			this.backpackPanel1.Name = "backpackPanel1";
			this.backpackPanel1.Size = new global::System.Drawing.Size(528, 436);
			this.backpackPanel1.TabIndex = 3;
			this.guna2DragControl3.DockIndicatorTransparencyValue = 0.6;
			this.guna2DragControl3.TargetControl = this.setPanel1;
			this.guna2DragControl3.UseTransparentDrag = true;
			this.setPanel1.BackColor = global::System.Drawing.Color.White;
			this.setPanel1.Location = new global::System.Drawing.Point(151, 12);
			this.setPanel1.Name = "setPanel1";
			this.setPanel1.Size = new global::System.Drawing.Size(528, 436);
			this.setPanel1.TabIndex = 4;
			this.others1.BackColor = global::System.Drawing.Color.White;
			this.others1.Location = new global::System.Drawing.Point(151, 12);
			this.others1.Name = "others1";
			this.others1.Size = new global::System.Drawing.Size(528, 436);
			this.others1.TabIndex = 1;
			this.guna2ControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.guna2ControlBox1.ControlBoxStyle = global::Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
			this.guna2ControlBox1.CustomIconSize = 13f;
			this.guna2ControlBox1.FillColor = global::System.Drawing.Color.White;
			this.guna2ControlBox1.IconColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.guna2ControlBox1.Location = new global::System.Drawing.Point(634, 12);
			this.guna2ControlBox1.Name = "guna2ControlBox1";
			this.guna2ControlBox1.Size = new global::System.Drawing.Size(45, 29);
			this.guna2ControlBox1.TabIndex = 5;
			this.guna2ControlBox1.Click += new global::System.EventHandler(this.guna2ControlBox1_Click_1);
			this.guna2ControlBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.guna2ControlBox2.ControlBoxStyle = global::Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
			this.guna2ControlBox2.ControlBoxType = global::Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
			this.guna2ControlBox2.CustomIconSize = 13f;
			this.guna2ControlBox2.FillColor = global::System.Drawing.Color.White;
			this.guna2ControlBox2.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.guna2ControlBox2.IconColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.guna2ControlBox2.Location = new global::System.Drawing.Point(589, 12);
			this.guna2ControlBox2.Name = "guna2ControlBox2";
			this.guna2ControlBox2.Size = new global::System.Drawing.Size(45, 29);
			this.guna2ControlBox2.TabIndex = 6;
			this.showKeyLabel.BackColor = global::System.Drawing.Color.Red;
			this.showKeyLabel.Font = new global::System.Drawing.Font("Segoe UI Black", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.showKeyLabel.ForeColor = global::System.Drawing.Color.White;
			this.showKeyLabel.Location = new global::System.Drawing.Point(176, 16);
			this.showKeyLabel.Name = "showKeyLabel";
			this.showKeyLabel.Size = new global::System.Drawing.Size(48, 19);
			this.showKeyLabel.TabIndex = 7;
			this.showKeyLabel.Text = "License";
			this.guna2DragControl6.DockIndicatorTransparencyValue = 0.6;
			this.guna2DragControl6.TargetControl = this.others1;
			this.guna2DragControl6.UseTransparentDrag = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(678, 447);
			base.Controls.Add(this.showKeyLabel);
			base.Controls.Add(this.guna2ControlBox2);
			base.Controls.Add(this.guna2ControlBox1);
			base.Controls.Add(this.setPanel1);
			base.Controls.Add(this.backpackPanel1);
			base.Controls.Add(this.weaponPanel1);
			base.Controls.Add(this.others1);
			base.Controls.Add(this.guna2Panel1);
			this.ForeColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "mainForm";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "mainForm";
			base.Load += new global::System.EventHandler(this.mainForm_Load);
			this.guna2Panel1.ResumeLayout(false);
			this.guna2Panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.guna2PictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000059 RID: 89
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400005A RID: 90
		private global::Guna.UI2.WinForms.Guna2Panel guna2Panel1;

		// Token: 0x0400005B RID: 91
		private global::Guna.UI2.WinForms.Guna2Button setPanelButton;

		// Token: 0x0400005C RID: 92
		private global::Guna.UI2.WinForms.Guna2Button backpackPanelButton;

		// Token: 0x0400005D RID: 93
		private global::Guna.UI2.WinForms.Guna2Button weaponPanelButton;

		// Token: 0x0400005E RID: 94
		private global::Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;

		// Token: 0x0400005F RID: 95
		private global::Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;

		// Token: 0x04000060 RID: 96
		private global::Guna.UI2.WinForms.Guna2DragControl guna2DragControl3;

		// Token: 0x04000061 RID: 97
		private global::Guna.UI2.WinForms.Guna2DragControl guna2DragControl4;

		// Token: 0x04000062 RID: 98
		private global::Guna.UI2.WinForms.Guna2DragControl guna2DragControl5;

		// Token: 0x04000063 RID: 99
		private global::Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;

		// Token: 0x04000064 RID: 100
		private global::Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;

		// Token: 0x04000065 RID: 101
		private global::Guna.UI2.WinForms.Guna2HtmlLabel infoModbyHaNguyen;

		// Token: 0x04000066 RID: 102
		private global::Guna.UI2.WinForms.Guna2Button otherPanelButton;

		// Token: 0x04000067 RID: 103
		private global::ModPubg.List_Panel.setPanel setPanel1;

		// Token: 0x04000068 RID: 104
		private global::ModPubg.Controls.backpackPanel backpackPanel1;

		// Token: 0x04000069 RID: 105
		private global::ModPubg.Controls.weaponPanel weaponPanel1;

		// Token: 0x0400006A RID: 106
		private global::ModPubg.fControls.others others1;

		// Token: 0x0400006B RID: 107
		private global::Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;

		// Token: 0x0400006C RID: 108
		private global::Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;

		// Token: 0x0400006D RID: 109
		private global::Guna.UI2.WinForms.Guna2HtmlLabel showKeyLabel;

		// Token: 0x0400006E RID: 110
		private global::Guna.UI2.WinForms.Guna2DragControl guna2DragControl6;
	}
}
