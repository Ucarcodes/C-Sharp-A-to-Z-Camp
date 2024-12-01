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

namespace EmployeeProject
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        //SQL Bağlantısı
        SqlConnection connection = new SqlConnection("Data Source = DESKTOP-GHP8JEF;Initial Catalog=DB_Employee;Integrated Security=True;TrustServerCertificate=True");
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand girisKontrolKomutu = new SqlCommand("Select * From Tbl_Giris_Bilgileri where KullaniciAdi=@kullaniciAdi and Sifre=@sifre", connection);
            girisKontrolKomutu.Parameters.AddWithValue("@kullaniciAdi", tBoxKullaniciAdi.Text);
            girisKontrolKomutu.Parameters.AddWithValue("@sifre", tBoxSifre.Text);
            SqlDataReader dr = girisKontrolKomutu.ExecuteReader();
            if (dr.Read())
            {
                FrmAnaForm anaForm = new FrmAnaForm();
                anaForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı ya da Şifre!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();
        }
    }
}
