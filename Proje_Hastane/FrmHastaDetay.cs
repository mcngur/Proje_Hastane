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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }

        public string tc;

        private SqlBaglanti bgl = new SqlBaglanti();
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            LblTc.Text = tc;
            // Kişi Bilgileri Okuma
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hastalar where HastaTc=@p1",
                bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Randevu Geçmişi Listeleme

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where HastaTc=" + tc, bgl.baglanti());
            da.Fill(dt);
            DtgrdRandevuGecmisi.DataSource = dt;

            // Branş Listeme

            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Branş Seçilince Doktor listelenecek 
            CmbDoktor.Items.Clear();

            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorBrans=@p1",
                bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", CmbBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                CmbDoktor.Items.Add(dr3[0]+ " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Doktor Seçilince Aktif Randevular Gelecek

            DataTable dt = new DataTable();
            SqlDataAdapter da =
                new SqlDataAdapter("Select * From Tbl_Randevular where RandevuBrans='" + CmbBrans.Text + "'"+ "and RandevuDoktor='" + CmbDoktor.Text + " ' and RandevuDurum=0",
                    bgl.baglanti());
            da.Fill(dt);
            DtgrdAktifRandevular.DataSource = dt;
        }

        private void LnkBilgiDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Bilgi Düzenleme (Randevu Düzenleme)
            FrmBilgiDüzenle fr = new FrmBilgiDüzenle();
            fr.TCno = LblTc.Text;
            fr.Show();

        }

        private void DtgrdAktifRandevular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = DtgrdAktifRandevular.SelectedCells[0].RowIndex;
            Txtid.Text = DtgrdAktifRandevular.Rows[secilen].Cells[0].Value.ToString();
        }

        private void BtnRandevuKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut =
                new SqlCommand(
                    "Update Tbl_Randevular set RandevuDurum=1,HastaTC=@p1,HastaSikayet=@p2 where Randevuid=@p3",
                    bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTc.Text);
            komut.Parameters.AddWithValue("@p2", RchSikayet.Text);
            komut.Parameters.AddWithValue("@p3", Txtid.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Randevu Alındı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
