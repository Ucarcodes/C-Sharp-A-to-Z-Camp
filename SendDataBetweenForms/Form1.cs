using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendDataBetweenForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnForm2Ac_Click(object sender, EventArgs e)
        {
            string gndDeger1 = tBoxGonDeg1.Text;
            string gndDeger2 = tBoxGonDeg2.Text;
            int gndDeger3 = Convert.ToInt16(tBoxGonDeg3.Text);

            Form2 frm2 = new Form2();

            frm2.cBoxGelDeg.Items.Add(gndDeger1);
            frm2.cBoxGelDeg.Items.Add(gndDeger2);
            frm2.cBoxGelDeg.Items.Add(gndDeger3.ToString());

            frm2.Show();
        }
    }
}
