using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginCodeGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (tBoxOlusanKod.Text == tBoxKod.Text)
            {
                MessageBox.Show("Girilen Kod Doğru!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Girilen Kod Hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] karakterB = { "A", "B", "C", "D", "E", "F", "G" };
            string[] karakterK = { "z", "y", "v", "u", "t", "s", "r" };
            string[] sembol = { "!", "^", "+", "-", "*", "/", "=" };
            int rndSayi1;
            int rndSayi2;

            Random rndOlustur = new Random();
            int kB = rndOlustur.Next(0, karakterB.Length);
            int kK = rndOlustur.Next(0, karakterK.Length);
            int smb = rndOlustur.Next(0, sembol.Length);
            rndSayi1 = rndOlustur.Next(0, 10);
            rndSayi2 = rndOlustur.Next(0, 10);

            tBoxOlusanKod.Text = karakterB[kB].ToString() + karakterK[kK].ToString() + sembol[smb].ToString() + rndSayi1.ToString() + rndSayi2.ToString();
        }
    }
}
