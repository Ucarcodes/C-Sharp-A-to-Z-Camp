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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        sqlBaglantisi connection = new sqlBaglantisi();
        public string doktorTC;
        private void btnInternet_Click(object sender, EventArgs e)
        {
            FrmInternet frmInternet = new FrmInternet();
            frmInternet.Show();
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular frmDuyurular = new FrmDuyurular();
            frmDuyurular.Show();
        }

        private void btnBilgiDuzenle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiGuncelle frmDoktorBilgiGuncelle = new FrmDoktorBilgiGuncelle();
            frmDoktorBilgiGuncelle.doktorTCsi = lblTCDegeri.Text; //Doktor TC değerini aktardık.
            frmDoktorBilgiGuncelle.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            //Doktor TC değerini getirelim.
            lblTCDegeri.Text = doktorTC;

            //Doktor Ad Soyad bilgisi getirelim.

            SqlCommand doktorAdSoyadGetir = new SqlCommand("Select DoktorAd, DoktorSoyad from Tbl_Doktorlar where DoktorTC=@doktorTC", connection.baglantiFunc());
            doktorAdSoyadGetir.Parameters.AddWithValue("@doktorTC", lblTCDegeri.Text);
            SqlDataReader dr = doktorAdSoyadGetir.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyadDegeri.Text = dr[0] + " " + dr[1];
            }
            connection.baglantiFunc().Close();

            //Doktor İsmine Göre Randevuları getirelim.
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevular where RandevuDoktor='" + lblAdSoyadDegeri.Text + "'", connection.baglantiFunc());
            da.Fill(dt);
            dGridRandevuListesi.DataSource = dt;
        }

        private void dGridRandevuListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Randevu Detaylarını TextBox'a aktaralım.
            int secilen = dGridRandevuListesi.SelectedCells[0].RowIndex;
            rTBoxSikayetDetaylari.Text= dGridRandevuListesi.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
