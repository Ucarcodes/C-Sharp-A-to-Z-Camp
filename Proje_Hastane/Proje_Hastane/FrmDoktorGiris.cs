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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }
        sqlBaglantisi connection = new sqlBaglantisi();

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand doktorGiris = new SqlCommand("Select * From Tbl_Doktorlar where DoktorTC=@doktorTC and DoktorSifre=@doktorSifre", connection.baglantiFunc());
            doktorGiris.Parameters.AddWithValue("@doktorTC", maskTboxTC.Text);
            doktorGiris.Parameters.AddWithValue("@doktorSifre", tBoxSifre.Text);
            SqlDataReader dr = doktorGiris.ExecuteReader();
            if (dr.Read())
            {
                FrmDoktorDetay frmDoktorDetay = new FrmDoktorDetay();
                frmDoktorDetay.doktorTC = maskTboxTC.Text; //Doktor TC değerini yolladık.
                frmDoktorDetay.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Doktor TC Kimlik veya şifre hatalı. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.baglantiFunc().Close();
        }
    }
}
