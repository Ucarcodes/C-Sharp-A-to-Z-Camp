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
    public partial class FrmDersler : Form
    {
        public FrmDersler()
        {
            InitializeComponent();
        }
        SqlBaglantisi connection = new SqlBaglantisi();

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Dersler", connection.baglantiFunc());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dGridDersler.DataSource = dt;
        }

        private void FrmOgrenciler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void dGridDersler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tBoxDersId.Text = dGridDersler.Rows[e.RowIndex].Cells[0].Value.ToString();
            tBoxDersAdi.Text = dGridDersler.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand dersGuncelle = new SqlCommand("Update Tbl_Dersler set DersAd=@dersAd where DersId=@dersId", connection.baglantiFunc());
            dersGuncelle.Parameters.AddWithValue("@dersAd", tBoxDersAdi.Text);
            dersGuncelle.Parameters.AddWithValue("@dersId", tBoxDersId.Text);
            dersGuncelle.ExecuteNonQuery();
            connection.baglantiFunc().Close();
            MessageBox.Show("Ders, listede güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand dersEkleme = new SqlCommand("Insert into Tbl_Dersler (DersAd) values (@dersAd)", connection.baglantiFunc());
            dersEkleme.Parameters.AddWithValue("@dersAd", tBoxDersAdi.Text);
            dersEkleme.ExecuteNonQuery();
            connection.baglantiFunc().Close();
            MessageBox.Show("Ders, listeye eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand dersSilme = new SqlCommand("Delete from Tbl_Dersler where DersId=@DersId", connection.baglantiFunc());
            dersSilme.Parameters.AddWithValue("@DersAd", tBoxDersAdi.Text);
            dersSilme.Parameters.AddWithValue("@DersId", tBoxDersId.Text);
            dersSilme.ExecuteNonQuery();
            connection.baglantiFunc().Close();
            MessageBox.Show("Ders, listeden silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
    }
}
