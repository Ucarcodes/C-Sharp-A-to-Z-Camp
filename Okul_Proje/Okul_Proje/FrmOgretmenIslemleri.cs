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
    public partial class FrmOgretmenIslemleri : Form
    {
        public FrmOgretmenIslemleri()
        {
            InitializeComponent();
        }

        private void btnKulupIslemleri_Click(object sender, EventArgs e)
        {
            FrmKulupler frmKulupler = new FrmKulupler();
            frmKulupler.Show();
        }

        private void btnDersIslemleri_Click(object sender, EventArgs e)
        {
            FrmDersler frmDersler = new FrmDersler();
            frmDersler.Show();
        }

        private void btnOgretmenler_Click(object sender, EventArgs e)
        {
            FrmOgretmenlerPanel frmOgretmenlerPanel = new FrmOgretmenlerPanel();
            frmOgretmenlerPanel.Show();
        }

        private void btnOgrenciler_Click(object sender, EventArgs e)
        {
            FrmOgrencilerPanel frmOgrencilerPanel = new FrmOgrencilerPanel();
            frmOgrencilerPanel.Show();
        }
    }
}
