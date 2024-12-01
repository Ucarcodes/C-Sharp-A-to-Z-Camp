namespace EmployeeProject
{
    partial class FrmGiris
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
            this.lblAnaBaslik = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.tBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.tBoxSifre = new System.Windows.Forms.TextBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAnaBaslik
            // 
            this.lblAnaBaslik.AutoSize = true;
            this.lblAnaBaslik.Font = new System.Drawing.Font("Segoe Script", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAnaBaslik.ForeColor = System.Drawing.Color.White;
            this.lblAnaBaslik.Location = new System.Drawing.Point(100, 35);
            this.lblAnaBaslik.Name = "lblAnaBaslik";
            this.lblAnaBaslik.Size = new System.Drawing.Size(550, 46);
            this.lblAnaBaslik.TabIndex = 0;
            this.lblAnaBaslik.Text = "Personel Takip Sistemi Giriş Paneli";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.BackColor = System.Drawing.Color.SteelBlue;
            this.lblKullaniciAdi.ForeColor = System.Drawing.Color.White;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(154, 103);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(125, 25);
            this.lblKullaniciAdi.TabIndex = 1;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.ForeColor = System.Drawing.Color.White;
            this.lblSifre.Location = new System.Drawing.Point(221, 142);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(58, 25);
            this.lblSifre.TabIndex = 2;
            this.lblSifre.Text = "Şifre:";
            // 
            // tBoxKullaniciAdi
            // 
            this.tBoxKullaniciAdi.Location = new System.Drawing.Point(286, 105);
            this.tBoxKullaniciAdi.Name = "tBoxKullaniciAdi";
            this.tBoxKullaniciAdi.Size = new System.Drawing.Size(253, 30);
            this.tBoxKullaniciAdi.TabIndex = 3;
            // 
            // tBoxSifre
            // 
            this.tBoxSifre.Location = new System.Drawing.Point(286, 142);
            this.tBoxSifre.Name = "tBoxSifre";
            this.tBoxSifre.Size = new System.Drawing.Size(253, 30);
            this.tBoxSifre.TabIndex = 4;
            this.tBoxSifre.UseSystemPasswordChar = true;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.White;
            this.btnGirisYap.Location = new System.Drawing.Point(421, 195);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(118, 37);
            this.btnGirisYap.TabIndex = 5;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(782, 328);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.tBoxSifre);
            this.Controls.Add(this.tBoxKullaniciAdi);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.lblAnaBaslik);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnaBaslik;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox tBoxKullaniciAdi;
        private System.Windows.Forms.TextBox tBoxSifre;
        private System.Windows.Forms.Button btnGirisYap;
    }
}