using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextFileCreation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string dosyaAdi, dosyaYolu;
        StreamWriter sw; //Metin belgisi yazdırma sürecinde kullanılır.

        private void btnYolSec_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                //dosyaYolu değişkenine, seçtiğimiz dosya yolunu atadık.
                dosyaYolu = folderBrowserDialog1.SelectedPath.ToString();
                tBoxDosyaYolu.Text = dosyaYolu;
            }
        }
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            dosyaAdi = tBoxDosyaAdi.Text;
            sw = File.CreateText(dosyaYolu + "\\" + dosyaAdi + ".txt");
            sw.Close();
            MessageBox.Show($"{dosyaAdi} isimli metin belgesi başarıyla oluşturuldu!");
        }
    }
}
