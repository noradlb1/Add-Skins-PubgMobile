namespace ModPubg
{
	// Token: 0x02000006 RID: 6
	public partial class Form_Alert : global::System.Windows.Forms.Form
	{
		// Token: 0x0600000C RID: 12 RVA: 0x000027DC File Offset: 0x000009DC
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000280C File Offset: 0x00000A0C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ModPubg.Form_Alert));
			this.lblMsg = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.guna2AnimateWindow1 = new global::Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
			this.guna2ControlBox1 = new global::Guna.UI2.WinForms.Guna2ControlBox();
			this.pictureBox1 = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.lblMsg.BackColor = global::System.Drawing.Color.Transparent;
			this.lblMsg.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblMsg.ForeColor = global::System.Drawing.Color.White;
			this.lblMsg.Location = new global::System.Drawing.Point(55, 11);
			this.lblMsg.Name = "lblMsg";
			this.lblMsg.Size = new global::System.Drawing.Size(106, 23);
			this.lblMsg.TabIndex = 0;
			this.lblMsg.Text = "Message Text";
			this.guna2ControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.guna2ControlBox1.BackColor = global::System.Drawing.Color.SeaGreen;
			this.guna2ControlBox1.ControlBoxStyle = global::Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
			this.guna2ControlBox1.CustomIconSize = 13f;
			this.guna2ControlBox1.FillColor = global::System.Drawing.Color.SeaGreen;
			this.guna2ControlBox1.IconColor = global::System.Drawing.Color.White;
			this.guna2ControlBox1.Location = new global::System.Drawing.Point(310, 10);
			this.guna2ControlBox1.Name = "guna2ControlBox1";
			this.guna2ControlBox1.Size = new global::System.Drawing.Size(37, 31);
			this.guna2ControlBox1.TabIndex = 1;
			this.pictureBox1.Image = global::ModPubg.Properties.Resources.success;
			this.pictureBox1.ImageRotate = 0f;
			this.pictureBox1.Location = new global::System.Drawing.Point(7, 11);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(38, 27);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			base.ClientSize = new global::System.Drawing.Size(359, 49);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.guna2ControlBox1);
			base.Controls.Add(this.lblMsg);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Form_Alert";
			base.Opacity = 0.7;
			this.Text = "Form_Alert";
			base.Load += new global::System.EventHandler(this.Form_Alert_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000007 RID: 7
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000008 RID: 8
		private global::Guna.UI2.WinForms.Guna2HtmlLabel lblMsg;

		// Token: 0x04000009 RID: 9
		private global::Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;

		// Token: 0x0400000A RID: 10
		private global::Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;

		// Token: 0x0400000B RID: 11
		private global::Guna.UI2.WinForms.Guna2PictureBox pictureBox1;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.Timer timer1;
	}
}
