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
	// Token: 0x02000017 RID: 23
	public partial class mainForm : Form
	{
		// Token: 0x060000A0 RID: 160 RVA: 0x0000248C File Offset: 0x0000068C
		public mainForm()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00004CD4 File Offset: 0x00002ED4
		private void mainForm_Load(object sender, EventArgs e)
		{

			this.setPanelButton.Checked = true;
			this.backpackPanel1.Hide();
			this.weaponPanel1.Hide();
			this.others1.Hide();
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00004D3C File Offset: 0x00002F3C
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

		// Token: 0x060000A3 RID: 163 RVA: 0x00004D84 File Offset: 0x00002F84
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

		// Token: 0x060000A4 RID: 164 RVA: 0x00004DCC File Offset: 0x00002FCC
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

		// Token: 0x060000A5 RID: 165 RVA: 0x00004E14 File Offset: 0x00003014
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

		// Token: 0x060000A6 RID: 166 RVA: 0x00002057 File Offset: 0x00000257
		private void weaponPanel1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002464 File Offset: 0x00000664
		private void guna2ControlBox1_Click_1(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

	}
}
