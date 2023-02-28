using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using ModPubg.fClass;

namespace ModPubg.Controls
{
	// Token: 0x0200001E RID: 30
	public class weaponPanel : UserControl
	{
		// Token: 0x060000E6 RID: 230 RVA: 0x00002535 File Offset: 0x00000735
		public weaponPanel()
		{
			this.func = new functions();
			this.InitializeComponent();
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00009838 File Offset: 0x00007A38
		private void modM416GlacierV1_Click(object sender, EventArgs e)
		{
			this.func.StartKernel();
			string procID = this.func.GetProcID();
			this.func.Rep(procID, "B0 1E 9A 00 00 00 00 00 00 00", "0E FD 9F 41");
			this.func.Rep(procID, "70 09 BC 01 00 00 00 00 00 00", "8D FE 33 3C");
			this.func.Rep(procID, "00 C4 35 01 00 00 00 00 00 00", "8E FE 33 3C");
			this.func.Rep(procID, "14 D0 38 01 00 00 00 00 00 00", "8F FE 33 3C");
			this.func.Rep(procID, "E8 CE 38 01 00 00 00 00 00 00", "A0 FE 33 3C");
			this.func.Alert("Mod M416 Glacier V1 done!", Form_Alert.enmType.Success);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000098DC File Offset: 0x00007ADC
		private void modM416GlacierV2_Click(object sender, EventArgs e)
		{
			this.func.StartKernel();
			string procID = this.func.GetProcID();
			this.func.Rep(procID, "E6 FC 9F 41 00 00 00 00 00 00", "0E FD 9F 41");
			this.func.Rep(procID, "FD FC 33 3C 00 00 00 00 00 00", "8D FE 33 3C");
			this.func.Rep(procID, "FE FC 33 3C 00 00 00 00 00 00", "84 FE 33 3C");
			this.func.Rep(procID, "FF FC 33 3C 00 00 00 00 00 00", "8F FE 33 3C");
			this.func.Rep(procID, "E8 CE 38 01 00 00 00 00 00 00", "A0 FE 33 3C");
			this.func.Alert("Mod M416 Glacier V2 done!", Form_Alert.enmType.Success);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00009980 File Offset: 0x00007B80
		private void modEffectM416GlacierV2_Click(object sender, EventArgs e)
		{
			this.func.StartKernel();
			string procID = this.func.GetProcID();
			this.func.Rep(procID, "E6 FC 9F 41", "0E FD 9F 41");
			this.func.Alert("Mod Effect M416 Glacier V2 done!", Form_Alert.enmType.Success);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000099CC File Offset: 0x00007BCC
		private void modM416SilverGuru_Click(object sender, EventArgs e)
		{
			this.func.StartKernel();
			string procID = this.func.GetProcID();
			this.func.Rep(procID, "B0 1E 9A 00 00 00 00 00 00 00", "A9 FD 9F 41");
			this.func.Rep(procID, "00 C4 35 01 00 00 00 00 00 00", "92 04 34 3C");
			this.func.Rep(procID, "70 09 BC 01 00 00 00 00 00 00", "9B 04 34 3C");
			this.func.Rep(procID, "E8 CE 38 01 00 00 00 00 00 00", "6E 04 34 3C");
			this.func.Rep(procID, "14 D0 38 01 00 00 00 00 00 00", "9D 04 34 3C");
			this.func.Alert("Mod M416 Sliver Guru done!", Form_Alert.enmType.Success);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00009A70 File Offset: 0x00007C70
		private void modM416ImperialSplendor_Click(object sender, EventArgs e)
		{
			this.func.StartKernel();
			string procID = this.func.GetProcID();
			this.func.Rep(procID, "B0 1E 9A 00 00 00 00 00 00 00", "83 FD 9F 41");
			this.func.Rep(procID, "00 C4 35 01 00 00 00 00 00 00", "20 03 34 3C");
			this.func.Rep(procID, "70 09 BC 01 00 00 00 00 00 00", "1F 03 34 3C");
			this.func.Rep(procID, "E8 CE 38 01 00 00 00 00 00 00", "21 03 34 3C");
			this.func.Rep(procID, "14 D0 38 01 00 00 00 00 00 00", "21 03 34 3C");
			this.func.Alert("Mod M416 Imperial Splendor done!", Form_Alert.enmType.Success);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00009B14 File Offset: 0x00007D14
		private void modM416Joker_Click(object sender, EventArgs e)
		{
			this.func.StartKernel();
			string procID = this.func.GetProcID();
			this.func.Rep(procID, "B0 1E 9A 00 00 00 00 00 00 00", "1E FD 9F 41");
			this.func.Rep(procID, "70 09 BC 01 00 00 00 00 00 00", "2D FF 33 3C");
			this.func.Rep(procID, "00 C4 35 01 00 00 00 00 00 00", "2E FF 33 3C");
			this.func.Rep(procID, "E8 CE 38 01 00 00 00 00 00 00", "2F FF 33 3C");
			this.func.Rep(procID, "14 D0 38 01 00 00 00 00 00 00", "2F FF 33 3C");
			this.func.Alert("Mod M416 Joker done!", Form_Alert.enmType.Success);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00009BB8 File Offset: 0x00007DB8
		private void modM416Lizard_Click(object sender, EventArgs e)
		{
			this.func.StartKernel();
			string procID = this.func.GetProcID();
			this.func.Rep(procID, "B0 1E 9A 00 00 00 00 00 00 00", "36 FD 9F 41");
			this.func.Rep(procID, "00 C4 35 01 00 00 00 00 00 00", "1D 00 34 3C");
			this.func.Rep(procID, "70 09 BC 01 00 00 00 00 00 00", "1E 00 34 3C");
			this.func.Rep(procID, "14 D0 38 01 00 00 00 00 00 00", "1F 00 34 3C");
			this.func.Alert("Mod M416 Lizard done!", Form_Alert.enmType.Success);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00009C48 File Offset: 0x00007E48
		private void modAKMStarseaAdmiral_Click(object sender, EventArgs e)
		{
			this.func.StartKernel();
			string procID = this.func.GetProcID();
			this.func.Rep(procID, "84 1D 9A 00 00 00 00 00 00 00", "FD F1 9F 41");
			this.func.Rep(procID, "44 08 BC 01 00 00 00 00 00 00", "E3 8F 33 3C");
			this.func.Alert("Mod AKM Starsea Admiral done!", Form_Alert.enmType.Success);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00009CAC File Offset: 0x00007EAC
		private void modAKMWanderingTyrant_Click(object sender, EventArgs e)
		{
			this.func.StartKernel();
			string procID = this.func.GetProcID();
			this.func.Rep(procID, "84 1D 9A 00 00 00 00 00 00 00", "D3 F1 9F 41");
			this.func.Rep(procID, "44 08 BC 01 00 00 00 00 00 00", "3F 8E 33 3C");
			this.func.Alert("Mod AKM Wandering Tyrant done!", Form_Alert.enmType.Success);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00009D10 File Offset: 0x00007F10
		private void modAKMGlacier_Click(object sender, EventArgs e)
		{
			this.func.StartKernel();
			string procID = this.func.GetProcID();
			this.func.Rep(procID, "84 1D 9A 00 00 00 00 00 00 00", "81 F1 9F 41");
			this.func.Rep(procID, "44 08 BC 01 00 00 00 00 00 00", "0B 8B 33 3C");
			this.func.Alert("Mod AKM Glacier done!", Form_Alert.enmType.Success);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00009D74 File Offset: 0x00007F74
		private void modGrozaRiverStyx_Click(object sender, EventArgs e)
		{
			string procID = this.func.GetProcID();
			this.func.Rep(procID, "14 1F 9A 00 00 00 00 00 00 00", "FC 00 A0 41");
			this.func.Rep(procID, "D4 09 BC 01 00 00 00 00 00 00", "D9 25 34 3C");
			this.func.Alert("Mod Groza River Styx done!", Form_Alert.enmType.Success);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00009DCC File Offset: 0x00007FCC
		private void modAWMFlameware_Click(object sender, EventArgs e)
		{
			this.func.StartKernel();
			string procID = this.func.GetProcID();
			this.func.Rep(procID, "8C 2B 9D 00 00 00 00 00 00 00", "B6 7D BE 41");
			this.func.Alert("Mod AWM Flameware done!", Form_Alert.enmType.Success);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00009E18 File Offset: 0x00008018
		private void modAWMGodzila_Click(object sender, EventArgs e)
		{
			this.func.StartKernel();
			string procID = this.func.GetProcID();
			this.func.Rep(procID, "8C 2B 9D 00 00 00 00 00 00 00", "A2 7D BE 41");
			this.func.Alert("Mod AWM Godzila done!", Form_Alert.enmType.Success);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002464 File Offset: 0x00000664
		private void guna2ControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00009E64 File Offset: 0x00008064
		private void modSomeWeapon_Click(object sender, EventArgs e)
		{
			this.func.StartKernel();
			string procID = this.func.GetProcID();
			this.func.Rep(procID, "4C 1E 9A 00 00 00 00 00 00 00", "7E F9 9F 41");
			this.func.Rep(procID, "0C 09 BC 01 00 00 00 00 00 00", "ED DA 33 3C");
			this.func.Rep(procID, "24 A4 9B 00 00 00 00 00 00 00", "8C 33 AF 41");
			this.func.Rep(procID, "00 02 20 10 00 00 00 00 00 00", "85 37 AF 41");
			this.func.Rep(procID, "C4 2A 9D 00 00 00 00 00 00 00", "0D 76 BE 41");
			this.func.Rep(procID, "28 2B 9D 00 00 00 00 00 00 00", "AE 79 BE 41");
			this.func.Alert("Some weapon done!!!", Form_Alert.enmType.Success);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00009F20 File Offset: 0x00008120
		private void modM762StrayRebellion_Click(object sender, EventArgs e)
		{
			this.func.StartKernel();
			string procID = this.func.GetProcID();
			this.func.Rep(procID, "40 20 9A 00 00 00 00 00 00 00", "D1 0C A0 41");
			this.func.Rep(procID, "00 0B BC 01 00 00 00 00 00 00", "2B 9C 34 3C");
			this.func.Alert("Mod M762 Stray Rebellion done!", Form_Alert.enmType.Success);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00009F84 File Offset: 0x00008184
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00009FB4 File Offset: 0x000081B4
		private void InitializeComponent()
		{
            this.modAWMGodzila = new Guna.UI2.WinForms.Guna2Button();
            this.modAKMWanderingTyrant = new Guna.UI2.WinForms.Guna2Button();
            this.modGrozaRiverStyx = new Guna.UI2.WinForms.Guna2Button();
            this.modAKMGlacier = new Guna.UI2.WinForms.Guna2Button();
            this.modAWMFlameware = new Guna.UI2.WinForms.Guna2Button();
            this.modM416GlacierV1 = new Guna.UI2.WinForms.Guna2Button();
            this.modM416GlacierV2 = new Guna.UI2.WinForms.Guna2Button();
            this.modAKMStarseaAdmiral = new Guna.UI2.WinForms.Guna2Button();
            this.modM416ImperialSplendor = new Guna.UI2.WinForms.Guna2Button();
            this.modM416SilverGuru = new Guna.UI2.WinForms.Guna2Button();
            this.modM416Lizard = new Guna.UI2.WinForms.Guna2Button();
            this.modM416Joker = new Guna.UI2.WinForms.Guna2Button();
            this.modEffectM416GlacierV2 = new Guna.UI2.WinForms.Guna2Button();
            this.modSomeWeapon = new Guna.UI2.WinForms.Guna2Button();
            this.modM762StrayRebellion = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // modAWMGodzila
            // 
            this.modAWMGodzila.BorderRadius = 5;
            this.modAWMGodzila.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.modAWMGodzila.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.modAWMGodzila.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.modAWMGodzila.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.modAWMGodzila.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.modAWMGodzila.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modAWMGodzila.ForeColor = System.Drawing.Color.White;
            this.modAWMGodzila.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.modAWMGodzila.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.modAWMGodzila.HoverState.ForeColor = System.Drawing.Color.Black;
            this.modAWMGodzila.Location = new System.Drawing.Point(275, 302);
            this.modAWMGodzila.Name = "modAWMGodzila";
            this.modAWMGodzila.Size = new System.Drawing.Size(230, 45);
            this.modAWMGodzila.TabIndex = 23;
            this.modAWMGodzila.Text = "AWM Godzilla";
            // 
            // modAKMWanderingTyrant
            // 
            this.modAKMWanderingTyrant.BorderRadius = 5;
            this.modAKMWanderingTyrant.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.modAKMWanderingTyrant.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.modAKMWanderingTyrant.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.modAKMWanderingTyrant.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.modAKMWanderingTyrant.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.modAKMWanderingTyrant.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modAKMWanderingTyrant.ForeColor = System.Drawing.Color.White;
            this.modAKMWanderingTyrant.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.modAKMWanderingTyrant.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.modAKMWanderingTyrant.HoverState.ForeColor = System.Drawing.Color.Black;
            this.modAKMWanderingTyrant.Location = new System.Drawing.Point(275, 198);
            this.modAKMWanderingTyrant.Name = "modAKMWanderingTyrant";
            this.modAKMWanderingTyrant.Size = new System.Drawing.Size(230, 45);
            this.modAKMWanderingTyrant.TabIndex = 15;
            this.modAKMWanderingTyrant.Text = "AKM Wandering Tyrant";
            // 
            // modGrozaRiverStyx
            // 
            this.modGrozaRiverStyx.BorderRadius = 5;
            this.modGrozaRiverStyx.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.modGrozaRiverStyx.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.modGrozaRiverStyx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.modGrozaRiverStyx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.modGrozaRiverStyx.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.modGrozaRiverStyx.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modGrozaRiverStyx.ForeColor = System.Drawing.Color.White;
            this.modGrozaRiverStyx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.modGrozaRiverStyx.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.modGrozaRiverStyx.HoverState.ForeColor = System.Drawing.Color.Black;
            this.modGrozaRiverStyx.Location = new System.Drawing.Point(23, 301);
            this.modGrozaRiverStyx.Name = "modGrozaRiverStyx";
            this.modGrozaRiverStyx.Size = new System.Drawing.Size(230, 45);
            this.modGrozaRiverStyx.TabIndex = 21;
            this.modGrozaRiverStyx.Text = "Groza River Styx";
            // 
            // modAKMGlacier
            // 
            this.modAKMGlacier.BorderRadius = 5;
            this.modAKMGlacier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.modAKMGlacier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.modAKMGlacier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.modAKMGlacier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.modAKMGlacier.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.modAKMGlacier.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modAKMGlacier.ForeColor = System.Drawing.Color.White;
            this.modAKMGlacier.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.modAKMGlacier.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.modAKMGlacier.HoverState.ForeColor = System.Drawing.Color.Black;
            this.modAKMGlacier.Location = new System.Drawing.Point(23, 250);
            this.modAKMGlacier.Name = "modAKMGlacier";
            this.modAKMGlacier.Size = new System.Drawing.Size(230, 45);
            this.modAKMGlacier.TabIndex = 22;
            this.modAKMGlacier.Text = "AKM Glacier";
            // 
            // modAWMFlameware
            // 
            this.modAWMFlameware.BorderRadius = 5;
            this.modAWMFlameware.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.modAWMFlameware.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.modAWMFlameware.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.modAWMFlameware.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.modAWMFlameware.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.modAWMFlameware.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modAWMFlameware.ForeColor = System.Drawing.Color.White;
            this.modAWMFlameware.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.modAWMFlameware.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.modAWMFlameware.HoverState.ForeColor = System.Drawing.Color.Black;
            this.modAWMFlameware.Location = new System.Drawing.Point(23, 353);
            this.modAWMFlameware.Name = "modAWMFlameware";
            this.modAWMFlameware.Size = new System.Drawing.Size(230, 45);
            this.modAWMFlameware.TabIndex = 16;
            this.modAWMFlameware.Text = "AWM Flameware";
            this.modAWMFlameware.Click += new System.EventHandler(this.modAWMFlameware_Click_1);
            // 
            // modM416GlacierV1
            // 
            this.modM416GlacierV1.BorderRadius = 5;
            this.modM416GlacierV1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.modM416GlacierV1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.modM416GlacierV1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.modM416GlacierV1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.modM416GlacierV1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.modM416GlacierV1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.modM416GlacierV1.ForeColor = System.Drawing.Color.White;
            this.modM416GlacierV1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.modM416GlacierV1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.modM416GlacierV1.HoverState.ForeColor = System.Drawing.Color.Black;
            this.modM416GlacierV1.Location = new System.Drawing.Point(23, 42);
            this.modM416GlacierV1.Name = "modM416GlacierV1";
            this.modM416GlacierV1.Size = new System.Drawing.Size(230, 45);
            this.modM416GlacierV1.TabIndex = 12;
            this.modM416GlacierV1.Text = "M416 Glacier v1";
            // 
            // modM416GlacierV2
            // 
            this.modM416GlacierV2.BorderRadius = 5;
            this.modM416GlacierV2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.modM416GlacierV2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.modM416GlacierV2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.modM416GlacierV2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.modM416GlacierV2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.modM416GlacierV2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.modM416GlacierV2.ForeColor = System.Drawing.Color.White;
            this.modM416GlacierV2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.modM416GlacierV2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.modM416GlacierV2.HoverState.ForeColor = System.Drawing.Color.Black;
            this.modM416GlacierV2.Location = new System.Drawing.Point(275, 42);
            this.modM416GlacierV2.Name = "modM416GlacierV2";
            this.modM416GlacierV2.Size = new System.Drawing.Size(118, 45);
            this.modM416GlacierV2.TabIndex = 13;
            this.modM416GlacierV2.Text = "M416 Glacier V2";
            // 
            // modAKMStarseaAdmiral
            // 
            this.modAKMStarseaAdmiral.BorderRadius = 5;
            this.modAKMStarseaAdmiral.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.modAKMStarseaAdmiral.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.modAKMStarseaAdmiral.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.modAKMStarseaAdmiral.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.modAKMStarseaAdmiral.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.modAKMStarseaAdmiral.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modAKMStarseaAdmiral.ForeColor = System.Drawing.Color.White;
            this.modAKMStarseaAdmiral.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.modAKMStarseaAdmiral.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.modAKMStarseaAdmiral.HoverState.ForeColor = System.Drawing.Color.Black;
            this.modAKMStarseaAdmiral.Location = new System.Drawing.Point(23, 198);
            this.modAKMStarseaAdmiral.Name = "modAKMStarseaAdmiral";
            this.modAKMStarseaAdmiral.Size = new System.Drawing.Size(230, 45);
            this.modAKMStarseaAdmiral.TabIndex = 14;
            this.modAKMStarseaAdmiral.Text = "AKM Starsea Admiral";
            // 
            // modM416ImperialSplendor
            // 
            this.modM416ImperialSplendor.BorderRadius = 5;
            this.modM416ImperialSplendor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.modM416ImperialSplendor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.modM416ImperialSplendor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.modM416ImperialSplendor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.modM416ImperialSplendor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.modM416ImperialSplendor.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modM416ImperialSplendor.ForeColor = System.Drawing.Color.White;
            this.modM416ImperialSplendor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.modM416ImperialSplendor.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.modM416ImperialSplendor.HoverState.ForeColor = System.Drawing.Color.Black;
            this.modM416ImperialSplendor.Location = new System.Drawing.Point(275, 94);
            this.modM416ImperialSplendor.Name = "modM416ImperialSplendor";
            this.modM416ImperialSplendor.Size = new System.Drawing.Size(230, 45);
            this.modM416ImperialSplendor.TabIndex = 19;
            this.modM416ImperialSplendor.Text = "M416 Imperial Splendor";
            // 
            // modM416SilverGuru
            // 
            this.modM416SilverGuru.BorderRadius = 5;
            this.modM416SilverGuru.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.modM416SilverGuru.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.modM416SilverGuru.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.modM416SilverGuru.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.modM416SilverGuru.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.modM416SilverGuru.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modM416SilverGuru.ForeColor = System.Drawing.Color.White;
            this.modM416SilverGuru.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.modM416SilverGuru.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.modM416SilverGuru.HoverState.ForeColor = System.Drawing.Color.Black;
            this.modM416SilverGuru.Location = new System.Drawing.Point(23, 94);
            this.modM416SilverGuru.Name = "modM416SilverGuru";
            this.modM416SilverGuru.Size = new System.Drawing.Size(230, 45);
            this.modM416SilverGuru.TabIndex = 20;
            this.modM416SilverGuru.Text = "M416 Silver Guru";
            // 
            // modM416Lizard
            // 
            this.modM416Lizard.BorderRadius = 5;
            this.modM416Lizard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.modM416Lizard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.modM416Lizard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.modM416Lizard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.modM416Lizard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.modM416Lizard.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modM416Lizard.ForeColor = System.Drawing.Color.White;
            this.modM416Lizard.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.modM416Lizard.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.modM416Lizard.HoverState.ForeColor = System.Drawing.Color.Black;
            this.modM416Lizard.Location = new System.Drawing.Point(275, 146);
            this.modM416Lizard.Name = "modM416Lizard";
            this.modM416Lizard.Size = new System.Drawing.Size(230, 45);
            this.modM416Lizard.TabIndex = 18;
            this.modM416Lizard.Text = "M416 Lizard";
            // 
            // modM416Joker
            // 
            this.modM416Joker.BorderRadius = 5;
            this.modM416Joker.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.modM416Joker.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.modM416Joker.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.modM416Joker.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.modM416Joker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.modM416Joker.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modM416Joker.ForeColor = System.Drawing.Color.White;
            this.modM416Joker.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.modM416Joker.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.modM416Joker.HoverState.ForeColor = System.Drawing.Color.Black;
            this.modM416Joker.Location = new System.Drawing.Point(23, 146);
            this.modM416Joker.Name = "modM416Joker";
            this.modM416Joker.Size = new System.Drawing.Size(230, 45);
            this.modM416Joker.TabIndex = 17;
            this.modM416Joker.Text = "M416 Joker";
            // 
            // modEffectM416GlacierV2
            // 
            this.modEffectM416GlacierV2.BorderRadius = 5;
            this.modEffectM416GlacierV2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.modEffectM416GlacierV2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.modEffectM416GlacierV2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.modEffectM416GlacierV2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.modEffectM416GlacierV2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.modEffectM416GlacierV2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.modEffectM416GlacierV2.ForeColor = System.Drawing.Color.White;
            this.modEffectM416GlacierV2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.modEffectM416GlacierV2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.modEffectM416GlacierV2.HoverState.ForeColor = System.Drawing.Color.Black;
            this.modEffectM416GlacierV2.Location = new System.Drawing.Point(399, 42);
            this.modEffectM416GlacierV2.Name = "modEffectM416GlacierV2";
            this.modEffectM416GlacierV2.Size = new System.Drawing.Size(106, 45);
            this.modEffectM416GlacierV2.TabIndex = 24;
            this.modEffectM416GlacierV2.Text = "<-Effect v2";
            // 
            // modSomeWeapon
            // 
            this.modSomeWeapon.BorderRadius = 5;
            this.modSomeWeapon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.modSomeWeapon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.modSomeWeapon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.modSomeWeapon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.modSomeWeapon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(150)))));
            this.modSomeWeapon.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modSomeWeapon.ForeColor = System.Drawing.Color.White;
            this.modSomeWeapon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.modSomeWeapon.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.modSomeWeapon.HoverState.ForeColor = System.Drawing.Color.Black;
            this.modSomeWeapon.Location = new System.Drawing.Point(275, 353);
            this.modSomeWeapon.Name = "modSomeWeapon";
            this.modSomeWeapon.Size = new System.Drawing.Size(230, 45);
            this.modSomeWeapon.TabIndex = 25;
            this.modSomeWeapon.Text = "Mod some weapon (SCAR-L, KAR-98,...)";
            // 
            // modM762StrayRebellion
            // 
            this.modM762StrayRebellion.BorderRadius = 5;
            this.modM762StrayRebellion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.modM762StrayRebellion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.modM762StrayRebellion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.modM762StrayRebellion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.modM762StrayRebellion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.modM762StrayRebellion.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modM762StrayRebellion.ForeColor = System.Drawing.Color.White;
            this.modM762StrayRebellion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.modM762StrayRebellion.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.modM762StrayRebellion.HoverState.ForeColor = System.Drawing.Color.Black;
            this.modM762StrayRebellion.Location = new System.Drawing.Point(275, 249);
            this.modM762StrayRebellion.Name = "modM762StrayRebellion";
            this.modM762StrayRebellion.Size = new System.Drawing.Size(230, 45);
            this.modM762StrayRebellion.TabIndex = 26;
            this.modM762StrayRebellion.Text = "M762 Stray Rebellion";
            // 
            // weaponPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.modM762StrayRebellion);
            this.Controls.Add(this.modSomeWeapon);
            this.Controls.Add(this.modEffectM416GlacierV2);
            this.Controls.Add(this.modAWMGodzila);
            this.Controls.Add(this.modAKMWanderingTyrant);
            this.Controls.Add(this.modGrozaRiverStyx);
            this.Controls.Add(this.modAKMGlacier);
            this.Controls.Add(this.modAWMFlameware);
            this.Controls.Add(this.modM416GlacierV1);
            this.Controls.Add(this.modM416GlacierV2);
            this.Controls.Add(this.modAKMStarseaAdmiral);
            this.Controls.Add(this.modM416ImperialSplendor);
            this.Controls.Add(this.modM416SilverGuru);
            this.Controls.Add(this.modM416Lizard);
            this.Controls.Add(this.modM416Joker);
            this.Name = "weaponPanel";
            this.Size = new System.Drawing.Size(528, 436);
            this.ResumeLayout(false);

		}

		// Token: 0x0400008F RID: 143
		private functions func;

		// Token: 0x04000090 RID: 144
		private IContainer components = null;

		// Token: 0x04000091 RID: 145
		private Guna2Button modAWMGodzila;

		// Token: 0x04000092 RID: 146
		private Guna2Button modAKMWanderingTyrant;

		// Token: 0x04000093 RID: 147
		private Guna2Button modGrozaRiverStyx;

		// Token: 0x04000094 RID: 148
		private Guna2Button modAKMGlacier;

		// Token: 0x04000095 RID: 149
		private Guna2Button modAWMFlameware;

		// Token: 0x04000096 RID: 150
		private Guna2Button modM416GlacierV1;

		// Token: 0x04000097 RID: 151
		private Guna2Button modM416GlacierV2;

		// Token: 0x04000098 RID: 152
		private Guna2Button modAKMStarseaAdmiral;

		// Token: 0x04000099 RID: 153
		private Guna2Button modM416ImperialSplendor;

		// Token: 0x0400009A RID: 154
		private Guna2Button modM416SilverGuru;

		// Token: 0x0400009B RID: 155
		private Guna2Button modM416Lizard;

		// Token: 0x0400009C RID: 156
		private Guna2Button modM416Joker;

		// Token: 0x0400009D RID: 157
		private Guna2Button modEffectM416GlacierV2;

		// Token: 0x0400009E RID: 158
		private Guna2Button modSomeWeapon;

		// Token: 0x0400009F RID: 159
		private Guna2Button modM762StrayRebellion;

        private void modAWMFlameware_Click_1(object sender, EventArgs e)
        {

        }
    }
}
