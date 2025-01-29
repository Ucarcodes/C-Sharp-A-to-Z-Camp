﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class FrmGirisler : Form
    {
        public FrmGirisler()
        {
            InitializeComponent();
        }

        private void btnHasta_Click(object sender, EventArgs e)
        {
            FrmHastaGiris frmHastaGiris = new FrmHastaGiris();
            frmHastaGiris.Show();
            this.Hide();
        }

        private void btnDoktor_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris frmDoktorGiris = new FrmDoktorGiris();
            frmDoktorGiris.Show();
            this.Hide();
        }

        private void btnSekreter_Click(object sender, EventArgs e)
        {
            FrmSekreterGiris frmSekreterGiris = new FrmSekreterGiris();
            frmSekreterGiris.Show();
            this.Hide();
        }
    }
}
