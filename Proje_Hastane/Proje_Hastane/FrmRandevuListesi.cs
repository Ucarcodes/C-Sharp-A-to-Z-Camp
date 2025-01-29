using System;
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
    public partial class FrmRandevuListesi : Form
    {
        public FrmRandevuListesi()
        {
            InitializeComponent();
        }

        sqlBaglantisi connection = new sqlBaglantisi();
        private void FrmRandevuListesi_Load(object sender, EventArgs e)
        {
            //Tüm randevuları DataGrid'e aktaralım.
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular", connection.baglantiFunc());
            da.Fill(dt);
            dGridRandevuListesi.DataSource = dt;
        }
    }
}
