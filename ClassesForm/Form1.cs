using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarInfo arbOzellikleri = new CarInfo();
            /* ARABA ÖZELLİKLERİ */
            arbOzellikleri.markaUpper = "Mercedes";
            arbOzellikleri.model = "E500";
            arbOzellikleri.hacimABS = -5000f;
            arbOzellikleri.renk = "040 - Metalik Siyah";
            /* KULLANICI BİLGİLERİ */
            arbOzellikleri.kullaniciAdi = "Kullanıcı Adı";
            arbOzellikleri.kullaniciSoyAdi = "Kullanıcı Soyadı";
            arbOzellikleri.kullaniciYasiABS = 25;

            /* ARABA ÖZELLİKLERİ YAZDIRMA */
            txtBoxMarka.Text = arbOzellikleri.markaUpper;
            txtBoxModel.Text = arbOzellikleri.model;
            txtBoxHacim.Text = arbOzellikleri.hacimABS.ToString();
            txtBoxRenk.Text = arbOzellikleri.renk;

            /* KULLANICI BİLGİLERİ YAZDIRMA */
            txtBoxKullaniciAdi.Text = arbOzellikleri.kullaniciAdi;
            txtBoxKullaniciSoyadi.Text = arbOzellikleri.kullaniciSoyAdi;
            txtBoxKullaniciYasi.Text = arbOzellikleri.kullaniciYasiABS.ToString();
        }
    }
}
