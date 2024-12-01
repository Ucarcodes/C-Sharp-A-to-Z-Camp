using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeProject
{
    public partial class FrmRaporlar : Form
    {
        public FrmRaporlar()
        {
            InitializeComponent();
        }

        private void FrmRaporlar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_EmployeeDataSet.Tbl_Employee' table. You can move, or remove it, as needed.
            this.tbl_EmployeeTableAdapter.Fill(this.dB_EmployeeDataSet.Tbl_Employee);

            this.reportViewer1.RefreshReport();
        }
    }
}
