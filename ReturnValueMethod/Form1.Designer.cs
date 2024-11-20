namespace ReturnValueMethod
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
            this.listBoxDegerler = new System.Windows.Forms.ListBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblDeger2 = new System.Windows.Forms.Label();
            this.lblDeger1 = new System.Windows.Forms.Label();
            this.txtBoxDeger2 = new System.Windows.Forms.TextBox();
            this.txtBoxDeger1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxDegerler
            // 
            this.listBoxDegerler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBoxDegerler.FormattingEnabled = true;
            this.listBoxDegerler.ItemHeight = 25;
            this.listBoxDegerler.Location = new System.Drawing.Point(8, 211);
            this.listBoxDegerler.Name = "listBoxDegerler";
            this.listBoxDegerler.Size = new System.Drawing.Size(381, 179);
            this.listBoxDegerler.TabIndex = 11;
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.ForeColor = System.Drawing.Color.White;
            this.btnHesapla.Location = new System.Drawing.Point(276, 159);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(113, 39);
            this.btnHesapla.TabIndex = 10;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblDeger2
            // 
            this.lblDeger2.AutoSize = true;
            this.lblDeger2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDeger2.Location = new System.Drawing.Point(8, 95);
            this.lblDeger2.Name = "lblDeger2";
            this.lblDeger2.Size = new System.Drawing.Size(169, 25);
            this.lblDeger2.TabIndex = 9;
            this.lblDeger2.Text = "Girilen Değer 2 :";
            // 
            // lblDeger1
            // 
            this.lblDeger1.AutoSize = true;
            this.lblDeger1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDeger1.Location = new System.Drawing.Point(8, 28);
            this.lblDeger1.Name = "lblDeger1";
            this.lblDeger1.Size = new System.Drawing.Size(169, 25);
            this.lblDeger1.TabIndex = 8;
            this.lblDeger1.Text = "Girilen Değer 1 :";
            // 
            // txtBoxDeger2
            // 
            this.txtBoxDeger2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxDeger2.Location = new System.Drawing.Point(8, 123);
            this.txtBoxDeger2.Name = "txtBoxDeger2";
            this.txtBoxDeger2.Size = new System.Drawing.Size(381, 30);
            this.txtBoxDeger2.TabIndex = 7;
            // 
            // txtBoxDeger1
            // 
            this.txtBoxDeger1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxDeger1.Location = new System.Drawing.Point(8, 56);
            this.txtBoxDeger1.Name = "txtBoxDeger1";
            this.txtBoxDeger1.Size = new System.Drawing.Size(381, 30);
            this.txtBoxDeger1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(397, 403);
            this.Controls.Add(this.listBoxDegerler);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblDeger2);
            this.Controls.Add(this.lblDeger1);
            this.Controls.Add(this.txtBoxDeger2);
            this.Controls.Add(this.txtBoxDeger1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return Value Method";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDegerler;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblDeger2;
        private System.Windows.Forms.Label lblDeger1;
        private System.Windows.Forms.TextBox txtBoxDeger2;
        private System.Windows.Forms.TextBox txtBoxDeger1;
    }
}

