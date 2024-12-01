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

namespace EmployeeProject
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }
        
        //SQL Bağlantısı
        SqlConnection connection = new SqlConnection("Data Source = DESKTOP-GHP8JEF;Initial Catalog=DB_Employee;Integrated Security=True;TrustServerCertificate=True");

        //Satırları Temizleme
        void SatirlariTemizle()
        {
            tBoxPersonelId.Text = "";
            tBoxAd.Text = "";
            tBoxSoyad.Text = "";
            tBoxSehir.Text = "";
            maskTBoxMaas.Text = "";
            rButtonEvli.Checked = false;
            rButtonBekar.Checked = false;
            tBoxMeslek.Text = "";

            tBoxAd.Focus(); //İmleç burada kalacak.
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rButtonBekar_CheckedChanged(object sender, EventArgs e)
        {
            lblPersonelDurum.Text = "False";
        }

        private void rButtonEvli_CheckedChanged(object sender, EventArgs e)
        {
            lblPersonelDurum.Text = "True";
        }

        //Listele Butonu
        private void btnListele_Click(object sender, EventArgs e)
        {
            this.tbl_EmployeeTableAdapter.Fill(this.dB_EmployeeDataSet.Tbl_Employee);
        }

        //Kaydet Butonu
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand eklemeKomutu = new SqlCommand("insert into Tbl_Employee (persAd, persSoyad, persSehir, persMaas, persDurum, persMeslek) values (@persAd, @persSoyad, @persSehir, @persMaas, @persDurum, @persMeslek)",connection);
            eklemeKomutu.Parameters.AddWithValue("@persAd", tBoxAd.Text);
            eklemeKomutu.Parameters.AddWithValue("@persSoyad", tBoxSoyad.Text);
            eklemeKomutu.Parameters.AddWithValue("@persSehir", tBoxSehir.Text);
            eklemeKomutu.Parameters.AddWithValue("@persMaas", maskTBoxMaas.Text);
            eklemeKomutu.Parameters.AddWithValue("@persDurum", lblPersonelDurum.Text);
            eklemeKomutu.Parameters.AddWithValue("@persMeslek", tBoxMeslek.Text);
            eklemeKomutu.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Çalışan, veritabanına başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Temizle Butonu
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            DialogResult dResult = MessageBox.Show("Şu anda girmekte olduğunuz satırları temizlemek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dResult == DialogResult.Yes)
            {
                SatirlariTemizle();
            }
            else if(dResult == DialogResult.No)
            {
                MessageBox.Show("Hayır seçeneğini seçtiğiniz için, satırlar temizlenmedi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        //Hücreye Çift Tıklayarak Değerleri Alanlara Aktarma
        private void dGridPersonel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenHucre = dGridPersonel.SelectedCells[0].RowIndex; //Seçilen hücreyi belirledik.

            tBoxPersonelId.Text = dGridPersonel.Rows[secilenHucre].Cells[0].Value.ToString();
            tBoxAd.Text = dGridPersonel.Rows[secilenHucre].Cells[1].Value.ToString();
            tBoxSoyad.Text = dGridPersonel.Rows[secilenHucre].Cells[2].Value.ToString();
            tBoxSehir.Text = dGridPersonel.Rows[secilenHucre].Cells[3].Value.ToString();
            maskTBoxMaas.Text = dGridPersonel.Rows[secilenHucre].Cells[4].Value.ToString();
            lblPersDurum.Text = dGridPersonel.Rows[secilenHucre].Cells[5].Value.ToString();
            if (lblPersDurum.Text == "True")
            {
                rButtonBekar.Checked = false;
                rButtonEvli.Checked = true;
            }
            else
            {
                rButtonBekar.Checked = true;
                rButtonEvli.Checked = false;
            }
            tBoxMeslek.Text = dGridPersonel.Rows[secilenHucre].Cells[6].Value.ToString();
        }

        //Silme Butonu
        private void btnSil_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand silmeKomutu = new SqlCommand("Delete From Tbl_Employee Where persId = @persId ",connection);

            DialogResult dResult = MessageBox.Show("İlgili personeli veritabanından silmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dResult == DialogResult.Yes)
            {
                silmeKomutu.Parameters.AddWithValue("@persId", tBoxPersonelId.Text);
                silmeKomutu.ExecuteNonQuery();
                MessageBox.Show("İlgili personel veri tabanından başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dResult == DialogResult.No)
            {
                MessageBox.Show("Hayır seçeneğini seçtiğiniz için, seçtiğiniz personel veri tabanından silinmedi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            connection.Close();
        }

        //Güncelleme Butonu
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand guncellemeKomutu = new SqlCommand("Update Tbl_Employee Set persAd=@persAd, persSoyad=@persSoyad, persSehir=@persSehir, persMaas=@persMaas, persDurum=@persDurum, persMeslek=@persMeslek Where persId=@persId ", connection);          
            DialogResult dResult = MessageBox.Show("İlgili personeli veritabanında güncellemek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dResult == DialogResult.Yes)
            {
                guncellemeKomutu.Parameters.AddWithValue("@persId", tBoxPersonelId.Text);
                guncellemeKomutu.Parameters.AddWithValue("@persAd", tBoxAd.Text);
                guncellemeKomutu.Parameters.AddWithValue("@persSoyad", tBoxSoyad.Text);
                guncellemeKomutu.Parameters.AddWithValue("@persSehir", tBoxSehir.Text);
                guncellemeKomutu.Parameters.AddWithValue("@persMaas", maskTBoxMaas.Text);
                guncellemeKomutu.Parameters.AddWithValue("@persDurum", lblPersonelDurum.Text);
                guncellemeKomutu.Parameters.AddWithValue("@persMeslek", tBoxMeslek.Text);
                guncellemeKomutu.ExecuteNonQuery();
                MessageBox.Show("İlgili personel veri tabanında başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dResult == DialogResult.No)
            {
                MessageBox.Show("Hayır seçeneğini seçtiğiniz için, seçtiğiniz personel veri tabanında güncellenmedi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            connection.Close();
        }

        //İstatistikler Butonu
        private void btnIstatistikler_Click(object sender, EventArgs e)
        {
            FrmIstatistik istatistikFormu = new FrmIstatistik();
            istatistikFormu.Show();
        }

        //Grafikler Butonu
        private void btnGrafikler_Click(object sender, EventArgs e)
        {
            FrmGrafikler grafikFormu = new FrmGrafikler();
            grafikFormu.Show();
        }

        //Raporlar Butonu
        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            FrmRaporlar raporFormu = new FrmRaporlar();
            raporFormu.Show();
        }
    }
}
