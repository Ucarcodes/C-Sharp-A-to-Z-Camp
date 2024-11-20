using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReturnValueMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int FuncDegerTopla(int deger1, int deger2)
        {
            int degerlerToplami = deger1 + deger2;
            return degerlerToplami;

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int gd1 = Convert.ToInt16(txtBoxDeger1.Text);
            int gd2 = Convert.ToInt16(txtBoxDeger2.Text);

            listBoxDegerler.Items.Add("Girilen Değer 1:");
            listBoxDegerler.Items.Add(gd1);
            listBoxDegerler.Items.Add("Girilen Değer 2:");
            listBoxDegerler.Items.Add(gd2);
            listBoxDegerler.Items.Add("Girilen Değerler Toplamı:");
            listBoxDegerler.Items.Add(FuncDegerTopla(gd1, gd2).ToString());
        }
    }
}
