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
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }

        //SQL Bağlantısı
        SqlConnection connection = new SqlConnection("Data Source = DESKTOP-GHP8JEF;Initial Catalog=DB_Employee;Integrated Security=True;TrustServerCertificate=True");
        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            //Şehirlerdeki Çalışan Sayısı Chart Grafiği
            connection.Open();
            SqlCommand sehirCalisanKomut = new SqlCommand("Select persSehir,Count(*) From Tbl_Employee group by persSehir",connection);
            SqlDataReader dr1 = sehirCalisanKomut.ExecuteReader();
            while (dr1.Read())
            {
                solChart.Series["Sehirler"].Points.AddXY(dr1[0], dr1[1]);
            }
            connection.Close();

            //Mesleklere Göre Ortalama Maaş Chart Grafiği
            connection.Open();
            SqlCommand sehirOrtalamaMaasKomut = new SqlCommand("Select persMeslek, Avg(persMaas) From Tbl_Employee group by persMeslek",connection);
            SqlDataReader dr2 = sehirOrtalamaMaasKomut.ExecuteReader();
            while (dr2.Read())
            {
                sagChart.Series["Meslek-Maas"].Points.AddXY(dr2[0], dr2[1]);
            }
            connection.Close();
        }
    }
}
