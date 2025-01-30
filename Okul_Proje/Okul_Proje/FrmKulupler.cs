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
    public partial class FrmKulupler : Form
    {
        public FrmKulupler()
        {
            InitializeComponent();
        }
        SqlBaglantisi connection = new SqlBaglantisi();

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Kulupler", connection.baglantiFunc());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dGridKulupIslemleri.DataSource = dt;
        }
        private void FrmKulupler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand kulupEkleme = new SqlCommand("Insert into Tbl_Kulupler (KulupAd) values (@kulupAd)", connection.baglantiFunc());
            kulupEkleme.Parameters.AddWithValue("@kulupAd", tBoxKulupAdi.Text);
            kulupEkleme.ExecuteNonQuery();
            connection.baglantiFunc().Close();
            MessageBox.Show("Kulüp, listeye eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void dGridKulupIslemleri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tBoxKulupId.Text = dGridKulupIslemleri.Rows[e.RowIndex].Cells[0].Value.ToString();
            tBoxKulupAdi.Text = dGridKulupIslemleri.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand kulupSilme = new SqlCommand("Delete from Tbl_Kulupler where KulupId=@kulupId", connection.baglantiFunc());
            kulupSilme.Parameters.AddWithValue("@kulupAd", tBoxKulupAdi.Text);
            kulupSilme.Parameters.AddWithValue("@kulupId", tBoxKulupId.Text);
            kulupSilme.ExecuteNonQuery();
            connection.baglantiFunc().Close();
            MessageBox.Show("Kulüp, listeden silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand kulupGuncelle = new SqlCommand("Update Tbl_Kulupler set KulupAd=@kulupAd where KulupId=@kulupId",connection.baglantiFunc());
            kulupGuncelle.Parameters.AddWithValue("@kulupAd", tBoxKulupAdi.Text);
            kulupGuncelle.Parameters.AddWithValue("@kulupId", tBoxKulupId.Text);
            kulupGuncelle.ExecuteNonQuery();
            connection.baglantiFunc().Close();
            MessageBox.Show("Kulüp, listede güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
    }


}
