using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using ModPubg.fClass;

namespace ModPubg.Controls
{
	// Token: 0x0200001D RID: 29
	public class backpackPanel : UserControl
	{
		// Token: 0x060000DB RID: 219 RVA: 0x00002515 File Offset: 0x00000715
		public backpackPanel()
		{
			this.func = new functions();
			this.InitializeComponent();
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002057 File Offset: 0x00000257
		private void backpackPanel_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00008924 File Offset: 0x00006B24
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

		// Token: 0x060000DE RID: 222 RVA: 0x000089E0 File Offset: 0x00006BE0
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

		// Token: 0x060000DF RID: 223 RVA: 0x00008A9C File Offset: 0x00006C9C
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

		// Token: 0x060000E0 RID: 224 RVA: 0x00008B58 File Offset: 0x00006D58
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

		// Token: 0x060000E1 RID: 225 RVA: 0x00008C14 File Offset: 0x00006E14
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

		// Token: 0x060000E2 RID: 226 RVA: 0x00008CD0 File Offset: 0x00006ED0
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

		// Token: 0x060000E3 RID: 227 RVA: 0x00002464 File Offset: 0x00000664
		private void guna2ControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00008D8C File Offset: 0x00006F8C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00008DBC File Offset: 0x00006FBC
		private void InitializeComponent()
		{
            this.silvanusBackpackButton = new Guna.UI2.WinForms.Guna2Button();
            this.bloodravensBackpackButton = new Guna.UI2.WinForms.Guna2Button();
            this.poseidonBackpackButton = new Guna.UI2.WinForms.Guna2Button();
            this.pharaohBackpackButton = new Guna.UI2.WinForms.Guna2Button();
            this.bapeBackPackButton = new Guna.UI2.WinForms.Guna2Button();
            this.countBackpack = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // silvanusBackpackButton
            // 
            this.silvanusBackpackButton.BorderRadius = 5;
            this.silvanusBackpackButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.silvanusBackpackButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.silvanusBackpackButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.silvanusBackpackButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.silvanusBackpackButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.silvanusBackpackButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.silvanusBackpackButton.ForeColor = System.Drawing.Color.White;
            this.silvanusBackpackButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.silvanusBackpackButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.silvanusBackpackButton.HoverState.ForeColor = System.Drawing.Color.Black;
            this.silvanusBackpackButton.Location = new System.Drawing.Point(275, 114);
            this.silvanusBackpackButton.Name = "silvanusBackpackButton";
            this.silvanusBackpackButton.Size = new System.Drawing.Size(230, 45);
            this.silvanusBackpackButton.TabIndex = 19;
            this.silvanusBackpackButton.Text = "Silvanus Backpack";
            // 
            // bloodravensBackpackButton
            // 
            this.bloodravensBackpackButton.BorderRadius = 5;
            this.bloodravensBackpackButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bloodravensBackpackButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bloodravensBackpackButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bloodravensBackpackButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bloodravensBackpackButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bloodravensBackpackButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodravensBackpackButton.ForeColor = System.Drawing.Color.White;
            this.bloodravensBackpackButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bloodravensBackpackButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bloodravensBackpackButton.HoverState.ForeColor = System.Drawing.Color.Black;
            this.bloodravensBackpackButton.Location = new System.Drawing.Point(23, 114);
            this.bloodravensBackpackButton.Name = "bloodravensBackpackButton";
            this.bloodravensBackpackButton.Size = new System.Drawing.Size(230, 45);
            this.bloodravensBackpackButton.TabIndex = 20;
            this.bloodravensBackpackButton.Text = "Blood ravens Backpack";
            // 
            // poseidonBackpackButton
            // 
            this.poseidonBackpackButton.BorderRadius = 5;
            this.poseidonBackpackButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.poseidonBackpackButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.poseidonBackpackButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.poseidonBackpackButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.poseidonBackpackButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.poseidonBackpackButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.poseidonBackpackButton.ForeColor = System.Drawing.Color.White;
            this.poseidonBackpackButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.poseidonBackpackButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.poseidonBackpackButton.HoverState.ForeColor = System.Drawing.Color.Black;
            this.poseidonBackpackButton.Location = new System.Drawing.Point(275, 51);
            this.poseidonBackpackButton.Name = "poseidonBackpackButton";
            this.poseidonBackpackButton.Size = new System.Drawing.Size(230, 45);
            this.poseidonBackpackButton.TabIndex = 13;
            this.poseidonBackpackButton.Text = "Poseidon Backpack";
            // 
            // pharaohBackpackButton
            // 
            this.pharaohBackpackButton.BorderRadius = 5;
            this.pharaohBackpackButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.pharaohBackpackButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.pharaohBackpackButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.pharaohBackpackButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.pharaohBackpackButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pharaohBackpackButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pharaohBackpackButton.ForeColor = System.Drawing.Color.White;
            this.pharaohBackpackButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pharaohBackpackButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pharaohBackpackButton.HoverState.ForeColor = System.Drawing.Color.Black;
            this.pharaohBackpackButton.Location = new System.Drawing.Point(23, 51);
            this.pharaohBackpackButton.Name = "pharaohBackpackButton";
            this.pharaohBackpackButton.Size = new System.Drawing.Size(230, 45);
            this.pharaohBackpackButton.TabIndex = 12;
            this.pharaohBackpackButton.Text = "Pharaoh BackPack";
            // 
            // bapeBackPackButton
            // 
            this.bapeBackPackButton.BorderRadius = 5;
            this.bapeBackPackButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bapeBackPackButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bapeBackPackButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bapeBackPackButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bapeBackPackButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bapeBackPackButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bapeBackPackButton.ForeColor = System.Drawing.Color.White;
            this.bapeBackPackButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bapeBackPackButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bapeBackPackButton.HoverState.ForeColor = System.Drawing.Color.Black;
            this.bapeBackPackButton.Location = new System.Drawing.Point(23, 177);
            this.bapeBackPackButton.Name = "bapeBackPackButton";
            this.bapeBackPackButton.Size = new System.Drawing.Size(230, 45);
            this.bapeBackPackButton.TabIndex = 21;
            this.bapeBackPackButton.Text = "Bape Backpack";
            // 
            // countBackpack
            // 
            this.countBackpack.BorderRadius = 5;
            this.countBackpack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.countBackpack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.countBackpack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.countBackpack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.countBackpack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.countBackpack.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countBackpack.ForeColor = System.Drawing.Color.White;
            this.countBackpack.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.countBackpack.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.countBackpack.HoverState.ForeColor = System.Drawing.Color.Black;
            this.countBackpack.Location = new System.Drawing.Point(275, 177);
            this.countBackpack.Name = "countBackpack";
            this.countBackpack.Size = new System.Drawing.Size(230, 45);
            this.countBackpack.TabIndex = 22;
            this.countBackpack.Text = "Count Backpack";
            this.countBackpack.Click += new System.EventHandler(this.countBackpack_Click_1);
            // 
            // backpackPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.countBackpack);
            this.Controls.Add(this.bapeBackPackButton);
            this.Controls.Add(this.pharaohBackpackButton);
            this.Controls.Add(this.poseidonBackpackButton);
            this.Controls.Add(this.silvanusBackpackButton);
            this.Controls.Add(this.bloodravensBackpackButton);
            this.Name = "backpackPanel";
            this.Size = new System.Drawing.Size(528, 436);
            this.ResumeLayout(false);

		}

		// Token: 0x04000087 RID: 135
		private functions func;

		// Token: 0x04000088 RID: 136
		private IContainer components = null;

		// Token: 0x04000089 RID: 137
		private Guna2Button silvanusBackpackButton;

		// Token: 0x0400008A RID: 138
		private Guna2Button bloodravensBackpackButton;

		// Token: 0x0400008B RID: 139
		private Guna2Button poseidonBackpackButton;

		// Token: 0x0400008C RID: 140
		private Guna2Button pharaohBackpackButton;

		// Token: 0x0400008D RID: 141
		private Guna2Button bapeBackPackButton;

		// Token: 0x0400008E RID: 142
		private Guna2Button countBackpack;

        private void countBackpack_Click_1(object sender, EventArgs e)
        {

        }
    }
}
