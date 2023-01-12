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
    public partial class FrmBilgiDüzenle : Form
    {
        public FrmBilgiDüzenle()
        {
            InitializeComponent();
        }

        public string TCno;

        private SqlBaglanti bgl = new SqlBaglanti();
        private void FrmBilgiDüzenle_Load(object sender, EventArgs e)
        {
            // Bilgi Düzenleme Formuna Verilerin Çekilmesi
            MskdTc.Text = TCno;
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskdTc.Text);
            SqlDataReader dr1 = komut.ExecuteReader();
            while (dr1.Read())
            {
                TxtAd.Text = dr1[1].ToString();
                TxtSoyAd.Text = dr1[2].ToString();
                MskdTel.Text = dr1[4].ToString();
                TxtSifre.Text = dr1[5].ToString();
                //CmbCinsiyet.Items.Add(dr[6]);
                CmbCinsiyet.Text = dr1[6].ToString();
            }
            bgl.baglanti().Close();

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 =
                new SqlCommand(
                    "update Tbl_Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTC=@p6",
                    bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut2.Parameters.AddWithValue("@p2", TxtSoyAd.Text);
            komut2.Parameters.AddWithValue("@p3", MskdTel.Text);
            komut2.Parameters.AddWithValue("@p4", TxtSifre.Text);
            komut2.Parameters.AddWithValue("@p5", CmbCinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6", MskdTc.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
