namespace EmployeeProject
{
    partial class FrmGrafikler
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.solChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sagChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.solChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sagChart)).BeginInit();
            this.SuspendLayout();
            // 
            // solChart
            // 
            chartArea3.Name = "ChartArea1";
            this.solChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.solChart.Legends.Add(legend3);
            this.solChart.Location = new System.Drawing.Point(12, 12);
            this.solChart.Name = "solChart";
            this.solChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.ChartArea = "ChartArea1";
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            series3.Legend = "Legend1";
            series3.Name = "Sehirler";
            this.solChart.Series.Add(series3);
            this.solChart.Size = new System.Drawing.Size(458, 306);
            this.solChart.TabIndex = 0;
            this.solChart.Text = "chart1";
            // 
            // sagChart
            // 
            chartArea4.Name = "ChartArea1";
            this.sagChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.sagChart.Legends.Add(legend4);
            this.sagChart.Location = new System.Drawing.Point(494, 12);
            this.sagChart.Name = "sagChart";
            this.sagChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series4.ChartArea = "ChartArea1";
            series4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            series4.Legend = "Legend1";
            series4.Name = "Meslek-Maas";
            this.sagChart.Series.Add(series4);
            this.sagChart.Size = new System.Drawing.Size(458, 306);
            this.sagChart.TabIndex = 1;
            this.sagChart.Text = "chart2";
            // 
            // FrmGrafikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(963, 350);
            this.Controls.Add(this.sagChart);
            this.Controls.Add(this.solChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmGrafikler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafikler";
            this.Load += new System.EventHandler(this.FrmGrafikler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.solChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sagChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart solChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart sagChart;
    }
}