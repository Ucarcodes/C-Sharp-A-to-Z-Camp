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
    public partial class FrmHastaBilgiGuncelle : Form
    {
        public FrmHastaBilgiGuncelle()
        {
            InitializeComponent();
        }

        public string TCno;

        sqlBaglantisi connection = new sqlBaglantisi();
        private void FrmHastaBilgiGuncelle_Load(object sender, EventArgs e)
        {
            maskTboxTC.Text = TCno;
            SqlCommand hastaBilgileriniGetir = new SqlCommand("Select * From Tbl_Hastalar where HastaTC=@hastaTC", connection.baglantiFunc());
            hastaBilgileriniGetir.Parameters.AddWithValue("@hastaTC", maskTboxTC.Text);
            SqlDataReader dr = hastaBilgileriniGetir.ExecuteReader();
            while (dr.Read())
            {
                tBoxAd.Text = dr[1].ToString(); //dr[1] -> SQL'de HastaAd'a karşılık gelir.
                tBoxSoyad.Text = dr[2].ToString();
                maskTBoxTelefon.Text = dr[4].ToString();
                tBoxSifre.Text = dr[5].ToString();
                cBoxCinsiyet.Text = dr[6].ToString();
            }
            connection.baglantiFunc().Close();
        }

        private void btnBilgileriGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand hastaBilgileriniGuncelle = new SqlCommand("Update Tbl_Hastalar set HastaAd=@hastaAd, HastaSoyad=@hastaSoyad, HastaTelefon=@hastaTelefon, HastaSifre=@hastaSifre, HastaCinsiyet=@hastaCinsiyet where HastaTC=@hastaTC",connection.baglantiFunc());
            hastaBilgileriniGuncelle.Parameters.AddWithValue("@hastaAd", tBoxAd.Text);
            hastaBilgileriniGuncelle.Parameters.AddWithValue("@hastaSoyad", tBoxSoyad.Text);
            hastaBilgileriniGuncelle.Parameters.AddWithValue("hastaTelefon", maskTBoxTelefon.Text);
            hastaBilgileriniGuncelle.Parameters.AddWithValue("@hastaSifre", tBoxSifre.Text);
            hastaBilgileriniGuncelle.Parameters.AddWithValue("@hastaCinsiyet", cBoxCinsiyet.Text);
            hastaBilgileriniGuncelle.Parameters.AddWithValue("@hastaTC", maskTboxTC.Text);
            hastaBilgileriniGuncelle.ExecuteNonQuery();
            connection.baglantiFunc().Close();

            MessageBox.Show("Hasta bilgileri başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
