using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using ModPubg.fClass;

namespace ModPubg.List_Panel
{
	// Token: 0x02000024 RID: 36
	public class setPanel : UserControl
	{
		// Token: 0x060000FA RID: 250 RVA: 0x00007F70 File Offset: 0x00006170
		public setPanel()
		{
			this.func = new functions();
			this.InitializeComponent();
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00007F9C File Offset: 0x0000619C
		private void modSetPharaohLv6_Click(object sender, EventArgs e)
		{
			this.func.StartKernel();
			string procID = this.func.GetProcID();
			this.func.Rep(procID, "A9 85 6B 02 00 00 00 00", "D2 66 15 00");
			this.func.Rep(procID, "3B 26 06 00 00 00 00 00", "BC 72 15 00");
			this.func.Alert("Set Pharaoh Lv.6 done!!!", Form_Alert.enmType.Success);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00008000 File Offset: 0x00006200
		private void modSetPharaohLv7_Click(object sender, EventArgs e)
		{
			this.func.StartKernel();
			string procID = this.func.GetProcID();
			this.func.Rep(procID, "A9 85 6B 02 00 00 00 00", "50 84 15 00");
			this.func.Rep(procID, "3B 26 06 00 00 00 00 00", "05 76 15 00");
			this.func.Alert("Set Pharaoh Lv.7 done!!!", Form_Alert.enmType.Success);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00008064 File Offset: 0x00006264
		private void modSetBloodravens_Click(object sender, EventArgs e)
		{
			this.func.StartKernel();
			string procID = this.func.GetProcID();
			this.func.Rep(procID, "A9 85 6B 02 00 00 00 00", "79 69 15 00");
			this.func.Rep(procID, "3B 26 06 00 00 00 00 00", "AE 73 15 00");
			this.func.Alert("Set Bloodravens done!!!", Form_Alert.enmType.Success);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000080C8 File Offset: 0x000062C8
		private void modSetArcaneJesterBlack_Click(object sender, EventArgs e)
		{
			this.func.StartKernel();
			string procID = this.func.GetProcID();
			this.func.Rep(procID, "3B 26 06 00 00 00 00 00", "B1 76 15 00");
			this.func.Alert("Set Arcane Jester Black done!!!", Form_Alert.enmType.Success);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00008114 File Offset: 0x00006314
		private void modSetArcaneJesterWhite_Click(object sender, EventArgs e)
		{
			this.func.StartKernel();
			string procID = this.func.GetProcID();
			this.func.Rep(procID, "3B 26 06 00 00 00 00 00", "AE 76 15 00");
			this.func.Alert("Set Arcane Jester White done!!!", Form_Alert.enmType.Success);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00008160 File Offset: 0x00006360
		private void modMummyWhite_Click(object sender, EventArgs e)
		{
			this.func.StartKernel();
			string procID = this.func.GetProcID();
			this.func.Rep(procID, "3B 26 06 00 00 00 00 00 00", "6F 5F 15 00");
			this.func.Alert("Set Mummy White done!!!", Form_Alert.enmType.Success);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x000081AC File Offset: 0x000063AC
		private void modMummyYellow_Click(object sender, EventArgs e)
		{
			this.func.StartKernel();
			string procID = this.func.GetProcID();
			this.func.Rep(procID, "3B 26 06 00 00 00 00 00", "B7 72 15 00");
			this.func.Alert("Set Mummy Yellow done!!!", Form_Alert.enmType.Success);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000081F8 File Offset: 0x000063F8
		private void modSetIridescence_Click(object sender, EventArgs e)
		{
			this.func.StartKernel();
			string procID = this.func.GetProcID();
			this.func.Rep(procID, "A9 85 6B 02 00 00 00 00", "53 84 15 00");
			this.func.Rep(procID, "3B 26 06 00 00 00 00 00", "0B 76 15 00");
			this.func.Alert("Set Iridescence done!!!", Form_Alert.enmType.Success);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000825C File Offset: 0x0000645C
		private void modSetWeddingDress_Click(object sender, EventArgs e)
		{
			this.func.StartKernel();
			string procID = this.func.GetProcID();
			this.func.Rep(procID, "A9 85 6B 02 00 00 00 00", "54 95 6B 02");
			this.func.Rep(procID, "3B 26 06 00 00 00 00 00", "F6 70 15 00");
			this.func.Alert("Set Wedding Dress done!!!", Form_Alert.enmType.Success);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000082C0 File Offset: 0x000064C0
		private void modSetBapeYellow_Click(object sender, EventArgs e)
		{
			this.func.StartKernel();
			string procID = this.func.GetProcID();
			this.func.Rep(procID, "3B 26 06 00 00 00 00 00", "91 6C 15 00");
			this.func.Rep(procID, "3A 2A 06 00 00 00 00 00", "92 6C 15 00");
			this.func.Rep(procID, "08 2E 06 00 00 00 00 00", "93 6C 15 00");
			this.func.Alert("Set Bape Yellow done!!!", Form_Alert.enmType.Success);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00008338 File Offset: 0x00006538
		private void modSetBapePurple_Click(object sender, EventArgs e)
		{
			this.func.StartKernel();
			string procID = this.func.GetProcID();
			this.func.Rep(procID, "3B 26 06 00 00 00 00 00", "F9 5E 15 00");
			this.func.Rep(procID, "3A 2A 06 00 00 00 00 00", "4A 5F 15 00");
			this.func.Rep(procID, "08 2E 06 00 00 00 00 00", "63 6C 15 00");
			this.func.Alert("Set Bape Purple done!!!", Form_Alert.enmType.Success);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00005C70 File Offset: 0x00003E70
		private void guna2ControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000083B0 File Offset: 0x000065B0
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000083E0 File Offset: 0x000065E0
		private void InitializeComponent()
		{
			this.modSetBapePurple = new Guna2Button();
			this.modSetIridescence = new Guna2Button();
			this.modSetWeddingDress = new Guna2Button();
			this.modSetBloodravens = new Guna2Button();
			this.modSetPoseidon = new Guna2Button();
			this.modSetArcaneJesterWhite = new Guna2Button();
			this.modSetArcaneJesterBlack = new Guna2Button();
			this.modSetBapeYellow = new Guna2Button();
			this.modMummyYellow = new Guna2Button();
			this.modMummyWhite = new Guna2Button();
			this.modSetPharaohLv7 = new Guna2Button();
			this.modSetPharaohLv6 = new Guna2Button();
			base.SuspendLayout();
			this.modSetBapePurple.BorderRadius = 5;
			this.modSetBapePurple.DisabledState.BorderColor = Color.DarkGray;
			this.modSetBapePurple.DisabledState.CustomBorderColor = Color.DarkGray;
			this.modSetBapePurple.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.modSetBapePurple.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.modSetBapePurple.FillColor = Color.FromArgb(128, 128, 255);
			this.modSetBapePurple.Font = new Font("Segoe UI Semibold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.modSetBapePurple.ForeColor = Color.White;
			this.modSetBapePurple.HoverState.BorderColor = Color.FromArgb(0, 0, 192);
			this.modSetBapePurple.HoverState.FillColor = Color.FromArgb(128, 128, 255);
			this.modSetBapePurple.HoverState.ForeColor = Color.Black;
			this.modSetBapePurple.Location = new Point(272, 363);
			this.modSetBapePurple.Name = "modSetBapePurple";
			this.modSetBapePurple.Size = new Size(230, 45);
			this.modSetBapePurple.TabIndex = 11;
			this.modSetBapePurple.Text = "Bape purple";
			this.modSetBapePurple.Click += this.modSetBapePurple_Click;
			this.modSetIridescence.BorderRadius = 5;
			this.modSetIridescence.DisabledState.BorderColor = Color.DarkGray;
			this.modSetIridescence.DisabledState.CustomBorderColor = Color.DarkGray;
			this.modSetIridescence.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.modSetIridescence.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.modSetIridescence.FillColor = Color.FromArgb(128, 128, 255);
			this.modSetIridescence.Font = new Font("Segoe UI Semibold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.modSetIridescence.ForeColor = Color.White;
			this.modSetIridescence.HoverState.BorderColor = Color.FromArgb(0, 0, 192);
			this.modSetIridescence.HoverState.FillColor = Color.FromArgb(128, 128, 255);
			this.modSetIridescence.HoverState.ForeColor = Color.Black;
			this.modSetIridescence.Location = new Point(20, 300);
			this.modSetIridescence.Name = "modSetIridescence";
			this.modSetIridescence.Size = new Size(230, 45);
			this.modSetIridescence.TabIndex = 10;
			this.modSetIridescence.Text = "Iridescence";
			this.modSetIridescence.Click += this.modSetIridescence_Click;
			this.modSetWeddingDress.BorderRadius = 5;
			this.modSetWeddingDress.DisabledState.BorderColor = Color.DarkGray;
			this.modSetWeddingDress.DisabledState.CustomBorderColor = Color.DarkGray;
			this.modSetWeddingDress.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.modSetWeddingDress.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.modSetWeddingDress.FillColor = Color.FromArgb(128, 128, 255);
			this.modSetWeddingDress.Font = new Font("Segoe UI Semibold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.modSetWeddingDress.ForeColor = Color.White;
			this.modSetWeddingDress.HoverState.BorderColor = Color.FromArgb(0, 0, 192);
			this.modSetWeddingDress.HoverState.FillColor = Color.FromArgb(128, 128, 255);
			this.modSetWeddingDress.HoverState.ForeColor = Color.Black;
			this.modSetWeddingDress.Location = new Point(272, 300);
			this.modSetWeddingDress.Name = "modSetWeddingDress";
			this.modSetWeddingDress.Size = new Size(230, 45);
			this.modSetWeddingDress.TabIndex = 9;
			this.modSetWeddingDress.Text = "Wedding dress";
			this.modSetWeddingDress.Click += this.modSetWeddingDress_Click;
			this.modSetBloodravens.BorderRadius = 5;
			this.modSetBloodravens.DisabledState.BorderColor = Color.DarkGray;
			this.modSetBloodravens.DisabledState.CustomBorderColor = Color.DarkGray;
			this.modSetBloodravens.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.modSetBloodravens.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.modSetBloodravens.FillColor = Color.FromArgb(128, 128, 255);
			this.modSetBloodravens.Font = new Font("Segoe UI Semibold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.modSetBloodravens.ForeColor = Color.White;
			this.modSetBloodravens.HoverState.BorderColor = Color.FromArgb(0, 0, 192);
			this.modSetBloodravens.HoverState.FillColor = Color.FromArgb(128, 128, 255);
			this.modSetBloodravens.HoverState.ForeColor = Color.Black;
			this.modSetBloodravens.Location = new Point(20, 111);
			this.modSetBloodravens.Name = "modSetBloodravens";
			this.modSetBloodravens.Size = new Size(230, 45);
			this.modSetBloodravens.TabIndex = 8;
			this.modSetBloodravens.Text = "Blood ravens";
			this.modSetBloodravens.Click += this.modSetBloodravens_Click;
			this.modSetPoseidon.BorderRadius = 5;
			this.modSetPoseidon.DisabledState.BorderColor = Color.DarkGray;
			this.modSetPoseidon.DisabledState.CustomBorderColor = Color.DarkGray;
			this.modSetPoseidon.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.modSetPoseidon.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.modSetPoseidon.FillColor = Color.FromArgb(128, 128, 255);
			this.modSetPoseidon.Font = new Font("Segoe UI Semibold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.modSetPoseidon.ForeColor = Color.White;
			this.modSetPoseidon.HoverState.BorderColor = Color.FromArgb(0, 0, 192);
			this.modSetPoseidon.HoverState.FillColor = Color.FromArgb(128, 128, 255);
			this.modSetPoseidon.HoverState.ForeColor = Color.Black;
			this.modSetPoseidon.Location = new Point(272, 111);
			this.modSetPoseidon.Name = "modSetPoseidon";
			this.modSetPoseidon.Size = new Size(230, 45);
			this.modSetPoseidon.TabIndex = 7;
			this.modSetPoseidon.Text = "Poseidon";
			this.modSetArcaneJesterWhite.BorderRadius = 5;
			this.modSetArcaneJesterWhite.DisabledState.BorderColor = Color.DarkGray;
			this.modSetArcaneJesterWhite.DisabledState.CustomBorderColor = Color.DarkGray;
			this.modSetArcaneJesterWhite.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.modSetArcaneJesterWhite.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.modSetArcaneJesterWhite.FillColor = Color.FromArgb(128, 128, 255);
			this.modSetArcaneJesterWhite.Font = new Font("Segoe UI Semibold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.modSetArcaneJesterWhite.ForeColor = Color.White;
			this.modSetArcaneJesterWhite.HoverState.BorderColor = Color.FromArgb(0, 0, 192);
			this.modSetArcaneJesterWhite.HoverState.FillColor = Color.FromArgb(128, 128, 255);
			this.modSetArcaneJesterWhite.HoverState.ForeColor = Color.Black;
			this.modSetArcaneJesterWhite.Location = new Point(272, 174);
			this.modSetArcaneJesterWhite.Name = "modSetArcaneJesterWhite";
			this.modSetArcaneJesterWhite.Size = new Size(230, 45);
			this.modSetArcaneJesterWhite.TabIndex = 6;
			this.modSetArcaneJesterWhite.Text = "Arcane Jester (White)";
			this.modSetArcaneJesterWhite.Click += this.modSetArcaneJesterWhite_Click;
			this.modSetArcaneJesterBlack.BorderRadius = 5;
			this.modSetArcaneJesterBlack.DisabledState.BorderColor = Color.DarkGray;
			this.modSetArcaneJesterBlack.DisabledState.CustomBorderColor = Color.DarkGray;
			this.modSetArcaneJesterBlack.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.modSetArcaneJesterBlack.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.modSetArcaneJesterBlack.FillColor = Color.FromArgb(128, 128, 255);
			this.modSetArcaneJesterBlack.Font = new Font("Segoe UI Semibold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.modSetArcaneJesterBlack.ForeColor = Color.White;
			this.modSetArcaneJesterBlack.HoverState.BorderColor = Color.FromArgb(0, 0, 192);
			this.modSetArcaneJesterBlack.HoverState.FillColor = Color.FromArgb(128, 128, 255);
			this.modSetArcaneJesterBlack.HoverState.ForeColor = Color.Black;
			this.modSetArcaneJesterBlack.Location = new Point(20, 174);
			this.modSetArcaneJesterBlack.Name = "modSetArcaneJesterBlack";
			this.modSetArcaneJesterBlack.Size = new Size(230, 45);
			this.modSetArcaneJesterBlack.TabIndex = 5;
			this.modSetArcaneJesterBlack.Text = "Arcane Jester (Black)";
			this.modSetArcaneJesterBlack.Click += this.modSetArcaneJesterBlack_Click;
			this.modSetBapeYellow.BorderRadius = 5;
			this.modSetBapeYellow.DisabledState.BorderColor = Color.DarkGray;
			this.modSetBapeYellow.DisabledState.CustomBorderColor = Color.DarkGray;
			this.modSetBapeYellow.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.modSetBapeYellow.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.modSetBapeYellow.FillColor = Color.FromArgb(128, 128, 255);
			this.modSetBapeYellow.Font = new Font("Segoe UI Semibold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.modSetBapeYellow.ForeColor = Color.White;
			this.modSetBapeYellow.HoverState.BorderColor = Color.FromArgb(0, 0, 192);
			this.modSetBapeYellow.HoverState.FillColor = Color.FromArgb(128, 128, 255);
			this.modSetBapeYellow.HoverState.ForeColor = Color.Black;
			this.modSetBapeYellow.Location = new Point(20, 363);
			this.modSetBapeYellow.Name = "modSetBapeYellow";
			this.modSetBapeYellow.Size = new Size(230, 45);
			this.modSetBapeYellow.TabIndex = 4;
			this.modSetBapeYellow.Text = "Bape Yellow";
			this.modSetBapeYellow.Click += this.modSetBapeYellow_Click;
			this.modMummyYellow.BorderRadius = 5;
			this.modMummyYellow.DisabledState.BorderColor = Color.DarkGray;
			this.modMummyYellow.DisabledState.CustomBorderColor = Color.DarkGray;
			this.modMummyYellow.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.modMummyYellow.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.modMummyYellow.FillColor = Color.FromArgb(128, 128, 255);
			this.modMummyYellow.Font = new Font("Segoe UI Semibold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.modMummyYellow.ForeColor = Color.White;
			this.modMummyYellow.HoverState.BorderColor = Color.FromArgb(0, 0, 192);
			this.modMummyYellow.HoverState.FillColor = Color.FromArgb(128, 128, 255);
			this.modMummyYellow.HoverState.ForeColor = Color.Black;
			this.modMummyYellow.Location = new Point(272, 237);
			this.modMummyYellow.Name = "modMummyYellow";
			this.modMummyYellow.Size = new Size(230, 45);
			this.modMummyYellow.TabIndex = 3;
			this.modMummyYellow.Text = "Mummy yellow";
			this.modMummyYellow.Click += this.modMummyYellow_Click;
			this.modMummyWhite.BorderRadius = 5;
			this.modMummyWhite.DisabledState.BorderColor = Color.DarkGray;
			this.modMummyWhite.DisabledState.CustomBorderColor = Color.DarkGray;
			this.modMummyWhite.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.modMummyWhite.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.modMummyWhite.FillColor = Color.FromArgb(128, 128, 255);
			this.modMummyWhite.Font = new Font("Segoe UI Semibold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.modMummyWhite.ForeColor = Color.White;
			this.modMummyWhite.HoverState.BorderColor = Color.FromArgb(0, 0, 192);
			this.modMummyWhite.HoverState.FillColor = Color.FromArgb(128, 128, 255);
			this.modMummyWhite.HoverState.ForeColor = Color.Black;
			this.modMummyWhite.Location = new Point(20, 237);
			this.modMummyWhite.Name = "modMummyWhite";
			this.modMummyWhite.Size = new Size(230, 45);
			this.modMummyWhite.TabIndex = 2;
			this.modMummyWhite.Text = "Mummy white";
			this.modMummyWhite.Click += this.modMummyWhite_Click;
			this.modSetPharaohLv7.BorderRadius = 5;
			this.modSetPharaohLv7.DisabledState.BorderColor = Color.DarkGray;
			this.modSetPharaohLv7.DisabledState.CustomBorderColor = Color.DarkGray;
			this.modSetPharaohLv7.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.modSetPharaohLv7.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.modSetPharaohLv7.FillColor = Color.FromArgb(128, 128, 255);
			this.modSetPharaohLv7.Font = new Font("Segoe UI Semibold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.modSetPharaohLv7.ForeColor = Color.White;
			this.modSetPharaohLv7.HoverState.BorderColor = Color.FromArgb(0, 0, 192);
			this.modSetPharaohLv7.HoverState.FillColor = Color.FromArgb(128, 128, 255);
			this.modSetPharaohLv7.HoverState.ForeColor = Color.Black;
			this.modSetPharaohLv7.Location = new Point(272, 48);
			this.modSetPharaohLv7.Name = "modSetPharaohLv7";
			this.modSetPharaohLv7.Size = new Size(230, 45);
			this.modSetPharaohLv7.TabIndex = 1;
			this.modSetPharaohLv7.Text = "Pharaoh Lv.7";
			this.modSetPharaohLv7.Click += this.modSetPharaohLv7_Click;
			this.modSetPharaohLv6.BorderRadius = 5;
			this.modSetPharaohLv6.DisabledState.BorderColor = Color.DarkGray;
			this.modSetPharaohLv6.DisabledState.CustomBorderColor = Color.DarkGray;
			this.modSetPharaohLv6.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.modSetPharaohLv6.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.modSetPharaohLv6.FillColor = Color.FromArgb(128, 128, 255);
			this.modSetPharaohLv6.Font = new Font("Segoe UI Semibold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.modSetPharaohLv6.ForeColor = Color.White;
			this.modSetPharaohLv6.HoverState.BorderColor = Color.FromArgb(0, 0, 192);
			this.modSetPharaohLv6.HoverState.FillColor = Color.FromArgb(128, 128, 255);
			this.modSetPharaohLv6.HoverState.ForeColor = Color.Black;
			this.modSetPharaohLv6.Location = new Point(20, 48);
			this.modSetPharaohLv6.Name = "modSetPharaohLv6";
			this.modSetPharaohLv6.Size = new Size(230, 45);
			this.modSetPharaohLv6.TabIndex = 0;
			this.modSetPharaohLv6.Text = "Pharaoh Lv.6";
			this.modSetPharaohLv6.Click += this.modSetPharaohLv6_Click;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.White;
			base.Controls.Add(this.modSetBapePurple);
			base.Controls.Add(this.modMummyYellow);
			base.Controls.Add(this.modSetWeddingDress);
			base.Controls.Add(this.modSetIridescence);
			base.Controls.Add(this.modSetBapeYellow);
			base.Controls.Add(this.modSetPharaohLv6);
			base.Controls.Add(this.modSetPharaohLv7);
			base.Controls.Add(this.modMummyWhite);
			base.Controls.Add(this.modSetPoseidon);
			base.Controls.Add(this.modSetBloodravens);
			base.Controls.Add(this.modSetArcaneJesterWhite);
			base.Controls.Add(this.modSetArcaneJesterBlack);
			base.Name = "setPanel";
			base.Size = new Size(528, 436);
			base.ResumeLayout(false);
		}

		// Token: 0x0400009D RID: 157
		private functions func;

		// Token: 0x0400009E RID: 158
		private IContainer components = null;

		// Token: 0x0400009F RID: 159
		private Guna2Button modSetBapePurple;

		// Token: 0x040000A0 RID: 160
		private Guna2Button modSetIridescence;

		// Token: 0x040000A1 RID: 161
		private Guna2Button modSetWeddingDress;

		// Token: 0x040000A2 RID: 162
		private Guna2Button modSetBloodravens;

		// Token: 0x040000A3 RID: 163
		private Guna2Button modSetPoseidon;

		// Token: 0x040000A4 RID: 164
		private Guna2Button modSetArcaneJesterWhite;

		// Token: 0x040000A5 RID: 165
		private Guna2Button modSetArcaneJesterBlack;

		// Token: 0x040000A6 RID: 166
		private Guna2Button modSetBapeYellow;

		// Token: 0x040000A7 RID: 167
		private Guna2Button modMummyYellow;

		// Token: 0x040000A8 RID: 168
		private Guna2Button modMummyWhite;

		// Token: 0x040000A9 RID: 169
		private Guna2Button modSetPharaohLv7;

		// Token: 0x040000AA RID: 170
		private Guna2Button modSetPharaohLv6;
	}
}
