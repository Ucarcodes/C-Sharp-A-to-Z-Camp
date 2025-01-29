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

namespace Kitaplik_Proje
{
    public partial class FrmKitaplik : Form
    {
        public FrmKitaplik()
        {
            InitializeComponent();
        }

        SqlBaglanti connection = new SqlBaglanti();

        void VerileriListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Kitaplar", connection.baglantiFunc());
            da.Fill(dt);
            dGridKitaplik.DataSource = dt;
        }

        private void FrmKitaplik_Load(object sender, EventArgs e)
        {
            VerileriListele();
        }
        string durum = "";
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand kitapEkle = new SqlCommand("Insert into Tbl_Kitaplar (KitapAd, Yazar, KitapTuru, Sayfa, Durum) values (@kitapAd, @yazar, @kitapTuru, @sayfa, @durum)", connection.baglantiFunc());
            kitapEkle.Parameters.AddWithValue("@kitapAd", tBoxKitapAd.Text);
            kitapEkle.Parameters.AddWithValue("@yazar", tBoxYazar.Text);
            kitapEkle.Parameters.AddWithValue("@kitapTuru", cBoxTur.Text);
            kitapEkle.Parameters.AddWithValue("@sayfa", tBoxSayfa.Text);
            kitapEkle.Parameters.AddWithValue("@durum", durum); //Radyo butonlara tıklanma durumuna göre durum değerimiz değişiyor.
            kitapEkle.ExecuteNonQuery();
            connection.baglantiFunc().Close();
            MessageBox.Show("Kitap sisteme kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            VerileriListele();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            VerileriListele();
        }

        private void rBtnSifir_CheckedChanged(object sender, EventArgs e)
        {
            durum = "1";
        }

        private void rBtnKullanilmis_CheckedChanged(object sender, EventArgs e)
        {
            durum = "0";
        }

        private void dGridKitaplik_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dGridKitaplik.SelectedCells[0].RowIndex;
            tBoxKitapId.Text = dGridKitaplik.Rows[secilen].Cells[0].Value.ToString();
            tBoxKitapAd.Text= dGridKitaplik.Rows[secilen].Cells[1].Value.ToString();
            tBoxYazar.Text= dGridKitaplik.Rows[secilen].Cells[2].Value.ToString();
            tBoxSayfa.Text = dGridKitaplik.Rows[secilen].Cells[4].Value.ToString();
            cBoxTur.Text = dGridKitaplik.Rows[secilen].Cells[3].Value.ToString();

            if (dGridKitaplik.Rows[secilen].Cells[5].Value.ToString() == "True")
            {
                rBtnSifir.Checked = true;
                rBtnKullanilmis.Checked = false;
            }
            else if (dGridKitaplik.Rows[secilen].Cells[5].Value.ToString() == "False")
            {
                rBtnKullanilmis.Checked = true;
                rBtnSifir.Checked = false;
            }


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand kitapSilme = new SqlCommand("Delete from Tbl_Kitaplar where KitapId=@kitapId ", connection.baglantiFunc());
            kitapSilme.Parameters.AddWithValue("@kitapId", tBoxKitapId.Text);
            kitapSilme.ExecuteNonQuery();
            connection.baglantiFunc().Close();
            MessageBox.Show("Kitap sistemden silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            VerileriListele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand kitapGuncelle = new SqlCommand("Update Tbl_Kitaplar set KitapAd=@kitapAd, Yazar=@yazar, KitapTuru=@kitapTuru, Sayfa=@sayfa, Durum=@durum where KitapId=@kitapId", connection.baglantiFunc());
            kitapGuncelle.Parameters.AddWithValue("@kitapAd", tBoxKitapAd.Text);
            kitapGuncelle.Parameters.AddWithValue("@yazar", tBoxYazar.Text);
            kitapGuncelle.Parameters.AddWithValue("@kitapTuru", cBoxTur.Text);
            kitapGuncelle.Parameters.AddWithValue("@sayfa", tBoxSayfa.Text);
            kitapGuncelle.Parameters.AddWithValue("@durum", durum); //Radyo butonlara tıklanma durumuna göre durum değerimiz değişiyor.
            kitapGuncelle.Parameters.AddWithValue("@kitapId", tBoxKitapId.Text);
            kitapGuncelle.ExecuteNonQuery();
            connection.baglantiFunc().Close();
            MessageBox.Show("Kitap sistemde güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            VerileriListele();
        }

        private void btnKitapBul_Click(object sender, EventArgs e)
        {
            SqlCommand kitapBul = new SqlCommand("Select * From Tbl_Kitaplar where KitapAd=@kitapAd", connection.baglantiFunc());
            kitapBul.Parameters.AddWithValue("@kitapAd", tBoxKitapArama.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(kitapBul);
            da.Fill(dt);
            dGridKitaplik.DataSource = dt;
        }

        private void btnHarflereGoreBul_Click(object sender, EventArgs e)
        {
            //like kullanımı ile girilen harflere göre eşleşme olursa kitap getir.
            SqlCommand harfeGoreKitapBul = new SqlCommand("Select * From Tbl_Kitaplar where KitapAd like '%" + tBoxKitapArama.Text + "%'", connection.baglantiFunc());
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(harfeGoreKitapBul);
            da2.Fill(dt2);
            dGridKitaplik.DataSource = dt2;
            connection.baglantiFunc().Close();
        }
    }
}
