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
    public partial class FrmHastaKayit : Form
    {
        public FrmHastaKayit()
        {
            InitializeComponent();
        }

        sqlBaglantisi baglanti = new sqlBaglantisi();
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            SqlCommand hastaKayit = new SqlCommand("Insert into Tbl_Hastalar (HastaAd, HastaSoyad, HastaTC, HastaTelefon, HastaSifre, HastaCinsiyet) values(@hastaAd, @hastaSoyad, @hastaTC, @hastaTelefon, @hastaSifre, @hastaCinsiyet)", baglanti.baglantiFunc());

            //@hastaAd, @hastaSoyad, @hastaTC @hastaTelefon, @hastaSifre, @hastaCinsiyet
            hastaKayit.Parameters.AddWithValue("@hastaAd", tBoxAd.Text);
            hastaKayit.Parameters.AddWithValue("@hastaSoyad", tBoxSoyad.Text);
            hastaKayit.Parameters.AddWithValue("@hastaTC", maskTboxTC.Text);
            hastaKayit.Parameters.AddWithValue("@hastaTelefon", maskTBoxTelefon.Text);
            hastaKayit.Parameters.AddWithValue("@hastaSifre", tBoxSifre.Text);
            hastaKayit.Parameters.AddWithValue("@hastaCinsiyet", cBoxCinsiyet.Text);
            hastaKayit.ExecuteNonQuery(); //İşlemi yapmasını sağladık.
            baglanti.baglantiFunc().Close(); //Bağlantıyı kapattık.
            MessageBox.Show("Hasta üye kaydı başarıyla yapıldı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
