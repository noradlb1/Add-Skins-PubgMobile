using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using ModPubg.fClass;
using ModPubg.Properties;

namespace ModPubg.fControls
{
	// Token: 0x02000025 RID: 37
	public class others : UserControl
	{
		// Token: 0x06000109 RID: 265 RVA: 0x00009844 File Offset: 0x00007A44
		public others()
		{
			this.func = new functions();
			this.InitializeComponent();
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00009870 File Offset: 0x00007A70
		private void modInfernoRiderHelmet_Click(object sender, EventArgs e)
		{
			this.func.StartKernel();
			string procID = this.func.GetProcID();
			this.func.Rep(procID, "F1 A8 07 00 00 00 00 00", "76 B7 86 59");
			this.func.Rep(procID, "F2 A8 07 00 00 00 00 00", "5E BB 86 59");
			this.func.Rep(procID, "F3 A8 07 00 00 00 00 00", "46 BF 86 59");
			this.func.Rep(procID, "F4 A8 07 00 00 00 00 00", "76 B7 86 59");
			this.func.Rep(procID, "F5 A8 07 00 00 00 00 00", "5E BB 86 59");
			this.func.Rep(procID, "F6 A8 07 00 00 00 00 00", "46 BF 86 59");
			this.func.Alert("Mod Inferno Rider Helmet", Form_Alert.enmType.Success);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0000992C File Offset: 0x00007B2C
		private void modSomeVehicle_Click(object sender, EventArgs e)
		{
			this.func.StartKernel();
			string procID = this.func.GetProcID();
			this.func.Rep(procID, "29 EC 1D 00 00 00 00 00 00", "3D EC 1D");
			this.func.Rep(procID, "99 09 1D 00 00 00 00 00 00", "E7 09 1D");
			this.func.Rep(procID, "9A 09 1D 00 00 00 00 00 00", "E7 09 1D");
			this.func.Rep(procID, "9B 09 1D 00 00 00 00 00 00", "E7 09 1D");
			this.func.Rep(procID, "9C 09 1D 00 00 00 00 00 00", "E7 09 1D");
			this.func.Rep(procID, "9D 09 1D 00 00 00 00 00 00", "E7 09 1D");
			this.func.Rep(procID, "21 1D 1D 00 00 00 00 00 00", "63 1D 1D");
			this.func.Rep(procID, "09 21 1D 00 00 00 00 00 00", "15 21 1D");
			this.func.Rep(procID, "F1 24 1D 00 00 00 00 00 00", "FA 24 1D");
			this.func.Alert("Set Vehicle skin done!!!", Form_Alert.enmType.Success);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00009A28 File Offset: 0x00007C28
		private void modAobFromTextboxBtn_Click(object sender, EventArgs e)
		{
			this.func.StartKernel();
			string procID = this.func.GetProcID();
			this.func.Rep(procID, this.scanAobTextbox.Text, this.replaceAobTextbox.Text);
			this.func.Alert("Mod from AOB done!", Form_Alert.enmType.Success);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00009A80 File Offset: 0x00007C80
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00009AB0 File Offset: 0x00007CB0
		private void InitializeComponent()
		{
			this.modInfernoRiderHelmet = new Guna2Button();
			this.modSomeVehicle = new Guna2Button();
			this.replaceAobTextbox = new Guna2TextBox();
			this.modAobFromTextboxBtn = new Guna2GradientButton();
			this.scanAobTextbox = new Guna2TextBox();
			base.SuspendLayout();
			this.modInfernoRiderHelmet.BorderRadius = 5;
			this.modInfernoRiderHelmet.DisabledState.BorderColor = Color.DarkGray;
			this.modInfernoRiderHelmet.DisabledState.CustomBorderColor = Color.DarkGray;
			this.modInfernoRiderHelmet.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.modInfernoRiderHelmet.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.modInfernoRiderHelmet.FillColor = Color.FromArgb(128, 128, 255);
			this.modInfernoRiderHelmet.Font = new Font("Segoe UI Semibold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.modInfernoRiderHelmet.ForeColor = Color.White;
			this.modInfernoRiderHelmet.HoverState.BorderColor = Color.FromArgb(0, 0, 192);
			this.modInfernoRiderHelmet.HoverState.FillColor = Color.FromArgb(128, 128, 255);
			this.modInfernoRiderHelmet.HoverState.ForeColor = Color.Black;
			this.modInfernoRiderHelmet.Location = new Point(21, 45);
			this.modInfernoRiderHelmet.Name = "modInfernoRiderHelmet";
			this.modInfernoRiderHelmet.Size = new Size(230, 45);
			this.modInfernoRiderHelmet.TabIndex = 20;
			this.modInfernoRiderHelmet.Text = "Inferno Rider Helmet";
			this.modInfernoRiderHelmet.Click += this.modInfernoRiderHelmet_Click;
			this.modSomeVehicle.BorderRadius = 5;
			this.modSomeVehicle.DisabledState.BorderColor = Color.DarkGray;
			this.modSomeVehicle.DisabledState.CustomBorderColor = Color.DarkGray;
			this.modSomeVehicle.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.modSomeVehicle.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.modSomeVehicle.FillColor = Color.FromArgb(128, 128, 255);
			this.modSomeVehicle.Font = new Font("Segoe UI Semibold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.modSomeVehicle.ForeColor = Color.White;
			this.modSomeVehicle.HoverState.BorderColor = Color.FromArgb(0, 0, 192);
			this.modSomeVehicle.HoverState.FillColor = Color.FromArgb(128, 128, 255);
			this.modSomeVehicle.HoverState.ForeColor = Color.Black;
			this.modSomeVehicle.Location = new Point(270, 45);
			this.modSomeVehicle.Name = "modSomeVehicle";
			this.modSomeVehicle.Size = new Size(230, 45);
			this.modSomeVehicle.TabIndex = 17;
			this.modSomeVehicle.Text = "Some Vehicle (Uaz, Coupo,..)";
			this.modSomeVehicle.Click += this.modSomeVehicle_Click;
			this.replaceAobTextbox.BorderColor = Color.FromArgb(0, 192, 0);
			this.replaceAobTextbox.BorderRadius = 5;
			this.replaceAobTextbox.BorderThickness = 2;
			this.replaceAobTextbox.Cursor = Cursors.IBeam;
			this.replaceAobTextbox.DefaultText = "";
			this.replaceAobTextbox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			this.replaceAobTextbox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			this.replaceAobTextbox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			this.replaceAobTextbox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			this.replaceAobTextbox.FillColor = Color.FromArgb(224, 224, 224);
			this.replaceAobTextbox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			this.replaceAobTextbox.Font = new Font("Segoe UI", 9f);
			this.replaceAobTextbox.ForeColor = Color.Black;
			this.replaceAobTextbox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
			this.replaceAobTextbox.IconLeft = Resources.Checkmark_480px;
			this.replaceAobTextbox.Location = new Point(270, 177);
			this.replaceAobTextbox.Name = "replaceAobTextbox";
			this.replaceAobTextbox.PasswordChar = '\0';
			this.replaceAobTextbox.PlaceholderForeColor = Color.Black;
			this.replaceAobTextbox.PlaceholderText = "Input Replace AOB";
			this.replaceAobTextbox.SelectedText = "";
			this.replaceAobTextbox.Size = new Size(230, 41);
			this.replaceAobTextbox.TabIndex = 22;
			this.modAobFromTextboxBtn.BorderRadius = 5;
			this.modAobFromTextboxBtn.DisabledState.BorderColor = Color.DarkGray;
			this.modAobFromTextboxBtn.DisabledState.CustomBorderColor = Color.DarkGray;
			this.modAobFromTextboxBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.modAobFromTextboxBtn.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
			this.modAobFromTextboxBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.modAobFromTextboxBtn.FillColor = Color.FromArgb(128, 128, 255);
			this.modAobFromTextboxBtn.FillColor2 = Color.FromArgb(255, 128, 255);
			this.modAobFromTextboxBtn.Font = new Font("Showcard Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.modAobFromTextboxBtn.ForeColor = Color.Black;
			this.modAobFromTextboxBtn.Location = new Point(21, 224);
			this.modAobFromTextboxBtn.Name = "modAobFromTextboxBtn";
			this.modAobFromTextboxBtn.Size = new Size(479, 42);
			this.modAobFromTextboxBtn.TabIndex = 23;
			this.modAobFromTextboxBtn.Text = "Mod from AOB input";
			this.modAobFromTextboxBtn.Click += this.modAobFromTextboxBtn_Click;
			this.scanAobTextbox.BorderColor = Color.FromArgb(192, 0, 0);
			this.scanAobTextbox.BorderRadius = 5;
			this.scanAobTextbox.BorderThickness = 2;
			this.scanAobTextbox.Cursor = Cursors.IBeam;
			this.scanAobTextbox.DefaultText = "";
			this.scanAobTextbox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			this.scanAobTextbox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			this.scanAobTextbox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			this.scanAobTextbox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			this.scanAobTextbox.FillColor = Color.FromArgb(224, 224, 224);
			this.scanAobTextbox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			this.scanAobTextbox.Font = new Font("Segoe UI", 9f);
			this.scanAobTextbox.ForeColor = Color.Black;
			this.scanAobTextbox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
			this.scanAobTextbox.IconLeft = Resources.search_red;
			this.scanAobTextbox.Location = new Point(21, 177);
			this.scanAobTextbox.Name = "scanAobTextbox";
			this.scanAobTextbox.PasswordChar = '\0';
			this.scanAobTextbox.PlaceholderForeColor = Color.Black;
			this.scanAobTextbox.PlaceholderText = "Input Scan AOB";
			this.scanAobTextbox.SelectedText = "";
			this.scanAobTextbox.Size = new Size(230, 41);
			this.scanAobTextbox.TabIndex = 24;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.White;
			base.Controls.Add(this.scanAobTextbox);
			base.Controls.Add(this.modAobFromTextboxBtn);
			base.Controls.Add(this.replaceAobTextbox);
			base.Controls.Add(this.modInfernoRiderHelmet);
			base.Controls.Add(this.modSomeVehicle);
			base.Name = "others";
			base.Size = new Size(528, 436);
			base.ResumeLayout(false);
		}

		// Token: 0x040000AB RID: 171
		private functions func;

		// Token: 0x040000AC RID: 172
		private IContainer components = null;

		// Token: 0x040000AD RID: 173
		private Guna2Button modInfernoRiderHelmet;

		// Token: 0x040000AE RID: 174
		private Guna2Button modSomeVehicle;

		// Token: 0x040000AF RID: 175
		private Guna2TextBox replaceAobTextbox;

		// Token: 0x040000B0 RID: 176
		private Guna2GradientButton modAobFromTextboxBtn;

		// Token: 0x040000B1 RID: 177
		private Guna2TextBox scanAobTextbox;
	}
}
