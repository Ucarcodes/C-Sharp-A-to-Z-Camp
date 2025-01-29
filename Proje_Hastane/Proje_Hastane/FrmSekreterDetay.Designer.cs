namespace Proje_Hastane
{
    partial class FrmSekreterDetay
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
            this.gBoxSekreterBilgisi = new System.Windows.Forms.GroupBox();
            this.lblAdSoyadDegeri = new System.Windows.Forms.Label();
            this.lblTCDegeri = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblTCKimlik = new System.Windows.Forms.Label();
            this.gBoxDuyuruOlustur = new System.Windows.Forms.GroupBox();
            this.btnDuyuruOlustur = new System.Windows.Forms.Button();
            this.rTBoxDuyuruOlustur = new System.Windows.Forms.RichTextBox();
            this.gBoxRandevuPaneli = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.chBoxRandevu = new System.Windows.Forms.CheckBox();
            this.maskTBoxTC = new System.Windows.Forms.MaskedTextBox();
            this.cBoxDoktor = new System.Windows.Forms.ComboBox();
            this.cBoxBrans = new System.Windows.Forms.ComboBox();
            this.maskTBoxSaat = new System.Windows.Forms.MaskedTextBox();
            this.maskTBoxTarih = new System.Windows.Forms.MaskedTextBox();
            this.tBoxId = new System.Windows.Forms.TextBox();
            this.lblTc = new System.Windows.Forms.Label();
            this.lblDoktor = new System.Windows.Forms.Label();
            this.lblBrans = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.gBoxHizliErisim = new System.Windows.Forms.GroupBox();
            this.btnDuyurular = new System.Windows.Forms.Button();
            this.btnRandevuListesi = new System.Windows.Forms.Button();
            this.btnBransPaneli = new System.Windows.Forms.Button();
            this.btnDoktorPaneli = new System.Windows.Forms.Button();
            this.gBoxBranslar = new System.Windows.Forms.GroupBox();
            this.dGridBranslar = new System.Windows.Forms.DataGridView();
            this.gBoxDoktorlar = new System.Windows.Forms.GroupBox();
            this.dGridDoktorlar = new System.Windows.Forms.DataGridView();
            this.gBoxSekreterBilgisi.SuspendLayout();
            this.gBoxDuyuruOlustur.SuspendLayout();
            this.gBoxRandevuPaneli.SuspendLayout();
            this.gBoxHizliErisim.SuspendLayout();
            this.gBoxBranslar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridBranslar)).BeginInit();
            this.gBoxDoktorlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridDoktorlar)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxSekreterBilgisi
            // 
            this.gBoxSekreterBilgisi.Controls.Add(this.lblAdSoyadDegeri);
            this.gBoxSekreterBilgisi.Controls.Add(this.lblTCDegeri);
            this.gBoxSekreterBilgisi.Controls.Add(this.lblAdSoyad);
            this.gBoxSekreterBilgisi.Controls.Add(this.lblTCKimlik);
            this.gBoxSekreterBilgisi.Location = new System.Drawing.Point(12, 12);
            this.gBoxSekreterBilgisi.Name = "gBoxSekreterBilgisi";
            this.gBoxSekreterBilgisi.Size = new System.Drawing.Size(322, 142);
            this.gBoxSekreterBilgisi.TabIndex = 5;
            this.gBoxSekreterBilgisi.TabStop = false;
            this.gBoxSekreterBilgisi.Text = "Sekreter Bilgisi";
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
            // gBoxDuyuruOlustur
            // 
            this.gBoxDuyuruOlustur.Controls.Add(this.btnDuyuruOlustur);
            this.gBoxDuyuruOlustur.Controls.Add(this.rTBoxDuyuruOlustur);
            this.gBoxDuyuruOlustur.Location = new System.Drawing.Point(12, 160);
            this.gBoxDuyuruOlustur.Name = "gBoxDuyuruOlustur";
            this.gBoxDuyuruOlustur.Size = new System.Drawing.Size(322, 270);
            this.gBoxDuyuruOlustur.TabIndex = 6;
            this.gBoxDuyuruOlustur.TabStop = false;
            this.gBoxDuyuruOlustur.Text = "Duyuru Oluştur";
            // 
            // btnDuyuruOlustur
            // 
            this.btnDuyuruOlustur.Location = new System.Drawing.Point(7, 205);
            this.btnDuyuruOlustur.Name = "btnDuyuruOlustur";
            this.btnDuyuruOlustur.Size = new System.Drawing.Size(309, 44);
            this.btnDuyuruOlustur.TabIndex = 1;
            this.btnDuyuruOlustur.Text = "Duyuru Oluştur";
            this.btnDuyuruOlustur.UseVisualStyleBackColor = true;
            this.btnDuyuruOlustur.Click += new System.EventHandler(this.btnDuyuruOlustur_Click);
            // 
            // rTBoxDuyuruOlustur
            // 
            this.rTBoxDuyuruOlustur.Location = new System.Drawing.Point(7, 30);
            this.rTBoxDuyuruOlustur.Name = "rTBoxDuyuruOlustur";
            this.rTBoxDuyuruOlustur.Size = new System.Drawing.Size(309, 168);
            this.rTBoxDuyuruOlustur.TabIndex = 0;
            this.rTBoxDuyuruOlustur.Text = "";
            // 
            // gBoxRandevuPaneli
            // 
            this.gBoxRandevuPaneli.Controls.Add(this.btnKaydet);
            this.gBoxRandevuPaneli.Controls.Add(this.chBoxRandevu);
            this.gBoxRandevuPaneli.Controls.Add(this.maskTBoxTC);
            this.gBoxRandevuPaneli.Controls.Add(this.cBoxDoktor);
            this.gBoxRandevuPaneli.Controls.Add(this.cBoxBrans);
            this.gBoxRandevuPaneli.Controls.Add(this.maskTBoxSaat);
            this.gBoxRandevuPaneli.Controls.Add(this.maskTBoxTarih);
            this.gBoxRandevuPaneli.Controls.Add(this.tBoxId);
            this.gBoxRandevuPaneli.Controls.Add(this.lblTc);
            this.gBoxRandevuPaneli.Controls.Add(this.lblDoktor);
            this.gBoxRandevuPaneli.Controls.Add(this.lblBrans);
            this.gBoxRandevuPaneli.Controls.Add(this.lblSaat);
            this.gBoxRandevuPaneli.Controls.Add(this.lblTarih);
            this.gBoxRandevuPaneli.Controls.Add(this.lblId);
            this.gBoxRandevuPaneli.Location = new System.Drawing.Point(340, 12);
            this.gBoxRandevuPaneli.Name = "gBoxRandevuPaneli";
            this.gBoxRandevuPaneli.Size = new System.Drawing.Size(345, 418);
            this.gBoxRandevuPaneli.TabIndex = 7;
            this.gBoxRandevuPaneli.TabStop = false;
            this.gBoxRandevuPaneli.Text = "Randevu Paneli";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(88, 287);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(200, 44);
            this.btnKaydet.TabIndex = 13;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // chBoxRandevu
            // 
            this.chBoxRandevu.AutoSize = true;
            this.chBoxRandevu.Location = new System.Drawing.Point(88, 252);
            this.chBoxRandevu.Name = "chBoxRandevu";
            this.chBoxRandevu.Size = new System.Drawing.Size(188, 29);
            this.chBoxRandevu.TabIndex = 12;
            this.chBoxRandevu.Text = "Randevu aktif mi?";
            this.chBoxRandevu.UseVisualStyleBackColor = true;
            // 
            // maskTBoxTC
            // 
            this.maskTBoxTC.Location = new System.Drawing.Point(89, 216);
            this.maskTBoxTC.Mask = "00000000000";
            this.maskTBoxTC.Name = "maskTBoxTC";
            this.maskTBoxTC.Size = new System.Drawing.Size(199, 30);
            this.maskTBoxTC.TabIndex = 11;
            this.maskTBoxTC.ValidatingType = typeof(int);
            // 
            // cBoxDoktor
            // 
            this.cBoxDoktor.FormattingEnabled = true;
            this.cBoxDoktor.Location = new System.Drawing.Point(88, 173);
            this.cBoxDoktor.Name = "cBoxDoktor";
            this.cBoxDoktor.Size = new System.Drawing.Size(200, 33);
            this.cBoxDoktor.TabIndex = 10;
            // 
            // cBoxBrans
            // 
            this.cBoxBrans.FormattingEnabled = true;
            this.cBoxBrans.Location = new System.Drawing.Point(89, 134);
            this.cBoxBrans.Name = "cBoxBrans";
            this.cBoxBrans.Size = new System.Drawing.Size(199, 33);
            this.cBoxBrans.TabIndex = 9;
            this.cBoxBrans.SelectedIndexChanged += new System.EventHandler(this.cBoxBrans_SelectedIndexChanged);
            // 
            // maskTBoxSaat
            // 
            this.maskTBoxSaat.Location = new System.Drawing.Point(88, 94);
            this.maskTBoxSaat.Mask = "00:00";
            this.maskTBoxSaat.Name = "maskTBoxSaat";
            this.maskTBoxSaat.Size = new System.Drawing.Size(200, 30);
            this.maskTBoxSaat.TabIndex = 8;
            this.maskTBoxSaat.ValidatingType = typeof(System.DateTime);
            // 
            // maskTBoxTarih
            // 
            this.maskTBoxTarih.Location = new System.Drawing.Point(88, 58);
            this.maskTBoxTarih.Mask = "00/00/0000";
            this.maskTBoxTarih.Name = "maskTBoxTarih";
            this.maskTBoxTarih.Size = new System.Drawing.Size(200, 30);
            this.maskTBoxTarih.TabIndex = 7;
            this.maskTBoxTarih.ValidatingType = typeof(System.DateTime);
            // 
            // tBoxId
            // 
            this.tBoxId.Location = new System.Drawing.Point(88, 23);
            this.tBoxId.Name = "tBoxId";
            this.tBoxId.Size = new System.Drawing.Size(200, 30);
            this.tBoxId.TabIndex = 6;
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(36, 219);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(46, 25);
            this.lblTc.TabIndex = 5;
            this.lblTc.Text = "TC:";
            // 
            // lblDoktor
            // 
            this.lblDoktor.AutoSize = true;
            this.lblDoktor.Location = new System.Drawing.Point(6, 176);
            this.lblDoktor.Name = "lblDoktor";
            this.lblDoktor.Size = new System.Drawing.Size(75, 25);
            this.lblDoktor.TabIndex = 4;
            this.lblDoktor.Text = "Doktor:";
            // 
            // lblBrans
            // 
            this.lblBrans.AutoSize = true;
            this.lblBrans.Location = new System.Drawing.Point(13, 137);
            this.lblBrans.Name = "lblBrans";
            this.lblBrans.Size = new System.Drawing.Size(69, 25);
            this.lblBrans.TabIndex = 3;
            this.lblBrans.Text = "Branş:";
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Location = new System.Drawing.Point(23, 99);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(59, 25);
            this.lblSaat.TabIndex = 2;
            this.lblSaat.Text = "Saat:";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(19, 63);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(63, 25);
            this.lblTarih.TabIndex = 1;
            this.lblTarih.Text = "Tarih:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(48, 28);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(34, 25);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id:";
            // 
            // gBoxHizliErisim
            // 
            this.gBoxHizliErisim.Controls.Add(this.btnDuyurular);
            this.gBoxHizliErisim.Controls.Add(this.btnRandevuListesi);
            this.gBoxHizliErisim.Controls.Add(this.btnBransPaneli);
            this.gBoxHizliErisim.Controls.Add(this.btnDoktorPaneli);
            this.gBoxHizliErisim.Location = new System.Drawing.Point(12, 436);
            this.gBoxHizliErisim.Name = "gBoxHizliErisim";
            this.gBoxHizliErisim.Size = new System.Drawing.Size(673, 74);
            this.gBoxHizliErisim.TabIndex = 8;
            this.gBoxHizliErisim.TabStop = false;
            this.gBoxHizliErisim.Text = "Hızlı Erişim";
            // 
            // btnDuyurular
            // 
            this.btnDuyurular.Location = new System.Drawing.Point(498, 29);
            this.btnDuyurular.Name = "btnDuyurular";
            this.btnDuyurular.Size = new System.Drawing.Size(158, 39);
            this.btnDuyurular.TabIndex = 17;
            this.btnDuyurular.Text = "Duyurular";
            this.btnDuyurular.UseVisualStyleBackColor = true;
            this.btnDuyurular.Click += new System.EventHandler(this.btnDuyurular_Click);
            // 
            // btnRandevuListesi
            // 
            this.btnRandevuListesi.Location = new System.Drawing.Point(334, 29);
            this.btnRandevuListesi.Name = "btnRandevuListesi";
            this.btnRandevuListesi.Size = new System.Drawing.Size(158, 39);
            this.btnRandevuListesi.TabIndex = 16;
            this.btnRandevuListesi.Text = "Randevular";
            this.btnRandevuListesi.UseVisualStyleBackColor = true;
            this.btnRandevuListesi.Click += new System.EventHandler(this.btnRandevuListesi_Click);
            // 
            // btnBransPaneli
            // 
            this.btnBransPaneli.Location = new System.Drawing.Point(170, 29);
            this.btnBransPaneli.Name = "btnBransPaneli";
            this.btnBransPaneli.Size = new System.Drawing.Size(158, 39);
            this.btnBransPaneli.TabIndex = 15;
            this.btnBransPaneli.Text = "Branş Paneli";
            this.btnBransPaneli.UseVisualStyleBackColor = true;
            this.btnBransPaneli.Click += new System.EventHandler(this.btnBransPaneli_Click);
            // 
            // btnDoktorPaneli
            // 
            this.btnDoktorPaneli.Location = new System.Drawing.Point(6, 29);
            this.btnDoktorPaneli.Name = "btnDoktorPaneli";
            this.btnDoktorPaneli.Size = new System.Drawing.Size(158, 39);
            this.btnDoktorPaneli.TabIndex = 14;
            this.btnDoktorPaneli.Text = "Doktor Paneli";
            this.btnDoktorPaneli.UseVisualStyleBackColor = true;
            this.btnDoktorPaneli.Click += new System.EventHandler(this.btnDoktorPaneli_Click);
            // 
            // gBoxBranslar
            // 
            this.gBoxBranslar.Controls.Add(this.dGridBranslar);
            this.gBoxBranslar.Location = new System.Drawing.Point(701, 12);
            this.gBoxBranslar.Name = "gBoxBranslar";
            this.gBoxBranslar.Size = new System.Drawing.Size(469, 244);
            this.gBoxBranslar.TabIndex = 9;
            this.gBoxBranslar.TabStop = false;
            this.gBoxBranslar.Text = "Branşlar";
            // 
            // dGridBranslar
            // 
            this.dGridBranslar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridBranslar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridBranslar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGridBranslar.Location = new System.Drawing.Point(3, 26);
            this.dGridBranslar.Name = "dGridBranslar";
            this.dGridBranslar.RowHeadersWidth = 51;
            this.dGridBranslar.RowTemplate.Height = 24;
            this.dGridBranslar.Size = new System.Drawing.Size(463, 215);
            this.dGridBranslar.TabIndex = 11;
            // 
            // gBoxDoktorlar
            // 
            this.gBoxDoktorlar.Controls.Add(this.dGridDoktorlar);
            this.gBoxDoktorlar.Location = new System.Drawing.Point(701, 266);
            this.gBoxDoktorlar.Name = "gBoxDoktorlar";
            this.gBoxDoktorlar.Size = new System.Drawing.Size(469, 244);
            this.gBoxDoktorlar.TabIndex = 10;
            this.gBoxDoktorlar.TabStop = false;
            this.gBoxDoktorlar.Text = "Doktorlar";
            // 
            // dGridDoktorlar
            // 
            this.dGridDoktorlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridDoktorlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridDoktorlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGridDoktorlar.Location = new System.Drawing.Point(3, 26);
            this.dGridDoktorlar.Name = "dGridDoktorlar";
            this.dGridDoktorlar.RowHeadersWidth = 51;
            this.dGridDoktorlar.RowTemplate.Height = 24;
            this.dGridDoktorlar.Size = new System.Drawing.Size(463, 215);
            this.dGridDoktorlar.TabIndex = 0;
            // 
            // FrmSekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1182, 522);
            this.Controls.Add(this.gBoxDoktorlar);
            this.Controls.Add(this.gBoxBranslar);
            this.Controls.Add(this.gBoxHizliErisim);
            this.Controls.Add(this.gBoxRandevuPaneli);
            this.Controls.Add(this.gBoxDuyuruOlustur);
            this.Controls.Add(this.gBoxSekreterBilgisi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmSekreterDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sekreter Detay Paneli";
            this.Load += new System.EventHandler(this.FrmSekreterDetay_Load);
            this.gBoxSekreterBilgisi.ResumeLayout(false);
            this.gBoxSekreterBilgisi.PerformLayout();
            this.gBoxDuyuruOlustur.ResumeLayout(false);
            this.gBoxRandevuPaneli.ResumeLayout(false);
            this.gBoxRandevuPaneli.PerformLayout();
            this.gBoxHizliErisim.ResumeLayout(false);
            this.gBoxBranslar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridBranslar)).EndInit();
            this.gBoxDoktorlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridDoktorlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxSekreterBilgisi;
        private System.Windows.Forms.Label lblAdSoyadDegeri;
        private System.Windows.Forms.Label lblTCDegeri;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblTCKimlik;
        private System.Windows.Forms.GroupBox gBoxDuyuruOlustur;
        private System.Windows.Forms.Button btnDuyuruOlustur;
        private System.Windows.Forms.RichTextBox rTBoxDuyuruOlustur;
        private System.Windows.Forms.GroupBox gBoxRandevuPaneli;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.CheckBox chBoxRandevu;
        private System.Windows.Forms.MaskedTextBox maskTBoxTC;
        private System.Windows.Forms.ComboBox cBoxDoktor;
        private System.Windows.Forms.ComboBox cBoxBrans;
        private System.Windows.Forms.MaskedTextBox maskTBoxSaat;
        private System.Windows.Forms.MaskedTextBox maskTBoxTarih;
        private System.Windows.Forms.TextBox tBoxId;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label lblDoktor;
        private System.Windows.Forms.Label lblBrans;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.GroupBox gBoxHizliErisim;
        private System.Windows.Forms.Button btnRandevuListesi;
        private System.Windows.Forms.Button btnBransPaneli;
        private System.Windows.Forms.Button btnDoktorPaneli;
        private System.Windows.Forms.GroupBox gBoxBranslar;
        private System.Windows.Forms.DataGridView dGridBranslar;
        private System.Windows.Forms.GroupBox gBoxDoktorlar;
        private System.Windows.Forms.DataGridView dGridDoktorlar;
        private System.Windows.Forms.Button btnDuyurular;
    }
}