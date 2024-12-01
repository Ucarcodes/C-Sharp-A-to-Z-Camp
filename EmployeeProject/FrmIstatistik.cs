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
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }

        //SQL Bağlantısı
        SqlConnection connection = new SqlConnection("Data Source = DESKTOP-GHP8JEF;Initial Catalog=DB_Employee;Integrated Security=True;TrustServerCertificate=True");

        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            //Toplam Personel Sayısı
            connection.Open();
            SqlCommand toplamPersonelSayisiKomut = new SqlCommand("Select Count (*) From Tbl_Employee",connection);
            SqlDataReader dr1 = toplamPersonelSayisiKomut.ExecuteReader();
            while (dr1.Read())
            {
                lblToplamSayi.Text= dr1[0].ToString();
            }
            connection.Close();

            //Toplam Maaş
            connection.Open();
            SqlCommand toplamMaasKomut = new SqlCommand("Select Sum(persMaas) From Tbl_Employee",connection);
            SqlDataReader dr2 = toplamMaasKomut.ExecuteReader();
            while (dr2.Read())
            {
                lblToplamMaasSayi.Text= dr2[0].ToString();
            }
            connection.Close();

            //Ortalama Maaş
            connection.Open();
            SqlCommand ortalamaMaasKomut = new SqlCommand("Select Avg(persMaas) From Tbl_Employee", connection);
            SqlDataReader dr3 = ortalamaMaasKomut.ExecuteReader();
            while (dr3.Read())
            {
                lblOrtalamaMaasSayi.Text = dr3[0].ToString();
            }
            connection.Close();

            //Evli Personel Sayısı
            connection.Open();
            SqlCommand evliPersonelSayisiKomut = new SqlCommand("Select Count (*) From Tbl_Employee Where persDurum=1", connection);
            SqlDataReader dr4 = evliPersonelSayisiKomut.ExecuteReader();
            while (dr4.Read())
            {
                lblEvliSayi.Text= dr4[0].ToString();
            }
            connection.Close();

            //Bekar Personel Sayısı
            connection.Open();
            SqlCommand bekarPersonelSayisiKomut = new SqlCommand("Select Count (*) From Tbl_Employee Where persDurum=0", connection);
            SqlDataReader dr5 = bekarPersonelSayisiKomut.ExecuteReader();
            while (dr5.Read())
            {
                lblBekarSayi.Text = dr5[0].ToString();
            }
            connection.Close();

            //Toplam Şehir Sayısı
            connection.Open();
            SqlCommand toplamSehirSayisiKomut = new SqlCommand("Select Count(distinct(persSehir)) From Tbl_Employee", connection);
            SqlDataReader dr6 = toplamSehirSayisiKomut.ExecuteReader();
            while (dr6.Read())
            {
                lblSehirSayi.Text = dr6[0].ToString();
            }
            connection.Close();


        }
    }
}
