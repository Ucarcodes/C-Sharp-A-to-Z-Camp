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
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }

        sqlBaglantisi connection = new sqlBaglantisi();

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand sekreterGirisKontrol = new SqlCommand("Select * From Tbl_Sekreter where SekreterTC=@sekreterTC and SekreterSifre=@sekreterSifre",connection.baglantiFunc());
            sekreterGirisKontrol.Parameters.AddWithValue("@sekreterTC", maskTboxTC.Text);
            sekreterGirisKontrol.Parameters.AddWithValue("@sekreterSifre", tBoxSifre.Text);
            SqlDataReader dr = sekreterGirisKontrol.ExecuteReader();
            if(dr.Read())
            {
                FrmSekreterDetay frmSekreterDetay = new FrmSekreterDetay();
                frmSekreterDetay.sekreterTC = maskTboxTC.Text;
                frmSekreterDetay.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sekreter TC veya şifre hatalı. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            connection.baglantiFunc().Close();
        }
    }
}
