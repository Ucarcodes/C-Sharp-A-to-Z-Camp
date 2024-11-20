namespace TrafficLight
{
    partial class Form1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelDisCerceve = new System.Windows.Forms.Panel();
            this.lblGecenSure = new System.Windows.Forms.Label();
            this.panelYesilIsik = new System.Windows.Forms.Panel();
            this.panelSariIsik = new System.Windows.Forms.Panel();
            this.panelKirmiziIsik = new System.Windows.Forms.Panel();
            this.panelDisCerceve.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelDisCerceve
            // 
            this.panelDisCerceve.BackColor = System.Drawing.Color.Black;
            this.panelDisCerceve.Controls.Add(this.lblGecenSure);
            this.panelDisCerceve.Controls.Add(this.panelYesilIsik);
            this.panelDisCerceve.Controls.Add(this.panelSariIsik);
            this.panelDisCerceve.Controls.Add(this.panelKirmiziIsik);
            this.panelDisCerceve.Location = new System.Drawing.Point(12, 16);
            this.panelDisCerceve.Name = "panelDisCerceve";
            this.panelDisCerceve.Size = new System.Drawing.Size(408, 820);
            this.panelDisCerceve.TabIndex = 1;
            // 
            // lblGecenSure
            // 
            this.lblGecenSure.AutoSize = true;
            this.lblGecenSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGecenSure.ForeColor = System.Drawing.Color.White;
            this.lblGecenSure.Location = new System.Drawing.Point(18, 9);
            this.lblGecenSure.Name = "lblGecenSure";
            this.lblGecenSure.Size = new System.Drawing.Size(165, 29);
            this.lblGecenSure.TabIndex = 3;
            this.lblGecenSure.Text = "Geçen Süre :";
            // 
            // panelYesilIsik
            // 
            this.panelYesilIsik.BackColor = System.Drawing.Color.Green;
            this.panelYesilIsik.Location = new System.Drawing.Point(23, 543);
            this.panelYesilIsik.Name = "panelYesilIsik";
            this.panelYesilIsik.Size = new System.Drawing.Size(361, 220);
            this.panelYesilIsik.TabIndex = 2;
            // 
            // panelSariIsik
            // 
            this.panelSariIsik.BackColor = System.Drawing.Color.Yellow;
            this.panelSariIsik.Location = new System.Drawing.Point(23, 300);
            this.panelSariIsik.Name = "panelSariIsik";
            this.panelSariIsik.Size = new System.Drawing.Size(361, 220);
            this.panelSariIsik.TabIndex = 1;
            // 
            // panelKirmiziIsik
            // 
            this.panelKirmiziIsik.BackColor = System.Drawing.Color.Red;
            this.panelKirmiziIsik.Location = new System.Drawing.Point(23, 52);
            this.panelKirmiziIsik.Name = "panelKirmiziIsik";
            this.panelKirmiziIsik.Size = new System.Drawing.Size(361, 220);
            this.panelKirmiziIsik.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(432, 853);
            this.Controls.Add(this.panelDisCerceve);
            this.Name = "Form1";
            this.Text = "Traffic Light";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelDisCerceve.ResumeLayout(false);
            this.panelDisCerceve.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelDisCerceve;
        private System.Windows.Forms.Label lblGecenSure;
        private System.Windows.Forms.Panel panelYesilIsik;
        private System.Windows.Forms.Panel panelSariIsik;
        private System.Windows.Forms.Panel panelKirmiziIsik;
    }
}

