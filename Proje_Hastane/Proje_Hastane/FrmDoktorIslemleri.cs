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
    public partial class FrmDoktorIslemleri : Form
    {
        public FrmDoktorIslemleri()
        {
            InitializeComponent();
        }

        sqlBaglantisi connection = new sqlBaglantisi();


        private void FrmDoktorIslemleri_Load(object sender, EventArgs e)
        {
            //Doktor bilgilerini DataGrid'e aktarma
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Doktorlar", connection.baglantiFunc());
            da.Fill(dt);
            dGridDoktorIslemleri.DataSource = dt;

            //Branş bilgilerini aktarma
            SqlCommand bransBilgileriniAktar = new SqlCommand("Select BransAd from Tbl_Branslar ", connection.baglantiFunc());
            SqlDataReader dr = bransBilgileriniAktar.ExecuteReader();
            while (dr.Read())
            {
                cBoxBrans.Items.Add(dr[0]); //Branş bilgilerini ekledik.
            }
        }

        private void satirlariTemizle()
        {
            tBoxAd.Text = "";
            tBoxSoyad.Text = "";
            cBoxBrans.Text = "";
            maskTboxTC.Text = "";
            tBoxSifre.Text = "";

        }

        //Yeni Doktor Ekleme
        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand yeniDoktorEkleme = new SqlCommand("Insert into Tbl_Doktorlar (DoktorAd, DoktorSoyad, DoktorBrans, DoktorTC, DoktorSifre) values (@doktorAd, @doktorSoyad, @doktorBrans, @doktorTC, @doktorSifre)", connection.baglantiFunc());
            yeniDoktorEkleme.Parameters.AddWithValue("@doktorAd", tBoxAd.Text);
            yeniDoktorEkleme.Parameters.AddWithValue("@doktorSoyad", tBoxSoyad.Text);
            yeniDoktorEkleme.Parameters.AddWithValue("@doktorBrans", cBoxBrans.Text);
            yeniDoktorEkleme.Parameters.AddWithValue("@doktorTC", maskTboxTC.Text);
            yeniDoktorEkleme.Parameters.AddWithValue("@doktorSifre", tBoxSifre.Text);
            yeniDoktorEkleme.ExecuteNonQuery();
            connection.baglantiFunc().Close();
            MessageBox.Show("Yeni doktor başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //DataGrid'e tıklandığında, DataGrid'de bulunan verileri ilgili alanlara aktarma
        private void dGridDoktorIslemleri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dGridDoktorIslemleri.SelectedCells[0].RowIndex;
            tBoxAd.Text= dGridDoktorIslemleri.Rows[secilen].Cells[1].Value.ToString();
            tBoxSoyad.Text= dGridDoktorIslemleri.Rows[secilen].Cells[2].Value.ToString();
            cBoxBrans.Text = dGridDoktorIslemleri.Rows[secilen].Cells[3].Value.ToString();
            maskTboxTC.Text = dGridDoktorIslemleri.Rows[secilen].Cells[4].Value.ToString();
            tBoxSifre.Text = dGridDoktorIslemleri.Rows[secilen].Cells[5].Value.ToString();
        }

        //Mevcut Doktoru silme 
        private void btnSil_Click(object sender, EventArgs e)
        {
           DialogResult dialogResult = MessageBox.Show("Gerçekten seçilen doktoru silmek istiyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand doktorSilme = new SqlCommand("Delete from Tbl_Doktorlar where DoktorTC=@doktorTC", connection.baglantiFunc());
                doktorSilme.Parameters.AddWithValue("@doktorTC", maskTboxTC.Text);
                doktorSilme.ExecuteNonQuery();
                MessageBox.Show("Seçilen doktor silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                satirlariTemizle(); //Doktor silindikten sonra satırları da temizleyelim.
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Hayır seçeneği seçildiği için, doktor silinmedi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
            }
            connection.baglantiFunc().Close();
        }

        //Mevcut Doktor bilgilerini güncelleme
        private void btnBilgileriGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Gerçekten seçilen doktor bilgilerini güncellemek istiyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand doktorGuncelleme = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@doktorAd, DoktorSoyad=@doktorSoyad, DoktorBrans=@doktorBrans,DoktorSifre=@doktorSifre where DoktorTC=@doktorTC", connection.baglantiFunc());
                doktorGuncelleme.Parameters.AddWithValue("@doktorAd", tBoxAd.Text);
                doktorGuncelleme.Parameters.AddWithValue("@doktorSoyad", tBoxSoyad.Text);
                doktorGuncelleme.Parameters.AddWithValue("@doktorBrans", cBoxBrans.Text);
                doktorGuncelleme.Parameters.AddWithValue("@doktorTC", maskTboxTC.Text);
                doktorGuncelleme.Parameters.AddWithValue("@doktorSifre",tBoxSifre.Text);
                doktorGuncelleme.ExecuteNonQuery();
                MessageBox.Show("Seçilen doktor güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Hayır seçeneği seçildiği için, doktor güncellenmedi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            connection.baglantiFunc().Close();
        }
    }
}
