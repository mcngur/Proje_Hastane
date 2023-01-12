
namespace Proje_Hastane
{
    partial class FrmHastaKayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaKayit));
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.MskdTc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtSoyAd = new System.Windows.Forms.TextBox();
            this.MskdTel = new System.Windows.Forms.MaskedTextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.CmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.BtnKayıtYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(149, 31);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(172, 31);
            this.TxtAd.TabIndex = 1;
            // 
            // MskdTc
            // 
            this.MskdTc.Location = new System.Drawing.Point(149, 105);
            this.MskdTc.Mask = "00000000000";
            this.MskdTc.Name = "MskdTc";
            this.MskdTc.Size = new System.Drawing.Size(172, 31);
            this.MskdTc.TabIndex = 3;
            this.MskdTc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Şifre :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "TC Kimlik No :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cinsiyet :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Telefon :";
            // 
            // TxtSoyAd
            // 
            this.TxtSoyAd.Location = new System.Drawing.Point(149, 68);
            this.TxtSoyAd.Name = "TxtSoyAd";
            this.TxtSoyAd.Size = new System.Drawing.Size(172, 31);
            this.TxtSoyAd.TabIndex = 2;
            // 
            // MskdTel
            // 
            this.MskdTel.Location = new System.Drawing.Point(149, 142);
            this.MskdTel.Mask = "(999) 000-0000";
            this.MskdTel.Name = "MskdTel";
            this.MskdTel.Size = new System.Drawing.Size(172, 31);
            this.MskdTel.TabIndex = 4;
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(149, 179);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(172, 31);
            this.TxtSifre.TabIndex = 5;
            // 
            // CmbCinsiyet
            // 
            this.CmbCinsiyet.FormattingEnabled = true;
            this.CmbCinsiyet.ItemHeight = 23;
            this.CmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.CmbCinsiyet.Location = new System.Drawing.Point(149, 216);
            this.CmbCinsiyet.Name = "CmbCinsiyet";
            this.CmbCinsiyet.Size = new System.Drawing.Size(172, 31);
            this.CmbCinsiyet.TabIndex = 16;
            // 
            // BtnKayıtYap
            // 
            this.BtnKayıtYap.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.BtnKayıtYap.Location = new System.Drawing.Point(149, 262);
            this.BtnKayıtYap.Name = "BtnKayıtYap";
            this.BtnKayıtYap.Size = new System.Drawing.Size(172, 42);
            this.BtnKayıtYap.TabIndex = 17;
            this.BtnKayıtYap.Text = "Kayıt Yap";
            this.BtnKayıtYap.UseVisualStyleBackColor = false;
            this.BtnKayıtYap.Click += new System.EventHandler(this.BtnKayıtYap_Click);
            // 
            // FrmHastaKayit
            // 
            this.AcceptButton = this.BtnKayıtYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(419, 339);
            this.Controls.Add(this.BtnKayıtYap);
            this.Controls.Add(this.CmbCinsiyet);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.MskdTel);
            this.Controls.Add(this.TxtSoyAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.MskdTc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 14.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmHastaKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.MaskedTextBox MskdTc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtSoyAd;
        private System.Windows.Forms.MaskedTextBox MskdTel;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.ComboBox CmbCinsiyet;
        private System.Windows.Forms.Button BtnKayıtYap;
    }
}