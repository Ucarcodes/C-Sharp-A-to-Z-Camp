namespace Proje_Hastane
{
    partial class FrmHastaKayit
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
            this.tBoxSifre = new System.Windows.Forms.TextBox();
            this.maskTboxTC = new System.Windows.Forms.MaskedTextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblTCKimlik = new System.Windows.Forms.Label();
            this.tBoxAd = new System.Windows.Forms.TextBox();
            this.tBoxSoyad = new System.Windows.Forms.TextBox();
            this.maskTBoxTelefon = new System.Windows.Forms.MaskedTextBox();
            this.cBoxCinsiyet = new System.Windows.Forms.ComboBox();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.lblHastaKayitEkrani = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tBoxSifre
            // 
            this.tBoxSifre.Location = new System.Drawing.Point(263, 254);
            this.tBoxSifre.Name = "tBoxSifre";
            this.tBoxSifre.PasswordChar = '*';
            this.tBoxSifre.Size = new System.Drawing.Size(214, 30);
            this.tBoxSifre.TabIndex = 5;
            // 
            // maskTboxTC
            // 
            this.maskTboxTC.Location = new System.Drawing.Point(263, 182);
            this.maskTboxTC.Mask = "00000000000";
            this.maskTboxTC.Name = "maskTboxTC";
            this.maskTboxTC.Size = new System.Drawing.Size(214, 30);
            this.maskTboxTC.TabIndex = 3;
            this.maskTboxTC.ValidatingType = typeof(int);
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(199, 259);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(58, 25);
            this.lblSifre.TabIndex = 6;
            this.lblSifre.Text = "Şifre:";
            // 
            // lblTCKimlik
            // 
            this.lblTCKimlik.AutoSize = true;
            this.lblTCKimlik.Location = new System.Drawing.Point(124, 185);
            this.lblTCKimlik.Name = "lblTCKimlik";
            this.lblTCKimlik.Size = new System.Drawing.Size(133, 25);
            this.lblTCKimlik.TabIndex = 5;
            this.lblTCKimlik.Text = "TC Kimlik No:";
            // 
            // tBoxAd
            // 
            this.tBoxAd.Location = new System.Drawing.Point(263, 110);
            this.tBoxAd.Name = "tBoxAd";
            this.tBoxAd.Size = new System.Drawing.Size(214, 30);
            this.tBoxAd.TabIndex = 1;
            // 
            // tBoxSoyad
            // 
            this.tBoxSoyad.Location = new System.Drawing.Point(263, 146);
            this.tBoxSoyad.Name = "tBoxSoyad";
            this.tBoxSoyad.Size = new System.Drawing.Size(214, 30);
            this.tBoxSoyad.TabIndex = 2;
            // 
            // maskTBoxTelefon
            // 
            this.maskTBoxTelefon.Location = new System.Drawing.Point(263, 218);
            this.maskTBoxTelefon.Mask = "(999) 000-0000";
            this.maskTBoxTelefon.Name = "maskTBoxTelefon";
            this.maskTBoxTelefon.Size = new System.Drawing.Size(214, 30);
            this.maskTBoxTelefon.TabIndex = 4;
            // 
            // cBoxCinsiyet
            // 
            this.cBoxCinsiyet.FormattingEnabled = true;
            this.cBoxCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cBoxCinsiyet.Location = new System.Drawing.Point(263, 290);
            this.cBoxCinsiyet.Name = "cBoxCinsiyet";
            this.cBoxCinsiyet.Size = new System.Drawing.Size(214, 33);
            this.cBoxCinsiyet.TabIndex = 6;
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnKayitOl.Location = new System.Drawing.Point(263, 339);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(214, 34);
            this.btnKayitOl.TabIndex = 7;
            this.btnKayitOl.Text = "Kayıt Ol";
            this.btnKayitOl.UseVisualStyleBackColor = false;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // lblHastaKayitEkrani
            // 
            this.lblHastaKayitEkrani.AutoSize = true;
            this.lblHastaKayitEkrani.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastaKayitEkrani.Location = new System.Drawing.Point(177, 50);
            this.lblHastaKayitEkrani.Name = "lblHastaKayitEkrani";
            this.lblHastaKayitEkrani.Size = new System.Drawing.Size(362, 55);
            this.lblHastaKayitEkrani.TabIndex = 14;
            this.lblHastaKayitEkrani.Text = "Hasta Kayıt Ekranı";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(214, 110);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(43, 25);
            this.lblAd.TabIndex = 15;
            this.lblAd.Text = "Ad:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(182, 146);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(75, 25);
            this.lblSoyad.TabIndex = 16;
            this.lblSoyad.Text = "Soyad:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(173, 221);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(84, 25);
            this.lblTelefon.TabIndex = 17;
            this.lblTelefon.Text = "Telefon:";
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Location = new System.Drawing.Point(169, 298);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(88, 25);
            this.lblCinsiyet.TabIndex = 18;
            this.lblCinsiyet.Text = "Cinsiyet:";
            // 
            // FrmHastaKayit
            // 
            this.AcceptButton = this.btnKayitOl;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(678, 449);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.lblHastaKayitEkrani);
            this.Controls.Add(this.btnKayitOl);
            this.Controls.Add(this.cBoxCinsiyet);
            this.Controls.Add(this.maskTBoxTelefon);
            this.Controls.Add(this.tBoxSoyad);
            this.Controls.Add(this.tBoxAd);
            this.Controls.Add(this.tBoxSifre);
            this.Controls.Add(this.maskTboxTC);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblTCKimlik);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmHastaKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Kayıt Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxSifre;
        private System.Windows.Forms.MaskedTextBox maskTboxTC;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblTCKimlik;
        private System.Windows.Forms.TextBox tBoxAd;
        private System.Windows.Forms.TextBox tBoxSoyad;
        private System.Windows.Forms.MaskedTextBox maskTBoxTelefon;
        private System.Windows.Forms.ComboBox cBoxCinsiyet;
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.Label lblHastaKayitEkrani;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblCinsiyet;
    }
}