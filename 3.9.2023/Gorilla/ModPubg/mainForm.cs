using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using ModPubg.Controls;
using ModPubg.fControls;
using ModPubg.List_Panel;
using ModPubg.Properties;

namespace ModPubg
{
	// Token: 0x02000020 RID: 32
	public partial class mainForm : Form
	{
		// Token: 0x060000D4 RID: 212 RVA: 0x00006710 File Offset: 0x00004910
		public mainForm()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00006730 File Offset: 0x00004930
		private void mainForm_Load(object sender, EventArgs e)
		{
			loginForm.KeyAuthApp.check();
			this.setPanelButton.Checked = true;
			this.backpackPanel1.Hide();
			this.weaponPanel1.Hide();
			this.others1.Hide();
			this.showKeyLabel.Text = "Your license: " + loginForm.KeyAuthApp.user_data.username;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00006798 File Offset: 0x00004998
		private void setPanelButton_Click(object sender, EventArgs e)
		{
			if (this.setPanelButton.Checked)
			{
				this.setPanel1.Show();
				this.backpackPanel1.Hide();
				this.weaponPanel1.Hide();
				this.others1.Hide();
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000067E0 File Offset: 0x000049E0
		private void backpackPanelButton_Click(object sender, EventArgs e)
		{
			if (this.backpackPanelButton.Checked)
			{
				this.backpackPanel1.Show();
				this.setPanel1.Hide();
				this.weaponPanel1.Hide();
				this.others1.Hide();
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00006828 File Offset: 0x00004A28
		private void weaponPanelButton_Click(object sender, EventArgs e)
		{
			if (this.weaponPanelButton.Checked)
			{
				this.weaponPanel1.Show();
				this.setPanel1.Hide();
				this.backpackPanel1.Hide();
				this.others1.Hide();
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00006870 File Offset: 0x00004A70
		private void otherPanelButton_Click(object sender, EventArgs e)
		{
			if (this.otherPanelButton.Checked)
			{
				this.others1.Show();
				this.setPanel1.Hide();
				this.backpackPanel1.Hide();
				this.weaponPanel1.Hide();
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002210 File Offset: 0x00000410
		private void weaponPanel1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00005C70 File Offset: 0x00003E70
		private void guna2ControlBox1_Click_1(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}
	}
}
