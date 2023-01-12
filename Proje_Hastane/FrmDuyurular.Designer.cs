
namespace Proje_Hastane
{
    partial class FrmDuyurular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDuyurular));
            this.DtgrdDuyurular = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DtgrdDuyurular)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgrdDuyurular
            // 
            this.DtgrdDuyurular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgrdDuyurular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgrdDuyurular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtgrdDuyurular.Location = new System.Drawing.Point(0, 0);
            this.DtgrdDuyurular.Name = "DtgrdDuyurular";
            this.DtgrdDuyurular.Size = new System.Drawing.Size(867, 444);
            this.DtgrdDuyurular.TabIndex = 0;
            // 
            // FrmDuyurular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(867, 444);
            this.Controls.Add(this.DtgrdDuyurular);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmDuyurular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDuyurular";
            this.Load += new System.EventHandler(this.FrmDuyurular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgrdDuyurular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgrdDuyurular;
    }
}