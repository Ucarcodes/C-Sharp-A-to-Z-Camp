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
    public partial class FrmOgretmenlerPanel : Form
    {
        public FrmOgretmenlerPanel()
        {
            InitializeComponent();
        }

        SqlBaglantisi connection = new SqlBaglantisi();

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Ogretmenler", connection.baglantiFunc());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dGridOgretmenler.DataSource = dt;
        }

        private void FrmOgretmenlerPanel_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void dGridOgretmenler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tBoxOgretmenId.Text = dGridOgretmenler.Rows[e.RowIndex].Cells[0].Value.ToString();
            tBoxBrans.Text = dGridOgretmenler.Rows[e.RowIndex].Cells[1].Value.ToString();
            tBoxOgretmenAdSoyad.Text = dGridOgretmenler.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand ogretmenEkleme = new SqlCommand("Insert into Tbl_Ogretmenler (OgretmenBrans, OgretmenAdSoyad) values (@ogretmenBrans, @ogretmenAdSoyad)", connection.baglantiFunc());
            ogretmenEkleme.Parameters.AddWithValue("@ogretmenBrans", tBoxBrans.Text);
            ogretmenEkleme.Parameters.AddWithValue("@ogretmenAdSoyad", tBoxOgretmenAdSoyad.Text);
            ogretmenEkleme.ExecuteNonQuery();
            connection.baglantiFunc().Close();
            MessageBox.Show("Öğretmen, listeye eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand ogretmenGuncelle = new SqlCommand("Update Tbl_Ogretmenler set OgretmenBrans=@ogretmenBrans, OgretmenAdSoyad=@ogretmenAdSoyad where OgretmenId=@ogretmenId", connection.baglantiFunc());
            ogretmenGuncelle.Parameters.AddWithValue("@ogretmenBrans", tBoxBrans.Text);
            ogretmenGuncelle.Parameters.AddWithValue("@ogretmenAdSoyad", tBoxOgretmenAdSoyad.Text);
            ogretmenGuncelle.Parameters.AddWithValue("@ogretmenId", tBoxOgretmenId.Text);
            ogretmenGuncelle.ExecuteNonQuery();
            connection.baglantiFunc().Close();
            MessageBox.Show("Öğretmen, listede güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand ogretmenSilme = new SqlCommand("Delete from Tbl_Ogretmenler where OgretmenId=@ogretmenId", connection.baglantiFunc());
            ogretmenSilme.Parameters.AddWithValue("@ogretmenBrans", tBoxBrans.Text);
            ogretmenSilme.Parameters.AddWithValue("@ogretmenAdSoyad", tBoxOgretmenAdSoyad.Text);
            ogretmenSilme.Parameters.AddWithValue("@ogretmenId", tBoxOgretmenId.Text);
            ogretmenSilme.ExecuteNonQuery();
            connection.baglantiFunc().Close();
            MessageBox.Show("Öğretmen, listeden silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
    }
}
