using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumericalOperations
{
    public partial class Form1 : Form
    {
        double sayi1, sayi2, sonuc;
        string islem;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(tBoxSayi1.Text);
            sayi2 = Convert.ToDouble(tBoxSayi2.Text);
            islem = cBoxIslem.Text;

            switch (islem)
            {
                case "+":
                    tBoxYapilanIslem.Text = "Toplama İşlemi";
                    sonuc = (sayi1 + sayi2);
                    tBoxSonuc.Text = sonuc.ToString("0.00");
                    break;

                case "-":
                    tBoxYapilanIslem.Text = "Çıkarma İşlemi";
                    sonuc = (sayi1 - sayi2);
                    tBoxSonuc.Text = sonuc.ToString("0.00");
                    break;

                case "*":
                    tBoxYapilanIslem.Text = "Çarpma İşlemi";
                    sonuc = (sayi1 * sayi2);
                    tBoxSonuc.Text = sonuc.ToString("0.00");
                    break;

                case "/":
                    tBoxYapilanIslem.Text = "Bölme İşlemi";
                    sonuc = (sayi1 / sayi2);
                    tBoxSonuc.Text = sonuc.ToString("0.00");
                    break;

                default:
                    tBoxYapilanIslem.Text = "Lütfen bir işlem seçiniz.";
                    break;
            }


        }


    }
}
