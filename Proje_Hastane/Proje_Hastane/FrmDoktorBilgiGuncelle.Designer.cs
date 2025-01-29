namespace Proje_Hastane
{
    partial class FrmDoktorBilgiGuncelle
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
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblDoktorBilgiGuncelleme = new System.Windows.Forms.Label();
            this.btnBilgileriGuncelle = new System.Windows.Forms.Button();
            this.tBoxSoyad = new System.Windows.Forms.TextBox();
            this.tBoxAd = new System.Windows.Forms.TextBox();
            this.tBoxSifre = new System.Windows.Forms.TextBox();
            this.maskTboxTC = new System.Windows.Forms.MaskedTextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblTCKimlik = new System.Windows.Forms.Label();
            this.tBoxBrans = new System.Windows.Forms.TextBox();
            this.lblBrans = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(194, 187);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(75, 25);
            this.lblSoyad.TabIndex = 44;
            this.lblSoyad.Text = "Soyad:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(226, 151);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(43, 25);
            this.lblAd.TabIndex = 43;
            this.lblAd.Text = "Ad:";
            // 
            // lblDoktorBilgiGuncelleme
            // 
            this.lblDoktorBilgiGuncelleme.AutoSize = true;
            this.lblDoktorBilgiGuncelleme.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDoktorBilgiGuncelleme.Location = new System.Drawing.Point(53, 59);
            this.lblDoktorBilgiGuncelleme.Name = "lblDoktorBilgiGuncelleme";
            this.lblDoktorBilgiGuncelleme.Size = new System.Drawing.Size(591, 55);
            this.lblDoktorBilgiGuncelleme.TabIndex = 42;
            this.lblDoktorBilgiGuncelleme.Text = "Doktor Bilgi Güncelleme Ekranı";
            // 
            // btnBilgileriGuncelle
            // 
            this.btnBilgileriGuncelle.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBilgileriGuncelle.Location = new System.Drawing.Point(275, 331);
            this.btnBilgileriGuncelle.Name = "btnBilgileriGuncelle";
            this.btnBilgileriGuncelle.Size = new System.Drawing.Size(214, 34);
            this.btnBilgileriGuncelle.TabIndex = 41;
            this.btnBilgileriGuncelle.Text = "Bilgileri Güncelle";
            this.btnBilgileriGuncelle.UseVisualStyleBackColor = false;
            this.btnBilgileriGuncelle.Click += new System.EventHandler(this.btnBilgileriGuncelle_Click);
            // 
            // tBoxSoyad
            // 
            this.tBoxSoyad.Location = new System.Drawing.Point(275, 187);
            this.tBoxSoyad.Name = "tBoxSoyad";
            this.tBoxSoyad.Size = new System.Drawing.Size(214, 30);
            this.tBoxSoyad.TabIndex = 38;
            // 
            // tBoxAd
            // 
            this.tBoxAd.Location = new System.Drawing.Point(275, 151);
            this.tBoxAd.Name = "tBoxAd";
            this.tBoxAd.Size = new System.Drawing.Size(214, 30);
            this.tBoxAd.TabIndex = 37;
            // 
            // tBoxSifre
            // 
            this.tBoxSifre.Location = new System.Drawing.Point(275, 295);
            this.tBoxSifre.Name = "tBoxSifre";
            this.tBoxSifre.PasswordChar = '*';
            this.tBoxSifre.Size = new System.Drawing.Size(214, 30);
            this.tBoxSifre.TabIndex = 36;
            // 
            // maskTboxTC
            // 
            this.maskTboxTC.Location = new System.Drawing.Point(275, 223);
            this.maskTboxTC.Mask = "00000000000";
            this.maskTboxTC.Name = "maskTboxTC";
            this.maskTboxTC.Size = new System.Drawing.Size(214, 30);
            this.maskTboxTC.TabIndex = 35;
            this.maskTboxTC.ValidatingType = typeof(int);
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(211, 295);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(58, 25);
            this.lblSifre.TabIndex = 34;
            this.lblSifre.Text = "Şifre:";
            // 
            // lblTCKimlik
            // 
            this.lblTCKimlik.AutoSize = true;
            this.lblTCKimlik.Location = new System.Drawing.Point(136, 223);
            this.lblTCKimlik.Name = "lblTCKimlik";
            this.lblTCKimlik.Size = new System.Drawing.Size(133, 25);
            this.lblTCKimlik.TabIndex = 33;
            this.lblTCKimlik.Text = "TC Kimlik No:";
            // 
            // tBoxBrans
            // 
            this.tBoxBrans.Location = new System.Drawing.Point(275, 259);
            this.tBoxBrans.Name = "tBoxBrans";
            this.tBoxBrans.Size = new System.Drawing.Size(214, 30);
            this.tBoxBrans.TabIndex = 45;
            // 
            // lblBrans
            // 
            this.lblBrans.AutoSize = true;
            this.lblBrans.Location = new System.Drawing.Point(200, 259);
            this.lblBrans.Name = "lblBrans";
            this.lblBrans.Size = new System.Drawing.Size(69, 25);
            this.lblBrans.TabIndex = 46;
            this.lblBrans.Text = "Branş:";
            // 
            // FrmDoktorBilgiGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(678, 449);
            this.Controls.Add(this.lblBrans);
            this.Controls.Add(this.tBoxBrans);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.lblDoktorBilgiGuncelleme);
            this.Controls.Add(this.btnBilgileriGuncelle);
            this.Controls.Add(this.tBoxSoyad);
            this.Controls.Add(this.tBoxAd);
            this.Controls.Add(this.tBoxSifre);
            this.Controls.Add(this.maskTboxTC);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblTCKimlik);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmDoktorBilgiGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Bilgi Güncelleme Paneli";
            this.Load += new System.EventHandler(this.FrmDoktorBilgiGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblDoktorBilgiGuncelleme;
        private System.Windows.Forms.Button btnBilgileriGuncelle;
        private System.Windows.Forms.TextBox tBoxSoyad;
        private System.Windows.Forms.TextBox tBoxAd;
        private System.Windows.Forms.TextBox tBoxSifre;
        private System.Windows.Forms.MaskedTextBox maskTboxTC;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblTCKimlik;
        private System.Windows.Forms.TextBox tBoxBrans;
        private System.Windows.Forms.Label lblBrans;
    }
}