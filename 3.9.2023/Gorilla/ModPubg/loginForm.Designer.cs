namespace ModPubg
{
	// Token: 0x0200001F RID: 31
	public partial class loginForm : global::System.Windows.Forms.Form
	{
		// Token: 0x060000D1 RID: 209 RVA: 0x00005C84 File Offset: 0x00003E84
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00005CB4 File Offset: 0x00003EB4
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ModPubg.loginForm));
			this.guna2DragControl1 = new global::Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.guna2ControlBox1 = new global::Guna.UI2.WinForms.Guna2ControlBox();
			this.guna2ControlBox2 = new global::Guna.UI2.WinForms.Guna2ControlBox();
			this.guna2DragControl2 = new global::Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.guna2Elipse1 = new global::Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.getFreeKetBtn = new global::Guna.UI2.WinForms.Guna2Button();
			this.howToGetFreeKeyBtn = new global::Guna.UI2.WinForms.Guna2Button();
			this.loginButton = new global::Guna.UI2.WinForms.Guna2Button();
			this.keyTextBox = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.guna2HtmlLabel1 = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			base.SuspendLayout();
			this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6;
			this.guna2DragControl1.TargetControl = this;
			this.guna2DragControl1.UseTransparentDrag = true;
			this.guna2ControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.guna2ControlBox1.ControlBoxStyle = global::Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
			this.guna2ControlBox1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.guna2ControlBox1.CustomIconSize = 13f;
			this.guna2ControlBox1.FillColor = global::System.Drawing.Color.White;
			this.guna2ControlBox1.IconColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.guna2ControlBox1.Location = new global::System.Drawing.Point(410, 0);
			this.guna2ControlBox1.Name = "guna2ControlBox1";
			this.guna2ControlBox1.Size = new global::System.Drawing.Size(45, 37);
			this.guna2ControlBox1.TabIndex = 4;
			this.guna2ControlBox1.Click += new global::System.EventHandler(this.guna2ControlBox1_Click);
			this.guna2ControlBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.guna2ControlBox2.ControlBoxStyle = global::Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
			this.guna2ControlBox2.ControlBoxType = global::Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
			this.guna2ControlBox2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.guna2ControlBox2.CustomIconSize = 13f;
			this.guna2ControlBox2.FillColor = global::System.Drawing.Color.White;
			this.guna2ControlBox2.IconColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.guna2ControlBox2.Location = new global::System.Drawing.Point(366, 0);
			this.guna2ControlBox2.Name = "guna2ControlBox2";
			this.guna2ControlBox2.Size = new global::System.Drawing.Size(40, 37);
			this.guna2ControlBox2.TabIndex = 5;
			this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6;
			this.guna2DragControl2.UseTransparentDrag = true;
			this.guna2Elipse1.TargetControl = this;
			this.getFreeKetBtn.BorderRadius = 5;
			this.getFreeKetBtn.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.getFreeKetBtn.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.getFreeKetBtn.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.getFreeKetBtn.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.getFreeKetBtn.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.getFreeKetBtn.FillColor = global::System.Drawing.Color.FromArgb(192, 64, 0);
			this.getFreeKetBtn.Font = new global::System.Drawing.Font("Segoe UI Black", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.getFreeKetBtn.ForeColor = global::System.Drawing.Color.White;
			this.getFreeKetBtn.Image = global::ModPubg.Properties.Resources.website_64px;
			this.getFreeKetBtn.Location = new global::System.Drawing.Point(233, 129);
			this.getFreeKetBtn.Name = "getFreeKetBtn";
			this.getFreeKetBtn.Size = new global::System.Drawing.Size(202, 38);
			this.getFreeKetBtn.TabIndex = 7;
			this.getFreeKetBtn.Text = "Get free key";
			this.getFreeKetBtn.Click += new global::System.EventHandler(this.getFreeKetBtn_Click);
			this.howToGetFreeKeyBtn.BorderRadius = 5;
			this.howToGetFreeKeyBtn.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.howToGetFreeKeyBtn.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.howToGetFreeKeyBtn.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.howToGetFreeKeyBtn.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.howToGetFreeKeyBtn.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.howToGetFreeKeyBtn.FillColor = global::System.Drawing.Color.FromArgb(192, 64, 0);
			this.howToGetFreeKeyBtn.Font = new global::System.Drawing.Font("Segoe UI Black", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.howToGetFreeKeyBtn.ForeColor = global::System.Drawing.Color.White;
			this.howToGetFreeKeyBtn.Image = global::ModPubg.Properties.Resources.Ask_Question_128px;
			this.howToGetFreeKeyBtn.Location = new global::System.Drawing.Point(12, 129);
			this.howToGetFreeKeyBtn.Name = "howToGetFreeKeyBtn";
			this.howToGetFreeKeyBtn.Size = new global::System.Drawing.Size(202, 38);
			this.howToGetFreeKeyBtn.TabIndex = 6;
			this.howToGetFreeKeyBtn.Text = "How to get key";
			this.howToGetFreeKeyBtn.Click += new global::System.EventHandler(this.howToGetFreeKeyBtn_Click);
			this.loginButton.BorderRadius = 5;
			this.loginButton.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.loginButton.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.loginButton.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.loginButton.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.loginButton.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.loginButton.FillColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.loginButton.Font = new global::System.Drawing.Font("Segoe UI Black", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.loginButton.ForeColor = global::System.Drawing.Color.White;
			this.loginButton.Image = global::ModPubg.Properties.Resources.enter_48px;
			this.loginButton.Location = new global::System.Drawing.Point(12, 85);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new global::System.Drawing.Size(423, 38);
			this.loginButton.TabIndex = 2;
			this.loginButton.Text = "Login";
			this.loginButton.Click += new global::System.EventHandler(this.loginButton_Click);
			this.keyTextBox.BorderColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.keyTextBox.BorderRadius = 5;
			this.keyTextBox.BorderThickness = 2;
			this.keyTextBox.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.keyTextBox.DefaultText = "";
			this.keyTextBox.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.keyTextBox.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.keyTextBox.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.keyTextBox.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.keyTextBox.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.keyTextBox.Font = new global::System.Drawing.Font("Segoe UI", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.keyTextBox.ForeColor = global::System.Drawing.Color.Black;
			this.keyTextBox.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.keyTextBox.IconLeft = (global::System.Drawing.Image)componentResourceManager.GetObject("keyTextBox.IconLeft");
			this.keyTextBox.IconLeftSize = new global::System.Drawing.Size(15, 15);
			this.keyTextBox.Location = new global::System.Drawing.Point(12, 44);
			this.keyTextBox.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.keyTextBox.Name = "keyTextBox";
			this.keyTextBox.PasswordChar = '\0';
			this.keyTextBox.PlaceholderForeColor = global::System.Drawing.Color.Black;
			this.keyTextBox.PlaceholderText = "Input key here";
			this.keyTextBox.SelectedText = "";
			this.keyTextBox.Size = new global::System.Drawing.Size(423, 34);
			this.keyTextBox.TabIndex = 1;
			this.keyTextBox.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.guna2HtmlLabel1.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2HtmlLabel1.Font = new global::System.Drawing.Font("Segoe UI", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2HtmlLabel1.Location = new global::System.Drawing.Point(12, 10);
			this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
			this.guna2HtmlLabel1.Size = new global::System.Drawing.Size(156, 22);
			this.guna2HtmlLabel1.TabIndex = 8;
			this.guna2HtmlLabel1.Text = "Gorilla mod skin login";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(455, 184);
			base.Controls.Add(this.guna2HtmlLabel1);
			base.Controls.Add(this.getFreeKetBtn);
			base.Controls.Add(this.howToGetFreeKeyBtn);
			base.Controls.Add(this.loginButton);
			base.Controls.Add(this.guna2ControlBox1);
			base.Controls.Add(this.guna2ControlBox2);
			base.Controls.Add(this.keyTextBox);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "loginForm";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login Form";
			base.Load += new global::System.EventHandler(this.loginForm_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000079 RID: 121
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400007A RID: 122
		private global::Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;

		// Token: 0x0400007B RID: 123
		private global::Guna.UI2.WinForms.Guna2TextBox keyTextBox;

		// Token: 0x0400007C RID: 124
		private global::Guna.UI2.WinForms.Guna2Button loginButton;

		// Token: 0x0400007D RID: 125
		private global::Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;

		// Token: 0x0400007E RID: 126
		private global::Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;

		// Token: 0x0400007F RID: 127
		private global::Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;

		// Token: 0x04000080 RID: 128
		private global::Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;

		// Token: 0x04000081 RID: 129
		private global::Guna.UI2.WinForms.Guna2Button howToGetFreeKeyBtn;

		// Token: 0x04000082 RID: 130
		private global::Guna.UI2.WinForms.Guna2Button getFreeKetBtn;

		// Token: 0x04000083 RID: 131
		private global::Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
	}
}
