using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using ModPubg.Properties;

namespace ModPubg
{
	// Token: 0x0200000F RID: 15
	public partial class Form_Alert : Form
	{
		// Token: 0x0600003C RID: 60 RVA: 0x00003620 File Offset: 0x00001820
		public Form_Alert()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002210 File Offset: 0x00000410
		private void Form_Alert_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003640 File Offset: 0x00001840
		private void timer1_Tick(object sender, EventArgs e)
		{
			switch (this.action)
			{
			case Form_Alert.enmAction.wait:
				this.timer1.Interval = 5000;
				this.action = Form_Alert.enmAction.close;
				break;
			case Form_Alert.enmAction.start:
				this.timer1.Interval = 1;
				base.Opacity += 0.1;
				if (this.x >= base.Location.X)
				{
					if (base.Opacity == 1.0)
					{
						this.action = Form_Alert.enmAction.wait;
					}
				}
				else
				{
					int left = base.Left;
					base.Left = left - 1;
				}
				break;
			case Form_Alert.enmAction.close:
				this.timer1.Interval = 1;
				base.Opacity -= 0.1;
				base.Left -= 3;
				if (base.Opacity == 0.0)
				{
					base.Close();
				}
				break;
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000373C File Offset: 0x0000193C
		public void showAlert(string msg, Form_Alert.enmType type)
		{
			base.Opacity = 0.0;
			base.StartPosition = FormStartPosition.Manual;
			for (int i = 1; i < 5; i++)
			{
				string name = "alert" + i.ToString();
				Form_Alert form_Alert = (Form_Alert)Application.OpenForms[name];
				if (form_Alert == null)
				{
					base.Name = name;
					this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width + 15;
					this.y = Screen.PrimaryScreen.WorkingArea.Height - base.Height * i - 5 * i;
					base.Location = new Point(this.x, this.y);
					break;
				}
			}
			this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;
			if (type == Form_Alert.enmType.Success)
			{
				this.pictureBox1.Image = Resources.success;
				this.BackColor = Color.SeaGreen;
			}
			this.lblMsg.Text = msg;
			base.Show();
			this.action = Form_Alert.enmAction.start;
			this.timer1.Interval = 1;
			this.timer1.Start();
		}

		// Token: 0x0400002F RID: 47
		private Form_Alert.enmAction action;

		// Token: 0x04000030 RID: 48
		private int x;

		// Token: 0x04000031 RID: 49
		private int y;

		// Token: 0x02000010 RID: 16
		public enum enmAction
		{
			// Token: 0x04000039 RID: 57
			wait,
			// Token: 0x0400003A RID: 58
			start,
			// Token: 0x0400003B RID: 59
			close
		}

		// Token: 0x02000011 RID: 17
		public enum enmType
		{
			// Token: 0x0400003D RID: 61
			Success
		}
	}
}
