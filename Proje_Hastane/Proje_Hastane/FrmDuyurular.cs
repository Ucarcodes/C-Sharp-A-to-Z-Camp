﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    public partial class FrmDuyurular : Form
    {
        public FrmDuyurular()
        {
            InitializeComponent();
        }

        sqlBaglantisi connection = new sqlBaglantisi();
        private void FrmDuyurular_Load(object sender, EventArgs e)
        {
            //Duyuruları DataGrid'e aktaralım.

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Duyurular", connection.baglantiFunc());
            da.Fill(dt);
            dGridDuyurular.DataSource = dt;

        }
    }
}
