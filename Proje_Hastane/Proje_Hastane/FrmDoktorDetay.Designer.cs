namespace Proje_Hastane
{
    partial class FrmDoktorDetay
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
            this.gBoxRandevuListesi = new System.Windows.Forms.GroupBox();
            this.dGridRandevuListesi = new System.Windows.Forms.DataGridView();
            this.gBoxRandevuDetaylari = new System.Windows.Forms.GroupBox();
            this.rTBoxSikayetDetaylari = new System.Windows.Forms.RichTextBox();
            this.gBoxDoktorBilgisi = new System.Windows.Forms.GroupBox();
            this.lblAdSoyadDegeri = new System.Windows.Forms.Label();
            this.lblTCDegeri = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblTCKimlik = new System.Windows.Forms.Label();
            this.gBoxHizliErisim = new System.Windows.Forms.GroupBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnInternet = new System.Windows.Forms.Button();
            this.btnDuyurular = new System.Windows.Forms.Button();
            this.btnBilgiDuzenle = new System.Windows.Forms.Button();
            this.gBoxRandevuListesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridRandevuListesi)).BeginInit();
            this.gBoxRandevuDetaylari.SuspendLayout();
            this.gBoxDoktorBilgisi.SuspendLayout();
            this.gBoxHizliErisim.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxRandevuListesi
            // 
            this.gBoxRandevuListesi.Controls.Add(this.dGridRandevuListesi);
            this.gBoxRandevuListesi.Location = new System.Drawing.Point(340, 12);
            this.gBoxRandevuListesi.Name = "gBoxRandevuListesi";
            this.gBoxRandevuListesi.Size = new System.Drawing.Size(830, 473);
            this.gBoxRandevuListesi.TabIndex = 7;
            this.gBoxRandevuListesi.TabStop = false;
            this.gBoxRandevuListesi.Text = "Randevu Listesi";
            // 
            // dGridRandevuListesi
            // 
            this.dGridRandevuListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridRandevuListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGridRandevuListesi.Location = new System.Drawing.Point(3, 26);
            this.dGridRandevuListesi.Name = "dGridRandevuListesi";
            this.dGridRandevuListesi.RowHeadersWidth = 51;
            this.dGridRandevuListesi.RowTemplate.Height = 24;
            this.dGridRandevuListesi.Size = new System.Drawing.Size(824, 444);
            this.dGridRandevuListesi.TabIndex = 0;
            this.dGridRandevuListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridRandevuListesi_CellClick);
            // 
            // gBoxRandevuDetaylari
            // 
            this.gBoxRandevuDetaylari.Controls.Add(this.rTBoxSikayetDetaylari);
            this.gBoxRandevuDetaylari.Location = new System.Drawing.Point(12, 160);
            this.gBoxRandevuDetaylari.Name = "gBoxRandevuDetaylari";
            this.gBoxRandevuDetaylari.Size = new System.Drawing.Size(322, 204);
            this.gBoxRandevuDetaylari.TabIndex = 5;
            this.gBoxRandevuDetaylari.TabStop = false;
            this.gBoxRandevuDetaylari.Text = "Randevu Şikayet Detayı";
            // 
            // rTBoxSikayetDetaylari
            // 
            this.rTBoxSikayetDetaylari.Location = new System.Drawing.Point(7, 30);
            this.rTBoxSikayetDetaylari.Name = "rTBoxSikayetDetaylari";
            this.rTBoxSikayetDetaylari.Size = new System.Drawing.Size(309, 168);
            this.rTBoxSikayetDetaylari.TabIndex = 0;
            this.rTBoxSikayetDetaylari.Text = "";
            // 
            // gBoxDoktorBilgisi
            // 
            this.gBoxDoktorBilgisi.Controls.Add(this.lblAdSoyadDegeri);
            this.gBoxDoktorBilgisi.Controls.Add(this.lblTCDegeri);
            this.gBoxDoktorBilgisi.Controls.Add(this.lblAdSoyad);
            this.gBoxDoktorBilgisi.Controls.Add(this.lblTCKimlik);
            this.gBoxDoktorBilgisi.Location = new System.Drawing.Point(12, 12);
            this.gBoxDoktorBilgisi.Name = "gBoxDoktorBilgisi";
            this.gBoxDoktorBilgisi.Size = new System.Drawing.Size(322, 142);
            this.gBoxDoktorBilgisi.TabIndex = 4;
            this.gBoxDoktorBilgisi.TabStop = false;
            this.gBoxDoktorBilgisi.Text = "Doktor Bilgisi";
            // 
            // lblAdSoyadDegeri
            // 
            this.lblAdSoyadDegeri.AutoSize = true;
            this.lblAdSoyadDegeri.Location = new System.Drawing.Point(146, 80);
            this.lblAdSoyadDegeri.Name = "lblAdSoyadDegeri";
            this.lblAdSoyadDegeri.Size = new System.Drawing.Size(83, 25);
            this.lblAdSoyadDegeri.TabIndex = 3;
            this.lblAdSoyadDegeri.Text = "Null Null";
            // 
            // lblTCDegeri
            // 
            this.lblTCDegeri.AutoSize = true;
            this.lblTCDegeri.Location = new System.Drawing.Point(146, 43);
            this.lblTCDegeri.Name = "lblTCDegeri";
            this.lblTCDegeri.Size = new System.Drawing.Size(133, 25);
            this.lblTCDegeri.TabIndex = 2;
            this.lblTCDegeri.Text = "00000000000";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(35, 80);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(105, 25);
            this.lblAdSoyad.TabIndex = 1;
            this.lblAdSoyad.Text = "Ad Soyad:";
            // 
            // lblTCKimlik
            // 
            this.lblTCKimlik.AutoSize = true;
            this.lblTCKimlik.Location = new System.Drawing.Point(7, 43);
            this.lblTCKimlik.Name = "lblTCKimlik";
            this.lblTCKimlik.Size = new System.Drawing.Size(133, 25);
            this.lblTCKimlik.TabIndex = 0;
            this.lblTCKimlik.Text = "TC Kimlik No:";
            // 
            // gBoxHizliErisim
            // 
            this.gBoxHizliErisim.Controls.Add(this.btnCikis);
            this.gBoxHizliErisim.Controls.Add(this.btnInternet);
            this.gBoxHizliErisim.Controls.Add(this.btnDuyurular);
            this.gBoxHizliErisim.Controls.Add(this.btnBilgiDuzenle);
            this.gBoxHizliErisim.Location = new System.Drawing.Point(12, 364);
            this.gBoxHizliErisim.Name = "gBoxHizliErisim";
            this.gBoxHizliErisim.Size = new System.Drawing.Size(322, 121);
            this.gBoxHizliErisim.TabIndex = 8;
            this.gBoxHizliErisim.TabStop = false;
            this.gBoxHizliErisim.Text = "Hızlı Erişim";
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(162, 69);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(150, 34);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnInternet
            // 
            this.btnInternet.Location = new System.Drawing.Point(6, 69);
            this.btnInternet.Name = "btnInternet";
            this.btnInternet.Size = new System.Drawing.Size(150, 34);
            this.btnInternet.TabIndex = 2;
            this.btnInternet.Text = "İnternet";
            this.btnInternet.UseVisualStyleBackColor = true;
            this.btnInternet.Click += new System.EventHandler(this.btnInternet_Click);
            // 
            // btnDuyurular
            // 
            this.btnDuyurular.Location = new System.Drawing.Point(162, 29);
            this.btnDuyurular.Name = "btnDuyurular";
            this.btnDuyurular.Size = new System.Drawing.Size(150, 34);
            this.btnDuyurular.TabIndex = 1;
            this.btnDuyurular.Text = "Duyurular";
            this.btnDuyurular.UseVisualStyleBackColor = true;
            this.btnDuyurular.Click += new System.EventHandler(this.btnDuyurular_Click);
            // 
            // btnBilgiDuzenle
            // 
            this.btnBilgiDuzenle.Location = new System.Drawing.Point(6, 29);
            this.btnBilgiDuzenle.Name = "btnBilgiDuzenle";
            this.btnBilgiDuzenle.Size = new System.Drawing.Size(150, 34);
            this.btnBilgiDuzenle.TabIndex = 0;
            this.btnBilgiDuzenle.Text = "Bilgi Düzenle";
            this.btnBilgiDuzenle.UseVisualStyleBackColor = true;
            this.btnBilgiDuzenle.Click += new System.EventHandler(this.btnBilgiDuzenle_Click);
            // 
            // FrmDoktorDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1182, 492);
            this.Controls.Add(this.gBoxHizliErisim);
            this.Controls.Add(this.gBoxRandevuListesi);
            this.Controls.Add(this.gBoxRandevuDetaylari);
            this.Controls.Add(this.gBoxDoktorBilgisi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDoktorDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Detay Paneli";
            this.Load += new System.EventHandler(this.FrmDoktorDetay_Load);
            this.gBoxRandevuListesi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridRandevuListesi)).EndInit();
            this.gBoxRandevuDetaylari.ResumeLayout(false);
            this.gBoxDoktorBilgisi.ResumeLayout(false);
            this.gBoxDoktorBilgisi.PerformLayout();
            this.gBoxHizliErisim.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxRandevuListesi;
        private System.Windows.Forms.DataGridView dGridRandevuListesi;
        private System.Windows.Forms.GroupBox gBoxRandevuDetaylari;
        private System.Windows.Forms.GroupBox gBoxDoktorBilgisi;
        private System.Windows.Forms.Label lblAdSoyadDegeri;
        private System.Windows.Forms.Label lblTCDegeri;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblTCKimlik;
        private System.Windows.Forms.RichTextBox rTBoxSikayetDetaylari;
        private System.Windows.Forms.GroupBox gBoxHizliErisim;
        private System.Windows.Forms.Button btnBilgiDuzenle;
        private System.Windows.Forms.Button btnDuyurular;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnInternet;
    }
}