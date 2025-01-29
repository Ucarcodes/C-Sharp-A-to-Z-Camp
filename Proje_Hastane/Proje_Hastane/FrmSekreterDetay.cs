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
using System.Data.Common;

namespace Proje_Hastane
{
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }

        public string sekreterTC;
        sqlBaglantisi connection = new sqlBaglantisi();

        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            lblTCDegeri.Text = sekreterTC;

            //Sekreter Ad Soyad bilgisi çekme

            SqlCommand sekreterAdSoyadCekme = new SqlCommand("Select SekreterAdSoyad from Tbl_Sekreter where SekreterTC=@sekreterTC",connection.baglantiFunc());
            sekreterAdSoyadCekme.Parameters.AddWithValue("@sekreterTC", lblTCDegeri.Text);
            SqlDataReader dr = sekreterAdSoyadCekme.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyadDegeri.Text = dr[0].ToString(); //Sekreter Ad Soyad bilgisini çektik.
            }
            connection.baglantiFunc().Close();


            //Branşları DataGrid'e aktarma

            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Tbl_Branslar", connection.baglantiFunc());
            da1.Fill(dt1);
            dGridBranslar.DataSource = dt1;
            connection.baglantiFunc().Close();

            //Doktorları DataGrid'e aktarma

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select DoktorAd, DoktorSoyad, DoktorBrans from Tbl_Doktorlar", connection.baglantiFunc());
            da2.Fill(dt2);
            dGridDoktorlar.DataSource = dt2;
            connection.baglantiFunc().Close();


            //Randevu Oluşturma ekranına Branş bilgisi çekme

            SqlCommand bransBilgisiCekme = new SqlCommand("Select BransAd from Tbl_Branslar", connection.baglantiFunc());
            SqlDataReader dr2 = bransBilgisiCekme.ExecuteReader();
            while (dr2.Read())
            {
                cBoxBrans.Items.Add(dr2[0]); //Branş bilgisini çektik.
            }
            connection.baglantiFunc().Close();
        }

        //Randevu oluşturma
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand randevuOlusturma = new SqlCommand("Insert into Tbl_Randevular (RandevuTarih, RandevuSaat, RandevuBrans, RandevuDoktor) values (@randevuTarih, @randevuSaat, @randevuBrans, @randevuDoktor)",connection.baglantiFunc());
            randevuOlusturma.Parameters.AddWithValue("@randevuTarih", maskTBoxTarih.Text);
            randevuOlusturma.Parameters.AddWithValue("@randevuSaat", maskTBoxSaat.Text);
            randevuOlusturma.Parameters.AddWithValue("@randevuBrans", cBoxBrans.Text);
            randevuOlusturma.Parameters.AddWithValue("@randevuDoktor", cBoxDoktor.Text);
            randevuOlusturma.ExecuteNonQuery();
            connection.baglantiFunc().Close();

            MessageBox.Show("Randevu başarıyla oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Branşa göre doktor bilgisi çekme
        private void cBoxBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBoxDoktor.Items.Clear();
            SqlCommand bransaGoreDoktorCek = new SqlCommand("Select DoktorAd, DoktorSoyad From Tbl_Doktorlar where DoktorBrans= @doktorBrans", connection.baglantiFunc());
            bransaGoreDoktorCek.Parameters.AddWithValue("@doktorBrans", cBoxBrans.Text);
            SqlDataReader dr3 = bransaGoreDoktorCek.ExecuteReader();
            while (dr3.Read())
            {
                cBoxDoktor.Items.Add(dr3[0] + " " + dr3[1]); //Branşa göre doktor ad soyadını ekledik.
            }
            connection.baglantiFunc().Close();
        }

        private void btnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand duyuruOlustur = new SqlCommand("Insert into Tbl_Duyurular (DuyuruMetin) values (@duyuruMetin)", connection.baglantiFunc());
            duyuruOlustur.Parameters.AddWithValue("@duyuruMetin", rTBoxDuyuruOlustur.Text);
            duyuruOlustur.ExecuteNonQuery();
            connection.baglantiFunc().Close();

            MessageBox.Show("Duyuru başarıyla oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDoktorPaneli_Click(object sender, EventArgs e)
        {
            FrmDoktorIslemleri frmDoktorIslemleri = new FrmDoktorIslemleri();
            frmDoktorIslemleri.Show();
        }

        private void btnBransPaneli_Click(object sender, EventArgs e)
        {
            FrmBransIslemleri frmBransIslemleri =new FrmBransIslemleri();
            frmBransIslemleri.Show();
        }

        private void btnRandevuListesi_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frmRandevuListesi = new FrmRandevuListesi();
            frmRandevuListesi.Show();
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular frmDuyurular = new FrmDuyurular();
            frmDuyurular.Show();
        }
    }
}
