using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using ModPubg.Properties;

namespace ModPubg
{
	// Token: 0x0200001F RID: 31
	public partial class loginForm : Form
	{
		// Token: 0x060000C9 RID: 201 RVA: 0x0000599C File Offset: 0x00003B9C
		public DateTime UnixTimeToDateTime(long unixtime)
		{
			DateTime result = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			try
			{
				result = result.AddSeconds((double)unixtime).ToLocalTime();
			}
			catch
			{
				result = DateTime.MaxValue;
			}
			return result;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x000059EC File Offset: 0x00003BEC
		private void loginForm_Load(object sender, EventArgs e)
		{
			loginForm.KeyAuthApp.init();
			loginForm.KeyAuthApp.check();
			this.keyTextBox.Text = Settings.Default.username;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00005A24 File Offset: 0x00003C24
		public loginForm()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00005A44 File Offset: 0x00003C44
		private void loginButton_Click(object sender, EventArgs e)
		{
			loginForm.KeyAuthApp.license(this.keyTextBox.Text);
			Settings.Default["username"] = this.keyTextBox.Text;
			Settings.Default.Save();
			if (!loginForm.KeyAuthApp.response.success)
			{
				MessageBox.Show(loginForm.KeyAuthApp.response.message);
				Process.Start("https://mod.gamevip.fun/");
				Application.Exit();
			}
			else
			{
				if (this.checkform("default"))
				{
					MessageBox.Show("địt mẹ mặt lồn crack");
					Environment.Exit(0);
				}
				if (this.checkform("vip"))
				{
					MessageBox.Show(loginForm.KeyAuthApp.response.message + "\nExpiry: " + this.UnixTimeToDateTime(long.Parse(loginForm.KeyAuthApp.user_data.subscriptions[0].expiry)).ToString(), "Informarion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					mainForm mainForm = new mainForm();
					mainForm.Show();
					base.Hide();
				}
				if (this.checkform("admin"))
				{
					MessageBox.Show(loginForm.KeyAuthApp.response.message + "\nExpiry: " + this.UnixTimeToDateTime(long.Parse(loginForm.KeyAuthApp.user_data.subscriptions[0].expiry)).ToString(), "Informarion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					Form1 form = new Form1();
					form.Show();
					base.Hide();
				}
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00005BD0 File Offset: 0x00003DD0
		private void getFreeKetBtn_Click(object sender, EventArgs e)
		{
			Process.Start("https://mod.gamevip.fun/");
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00005BE8 File Offset: 0x00003DE8
		private void howToGetFreeKeyBtn_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/watch?v=ks3Z345-VzI");
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00005C00 File Offset: 0x00003E00
		public bool checkform(string nameKey)
		{
			foreach (api.Data data in loginForm.KeyAuthApp.user_data.subscriptions)
			{
				if (data.subscription == nameKey)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00005C70 File Offset: 0x00003E70
		private void guna2ControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x04000078 RID: 120
		public static api KeyAuthApp = new api("modskin", "HvgVPUCbHy", "f9d64c3605700c318ba0b34d0a41f5254d496925f59c52c580285a8576dc3307", "1.0");
	}
}
