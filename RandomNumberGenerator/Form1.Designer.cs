namespace RandomNumberGenerator
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
            this.tBoxUretilenSayi = new System.Windows.Forms.TextBox();
            this.lblUretilenSayi = new System.Windows.Forms.Label();
            this.btnSayiUret = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBoxUretilenSayi
            // 
            this.tBoxUretilenSayi.Enabled = false;
            this.tBoxUretilenSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tBoxUretilenSayi.Location = new System.Drawing.Point(258, 52);
            this.tBoxUretilenSayi.Name = "tBoxUretilenSayi";
            this.tBoxUretilenSayi.Size = new System.Drawing.Size(210, 30);
            this.tBoxUretilenSayi.TabIndex = 5;
            // 
            // lblUretilenSayi
            // 
            this.lblUretilenSayi.AutoSize = true;
            this.lblUretilenSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUretilenSayi.Location = new System.Drawing.Point(14, 55);
            this.lblUretilenSayi.Name = "lblUretilenSayi";
            this.lblUretilenSayi.Size = new System.Drawing.Size(238, 25);
            this.lblUretilenSayi.TabIndex = 4;
            this.lblUretilenSayi.Text = "Rastgele Üretilen Sayı :";
            // 
            // btnSayiUret
            // 
            this.btnSayiUret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSayiUret.Location = new System.Drawing.Point(174, 114);
            this.btnSayiUret.Name = "btnSayiUret";
            this.btnSayiUret.Size = new System.Drawing.Size(134, 33);
            this.btnSayiUret.TabIndex = 3;
            this.btnSayiUret.Text = "Sayı Üret";
            this.btnSayiUret.UseVisualStyleBackColor = true;
            this.btnSayiUret.Click += new System.EventHandler(this.btnSayiUret_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(482, 159);
            this.Controls.Add(this.tBoxUretilenSayi);
            this.Controls.Add(this.lblUretilenSayi);
            this.Controls.Add(this.btnSayiUret);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random Number Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxUretilenSayi;
        private System.Windows.Forms.Label lblUretilenSayi;
        private System.Windows.Forms.Button btnSayiUret;
    }
}

