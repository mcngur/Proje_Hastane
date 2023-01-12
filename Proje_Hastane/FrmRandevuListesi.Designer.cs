
namespace Proje_Hastane
{
    partial class FrmRandevuListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRandevuListesi));
            this.DtgrdRandevular = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DtgrdRandevular)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgrdRandevular
            // 
            this.DtgrdRandevular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgrdRandevular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgrdRandevular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtgrdRandevular.Location = new System.Drawing.Point(0, 0);
            this.DtgrdRandevular.Name = "DtgrdRandevular";
            this.DtgrdRandevular.Size = new System.Drawing.Size(798, 525);
            this.DtgrdRandevular.TabIndex = 0;
//            this.DtgrdRandevular.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgrdRandevular_CellDoubleClick);
            // 
            // FrmRandevuListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(798, 525);
            this.Controls.Add(this.DtgrdRandevular);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmRandevuListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevu Listesi";
            this.Load += new System.EventHandler(this.FrmRandevuListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgrdRandevular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgrdRandevular;
    }
}