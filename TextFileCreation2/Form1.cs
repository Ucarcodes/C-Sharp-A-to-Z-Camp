﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextFileCreation2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMetinOlustur_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Metin Dosyaları| *.txt";
            saveFileDialog1.Title = "Metin Belgesi Oluşturma";
            saveFileDialog1.ShowDialog();
            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
            sw.WriteLine(rTBoxMetin.Text);
            sw.Close();
            MessageBox.Show("Metin belgesi başarıyla oluşturuldu!");
        }
    }
}
