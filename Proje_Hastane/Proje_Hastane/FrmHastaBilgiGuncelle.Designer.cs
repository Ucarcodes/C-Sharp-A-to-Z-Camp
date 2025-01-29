namespace Proje_Hastane
{
    partial class FrmHastaBilgiGuncelle
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
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblHastaBilgiGuncelleme = new System.Windows.Forms.Label();
            this.btnBilgileriGuncelle = new System.Windows.Forms.Button();
            this.cBoxCinsiyet = new System.Windows.Forms.ComboBox();
            this.maskTBoxTelefon = new System.Windows.Forms.MaskedTextBox();
            this.tBoxSoyad = new System.Windows.Forms.TextBox();
            this.tBoxAd = new System.Windows.Forms.TextBox();
            this.tBoxSifre = new System.Windows.Forms.TextBox();
            this.maskTboxTC = new System.Windows.Forms.MaskedTextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblTCKimlik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Location = new System.Drawing.Point(179, 313);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(88, 25);
            this.lblCinsiyet.TabIndex = 32;
            this.lblCinsiyet.Text = "Cinsiyet:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(183, 236);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(84, 25);
            this.lblTelefon.TabIndex = 31;
            this.lblTelefon.Text = "Telefon:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(192, 161);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(75, 25);
            this.lblSoyad.TabIndex = 30;
            this.lblSoyad.Text = "Soyad:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(224, 125);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(43, 25);
            this.lblAd.TabIndex = 29;
            this.lblAd.Text = "Ad:";
            // 
            // lblHastaBilgiGuncelleme
            // 
            this.lblHastaBilgiGuncelleme.AutoSize = true;
            this.lblHastaBilgiGuncelleme.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastaBilgiGuncelleme.Location = new System.Drawing.Point(66, 67);
            this.lblHastaBilgiGuncelleme.Name = "lblHastaBilgiGuncelleme";
            this.lblHastaBilgiGuncelleme.Size = new System.Drawing.Size(567, 55);
            this.lblHastaBilgiGuncelleme.TabIndex = 28;
            this.lblHastaBilgiGuncelleme.Text = "Hasta Bilgi Güncelleme Ekranı";
            // 
            // btnBilgileriGuncelle
            // 
            this.btnBilgileriGuncelle.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBilgileriGuncelle.Location = new System.Drawing.Point(273, 354);
            this.btnBilgileriGuncelle.Name = "btnBilgileriGuncelle";
            this.btnBilgileriGuncelle.Size = new System.Drawing.Size(214, 34);
            this.btnBilgileriGuncelle.TabIndex = 27;
            this.btnBilgileriGuncelle.Text = "Bilgileri Güncelle";
            this.btnBilgileriGuncelle.UseVisualStyleBackColor = false;
            this.btnBilgileriGuncelle.Click += new System.EventHandler(this.btnBilgileriGuncelle_Click);
            // 
            // cBoxCinsiyet
            // 
            this.cBoxCinsiyet.FormattingEnabled = true;
            this.cBoxCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cBoxCinsiyet.Location = new System.Drawing.Point(273, 305);
            this.cBoxCinsiyet.Name = "cBoxCinsiyet";
            this.cBoxCinsiyet.Size = new System.Drawing.Size(214, 33);
            this.cBoxCinsiyet.TabIndex = 26;
            // 
            // maskTBoxTelefon
            // 
            this.maskTBoxTelefon.Location = new System.Drawing.Point(273, 233);
            this.maskTBoxTelefon.Mask = "(999) 000-0000";
            this.maskTBoxTelefon.Name = "maskTBoxTelefon";
            this.maskTBoxTelefon.Size = new System.Drawing.Size(214, 30);
            this.maskTBoxTelefon.TabIndex = 25;
            // 
            // tBoxSoyad
            // 
            this.tBoxSoyad.Location = new System.Drawing.Point(273, 161);
            this.tBoxSoyad.Name = "tBoxSoyad";
            this.tBoxSoyad.Size = new System.Drawing.Size(214, 30);
            this.tBoxSoyad.TabIndex = 24;
            // 
            // tBoxAd
            // 
            this.tBoxAd.Location = new System.Drawing.Point(273, 125);
            this.tBoxAd.Name = "tBoxAd";
            this.tBoxAd.Size = new System.Drawing.Size(214, 30);
            this.tBoxAd.TabIndex = 23;
            // 
            // tBoxSifre
            // 
            this.tBoxSifre.Location = new System.Drawing.Point(273, 269);
            this.tBoxSifre.Name = "tBoxSifre";
            this.tBoxSifre.PasswordChar = '*';
            this.tBoxSifre.Size = new System.Drawing.Size(214, 30);
            this.tBoxSifre.TabIndex = 22;
            // 
            // maskTboxTC
            // 
            this.maskTboxTC.Location = new System.Drawing.Point(273, 197);
            this.maskTboxTC.Mask = "00000000000";
            this.maskTboxTC.Name = "maskTboxTC";
            this.maskTboxTC.Size = new System.Drawing.Size(214, 30);
            this.maskTboxTC.TabIndex = 21;
            this.maskTboxTC.ValidatingType = typeof(int);
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(209, 274);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(58, 25);
            this.lblSifre.TabIndex = 20;
            this.lblSifre.Text = "Şifre:";
            // 
            // lblTCKimlik
            // 
            this.lblTCKimlik.AutoSize = true;
            this.lblTCKimlik.Location = new System.Drawing.Point(134, 200);
            this.lblTCKimlik.Name = "lblTCKimlik";
            this.lblTCKimlik.Size = new System.Drawing.Size(133, 25);
            this.lblTCKimlik.TabIndex = 19;
            this.lblTCKimlik.Text = "TC Kimlik No:";
            // 
            // FrmHastaBilgiGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.lblHastaBilgiGuncelleme);
            this.Controls.Add(this.btnBilgileriGuncelle);
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
            this.Name = "FrmHastaBilgiGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Bilgi Güncelleme Paneli";
            this.Load += new System.EventHandler(this.FrmHastaBilgiGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblHastaBilgiGuncelleme;
        private System.Windows.Forms.Button btnBilgileriGuncelle;
        private System.Windows.Forms.ComboBox cBoxCinsiyet;
        private System.Windows.Forms.MaskedTextBox maskTBoxTelefon;
        private System.Windows.Forms.TextBox tBoxSoyad;
        private System.Windows.Forms.TextBox tBoxAd;
        private System.Windows.Forms.TextBox tBoxSifre;
        private System.Windows.Forms.MaskedTextBox maskTboxTC;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblTCKimlik;
    }
}