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

namespace Okul_Proje
{
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }

        public string ogrenciIdsi;
        SqlBaglantisi connection = new SqlBaglantisi();
        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            //Inner Joinle Ders Adına erişelim ve öğrenci Id'ye göre not bilgisi getirelim.
            SqlCommand ogrenciBilgileriniGetir = new SqlCommand("Select DersAd, Sinav1, Sinav2, Sinav3, Proje, Ortalama, Durum From Tbl_Notlar Inner Join Tbl_Dersler on Tbl_Notlar.DersId = Tbl_Dersler.DersId where OgrenciId = @ogrenciId", connection.baglantiFunc());
            ogrenciBilgileriniGetir.Parameters.AddWithValue("@ogrenciId", ogrenciIdsi);

            SqlDataAdapter da = new SqlDataAdapter(ogrenciBilgileriniGetir);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dGridOgrenci.DataSource = dt;

            //Öğrenci Adını form başlığımız yapalım.

            SqlCommand ogrenciAdiGetir = new SqlCommand("Select OgrenciAd, OgrenciSoyad from Tbl_Ogrenciler where OgrenciId=@ogrenciId", connection.baglantiFunc());
            ogrenciAdiGetir.Parameters.AddWithValue("@ogrenciId", ogrenciIdsi);
            SqlDataReader dr = ogrenciAdiGetir.ExecuteReader();
            dr.Read();
            while(dr.Read())
            {
                this.Text= dr[0] + " " + dr[1]; //Bura çalışmadı bakılacak.
            }
           

        }
    }
}
