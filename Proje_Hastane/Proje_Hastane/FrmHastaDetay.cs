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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }

        public string hastaTC;
        sqlBaglantisi connection = new sqlBaglantisi();
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            lblTCDegeri.Text = hastaTC;

            //Hasta Ad-Soyad Bilgisi Çekme

            SqlCommand hastaAdSoyadGetir = new SqlCommand("Select HastaAd, HastaSoyad From Tbl_Hastalar where HastaTC = @hastaTC", connection.baglantiFunc());
            hastaAdSoyadGetir.Parameters.AddWithValue("@hastaTC", lblTCDegeri.Text); //Çektiğimiz TC değeri
            SqlDataReader dr = hastaAdSoyadGetir.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyadDegeri.Text = dr[0] + " " + dr[1]; //Ad + boşluk + soyad yazdırdık.
            }

            //Hasta Randevu Geçmişi Çekme

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where HastaTC=" + hastaTC, connection.baglantiFunc());
            da.Fill(dt);
            dGridRandevuGecmisi.DataSource = dt;


            //Branşları Çekme
            SqlCommand bransGetir = new SqlCommand("Select BransAd From Tbl_Branslar", connection.baglantiFunc());
            SqlDataReader dr2 =bransGetir.ExecuteReader();
            while (dr2.Read())
            {
                cBoxBrans.Items.Add(dr2[0]); //Çekilen veriyi ComboBox'a ekle.
            }
            connection.baglantiFunc().Close();
        }

        private void cBoxBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBoxDoktor.Items.Clear();
            SqlCommand bransaGoreDoktorCek = new SqlCommand("Select DoktorAd, DoktorSoyad From Tbl_Doktorlar where DoktorBrans= @doktorBrans", connection.baglantiFunc());
            bransaGoreDoktorCek.Parameters.AddWithValue("@doktorBrans", cBoxBrans.Text);
            SqlDataReader dr = bransaGoreDoktorCek.ExecuteReader();
            while (dr.Read())
            {
                cBoxDoktor.Items.Add(dr[0] + " " + dr[1]); //Branşa göre doktor ad soyadını ekledik.
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaBilgiGuncelle frmHastaBilgiGuncelle = new FrmHastaBilgiGuncelle();
            frmHastaBilgiGuncelle.TCno = lblTCDegeri.Text; //TC Kimlik bilgisi yolladık.
            frmHastaBilgiGuncelle.Show();
        }

        private void cBoxDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            //SQL'de kelime bazlı aramalarda tek tırnak (') kullanmak gerekir.
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuBrans='" + cBoxBrans.Text + "'" + " and RandevuDoktor='" + cBoxDoktor.Text + "' and RandevuDurum=0",connection.baglantiFunc());
            da.Fill(dt);
            dGridAktifRandevular.DataSource = dt; //Aktif randevular dataGridine veri aktardık.


        }

        //RandevuId bilgisini textBox'a yazdırdık.
        private void dGridAktifRandevular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dGridAktifRandevular.SelectedCells[0].RowIndex;
            tBoxRandevuId.Text = dGridAktifRandevular.Rows[secilen].Cells[0].Value.ToString();
        }

        //Hasta randevu alma işlemi
        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand randevuAl = new SqlCommand("Update Tbl_Randevular set RandevuDurum=1, HastaTC=@hastaTC, HastaSikayet=@hastaSikayet where RandevuId=@randevuId", connection.baglantiFunc());
            randevuAl.Parameters.AddWithValue("@hastaTC", lblTCDegeri.Text);
            randevuAl.Parameters.AddWithValue("@hastaSikayet", rTBoxSikayet.Text);
            randevuAl.Parameters.AddWithValue("@randevuId", tBoxRandevuId.Text);
            randevuAl.ExecuteNonQuery();
            MessageBox.Show("Hasta, başarıyla randevu almıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.baglantiFunc().Close();
        }
    }
}
