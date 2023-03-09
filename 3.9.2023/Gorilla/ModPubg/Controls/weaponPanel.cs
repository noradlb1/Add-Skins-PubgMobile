using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using ModPubg.fClass;

namespace ModPubg.Controls
{
	// Token: 0x02000027 RID: 39
	public class weaponPanel : UserControl
	{
		// Token: 0x0600011A RID: 282 RVA: 0x0000B380 File Offset: 0x00009580
		public weaponPanel()
		{
			this.func = new functions();
			this.InitializeComponent();
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000B3AC File Offset: 0x000095AC
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

		// Token: 0x0600011C RID: 284 RVA: 0x0000B450 File Offset: 0x00009650
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

		// Token: 0x0600011D RID: 285 RVA: 0x0000B4F4 File Offset: 0x000096F4
		private void modEffectM416GlacierV2_Click(object sender, EventArgs e)
		{
			this.func.StartKernel();
			string procID = this.func.GetProcID();
			this.func.Rep(procID, "E6 FC 9F 41", "0E FD 9F 41");
			this.func.Alert("Mod Effect M416 Glacier V2 done!", Form_Alert.enmType.Success);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000B540 File Offset: 0x00009740
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

		// Token: 0x0600011F RID: 287 RVA: 0x0000B5E4 File Offset: 0x000097E4
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

		// Token: 0x06000120 RID: 288 RVA: 0x0000B688 File Offset: 0x00009888
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

		// Token: 0x06000121 RID: 289 RVA: 0x0000B72C File Offset: 0x0000992C
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

		// Token: 0x06000122 RID: 290 RVA: 0x0000B7BC File Offset: 0x000099BC
		private void modAKMStarseaAdmiral_Click(object sender, EventArgs e)
		{
			this.func.StartKernel();
			string procID = this.func.GetProcID();
			this.func.Rep(procID, "84 1D 9A 00 00 00 00 00 00 00", "FD F1 9F 41");
			this.func.Rep(procID, "44 08 BC 01 00 00 00 00 00 00", "E3 8F 33 3C");
			this.func.Alert("Mod AKM Starsea Admiral done!", Form_Alert.enmType.Success);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0000B820 File Offset: 0x00009A20
		private void modAKMWanderingTyrant_Click(object sender, EventArgs e)
		{
			this.func.StartKernel();
			string procID = this.func.GetProcID();
			this.func.Rep(procID, "84 1D 9A 00 00 00 00 00 00 00", "D3 F1 9F 41");
			this.func.Rep(procID, "44 08 BC 01 00 00 00 00 00 00", "3F 8E 33 3C");
			this.func.Alert("Mod AKM Wandering Tyrant done!", Form_Alert.enmType.Success);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0000B884 File Offset: 0x00009A84
		private void modAKMGlacier_Click(object sender, EventArgs e)
		{
			this.func.StartKernel();
			string procID = this.func.GetProcID();
			this.func.Rep(procID, "84 1D 9A 00 00 00 00 00 00 00", "81 F1 9F 41");
			this.func.Rep(procID, "44 08 BC 01 00 00 00 00 00 00", "0B 8B 33 3C");
			this.func.Alert("Mod AKM Glacier done!", Form_Alert.enmType.Success);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0000B8E8 File Offset: 0x00009AE8
		private void modGrozaRiverStyx_Click(object sender, EventArgs e)
		{
			string procID = this.func.GetProcID();
			this.func.Rep(procID, "14 1F 9A 00 00 00 00 00 00 00", "FC 00 A0 41");
			this.func.Rep(procID, "D4 09 BC 01 00 00 00 00 00 00", "D9 25 34 3C");
			this.func.Alert("Mod Groza River Styx done!", Form_Alert.enmType.Success);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000B940 File Offset: 0x00009B40
		private void modAWMFlameware_Click(object sender, EventArgs e)
		{
			this.func.StartKernel();
			string procID = this.func.GetProcID();
			this.func.Rep(procID, "8C 2B 9D 00 00 00 00 00 00 00", "B6 7D BE 41");
			this.func.Alert("Mod AWM Flameware done!", Form_Alert.enmType.Success);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0000B98C File Offset: 0x00009B8C
		private void modAWMGodzila_Click(object sender, EventArgs e)
		{
			this.func.StartKernel();
			string procID = this.func.GetProcID();
			this.func.Rep(procID, "8C 2B 9D 00 00 00 00 00 00 00", "A2 7D BE 41");
			this.func.Alert("Mod AWM Godzila done!", Form_Alert.enmType.Success);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00005C70 File Offset: 0x00003E70
		private void guna2ControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0000B9D8 File Offset: 0x00009BD8
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
			this.func.Rep(procID, "88 A4 9B 00 00 00 00 00 00 00", "7B 37 AF 41");
			this.func.Rep(procID, "48 8F BD 01 00 00 00 00 00 00", "CF 46 CC 3C");
			this.func.Rep(procID, "24 A4 9B 00 00 00 00 00 00 00", "A2 33 AF 41");
			this.func.Rep(procID, "E4 8E BD 01 00 00 00 00 00 00", "55 20 CC 3C");
			this.func.Rep(procID, "EC A4 9B 00 00 00 00 00 00 00", "5F 3B AF 41");
			this.func.Rep(procID, "AC 8F BD 01 00 00 00 00 00 00", "B7 6D CC 3C");
			this.func.Rep(procID, "B8 2C 9D 00 00 00 00 00 00 00", "4E 89 BE 41");
			this.func.Rep(procID, "78 17 BF 01 00 00 00 00 00 00", "0D 79 65 3D");
			this.func.Alert("Some weapon done!!!", Form_Alert.enmType.Success);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x0000BB44 File Offset: 0x00009D44
		private void modM762StrayRebellion_Click(object sender, EventArgs e)
		{
			this.func.StartKernel();
			string procID = this.func.GetProcID();
			this.func.Rep(procID, "40 20 9A 00 00 00 00 00 00 00", "D1 0C A0 41");
			this.func.Rep(procID, "00 0B BC 01 00 00 00 00 00 00", "2B 9C 34 3C");
			this.func.Alert("Mod M762 Stray Rebellion done!", Form_Alert.enmType.Success);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0000BBA8 File Offset: 0x00009DA8
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0000BBD8 File Offset: 0x00009DD8
		private void InitializeComponent()
		{
			this.modAWMGodzila = new Guna2Button();
			this.modAKMWanderingTyrant = new Guna2Button();
			this.modGrozaRiverStyx = new Guna2Button();
			this.modAKMGlacier = new Guna2Button();
			this.modAWMFlameware = new Guna2Button();
			this.modM416GlacierV1 = new Guna2Button();
			this.modM416GlacierV2 = new Guna2Button();
			this.modAKMStarseaAdmiral = new Guna2Button();
			this.modM416ImperialSplendor = new Guna2Button();
			this.modM416SilverGuru = new Guna2Button();
			this.modM416Lizard = new Guna2Button();
			this.modM416Joker = new Guna2Button();
			this.modEffectM416GlacierV2 = new Guna2Button();
			this.modSomeWeapon = new Guna2Button();
			this.modM762StrayRebellion = new Guna2Button();
			base.SuspendLayout();
			this.modAWMGodzila.BorderRadius = 5;
			this.modAWMGodzila.DisabledState.BorderColor = Color.DarkGray;
			this.modAWMGodzila.DisabledState.CustomBorderColor = Color.DarkGray;
			this.modAWMGodzila.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.modAWMGodzila.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.modAWMGodzila.FillColor = Color.FromArgb(128, 128, 255);
			this.modAWMGodzila.Font = new Font("Segoe UI Semibold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.modAWMGodzila.ForeColor = Color.White;
			this.modAWMGodzila.HoverState.BorderColor = Color.FromArgb(0, 0, 192);
			this.modAWMGodzila.HoverState.FillColor = Color.FromArgb(128, 128, 255);
			this.modAWMGodzila.HoverState.ForeColor = Color.Black;
			this.modAWMGodzila.Location = new Point(275, 302);
			this.modAWMGodzila.Name = "modAWMGodzila";
			this.modAWMGodzila.Size = new Size(230, 45);
			this.modAWMGodzila.TabIndex = 23;
			this.modAWMGodzila.Text = "AWM Godzilla";
			this.modAWMGodzila.Click += this.modAWMGodzila_Click;
			this.modAKMWanderingTyrant.BorderRadius = 5;
			this.modAKMWanderingTyrant.DisabledState.BorderColor = Color.DarkGray;
			this.modAKMWanderingTyrant.DisabledState.CustomBorderColor = Color.DarkGray;
			this.modAKMWanderingTyrant.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.modAKMWanderingTyrant.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.modAKMWanderingTyrant.FillColor = Color.FromArgb(128, 128, 255);
			this.modAKMWanderingTyrant.Font = new Font("Segoe UI Semibold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.modAKMWanderingTyrant.ForeColor = Color.White;
			this.modAKMWanderingTyrant.HoverState.BorderColor = Color.FromArgb(0, 0, 192);
			this.modAKMWanderingTyrant.HoverState.FillColor = Color.FromArgb(128, 128, 255);
			this.modAKMWanderingTyrant.HoverState.ForeColor = Color.Black;
			this.modAKMWanderingTyrant.Location = new Point(275, 198);
			this.modAKMWanderingTyrant.Name = "modAKMWanderingTyrant";
			this.modAKMWanderingTyrant.Size = new Size(230, 45);
			this.modAKMWanderingTyrant.TabIndex = 15;
			this.modAKMWanderingTyrant.Text = "AKM Wandering Tyrant";
			this.modAKMWanderingTyrant.Click += this.modAKMWanderingTyrant_Click;
			this.modGrozaRiverStyx.BorderRadius = 5;
			this.modGrozaRiverStyx.DisabledState.BorderColor = Color.DarkGray;
			this.modGrozaRiverStyx.DisabledState.CustomBorderColor = Color.DarkGray;
			this.modGrozaRiverStyx.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.modGrozaRiverStyx.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.modGrozaRiverStyx.FillColor = Color.FromArgb(128, 128, 255);
			this.modGrozaRiverStyx.Font = new Font("Segoe UI Semibold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.modGrozaRiverStyx.ForeColor = Color.White;
			this.modGrozaRiverStyx.HoverState.BorderColor = Color.FromArgb(0, 0, 192);
			this.modGrozaRiverStyx.HoverState.FillColor = Color.FromArgb(128, 128, 255);
			this.modGrozaRiverStyx.HoverState.ForeColor = Color.Black;
			this.modGrozaRiverStyx.Location = new Point(23, 301);
			this.modGrozaRiverStyx.Name = "modGrozaRiverStyx";
			this.modGrozaRiverStyx.Size = new Size(230, 45);
			this.modGrozaRiverStyx.TabIndex = 21;
			this.modGrozaRiverStyx.Text = "Groza River Styx";
			this.modGrozaRiverStyx.Click += this.modGrozaRiverStyx_Click;
			this.modAKMGlacier.BorderRadius = 5;
			this.modAKMGlacier.DisabledState.BorderColor = Color.DarkGray;
			this.modAKMGlacier.DisabledState.CustomBorderColor = Color.DarkGray;
			this.modAKMGlacier.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.modAKMGlacier.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.modAKMGlacier.FillColor = Color.FromArgb(128, 128, 255);
			this.modAKMGlacier.Font = new Font("Segoe UI Semibold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.modAKMGlacier.ForeColor = Color.White;
			this.modAKMGlacier.HoverState.BorderColor = Color.FromArgb(0, 0, 192);
			this.modAKMGlacier.HoverState.FillColor = Color.FromArgb(128, 128, 255);
			this.modAKMGlacier.HoverState.ForeColor = Color.Black;
			this.modAKMGlacier.Location = new Point(23, 250);
			this.modAKMGlacier.Name = "modAKMGlacier";
			this.modAKMGlacier.Size = new Size(230, 45);
			this.modAKMGlacier.TabIndex = 22;
			this.modAKMGlacier.Text = "AKM Glacier";
			this.modAKMGlacier.Click += this.modAKMGlacier_Click;
			this.modAWMFlameware.BorderRadius = 5;
			this.modAWMFlameware.DisabledState.BorderColor = Color.DarkGray;
			this.modAWMFlameware.DisabledState.CustomBorderColor = Color.DarkGray;
			this.modAWMFlameware.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.modAWMFlameware.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.modAWMFlameware.FillColor = Color.FromArgb(128, 128, 255);
			this.modAWMFlameware.Font = new Font("Segoe UI Semibold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.modAWMFlameware.ForeColor = Color.White;
			this.modAWMFlameware.HoverState.BorderColor = Color.FromArgb(0, 0, 192);
			this.modAWMFlameware.HoverState.FillColor = Color.FromArgb(128, 128, 255);
			this.modAWMFlameware.HoverState.ForeColor = Color.Black;
			this.modAWMFlameware.Location = new Point(23, 353);
			this.modAWMFlameware.Name = "modAWMFlameware";
			this.modAWMFlameware.Size = new Size(230, 45);
			this.modAWMFlameware.TabIndex = 16;
			this.modAWMFlameware.Text = "AWM Flameware";
			this.modAWMFlameware.Click += this.modAWMFlameware_Click;
			this.modM416GlacierV1.BorderRadius = 5;
			this.modM416GlacierV1.DisabledState.BorderColor = Color.DarkGray;
			this.modM416GlacierV1.DisabledState.CustomBorderColor = Color.DarkGray;
			this.modM416GlacierV1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.modM416GlacierV1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.modM416GlacierV1.FillColor = Color.FromArgb(128, 128, 255);
			this.modM416GlacierV1.Font = new Font("Segoe UI Semibold", 11.25f, FontStyle.Bold);
			this.modM416GlacierV1.ForeColor = Color.White;
			this.modM416GlacierV1.HoverState.BorderColor = Color.FromArgb(0, 0, 192);
			this.modM416GlacierV1.HoverState.FillColor = Color.FromArgb(128, 128, 255);
			this.modM416GlacierV1.HoverState.ForeColor = Color.Black;
			this.modM416GlacierV1.Location = new Point(23, 42);
			this.modM416GlacierV1.Name = "modM416GlacierV1";
			this.modM416GlacierV1.Size = new Size(230, 45);
			this.modM416GlacierV1.TabIndex = 12;
			this.modM416GlacierV1.Text = "M416 Glacier v1";
			this.modM416GlacierV1.Click += this.modM416GlacierV1_Click;
			this.modM416GlacierV2.BorderRadius = 5;
			this.modM416GlacierV2.DisabledState.BorderColor = Color.DarkGray;
			this.modM416GlacierV2.DisabledState.CustomBorderColor = Color.DarkGray;
			this.modM416GlacierV2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.modM416GlacierV2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.modM416GlacierV2.FillColor = Color.FromArgb(128, 128, 255);
			this.modM416GlacierV2.Font = new Font("Segoe UI Semibold", 11.25f, FontStyle.Bold);
			this.modM416GlacierV2.ForeColor = Color.White;
			this.modM416GlacierV2.HoverState.BorderColor = Color.FromArgb(0, 0, 192);
			this.modM416GlacierV2.HoverState.FillColor = Color.FromArgb(128, 128, 255);
			this.modM416GlacierV2.HoverState.ForeColor = Color.Black;
			this.modM416GlacierV2.Location = new Point(275, 42);
			this.modM416GlacierV2.Name = "modM416GlacierV2";
			this.modM416GlacierV2.Size = new Size(118, 45);
			this.modM416GlacierV2.TabIndex = 13;
			this.modM416GlacierV2.Text = "M416 Glacier V2";
			this.modM416GlacierV2.Click += this.modM416GlacierV2_Click;
			this.modAKMStarseaAdmiral.BorderRadius = 5;
			this.modAKMStarseaAdmiral.DisabledState.BorderColor = Color.DarkGray;
			this.modAKMStarseaAdmiral.DisabledState.CustomBorderColor = Color.DarkGray;
			this.modAKMStarseaAdmiral.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.modAKMStarseaAdmiral.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.modAKMStarseaAdmiral.FillColor = Color.FromArgb(128, 128, 255);
			this.modAKMStarseaAdmiral.Font = new Font("Segoe UI Semibold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.modAKMStarseaAdmiral.ForeColor = Color.White;
			this.modAKMStarseaAdmiral.HoverState.BorderColor = Color.FromArgb(0, 0, 192);
			this.modAKMStarseaAdmiral.HoverState.FillColor = Color.FromArgb(128, 128, 255);
			this.modAKMStarseaAdmiral.HoverState.ForeColor = Color.Black;
			this.modAKMStarseaAdmiral.Location = new Point(23, 198);
			this.modAKMStarseaAdmiral.Name = "modAKMStarseaAdmiral";
			this.modAKMStarseaAdmiral.Size = new Size(230, 45);
			this.modAKMStarseaAdmiral.TabIndex = 14;
			this.modAKMStarseaAdmiral.Text = "AKM Starsea Admiral";
			this.modAKMStarseaAdmiral.Click += this.modAKMStarseaAdmiral_Click;
			this.modM416ImperialSplendor.BorderRadius = 5;
			this.modM416ImperialSplendor.DisabledState.BorderColor = Color.DarkGray;
			this.modM416ImperialSplendor.DisabledState.CustomBorderColor = Color.DarkGray;
			this.modM416ImperialSplendor.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.modM416ImperialSplendor.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.modM416ImperialSplendor.FillColor = Color.FromArgb(128, 128, 255);
			this.modM416ImperialSplendor.Font = new Font("Segoe UI Semibold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.modM416ImperialSplendor.ForeColor = Color.White;
			this.modM416ImperialSplendor.HoverState.BorderColor = Color.FromArgb(0, 0, 192);
			this.modM416ImperialSplendor.HoverState.FillColor = Color.FromArgb(128, 128, 255);
			this.modM416ImperialSplendor.HoverState.ForeColor = Color.Black;
			this.modM416ImperialSplendor.Location = new Point(275, 94);
			this.modM416ImperialSplendor.Name = "modM416ImperialSplendor";
			this.modM416ImperialSplendor.Size = new Size(230, 45);
			this.modM416ImperialSplendor.TabIndex = 19;
			this.modM416ImperialSplendor.Text = "M416 Imperial Splendor";
			this.modM416ImperialSplendor.Click += this.modM416ImperialSplendor_Click;
			this.modM416SilverGuru.BorderRadius = 5;
			this.modM416SilverGuru.DisabledState.BorderColor = Color.DarkGray;
			this.modM416SilverGuru.DisabledState.CustomBorderColor = Color.DarkGray;
			this.modM416SilverGuru.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.modM416SilverGuru.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.modM416SilverGuru.FillColor = Color.FromArgb(128, 128, 255);
			this.modM416SilverGuru.Font = new Font("Segoe UI Semibold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.modM416SilverGuru.ForeColor = Color.White;
			this.modM416SilverGuru.HoverState.BorderColor = Color.FromArgb(0, 0, 192);
			this.modM416SilverGuru.HoverState.FillColor = Color.FromArgb(128, 128, 255);
			this.modM416SilverGuru.HoverState.ForeColor = Color.Black;
			this.modM416SilverGuru.Location = new Point(23, 94);
			this.modM416SilverGuru.Name = "modM416SilverGuru";
			this.modM416SilverGuru.Size = new Size(230, 45);
			this.modM416SilverGuru.TabIndex = 20;
			this.modM416SilverGuru.Text = "M416 Silver Guru";
			this.modM416SilverGuru.Click += this.modM416SilverGuru_Click;
			this.modM416Lizard.BorderRadius = 5;
			this.modM416Lizard.DisabledState.BorderColor = Color.DarkGray;
			this.modM416Lizard.DisabledState.CustomBorderColor = Color.DarkGray;
			this.modM416Lizard.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.modM416Lizard.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.modM416Lizard.FillColor = Color.FromArgb(128, 128, 255);
			this.modM416Lizard.Font = new Font("Segoe UI Semibold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.modM416Lizard.ForeColor = Color.White;
			this.modM416Lizard.HoverState.BorderColor = Color.FromArgb(0, 0, 192);
			this.modM416Lizard.HoverState.FillColor = Color.FromArgb(128, 128, 255);
			this.modM416Lizard.HoverState.ForeColor = Color.Black;
			this.modM416Lizard.Location = new Point(275, 146);
			this.modM416Lizard.Name = "modM416Lizard";
			this.modM416Lizard.Size = new Size(230, 45);
			this.modM416Lizard.TabIndex = 18;
			this.modM416Lizard.Text = "M416 Lizard";
			this.modM416Lizard.Click += this.modM416Lizard_Click;
			this.modM416Joker.BorderRadius = 5;
			this.modM416Joker.DisabledState.BorderColor = Color.DarkGray;
			this.modM416Joker.DisabledState.CustomBorderColor = Color.DarkGray;
			this.modM416Joker.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.modM416Joker.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.modM416Joker.FillColor = Color.FromArgb(128, 128, 255);
			this.modM416Joker.Font = new Font("Segoe UI Semibold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.modM416Joker.ForeColor = Color.White;
			this.modM416Joker.HoverState.BorderColor = Color.FromArgb(0, 0, 192);
			this.modM416Joker.HoverState.FillColor = Color.FromArgb(128, 128, 255);
			this.modM416Joker.HoverState.ForeColor = Color.Black;
			this.modM416Joker.Location = new Point(23, 146);
			this.modM416Joker.Name = "modM416Joker";
			this.modM416Joker.Size = new Size(230, 45);
			this.modM416Joker.TabIndex = 17;
			this.modM416Joker.Text = "M416 Joker";
			this.modM416Joker.Click += this.modM416Joker_Click;
			this.modEffectM416GlacierV2.BorderRadius = 5;
			this.modEffectM416GlacierV2.DisabledState.BorderColor = Color.DarkGray;
			this.modEffectM416GlacierV2.DisabledState.CustomBorderColor = Color.DarkGray;
			this.modEffectM416GlacierV2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.modEffectM416GlacierV2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.modEffectM416GlacierV2.FillColor = Color.FromArgb(128, 128, 255);
			this.modEffectM416GlacierV2.Font = new Font("Segoe UI Semibold", 11.25f, FontStyle.Bold);
			this.modEffectM416GlacierV2.ForeColor = Color.White;
			this.modEffectM416GlacierV2.HoverState.BorderColor = Color.FromArgb(0, 0, 192);
			this.modEffectM416GlacierV2.HoverState.FillColor = Color.FromArgb(128, 128, 255);
			this.modEffectM416GlacierV2.HoverState.ForeColor = Color.Black;
			this.modEffectM416GlacierV2.Location = new Point(399, 42);
			this.modEffectM416GlacierV2.Name = "modEffectM416GlacierV2";
			this.modEffectM416GlacierV2.Size = new Size(106, 45);
			this.modEffectM416GlacierV2.TabIndex = 24;
			this.modEffectM416GlacierV2.Text = "<-Effect v2";
			this.modEffectM416GlacierV2.Click += this.modEffectM416GlacierV2_Click;
			this.modSomeWeapon.BorderRadius = 5;
			this.modSomeWeapon.DisabledState.BorderColor = Color.DarkGray;
			this.modSomeWeapon.DisabledState.CustomBorderColor = Color.DarkGray;
			this.modSomeWeapon.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.modSomeWeapon.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.modSomeWeapon.FillColor = Color.FromArgb(255, 140, 150);
			this.modSomeWeapon.Font = new Font("Segoe UI Semibold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.modSomeWeapon.ForeColor = Color.White;
			this.modSomeWeapon.HoverState.BorderColor = Color.FromArgb(0, 0, 192);
			this.modSomeWeapon.HoverState.FillColor = Color.FromArgb(128, 128, 255);
			this.modSomeWeapon.HoverState.ForeColor = Color.Black;
			this.modSomeWeapon.Location = new Point(275, 353);
			this.modSomeWeapon.Name = "modSomeWeapon";
			this.modSomeWeapon.Size = new Size(230, 45);
			this.modSomeWeapon.TabIndex = 25;
			this.modSomeWeapon.Text = "Mod some weapon (SCAR-L, KAR-98,...)";
			this.modSomeWeapon.Click += this.modSomeWeapon_Click;
			this.modM762StrayRebellion.BorderRadius = 5;
			this.modM762StrayRebellion.DisabledState.BorderColor = Color.DarkGray;
			this.modM762StrayRebellion.DisabledState.CustomBorderColor = Color.DarkGray;
			this.modM762StrayRebellion.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.modM762StrayRebellion.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.modM762StrayRebellion.FillColor = Color.FromArgb(128, 128, 255);
			this.modM762StrayRebellion.Font = new Font("Segoe UI Semibold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.modM762StrayRebellion.ForeColor = Color.White;
			this.modM762StrayRebellion.HoverState.BorderColor = Color.FromArgb(0, 0, 192);
			this.modM762StrayRebellion.HoverState.FillColor = Color.FromArgb(128, 128, 255);
			this.modM762StrayRebellion.HoverState.ForeColor = Color.Black;
			this.modM762StrayRebellion.Location = new Point(275, 249);
			this.modM762StrayRebellion.Name = "modM762StrayRebellion";
			this.modM762StrayRebellion.Size = new Size(230, 45);
			this.modM762StrayRebellion.TabIndex = 26;
			this.modM762StrayRebellion.Text = "M762 Stray Rebellion";
			this.modM762StrayRebellion.Click += this.modM762StrayRebellion_Click;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.White;
			base.Controls.Add(this.modM762StrayRebellion);
			base.Controls.Add(this.modSomeWeapon);
			base.Controls.Add(this.modEffectM416GlacierV2);
			base.Controls.Add(this.modAWMGodzila);
			base.Controls.Add(this.modAKMWanderingTyrant);
			base.Controls.Add(this.modGrozaRiverStyx);
			base.Controls.Add(this.modAKMGlacier);
			base.Controls.Add(this.modAWMFlameware);
			base.Controls.Add(this.modM416GlacierV1);
			base.Controls.Add(this.modM416GlacierV2);
			base.Controls.Add(this.modAKMStarseaAdmiral);
			base.Controls.Add(this.modM416ImperialSplendor);
			base.Controls.Add(this.modM416SilverGuru);
			base.Controls.Add(this.modM416Lizard);
			base.Controls.Add(this.modM416Joker);
			base.Name = "weaponPanel";
			base.Size = new Size(528, 436);
			base.ResumeLayout(false);
		}

		// Token: 0x040000BA RID: 186
		private functions func;

		// Token: 0x040000BB RID: 187
		private IContainer components = null;

		// Token: 0x040000BC RID: 188
		private Guna2Button modAWMGodzila;

		// Token: 0x040000BD RID: 189
		private Guna2Button modAKMWanderingTyrant;

		// Token: 0x040000BE RID: 190
		private Guna2Button modGrozaRiverStyx;

		// Token: 0x040000BF RID: 191
		private Guna2Button modAKMGlacier;

		// Token: 0x040000C0 RID: 192
		private Guna2Button modAWMFlameware;

		// Token: 0x040000C1 RID: 193
		private Guna2Button modM416GlacierV1;

		// Token: 0x040000C2 RID: 194
		private Guna2Button modM416GlacierV2;

		// Token: 0x040000C3 RID: 195
		private Guna2Button modAKMStarseaAdmiral;

		// Token: 0x040000C4 RID: 196
		private Guna2Button modM416ImperialSplendor;

		// Token: 0x040000C5 RID: 197
		private Guna2Button modM416SilverGuru;

		// Token: 0x040000C6 RID: 198
		private Guna2Button modM416Lizard;

		// Token: 0x040000C7 RID: 199
		private Guna2Button modM416Joker;

		// Token: 0x040000C8 RID: 200
		private Guna2Button modEffectM416GlacierV2;

		// Token: 0x040000C9 RID: 201
		private Guna2Button modSomeWeapon;

		// Token: 0x040000CA RID: 202
		private Guna2Button modM762StrayRebellion;
	}
}
