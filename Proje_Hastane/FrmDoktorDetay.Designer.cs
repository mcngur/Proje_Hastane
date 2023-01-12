
namespace Proje_Hastane
{
    partial class FrmDoktorDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorDetay));
            this.groupBoxBilgi = new System.Windows.Forms.GroupBox();
            this.LblAdSoyad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblTc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RchSikayet = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DtgrdDrRandevu = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnDuyurular = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.groupBoxBilgi.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgrdDrRandevu)).BeginInit();
            this.groupBox3.SuspendLayout();
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
            this.groupBoxBilgi.TabIndex = 1;
            this.groupBoxBilgi.TabStop = false;
            this.groupBoxBilgi.Text = "Kişi Bilgileri";
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
            this.groupBox1.Controls.Add(this.RchSikayet);
            this.groupBox1.Location = new System.Drawing.Point(12, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 270);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Randevu Detay";
            // 
            // RchSikayet
            // 
            this.RchSikayet.Location = new System.Drawing.Point(6, 30);
            this.RchSikayet.Name = "RchSikayet";
            this.RchSikayet.Size = new System.Drawing.Size(381, 222);
            this.RchSikayet.TabIndex = 12;
            this.RchSikayet.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DtgrdDrRandevu);
            this.groupBox2.Location = new System.Drawing.Point(428, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(823, 649);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Listesi";
            // 
            // DtgrdDrRandevu
            // 
            this.DtgrdDrRandevu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgrdDrRandevu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtgrdDrRandevu.Location = new System.Drawing.Point(3, 27);
            this.DtgrdDrRandevu.Name = "DtgrdDrRandevu";
            this.DtgrdDrRandevu.Size = new System.Drawing.Size(817, 619);
            this.DtgrdDrRandevu.TabIndex = 0;
            this.DtgrdDrRandevu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgrdDrRandevu_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnExit);
            this.groupBox3.Controls.Add(this.BtnDuyurular);
            this.groupBox3.Controls.Add(this.BtnGuncelle);
            this.groupBox3.Location = new System.Drawing.Point(12, 500);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(395, 161);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hızlı Erişim";
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(40, 94);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(313, 48);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "ÇIKIŞ";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnDuyurular
            // 
            this.BtnDuyurular.Location = new System.Drawing.Point(209, 35);
            this.BtnDuyurular.Name = "BtnDuyurular";
            this.BtnDuyurular.Size = new System.Drawing.Size(144, 42);
            this.BtnDuyurular.TabIndex = 1;
            this.BtnDuyurular.Text = "Duyurular";
            this.BtnDuyurular.UseVisualStyleBackColor = true;
            this.BtnDuyurular.Click += new System.EventHandler(this.BtnDuyurular_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(40, 35);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(144, 42);
            this.BtnGuncelle.TabIndex = 0;
            this.BtnGuncelle.Text = "Bilgi Düzenle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // FrmDoktorDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1263, 673);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxBilgi);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Detay";
            this.Load += new System.EventHandler(this.FrmDoktorDetay_Load);
            this.groupBoxBilgi.ResumeLayout(false);
            this.groupBoxBilgi.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgrdDrRandevu)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBilgi;
        private System.Windows.Forms.Label LblAdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblTc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DtgrdDrRandevu;
        private System.Windows.Forms.RichTextBox RchSikayet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnDuyurular;
        private System.Windows.Forms.Button BtnGuncelle;
    }
}