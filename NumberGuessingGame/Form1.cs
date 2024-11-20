using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGuessingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSansiniDene_Click(object sender, EventArgs e)
        {
            int rndSayi1, rndSayi2, rndSayi3, rndSayi4;

            Random rndSayiUret = new Random();

            rndSayi1 = rndSayiUret.Next(1, 5);
            rndSayi2 = rndSayiUret.Next(1, 5);
            rndSayi3 = rndSayiUret.Next(1, 5);
            rndSayi4 = rndSayiUret.Next(1, 5);

            lblRastgeleSayi1.Text = rndSayi1.ToString();
            lblRastgeleSayi2.Text = rndSayi2.ToString();
            lblRastgeleSayi3.Text = rndSayi3.ToString();
            lblRastgeleSayi4.Text = rndSayi4.ToString();

            /* Textbox 1 Kontrolü */
            if (tBoxRastgeleSayi1.Text == lblRastgeleSayi1.Text)
            {
                tBoxRastgeleSayi1.BackColor = Color.Green;
            }
            else
            {
                tBoxRastgeleSayi1.BackColor = Color.Red;
            }
            /* Textbox 2 Kontrolü */
            if (tBoxRastgeleSayi2.Text == lblRastgeleSayi2.Text)
            {
                tBoxRastgeleSayi2.BackColor = Color.Green;
            }
            else
            {
                tBoxRastgeleSayi2.BackColor = Color.Red;
            }
            /* Textbox 3 Kontrolü */
            if (tBoxRastgeleSayi3.Text == lblRastgeleSayi3.Text)
            {
                tBoxRastgeleSayi3.BackColor = Color.Green;
            }
            else
            {
                tBoxRastgeleSayi3.BackColor = Color.Red;
            }
            /* Textbox 4 Kontrolü */
            if (tBoxRastgeleSayi4.Text == lblRastgeleSayi4.Text)
            {
                tBoxRastgeleSayi4.BackColor = Color.Green;
            }
            else
            {
                tBoxRastgeleSayi4.BackColor = Color.Red;
            }
        }
    }
}
