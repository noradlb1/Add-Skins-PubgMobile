using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using ModPubg.fClass;
using ModPubg.Properties;

namespace ModPubg.fControls
{
	// Token: 0x0200001C RID: 28
	public class others : UserControl
	{
		// Token: 0x060000D5 RID: 213 RVA: 0x000024F5 File Offset: 0x000006F5
		public others()
		{
			this.func = new functions();
			this.InitializeComponent();
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00007D54 File Offset: 0x00005F54
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

		// Token: 0x060000D7 RID: 215 RVA: 0x00007E10 File Offset: 0x00006010
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

		// Token: 0x060000D8 RID: 216 RVA: 0x00007F0C File Offset: 0x0000610C
		private void modAobFromTextboxBtn_Click(object sender, EventArgs e)
		{
			this.func.StartKernel();
			string procID = this.func.GetProcID();
			this.func.Rep(procID, this.scanAobTextbox.Text, this.replaceAobTextbox.Text);
			this.func.Alert("Mod from AOB done!", Form_Alert.enmType.Success);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00007F64 File Offset: 0x00006164
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00007F94 File Offset: 0x00006194
		private void InitializeComponent()
		{
            this.modInfernoRiderHelmet = new Guna.UI2.WinForms.Guna2Button();
            this.modSomeVehicle = new Guna.UI2.WinForms.Guna2Button();
            this.replaceAobTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.modAobFromTextboxBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.scanAobTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // modInfernoRiderHelmet
            // 
            this.modInfernoRiderHelmet.BorderRadius = 5;
            this.modInfernoRiderHelmet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.modInfernoRiderHelmet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.modInfernoRiderHelmet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.modInfernoRiderHelmet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.modInfernoRiderHelmet.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.modInfernoRiderHelmet.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modInfernoRiderHelmet.ForeColor = System.Drawing.Color.White;
            this.modInfernoRiderHelmet.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.modInfernoRiderHelmet.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.modInfernoRiderHelmet.HoverState.ForeColor = System.Drawing.Color.Black;
            this.modInfernoRiderHelmet.Location = new System.Drawing.Point(21, 45);
            this.modInfernoRiderHelmet.Name = "modInfernoRiderHelmet";
            this.modInfernoRiderHelmet.Size = new System.Drawing.Size(230, 45);
            this.modInfernoRiderHelmet.TabIndex = 20;
            this.modInfernoRiderHelmet.Text = "Inferno Rider Helmet";
            // 
            // modSomeVehicle
            // 
            this.modSomeVehicle.BorderRadius = 5;
            this.modSomeVehicle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.modSomeVehicle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.modSomeVehicle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.modSomeVehicle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.modSomeVehicle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.modSomeVehicle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modSomeVehicle.ForeColor = System.Drawing.Color.White;
            this.modSomeVehicle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.modSomeVehicle.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.modSomeVehicle.HoverState.ForeColor = System.Drawing.Color.Black;
            this.modSomeVehicle.Location = new System.Drawing.Point(270, 45);
            this.modSomeVehicle.Name = "modSomeVehicle";
            this.modSomeVehicle.Size = new System.Drawing.Size(230, 45);
            this.modSomeVehicle.TabIndex = 17;
            this.modSomeVehicle.Text = "Some Vehicle (Uaz, Coupo,..)";
            // 
            // replaceAobTextbox
            // 
            this.replaceAobTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.replaceAobTextbox.BorderRadius = 5;
            this.replaceAobTextbox.BorderThickness = 2;
            this.replaceAobTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.replaceAobTextbox.DefaultText = "";
            this.replaceAobTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.replaceAobTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.replaceAobTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.replaceAobTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.replaceAobTextbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.replaceAobTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.replaceAobTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.replaceAobTextbox.ForeColor = System.Drawing.Color.Black;
            this.replaceAobTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.replaceAobTextbox.Location = new System.Drawing.Point(270, 177);
            this.replaceAobTextbox.Name = "replaceAobTextbox";
            this.replaceAobTextbox.PasswordChar = '\0';
            this.replaceAobTextbox.PlaceholderForeColor = System.Drawing.Color.Black;
            this.replaceAobTextbox.PlaceholderText = "Input Replace AOB";
            this.replaceAobTextbox.SelectedText = "";
            this.replaceAobTextbox.Size = new System.Drawing.Size(230, 41);
            this.replaceAobTextbox.TabIndex = 22;
            // 
            // modAobFromTextboxBtn
            // 
            this.modAobFromTextboxBtn.BorderRadius = 5;
            this.modAobFromTextboxBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.modAobFromTextboxBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.modAobFromTextboxBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.modAobFromTextboxBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.modAobFromTextboxBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.modAobFromTextboxBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.modAobFromTextboxBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.modAobFromTextboxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modAobFromTextboxBtn.ForeColor = System.Drawing.Color.Black;
            this.modAobFromTextboxBtn.Location = new System.Drawing.Point(21, 224);
            this.modAobFromTextboxBtn.Name = "modAobFromTextboxBtn";
            this.modAobFromTextboxBtn.Size = new System.Drawing.Size(479, 42);
            this.modAobFromTextboxBtn.TabIndex = 23;
            this.modAobFromTextboxBtn.Text = "Mod from AOB input";
            this.modAobFromTextboxBtn.Click += new System.EventHandler(this.modAobFromTextboxBtn_Click_1);
            // 
            // scanAobTextbox
            // 
            this.scanAobTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.scanAobTextbox.BorderRadius = 5;
            this.scanAobTextbox.BorderThickness = 2;
            this.scanAobTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.scanAobTextbox.DefaultText = "";
            this.scanAobTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.scanAobTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.scanAobTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.scanAobTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.scanAobTextbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.scanAobTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.scanAobTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.scanAobTextbox.ForeColor = System.Drawing.Color.Black;
            this.scanAobTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.scanAobTextbox.Location = new System.Drawing.Point(21, 177);
            this.scanAobTextbox.Name = "scanAobTextbox";
            this.scanAobTextbox.PasswordChar = '\0';
            this.scanAobTextbox.PlaceholderForeColor = System.Drawing.Color.Black;
            this.scanAobTextbox.PlaceholderText = "Input Scan AOB";
            this.scanAobTextbox.SelectedText = "";
            this.scanAobTextbox.Size = new System.Drawing.Size(230, 41);
            this.scanAobTextbox.TabIndex = 24;
            // 
            // others
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.scanAobTextbox);
            this.Controls.Add(this.modAobFromTextboxBtn);
            this.Controls.Add(this.replaceAobTextbox);
            this.Controls.Add(this.modInfernoRiderHelmet);
            this.Controls.Add(this.modSomeVehicle);
            this.Name = "others";
            this.Size = new System.Drawing.Size(528, 436);
            this.ResumeLayout(false);

		}

		// Token: 0x04000080 RID: 128
		private functions func;

		// Token: 0x04000081 RID: 129
		private IContainer components = null;

		// Token: 0x04000082 RID: 130
		private Guna2Button modInfernoRiderHelmet;

		// Token: 0x04000083 RID: 131
		private Guna2Button modSomeVehicle;

		// Token: 0x04000084 RID: 132
		private Guna2TextBox replaceAobTextbox;

		// Token: 0x04000085 RID: 133
		private Guna2GradientButton modAobFromTextboxBtn;

		// Token: 0x04000086 RID: 134
		private Guna2TextBox scanAobTextbox;

        private void modAobFromTextboxBtn_Click_1(object sender, EventArgs e)
        {

        }
    }
}
