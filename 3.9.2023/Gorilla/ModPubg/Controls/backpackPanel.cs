using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using ModPubg.fClass;

namespace ModPubg.Controls
{
	// Token: 0x02000026 RID: 38
	public class backpackPanel : UserControl
	{
		// Token: 0x0600010F RID: 271 RVA: 0x0000A440 File Offset: 0x00008640
		public backpackPanel()
		{
			this.func = new functions();
			this.InitializeComponent();
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002210 File Offset: 0x00000410
		private void backpackPanel_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0000A46C File Offset: 0x0000866C
		private void countBackpack_Click(object sender, EventArgs e)
		{
			this.func.StartKernel();
			string procID = this.func.GetProcID();
			this.func.Rep(procID, "09 A5 07 00 00 00 00 00 00 00", "40 75 77 59");
			this.func.Rep(procID, "0A A5 07 00 00 00 00 00 00 00", "28 79 77 59");
			this.func.Rep(procID, "0B A5 07 00 00 00 00 00 00 00", "10 7D 77 59");
			this.func.Rep(procID, "0C A5 07 00 00 00 00 00 00 00", "40 75 77 59");
			this.func.Rep(procID, "0D A5 07 00 00 00 00 00 00 00", "28 79 77 59");
			this.func.Rep(procID, "0E A5 07 00 00 00 00 00 00 00", "10 7D 77 59");
			this.func.Alert("Mod count backpack done!!!", Form_Alert.enmType.Success);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0000A528 File Offset: 0x00008728
		private void silvanusBackpackButton_Click(object sender, EventArgs e)
		{
			this.func.StartKernel();
			string procID = this.func.GetProcID();
			this.func.Rep(procID, "09 A5 07 00 00 00 00 00 00 00", "78 76 77 59");
			this.func.Rep(procID, "0A A5 07 00 00 00 00 00 00 00", "60 7A 77 59");
			this.func.Rep(procID, "0B A5 07 00 00 00 00 00 00 00", "48 7E 77 59");
			this.func.Rep(procID, "0C A5 07 00 00 00 00 00 00 00", "78 76 77 59");
			this.func.Rep(procID, "0D A5 07 00 00 00 00 00 00 00", "60 7A 77 59");
			this.func.Rep(procID, "0E A5 07 00 00 00 00 00 00 00", "48 7E 77 59");
			this.func.Alert("Mod Silvanus backpack done!!!", Form_Alert.enmType.Success);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0000A5E4 File Offset: 0x000087E4
		private void poseidonBackpackButton_Click(object sender, EventArgs e)
		{
			this.func.StartKernel();
			string procID = this.func.GetProcID();
			this.func.Rep(procID, "09 A5 07 00 00 00 00 00 00 00", "31 76 77 59");
			this.func.Rep(procID, "0A A5 07 00 00 00 00 00 00 00", "19 7A 77 59");
			this.func.Rep(procID, "0B A5 07 00 00 00 00 00 00 00", "01 7E 77 59");
			this.func.Rep(procID, "0C A5 07 00 00 00 00 00 00 00", "31 76 77 59");
			this.func.Rep(procID, "0D A5 07 00 00 00 00 00 00 00", "19 7A 77 59");
			this.func.Rep(procID, "0E A5 07 00 00 00 00 00 00 00", "01 7E 77 59");
			this.func.Alert("Mod Poseidon backpack done!!!", Form_Alert.enmType.Success);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0000A6A0 File Offset: 0x000088A0
		private void bapeBackPackButton_Click(object sender, EventArgs e)
		{
			this.func.StartKernel();
			string procID = this.func.GetProcID();
			this.func.Rep(procID, "09 A5 07 00 00 00 00 00 00 00", "62 75 77 59");
			this.func.Rep(procID, "0A A5 07 00 00 00 00 00 00 00", "4A 79 77 59");
			this.func.Rep(procID, "0B A5 07 00 00 00 00 00 00 00", "32 7D 77 59");
			this.func.Rep(procID, "0C A5 07 00 00 00 00 00 00 00", "62 75 77 59");
			this.func.Rep(procID, "0D A5 07 00 00 00 00 00 00 00", "4A 79 77 59");
			this.func.Rep(procID, "0E A5 07 00 00 00 00 00 00 00", "32 7D 77 59");
			this.func.Alert("Mod Bape backpack done!!!", Form_Alert.enmType.Success);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0000A75C File Offset: 0x0000895C
		private void bloodravensBackpackButton_Click(object sender, EventArgs e)
		{
			this.func.StartKernel();
			string procID = this.func.GetProcID();
			this.func.Rep(procID, "09 A5 07 00 00 00 00 00 00 00", "04 76 77 59");
			this.func.Rep(procID, "0A A5 07 00 00 00 00 00 00 00", "EC 79 77 59");
			this.func.Rep(procID, "0B A5 07 00 00 00 00 00 00 00", "D4 7D 77 59");
			this.func.Rep(procID, "0C A5 07 00 00 00 00 00 00 00", "04 76 77 59");
			this.func.Rep(procID, "0D A5 07 00 00 00 00 00 00 00", "EC 79 77 59");
			this.func.Rep(procID, "0E A5 07 00 00 00 00 00 00 00", "D4 7D 77 59");
			this.func.Alert("Mod Bloodravens backpack done!!!", Form_Alert.enmType.Success);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0000A818 File Offset: 0x00008A18
		private void pharaohBackpackButton_Click(object sender, EventArgs e)
		{
			this.func.StartKernel();
			string procID = this.func.GetProcID();
			this.func.Rep(procID, "09 A5 07 00 00 00 00 00 00 00", "D6 75 77 59");
			this.func.Rep(procID, "0A A5 07 00 00 00 00 00 00 00", "BE 79 77 59");
			this.func.Rep(procID, "0B A5 07 00 00 00 00 00 00 00", "A6 7D 77 59");
			this.func.Rep(procID, "0C A5 07 00 00 00 00 00 00 00", "D6 75 77 59");
			this.func.Rep(procID, "0D A5 07 00 00 00 00 00 00 00", "BE 79 77 59");
			this.func.Rep(procID, "0E A5 07 00 00 00 00 00 00 00", "A6 7D 77 59");
			this.func.Alert("Mod Pharaoh backpack done!!!", Form_Alert.enmType.Success);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00005C70 File Offset: 0x00003E70
		private void guna2ControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0000A8D4 File Offset: 0x00008AD4
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0000A904 File Offset: 0x00008B04
		private void InitializeComponent()
		{
			this.silvanusBackpackButton = new Guna2Button();
			this.bloodravensBackpackButton = new Guna2Button();
			this.poseidonBackpackButton = new Guna2Button();
			this.pharaohBackpackButton = new Guna2Button();
			this.bapeBackPackButton = new Guna2Button();
			this.countBackpack = new Guna2Button();
			base.SuspendLayout();
			this.silvanusBackpackButton.BorderRadius = 5;
			this.silvanusBackpackButton.DisabledState.BorderColor = Color.DarkGray;
			this.silvanusBackpackButton.DisabledState.CustomBorderColor = Color.DarkGray;
			this.silvanusBackpackButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.silvanusBackpackButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.silvanusBackpackButton.FillColor = Color.FromArgb(128, 128, 255);
			this.silvanusBackpackButton.Font = new Font("Segoe UI Semibold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.silvanusBackpackButton.ForeColor = Color.White;
			this.silvanusBackpackButton.HoverState.BorderColor = Color.FromArgb(0, 0, 192);
			this.silvanusBackpackButton.HoverState.FillColor = Color.FromArgb(128, 128, 255);
			this.silvanusBackpackButton.HoverState.ForeColor = Color.Black;
			this.silvanusBackpackButton.Location = new Point(275, 114);
			this.silvanusBackpackButton.Name = "silvanusBackpackButton";
			this.silvanusBackpackButton.Size = new Size(230, 45);
			this.silvanusBackpackButton.TabIndex = 19;
			this.silvanusBackpackButton.Text = "Silvanus Backpack";
			this.silvanusBackpackButton.Click += this.silvanusBackpackButton_Click;
			this.bloodravensBackpackButton.BorderRadius = 5;
			this.bloodravensBackpackButton.DisabledState.BorderColor = Color.DarkGray;
			this.bloodravensBackpackButton.DisabledState.CustomBorderColor = Color.DarkGray;
			this.bloodravensBackpackButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.bloodravensBackpackButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.bloodravensBackpackButton.FillColor = Color.FromArgb(128, 128, 255);
			this.bloodravensBackpackButton.Font = new Font("Segoe UI Semibold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.bloodravensBackpackButton.ForeColor = Color.White;
			this.bloodravensBackpackButton.HoverState.BorderColor = Color.FromArgb(192, 0, 0);
			this.bloodravensBackpackButton.HoverState.FillColor = Color.FromArgb(128, 128, 255);
			this.bloodravensBackpackButton.HoverState.ForeColor = Color.Black;
			this.bloodravensBackpackButton.Location = new Point(23, 114);
			this.bloodravensBackpackButton.Name = "bloodravensBackpackButton";
			this.bloodravensBackpackButton.Size = new Size(230, 45);
			this.bloodravensBackpackButton.TabIndex = 20;
			this.bloodravensBackpackButton.Text = "Blood ravens Backpack";
			this.bloodravensBackpackButton.Click += this.bloodravensBackpackButton_Click;
			this.poseidonBackpackButton.BorderRadius = 5;
			this.poseidonBackpackButton.DisabledState.BorderColor = Color.DarkGray;
			this.poseidonBackpackButton.DisabledState.CustomBorderColor = Color.DarkGray;
			this.poseidonBackpackButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.poseidonBackpackButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.poseidonBackpackButton.FillColor = Color.FromArgb(128, 128, 255);
			this.poseidonBackpackButton.Font = new Font("Segoe UI Semibold", 11.25f, FontStyle.Bold);
			this.poseidonBackpackButton.ForeColor = Color.White;
			this.poseidonBackpackButton.HoverState.BorderColor = Color.FromArgb(0, 0, 192);
			this.poseidonBackpackButton.HoverState.FillColor = Color.FromArgb(128, 128, 255);
			this.poseidonBackpackButton.HoverState.ForeColor = Color.Black;
			this.poseidonBackpackButton.Location = new Point(275, 51);
			this.poseidonBackpackButton.Name = "poseidonBackpackButton";
			this.poseidonBackpackButton.Size = new Size(230, 45);
			this.poseidonBackpackButton.TabIndex = 13;
			this.poseidonBackpackButton.Text = "Poseidon Backpack";
			this.poseidonBackpackButton.Click += this.poseidonBackpackButton_Click;
			this.pharaohBackpackButton.BorderRadius = 5;
			this.pharaohBackpackButton.DisabledState.BorderColor = Color.DarkGray;
			this.pharaohBackpackButton.DisabledState.CustomBorderColor = Color.DarkGray;
			this.pharaohBackpackButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.pharaohBackpackButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.pharaohBackpackButton.FillColor = Color.FromArgb(128, 128, 255);
			this.pharaohBackpackButton.Font = new Font("Segoe UI Semibold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.pharaohBackpackButton.ForeColor = Color.White;
			this.pharaohBackpackButton.HoverState.BorderColor = Color.FromArgb(192, 0, 0);
			this.pharaohBackpackButton.HoverState.FillColor = Color.FromArgb(128, 128, 255);
			this.pharaohBackpackButton.HoverState.ForeColor = Color.Black;
			this.pharaohBackpackButton.Location = new Point(23, 51);
			this.pharaohBackpackButton.Name = "pharaohBackpackButton";
			this.pharaohBackpackButton.Size = new Size(230, 45);
			this.pharaohBackpackButton.TabIndex = 12;
			this.pharaohBackpackButton.Text = "Pharaoh BackPack";
			this.pharaohBackpackButton.Click += this.pharaohBackpackButton_Click;
			this.bapeBackPackButton.BorderRadius = 5;
			this.bapeBackPackButton.DisabledState.BorderColor = Color.DarkGray;
			this.bapeBackPackButton.DisabledState.CustomBorderColor = Color.DarkGray;
			this.bapeBackPackButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.bapeBackPackButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.bapeBackPackButton.FillColor = Color.FromArgb(128, 128, 255);
			this.bapeBackPackButton.Font = new Font("Segoe UI Semibold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.bapeBackPackButton.ForeColor = Color.White;
			this.bapeBackPackButton.HoverState.BorderColor = Color.FromArgb(0, 0, 192);
			this.bapeBackPackButton.HoverState.FillColor = Color.FromArgb(128, 128, 255);
			this.bapeBackPackButton.HoverState.ForeColor = Color.Black;
			this.bapeBackPackButton.Location = new Point(23, 177);
			this.bapeBackPackButton.Name = "bapeBackPackButton";
			this.bapeBackPackButton.Size = new Size(230, 45);
			this.bapeBackPackButton.TabIndex = 21;
			this.bapeBackPackButton.Text = "Bape Backpack";
			this.bapeBackPackButton.Click += this.bapeBackPackButton_Click;
			this.countBackpack.BorderRadius = 5;
			this.countBackpack.DisabledState.BorderColor = Color.DarkGray;
			this.countBackpack.DisabledState.CustomBorderColor = Color.DarkGray;
			this.countBackpack.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.countBackpack.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.countBackpack.FillColor = Color.FromArgb(128, 128, 255);
			this.countBackpack.Font = new Font("Segoe UI Semibold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.countBackpack.ForeColor = Color.White;
			this.countBackpack.HoverState.BorderColor = Color.FromArgb(0, 0, 192);
			this.countBackpack.HoverState.FillColor = Color.FromArgb(128, 128, 255);
			this.countBackpack.HoverState.ForeColor = Color.Black;
			this.countBackpack.Location = new Point(275, 177);
			this.countBackpack.Name = "countBackpack";
			this.countBackpack.Size = new Size(230, 45);
			this.countBackpack.TabIndex = 22;
			this.countBackpack.Text = "Count Backpack";
			this.countBackpack.Click += this.countBackpack_Click;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.White;
			base.Controls.Add(this.countBackpack);
			base.Controls.Add(this.bapeBackPackButton);
			base.Controls.Add(this.pharaohBackpackButton);
			base.Controls.Add(this.poseidonBackpackButton);
			base.Controls.Add(this.silvanusBackpackButton);
			base.Controls.Add(this.bloodravensBackpackButton);
			base.Name = "backpackPanel";
			base.Size = new Size(528, 436);
			base.Load += this.backpackPanel_Load;
			base.ResumeLayout(false);
		}

		// Token: 0x040000B2 RID: 178
		private functions func;

		// Token: 0x040000B3 RID: 179
		private IContainer components = null;

		// Token: 0x040000B4 RID: 180
		private Guna2Button silvanusBackpackButton;

		// Token: 0x040000B5 RID: 181
		private Guna2Button bloodravensBackpackButton;

		// Token: 0x040000B6 RID: 182
		private Guna2Button poseidonBackpackButton;

		// Token: 0x040000B7 RID: 183
		private Guna2Button pharaohBackpackButton;

		// Token: 0x040000B8 RID: 184
		private Guna2Button bapeBackPackButton;

		// Token: 0x040000B9 RID: 185
		private Guna2Button countBackpack;
	}
}
