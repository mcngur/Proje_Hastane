
namespace Proje_Hastane
{
    partial class FrmSekreterDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterDetay));
            this.groupBoxBilgi = new System.Windows.Forms.GroupBox();
            this.LblAdSoyad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblTc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnDuyuruOlustur = new System.Windows.Forms.Button();
            this.RchDuyuru = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.ChkRandevuDurum = new System.Windows.Forms.CheckBox();
            this.MskTc = new System.Windows.Forms.MaskedTextBox();
            this.CmbDoktor = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CmbBrans = new System.Windows.Forms.ComboBox();
            this.MskSaat = new System.Windows.Forms.MaskedTextBox();
            this.MskTarih = new System.Windows.Forms.MaskedTextBox();
            this.Txtid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DtgrdBiranslar = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DtgrdDoktorlar = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BtnRandevuList = new System.Windows.Forms.Button();
            this.BtnBransPanel = new System.Windows.Forms.Button();
            this.BtnDrPanel = new System.Windows.Forms.Button();
            this.BtnDuyurular = new System.Windows.Forms.Button();
            this.groupBoxBilgi.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgrdBiranslar)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgrdDoktorlar)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBilgi
            // 
            this.groupBoxBilgi.Controls.Add(this.LblAdSoyad);
            this.groupBoxBilgi.Controls.Add(this.label1);
            this.groupBoxBilgi.Controls.Add(this.LblTc);
            this.groupBoxBilgi.Controls.Add(this.label2);
            this.groupBoxBilgi.Location = new System.Drawing.Point(12, 12);
            this.groupBoxBilgi.Name = "groupBoxBilgi";
            this.groupBoxBilgi.Size = new System.Drawing.Size(395, 189);
            this.groupBoxBilgi.TabIndex = 2;
            this.groupBoxBilgi.TabStop = false;
            this.groupBoxBilgi.Text = "Sekreter Bilgileri";
            // 
            // LblAdSoyad
            // 
            this.LblAdSoyad.AutoSize = true;
            this.LblAdSoyad.Location = new System.Drawing.Point(156, 97);
            this.LblAdSoyad.Name = "LblAdSoyad";
            this.LblAdSoyad.Size = new System.Drawing.Size(76, 23);
            this.LblAdSoyad.TabIndex = 9;
            this.LblAdSoyad.Text = "Null Null";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ad Soyad :";
            // 
            // LblTc
            // 
            this.LblTc.AutoSize = true;
            this.LblTc.Location = new System.Drawing.Point(156, 58);
            this.LblTc.Name = "LblTc";
            this.LblTc.Size = new System.Drawing.Size(120, 23);
            this.LblTc.TabIndex = 7;
            this.LblTc.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "TC NO :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnDuyuruOlustur);
            this.groupBox1.Controls.Add(this.RchDuyuru);
            this.groupBox1.Location = new System.Drawing.Point(12, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 273);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Duyuru Paneli";
            // 
            // BtnDuyuruOlustur
            // 
            this.BtnDuyuruOlustur.Location = new System.Drawing.Point(82, 223);
            this.BtnDuyuruOlustur.Name = "BtnDuyuruOlustur";
            this.BtnDuyuruOlustur.Size = new System.Drawing.Size(227, 34);
            this.BtnDuyuruOlustur.TabIndex = 12;
            this.BtnDuyuruOlustur.Text = "Duyuru Oluştur";
            this.BtnDuyuruOlustur.UseVisualStyleBackColor = true;
            this.BtnDuyuruOlustur.Click += new System.EventHandler(this.BtnDuyuruOlustur_Click);
            // 
            // RchDuyuru
            // 
            this.RchDuyuru.Location = new System.Drawing.Point(16, 31);
            this.RchDuyuru.Name = "RchDuyuru";
            this.RchDuyuru.Size = new System.Drawing.Size(357, 183);
            this.RchDuyuru.TabIndex = 11;
            this.RchDuyuru.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnKaydet);
            this.groupBox2.Controls.Add(this.ChkRandevuDurum);
            this.groupBox2.Controls.Add(this.MskTc);
            this.groupBox2.Controls.Add(this.CmbDoktor);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.CmbBrans);
            this.groupBox2.Controls.Add(this.MskSaat);
            this.groupBox2.Controls.Add(this.MskTarih);
            this.groupBox2.Controls.Add(this.Txtid);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(413, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 486);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Paneli";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(89, 393);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(156, 34);
            this.BtnKaydet.TabIndex = 13;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // ChkRandevuDurum
            // 
            this.ChkRandevuDurum.AutoSize = true;
            this.ChkRandevuDurum.Location = new System.Drawing.Point(89, 320);
            this.ChkRandevuDurum.Name = "ChkRandevuDurum";
            this.ChkRandevuDurum.Size = new System.Drawing.Size(156, 27);
            this.ChkRandevuDurum.TabIndex = 20;
            this.ChkRandevuDurum.Text = "Randevu Durum";
            this.ChkRandevuDurum.UseVisualStyleBackColor = true;
            // 
            // MskTc
            // 
            this.MskTc.Location = new System.Drawing.Point(93, 264);
            this.MskTc.Mask = "00000000000";
            this.MskTc.Name = "MskTc";
            this.MskTc.Size = new System.Drawing.Size(152, 31);
            this.MskTc.TabIndex = 19;
            this.MskTc.ValidatingType = typeof(int);
            // 
            // CmbDoktor
            // 
            this.CmbDoktor.FormattingEnabled = true;
            this.CmbDoktor.Location = new System.Drawing.Point(93, 224);
            this.CmbDoktor.Name = "CmbDoktor";
            this.CmbDoktor.Size = new System.Drawing.Size(152, 31);
            this.CmbDoktor.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 23);
            this.label9.TabIndex = 17;
            this.label9.Text = "TC :";
            // 
            // CmbBrans
            // 
            this.CmbBrans.FormattingEnabled = true;
            this.CmbBrans.Location = new System.Drawing.Point(93, 183);
            this.CmbBrans.Name = "CmbBrans";
            this.CmbBrans.Size = new System.Drawing.Size(152, 31);
            this.CmbBrans.TabIndex = 16;
            this.CmbBrans.SelectedIndexChanged += new System.EventHandler(this.CmbBrans_SelectedIndexChanged);
            // 
            // MskSaat
            // 
            this.MskSaat.Location = new System.Drawing.Point(93, 142);
            this.MskSaat.Mask = "00:00";
            this.MskSaat.Name = "MskSaat";
            this.MskSaat.Size = new System.Drawing.Size(152, 31);
            this.MskSaat.TabIndex = 15;
            this.MskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // MskTarih
            // 
            this.MskTarih.Location = new System.Drawing.Point(93, 99);
            this.MskTarih.Mask = "00/00/0000";
            this.MskTarih.Name = "MskTarih";
            this.MskTarih.Size = new System.Drawing.Size(152, 31);
            this.MskTarih.TabIndex = 14;
            this.MskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // Txtid
            // 
            this.Txtid.Location = new System.Drawing.Point(93, 58);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(152, 31);
            this.Txtid.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Doktor :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Branş :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Saat :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tarih :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "id :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DtgrdBiranslar);
            this.groupBox3.Location = new System.Drawing.Point(731, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(546, 246);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Branşlar";
            // 
            // DtgrdBiranslar
            // 
            this.DtgrdBiranslar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgrdBiranslar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgrdBiranslar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtgrdBiranslar.Location = new System.Drawing.Point(3, 27);
            this.DtgrdBiranslar.Name = "DtgrdBiranslar";
            this.DtgrdBiranslar.Size = new System.Drawing.Size(540, 216);
            this.DtgrdBiranslar.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DtgrdDoktorlar);
            this.groupBox4.Location = new System.Drawing.Point(731, 264);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(546, 410);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Doktorlar";
            // 
            // DtgrdDoktorlar
            // 
            this.DtgrdDoktorlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgrdDoktorlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgrdDoktorlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtgrdDoktorlar.Location = new System.Drawing.Point(3, 27);
            this.DtgrdDoktorlar.Name = "DtgrdDoktorlar";
            this.DtgrdDoktorlar.Size = new System.Drawing.Size(540, 380);
            this.DtgrdDoktorlar.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BtnDuyurular);
            this.groupBox5.Controls.Add(this.BtnRandevuList);
            this.groupBox5.Controls.Add(this.BtnBransPanel);
            this.groupBox5.Controls.Add(this.BtnDrPanel);
            this.groupBox5.Location = new System.Drawing.Point(12, 504);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(713, 167);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Hızlı Erişim";
            // 
            // BtnRandevuList
            // 
            this.BtnRandevuList.Location = new System.Drawing.Point(370, 71);
            this.BtnRandevuList.Name = "BtnRandevuList";
            this.BtnRandevuList.Size = new System.Drawing.Size(144, 42);
            this.BtnRandevuList.TabIndex = 3;
            this.BtnRandevuList.Text = "Randevu Liste";
            this.BtnRandevuList.UseVisualStyleBackColor = true;
            this.BtnRandevuList.Click += new System.EventHandler(this.BtnRandevuList_Click);
            // 
            // BtnBransPanel
            // 
            this.BtnBransPanel.Location = new System.Drawing.Point(190, 71);
            this.BtnBransPanel.Name = "BtnBransPanel";
            this.BtnBransPanel.Size = new System.Drawing.Size(144, 42);
            this.BtnBransPanel.TabIndex = 2;
            this.BtnBransPanel.Text = "Branş Paneli";
            this.BtnBransPanel.UseVisualStyleBackColor = true;
            this.BtnBransPanel.Click += new System.EventHandler(this.BtnBransPanel_Click);
            // 
            // BtnDrPanel
            // 
            this.BtnDrPanel.Location = new System.Drawing.Point(8, 71);
            this.BtnDrPanel.Name = "BtnDrPanel";
            this.BtnDrPanel.Size = new System.Drawing.Size(144, 42);
            this.BtnDrPanel.TabIndex = 1;
            this.BtnDrPanel.Text = "Doktor Paneli";
            this.BtnDrPanel.UseVisualStyleBackColor = true;
            this.BtnDrPanel.Click += new System.EventHandler(this.BtnDrPanel_Click);
            // 
            // BtnDuyurular
            // 
            this.BtnDuyurular.Location = new System.Drawing.Point(544, 71);
            this.BtnDuyurular.Name = "BtnDuyurular";
            this.BtnDuyurular.Size = new System.Drawing.Size(144, 42);
            this.BtnDuyurular.TabIndex = 4;
            this.BtnDuyurular.Text = "Duyurular";
            this.BtnDuyurular.UseVisualStyleBackColor = true;
            this.BtnDuyurular.Click += new System.EventHandler(this.BtnDuyurular_Click);
            // 
            // FrmSekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1289, 686);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxBilgi);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmSekreterDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sekreter Ekranı";
            this.Load += new System.EventHandler(this.FrmSekreterDetay_Load);
            this.groupBoxBilgi.ResumeLayout(false);
            this.groupBoxBilgi.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgrdBiranslar)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgrdDoktorlar)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBilgi;
        private System.Windows.Forms.Label LblAdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblTc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnDuyuruOlustur;
        private System.Windows.Forms.RichTextBox RchDuyuru;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox MskSaat;
        private System.Windows.Forms.MaskedTextBox MskTarih;
        private System.Windows.Forms.TextBox Txtid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.CheckBox ChkRandevuDurum;
        private System.Windows.Forms.MaskedTextBox MskTc;
        private System.Windows.Forms.ComboBox CmbDoktor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CmbBrans;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DtgrdBiranslar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView DtgrdDoktorlar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button BtnRandevuList;
        private System.Windows.Forms.Button BtnBransPanel;
        private System.Windows.Forms.Button BtnDrPanel;
        private System.Windows.Forms.Button BtnDuyurular;
    }
}