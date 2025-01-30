using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okul_Proje
{
    public partial class FrmOkulGiris : Form
    {
        public FrmOkulGiris()
        {
            InitializeComponent();
        }


        private void FrmOkulGiris_Load(object sender, EventArgs e)
        {
            tBoxOgrenciNo.TabStop = false;
            tBoxOgrenciNo.ForeColor = Color.Gray;
            tBoxOgrenciNo.Text = "Öğrenci No Giriniz...";
        }

        private void tBoxOgrenciNo_MouseClick(object sender, MouseEventArgs e)
        {
            tBoxOgrenciNo.Text = "";
            tBoxOgrenciNo.ForeColor = Color.Black;
        }

        private void pBoxOgrenci_Click(object sender, EventArgs e)
        {
            if (tBoxOgrenciNo.Text != string.Empty)
            {
                FrmOgrenci frmOgrenci = new FrmOgrenci();
                frmOgrenci.ogrenciIdsi = tBoxOgrenciNo.Text;
                frmOgrenci.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir Öğrenci ID'si giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pBoxOgretmen_Click(object sender, EventArgs e)
        {
            FrmOgretmenIslemleri frmOgretmenIslemleri = new FrmOgretmenIslemleri();
            frmOgretmenIslemleri.Show();
            this.Hide();
        }
    }
}
