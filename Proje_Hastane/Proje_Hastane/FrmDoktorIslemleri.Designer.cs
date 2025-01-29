namespace Proje_Hastane
{
    partial class FrmDoktorIslemleri
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
            this.btnBilgileriGuncelle = new System.Windows.Forms.Button();
            this.tBoxSoyad = new System.Windows.Forms.TextBox();
            this.tBoxAd = new System.Windows.Forms.TextBox();
            this.tBoxSifre = new System.Windows.Forms.TextBox();
            this.maskTboxTC = new System.Windows.Forms.MaskedTextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblTCKimlik = new System.Windows.Forms.Label();
            this.lblBrans = new System.Windows.Forms.Label();
            this.cBoxBrans = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dGridDoktorIslemleri = new System.Windows.Forms.DataGridView();
            this.lblHastaGirisPaneli = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGridDoktorIslemleri)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(66, 121);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(75, 25);
            this.lblSoyad.TabIndex = 53;
            this.lblSoyad.Text = "Soyad:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(98, 85);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(43, 25);
            this.lblAd.TabIndex = 52;
            this.lblAd.Text = "Ad:";
            // 
            // btnBilgileriGuncelle
            // 
            this.btnBilgileriGuncelle.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBilgileriGuncelle.Location = new System.Drawing.Point(147, 320);
            this.btnBilgileriGuncelle.Name = "btnBilgileriGuncelle";
            this.btnBilgileriGuncelle.Size = new System.Drawing.Size(214, 34);
            this.btnBilgileriGuncelle.TabIndex = 8;
            this.btnBilgileriGuncelle.Text = "Bilgileri Güncelle";
            this.btnBilgileriGuncelle.UseVisualStyleBackColor = false;
            this.btnBilgileriGuncelle.Click += new System.EventHandler(this.btnBilgileriGuncelle_Click);
            // 
            // tBoxSoyad
            // 
            this.tBoxSoyad.Location = new System.Drawing.Point(147, 121);
            this.tBoxSoyad.Name = "tBoxSoyad";
            this.tBoxSoyad.Size = new System.Drawing.Size(214, 30);
            this.tBoxSoyad.TabIndex = 2;
            // 
            // tBoxAd
            // 
            this.tBoxAd.Location = new System.Drawing.Point(147, 85);
            this.tBoxAd.Name = "tBoxAd";
            this.tBoxAd.Size = new System.Drawing.Size(214, 30);
            this.tBoxAd.TabIndex = 1;
            // 
            // tBoxSifre
            // 
            this.tBoxSifre.Location = new System.Drawing.Point(147, 235);
            this.tBoxSifre.Name = "tBoxSifre";
            this.tBoxSifre.Size = new System.Drawing.Size(214, 30);
            this.tBoxSifre.TabIndex = 5;
            // 
            // maskTboxTC
            // 
            this.maskTboxTC.Location = new System.Drawing.Point(147, 199);
            this.maskTboxTC.Mask = "00000000000";
            this.maskTboxTC.Name = "maskTboxTC";
            this.maskTboxTC.Size = new System.Drawing.Size(214, 30);
            this.maskTboxTC.TabIndex = 4;
            this.maskTboxTC.ValidatingType = typeof(int);
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(83, 240);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(58, 25);
            this.lblSifre.TabIndex = 46;
            this.lblSifre.Text = "Şifre:";
            // 
            // lblTCKimlik
            // 
            this.lblTCKimlik.AutoSize = true;
            this.lblTCKimlik.Location = new System.Drawing.Point(8, 202);
            this.lblTCKimlik.Name = "lblTCKimlik";
            this.lblTCKimlik.Size = new System.Drawing.Size(133, 25);
            this.lblTCKimlik.TabIndex = 45;
            this.lblTCKimlik.Text = "TC Kimlik No:";
            // 
            // lblBrans
            // 
            this.lblBrans.AutoSize = true;
            this.lblBrans.Location = new System.Drawing.Point(66, 163);
            this.lblBrans.Name = "lblBrans";
            this.lblBrans.Size = new System.Drawing.Size(69, 25);
            this.lblBrans.TabIndex = 54;
            this.lblBrans.Text = "Branş:";
            // 
            // cBoxBrans
            // 
            this.cBoxBrans.FormattingEnabled = true;
            this.cBoxBrans.Location = new System.Drawing.Point(147, 160);
            this.cBoxBrans.Name = "cBoxBrans";
            this.cBoxBrans.Size = new System.Drawing.Size(214, 33);
            this.cBoxBrans.TabIndex = 3;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.ForestGreen;
            this.btnEkle.Location = new System.Drawing.Point(147, 280);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(83, 34);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSil.Location = new System.Drawing.Point(278, 280);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(83, 34);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dGridDoktorIslemleri
            // 
            this.dGridDoktorIslemleri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridDoktorIslemleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridDoktorIslemleri.Location = new System.Drawing.Point(367, 85);
            this.dGridDoktorIslemleri.Name = "dGridDoktorIslemleri";
            this.dGridDoktorIslemleri.RowHeadersWidth = 51;
            this.dGridDoktorIslemleri.RowTemplate.Height = 24;
            this.dGridDoktorIslemleri.Size = new System.Drawing.Size(799, 269);
            this.dGridDoktorIslemleri.TabIndex = 9;
            this.dGridDoktorIslemleri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridDoktorIslemleri_CellClick);
            // 
            // lblHastaGirisPaneli
            // 
            this.lblHastaGirisPaneli.AutoSize = true;
            this.lblHastaGirisPaneli.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastaGirisPaneli.Location = new System.Drawing.Point(422, 27);
            this.lblHastaGirisPaneli.Name = "lblHastaGirisPaneli";
            this.lblHastaGirisPaneli.Size = new System.Drawing.Size(430, 55);
            this.lblHastaGirisPaneli.TabIndex = 59;
            this.lblHastaGirisPaneli.Text = "Doktor İşlemleri Paneli";
            // 
            // FrmDoktorIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1178, 449);
            this.Controls.Add(this.lblHastaGirisPaneli);
            this.Controls.Add(this.dGridDoktorIslemleri);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cBoxBrans);
            this.Controls.Add(this.lblBrans);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.btnBilgileriGuncelle);
            this.Controls.Add(this.tBoxSoyad);
            this.Controls.Add(this.tBoxAd);
            this.Controls.Add(this.tBoxSifre);
            this.Controls.Add(this.maskTboxTC);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblTCKimlik);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmDoktorIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor İşlemleri Paneli";
            this.Load += new System.EventHandler(this.FrmDoktorIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridDoktorIslemleri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Button btnBilgileriGuncelle;
        private System.Windows.Forms.TextBox tBoxSoyad;
        private System.Windows.Forms.TextBox tBoxAd;
        private System.Windows.Forms.TextBox tBoxSifre;
        private System.Windows.Forms.MaskedTextBox maskTboxTC;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblTCKimlik;
        private System.Windows.Forms.Label lblBrans;
        private System.Windows.Forms.ComboBox cBoxBrans;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dGridDoktorIslemleri;
        private System.Windows.Forms.Label lblHastaGirisPaneli;
    }
}