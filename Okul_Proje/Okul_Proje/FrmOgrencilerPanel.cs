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
    public partial class FrmOgrencilerPanel : Form
    {
        public FrmOgrencilerPanel()
        {
            InitializeComponent();
        }
        SqlBaglantisi connection = new SqlBaglantisi();

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Ogrenciler", connection.baglantiFunc());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dGridOgrenciler.DataSource = dt;
        }

        private void FrmOgrencilerPanel_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void dGridOgrenciler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tBoxOgrenciId.Text = dGridOgrenciler.Rows[e.RowIndex].Cells[0].Value.ToString();
            tBoxOgrenciAd.Text = dGridOgrenciler.Rows[e.RowIndex].Cells[1].Value.ToString();
            tBoxOgrenciSoyad.Text = dGridOgrenciler.Rows[e.RowIndex].Cells[2].Value.ToString();
            tBoxOgrenciKulup.Text = dGridOgrenciler.Rows[e.RowIndex].Cells[3].Value.ToString();
            tBoxOgrenciCinsiyet.Text = dGridOgrenciler.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand ogrenciEkleme = new SqlCommand("Insert into Tbl_Ogrenciler (OgrenciAd, OgrenciSoyad, OgrenciKulup, OgrenciCinsiyet) values (@ogrenciAd, @ogrenciSoyad, @ogrenciKulup, @ogrenciCinsiyet)", connection.baglantiFunc());
            ogrenciEkleme.Parameters.AddWithValue("@ogrenciAd", tBoxOgrenciAd.Text);
            ogrenciEkleme.Parameters.AddWithValue("@ogrenciSoyad", tBoxOgrenciSoyad.Text);
            ogrenciEkleme.Parameters.AddWithValue("@ogrenciKulup", tBoxOgrenciKulup.Text);
            ogrenciEkleme.Parameters.AddWithValue("@ogrenciCinsiyet", tBoxOgrenciCinsiyet.Text);
            ogrenciEkleme.ExecuteNonQuery();
            connection.baglantiFunc().Close();
            MessageBox.Show("Öğrenci, listeye eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand ogrenciGuncelleme = new SqlCommand("Update Tbl_Ogrenciler set OgrenciAd=@ogrenciAd, OgrenciSoyad=@ogrenciSoyad, OgrenciKulup=@ogrenciKulup, OgrenciCinsiyet=@ogrenciCinsiyet where OgrenciId=@ogrenciId", connection.baglantiFunc());
            ogrenciGuncelleme.Parameters.AddWithValue("@ogrenciAd", tBoxOgrenciAd.Text);
            ogrenciGuncelleme.Parameters.AddWithValue("@ogrenciSoyad", tBoxOgrenciSoyad.Text);
            ogrenciGuncelleme.Parameters.AddWithValue("@ogrenciKulup", tBoxOgrenciKulup.Text);
            ogrenciGuncelleme.Parameters.AddWithValue("@ogrenciCinsiyet", tBoxOgrenciCinsiyet.Text);
            ogrenciGuncelleme.Parameters.AddWithValue("@ogrenciId", tBoxOgrenciId.Text);
            ogrenciGuncelleme.ExecuteNonQuery();
            connection.baglantiFunc().Close();
            MessageBox.Show("Öğrenci, listede güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand ogrenciSilme = new SqlCommand("Delete from Tbl_Ogrenciler where OgrenciId=@ogrenciId", connection.baglantiFunc());
            ogrenciSilme.Parameters.AddWithValue("@ogrenciAd", tBoxOgrenciAd.Text);
            ogrenciSilme.Parameters.AddWithValue("@ogrenciSoyad", tBoxOgrenciSoyad.Text);
            ogrenciSilme.Parameters.AddWithValue("@ogrenciKulup", tBoxOgrenciKulup.Text);
            ogrenciSilme.Parameters.AddWithValue("@ogrenciCinsiyet", tBoxOgrenciCinsiyet.Text);
            ogrenciSilme.Parameters.AddWithValue("@ogrenciId", tBoxOgrenciId.Text);
            ogrenciSilme.ExecuteNonQuery();
            connection.baglantiFunc().Close();
            MessageBox.Show("Öğrenci, listeden silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
    }
}
