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
    public partial class FrmBransIslemleri : Form
    {
        public FrmBransIslemleri()
        {
            InitializeComponent();
        }

        sqlBaglantisi connection = new sqlBaglantisi();
        private void FrmBransIslemleri_Load(object sender, EventArgs e)
        {
            //DataGrid'e verileri çekelim.
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Branslar", connection.baglantiFunc());
            da.Fill(dt);
            dGridBransIslemleri.DataSource = dt;
        }
        //Datagridde bulunan verileri alanlara aktaralım.
        private void dGridBransIslemleri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dGridBransIslemleri.SelectedCells[0].RowIndex;
            tBoxBransId.Text = dGridBransIslemleri.Rows[secilen].Cells[0].Value.ToString();
            tBoxBransAdi.Text = dGridBransIslemleri.Rows[secilen].Cells[1].Value.ToString();
        }

        //Yeni branş ekleme
        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand bransEkleme = new SqlCommand("Insert into Tbl_Branslar (BransAd) values (@bransAd)", connection.baglantiFunc());
            bransEkleme.Parameters.AddWithValue("@bransAd", tBoxBransAdi.Text);
            bransEkleme.ExecuteNonQuery();
            MessageBox.Show("Yeni branş başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Branş güncelleme
        private void btnBilgileriGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Gerçekten seçilen branş bilgilerini güncellemek istiyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand bransGuncelleme = new SqlCommand("Update Tbl_Branslar set BransAd=@bransAd where BransId=@bransId", connection.baglantiFunc());
                bransGuncelleme.Parameters.AddWithValue("@bransAd", tBoxBransAdi.Text);
                bransGuncelleme.Parameters.AddWithValue("@bransId", tBoxBransId.Text);
                bransGuncelleme.ExecuteNonQuery();
                MessageBox.Show("Branş başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Hayır seçeneği seçildiği için, branş güncellenmedi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            connection.baglantiFunc().Close();
        }

        //Branş silme
        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Gerçekten seçilen branş bilgilerini silmek istiyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand bransSilme = new SqlCommand("Delete from Tbl_Branslar where BransId=@bransId", connection.baglantiFunc());
                bransSilme.Parameters.AddWithValue("@bransId", tBoxBransId.Text);
                bransSilme.ExecuteNonQuery();
                MessageBox.Show("Branş başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Hayır seçeneği seçildiği için, branş silinmedi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            connection.baglantiFunc().Close();
        }
    }
}
