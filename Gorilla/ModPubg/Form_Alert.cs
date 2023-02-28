using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using ModPubg.Properties;

namespace ModPubg
{
	// Token: 0x02000006 RID: 6
	public partial class Form_Alert : Form
	{
		// Token: 0x06000008 RID: 8 RVA: 0x000020AA File Offset: 0x000002AA
		public Form_Alert()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002057 File Offset: 0x00000257
		private void Form_Alert_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000025A4 File Offset: 0x000007A4
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
				if (this.x < base.Location.X)
				{
					int left = base.Left;
					base.Left = left - 1;
				}
				else if (base.Opacity == 1.0)
				{
					this.action = Form_Alert.enmAction.wait;
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

		// Token: 0x0600000B RID: 11 RVA: 0x000026A0 File Offset: 0x000008A0
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
					IL_B6:
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
					return;
				}
			}
		
		}

		// Token: 0x04000004 RID: 4
		private Form_Alert.enmAction action;

		// Token: 0x04000005 RID: 5
		private int x;

		// Token: 0x04000006 RID: 6
		private int y;

		// Token: 0x02000007 RID: 7
		public enum enmAction
		{
			// Token: 0x0400000E RID: 14
			wait,
			// Token: 0x0400000F RID: 15
			start,
			// Token: 0x04000010 RID: 16
			close
		}

		// Token: 0x02000008 RID: 8
		public enum enmType
		{
			// Token: 0x04000012 RID: 18
			Success
		}
	}
}
