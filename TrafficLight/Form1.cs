using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficLight
{
    public partial class Form1 : Form
    {
        int gecenSure = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            panelKirmiziIsik.Visible = true;
            panelSariIsik.Visible = false;
            panelYesilIsik.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gecenSure++;
            lblGecenSure.Text = "Geçen Süre: " + gecenSure.ToString();

            if (gecenSure >= 0 && gecenSure <= 30)
            {
                panelKirmiziIsik.Visible = true;
                panelSariIsik.Visible = false;
                panelYesilIsik.Visible = false;
            }

            else if (gecenSure > 30 && gecenSure <= 40)
            {
                panelKirmiziIsik.Visible = false;
                panelSariIsik.Visible = true;
                panelYesilIsik.Visible = false;
            }

            else if (gecenSure > 40 && gecenSure <= 70)
            {
                panelKirmiziIsik.Visible = false;
                panelSariIsik.Visible = false;
                panelYesilIsik.Visible = true;
            }

            else
            {
                gecenSure = 0;
            }
        }
    }
}
