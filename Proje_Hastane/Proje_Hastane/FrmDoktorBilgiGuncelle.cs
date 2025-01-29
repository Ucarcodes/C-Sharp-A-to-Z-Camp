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
    public partial class FrmDoktorBilgiGuncelle : Form
    {
        public FrmDoktorBilgiGuncelle()
        {
            InitializeComponent();
        }

        sqlBaglantisi connection = new sqlBaglantisi();
        public string doktorTCsi;
        private void FrmDoktorBilgiGuncelle_Load(object sender, EventArgs e)
        {
            //Doktor TC'sini aldık.
            maskTboxTC.Text = doktorTCsi;

            //TC'ye göre doktor bilgilerini getirelim.
            SqlCommand doktorBilgileriniGetir = new SqlCommand("Select * from Tbl_Doktorlar where DoktorTC=@doktorTC", connection.baglantiFunc());
            doktorBilgileriniGetir.Parameters.AddWithValue("@doktorTC", maskTboxTC.Text);
            SqlDataReader dr = doktorBilgileriniGetir.ExecuteReader();
            while (dr.Read())
            {
                tBoxAd.Text = dr[1].ToString();
                tBoxSoyad.Text = dr[2].ToString();
                tBoxBrans.Text = dr[3].ToString();
                tBoxSifre.Text = dr[5].ToString();
            }
            connection.baglantiFunc().Close();
        }

        private void btnBilgileriGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Gerçekten seçilen doktor bilgilerini güncellemek istiyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand bilgiGuncelle = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@doktorAd, DoktorSoyad=@doktorSoyad, DoktorBrans=@doktorBrans, DoktorSifre=@doktorSifre where DoktorTC=@doktorTC", connection.baglantiFunc());
                bilgiGuncelle.Parameters.AddWithValue("@doktorAd", tBoxAd.Text);
                bilgiGuncelle.Parameters.AddWithValue("@doktorSoyad", tBoxSoyad.Text);
                bilgiGuncelle.Parameters.AddWithValue("@doktorBrans", tBoxBrans.Text);
                bilgiGuncelle.Parameters.AddWithValue("@doktorSifre", tBoxSifre.Text);
                bilgiGuncelle.Parameters.AddWithValue("@doktorTC", maskTboxTC.Text);
                bilgiGuncelle.ExecuteNonQuery();
                connection.baglantiFunc().Close();
                MessageBox.Show("Seçilen doktor bilgileri başarıyla güncellenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Hayır seçeneğine tıklandığı için doktor bilgileri güncellenmemiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
