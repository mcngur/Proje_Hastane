using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Proje_Hastane
{
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        public string tc;

        private SqlBaglanti bgl = new SqlBaglanti();
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            LblTc.Text = tc;
            // Kişi Bilgileri Okuma
            SqlCommand komut1 = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorTC=@p1",
                bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", LblTc.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                LblAdSoyad.Text = dr1[0] + " " + dr1[1];
            }
            bgl.baglanti().Close();

            // Giriş Yapan Doktora Ait Randevular

            DataTable dt = new DataTable();
            SqlDataAdapter da =
                new SqlDataAdapter("Select * From Tbl_Randevular where RandevuDoktor='" + LblAdSoyad.Text+ "'",
                    bgl.baglanti());
            da.Fill(dt);
            DtgrdDrRandevu.DataSource = dt;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDuzenle fr = new FrmDoktorBilgiDuzenle();
            fr.TCNO = LblTc.Text;
            fr.Show();
        }

        private void BtnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DtgrdDrRandevu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = DtgrdDrRandevu.SelectedCells[0].RowIndex;
            RchSikayet.Text = DtgrdDrRandevu.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
