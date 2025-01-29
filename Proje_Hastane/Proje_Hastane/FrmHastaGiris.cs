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
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }
        sqlBaglantisi connection = new sqlBaglantisi();

        private void LnkUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayit frmHastaKayit = new FrmHastaKayit();
            frmHastaKayit.Show();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand girisBilgisiKontrolu = new SqlCommand("Select * From Tbl_Hastalar Where HastaTC= @hastaTC and HastaSifre = @hastaSifre", connection.baglantiFunc());
            girisBilgisiKontrolu.Parameters.AddWithValue("@hastaTC", maskTboxTC.Text);
            girisBilgisiKontrolu.Parameters.AddWithValue("@hastaSifre", tBoxSifre.Text);
            SqlDataReader dr = girisBilgisiKontrolu.ExecuteReader();
            if (dr.Read())
            {
                FrmHastaDetay frmHastaDetay = new FrmHastaDetay();
                frmHastaDetay.hastaTC = maskTboxTC.Text;
                frmHastaDetay.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("TC Kimlik ya da Şifre hatalı! Lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.baglantiFunc().Close();
        }
    }
}
