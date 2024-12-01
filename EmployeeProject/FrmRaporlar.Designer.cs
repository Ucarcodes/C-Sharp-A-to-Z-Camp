namespace EmployeeProject
{
    partial class FrmRaporlar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dB_EmployeeDataSet = new EmployeeProject.DB_EmployeeDataSet();
            this.dBEmployeeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_EmployeeTableAdapter = new EmployeeProject.DB_EmployeeDataSetTableAdapters.Tbl_EmployeeTableAdapter();
            this.Tbl_EmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dB_EmployeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBEmployeeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_EmployeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetPersonel";
            reportDataSource1.Value = this.Tbl_EmployeeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EmployeeProject.reportPersonel.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1032, 553);
            this.reportViewer1.TabIndex = 0;
            // 
            // dB_EmployeeDataSet
            // 
            this.dB_EmployeeDataSet.DataSetName = "DB_EmployeeDataSet";
            this.dB_EmployeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBEmployeeDataSetBindingSource
            // 
            this.dBEmployeeDataSetBindingSource.DataSource = this.dB_EmployeeDataSet;
            this.dBEmployeeDataSetBindingSource.Position = 0;
            // 
            // tblEmployeeBindingSource
            // 
            this.tblEmployeeBindingSource.DataMember = "Tbl_Employee";
            this.tblEmployeeBindingSource.DataSource = this.dBEmployeeDataSetBindingSource;
            // 
            // tbl_EmployeeTableAdapter
            // 
            this.tbl_EmployeeTableAdapter.ClearBeforeFill = true;
            // 
            // Tbl_EmployeeBindingSource
            // 
            this.Tbl_EmployeeBindingSource.DataMember = "Tbl_Employee";
            this.Tbl_EmployeeBindingSource.DataSource = this.dB_EmployeeDataSet;
            // 
            // FrmRaporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1032, 553);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRaporlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raporlar";
            this.Load += new System.EventHandler(this.FrmRaporlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_EmployeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBEmployeeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_EmployeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dBEmployeeDataSetBindingSource;
        private DB_EmployeeDataSet dB_EmployeeDataSet;
        private System.Windows.Forms.BindingSource tblEmployeeBindingSource;
        private DB_EmployeeDataSetTableAdapters.Tbl_EmployeeTableAdapter tbl_EmployeeTableAdapter;
        private System.Windows.Forms.BindingSource Tbl_EmployeeBindingSource;
    }
}