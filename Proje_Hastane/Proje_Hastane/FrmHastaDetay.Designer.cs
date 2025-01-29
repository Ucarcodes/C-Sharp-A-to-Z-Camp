namespace Proje_Hastane
{
    partial class FrmHastaDetay
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
            this.gBoxHastaBilgisi = new System.Windows.Forms.GroupBox();
            this.lblAdSoyadDegeri = new System.Windows.Forms.Label();
            this.lblTCDegeri = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblTCKimlik = new System.Windows.Forms.Label();
            this.gBoxRandevuBilgisi = new System.Windows.Forms.GroupBox();
            this.lnkLblBilgileriDuzenle = new System.Windows.Forms.LinkLabel();
            this.btnRandevuAl = new System.Windows.Forms.Button();
            this.rTBoxSikayet = new System.Windows.Forms.RichTextBox();
            this.cBoxDoktor = new System.Windows.Forms.ComboBox();
            this.lblSikayet = new System.Windows.Forms.Label();
            this.lblDoktor = new System.Windows.Forms.Label();
            this.lblBrans = new System.Windows.Forms.Label();
            this.cBoxBrans = new System.Windows.Forms.ComboBox();
            this.gBoxRandevuGecmisi = new System.Windows.Forms.GroupBox();
            this.dGridRandevuGecmisi = new System.Windows.Forms.DataGridView();
            this.gBoxAktifRandevular = new System.Windows.Forms.GroupBox();
            this.dGridAktifRandevular = new System.Windows.Forms.DataGridView();
            this.lblId = new System.Windows.Forms.Label();
            this.tBoxRandevuId = new System.Windows.Forms.TextBox();
            this.gBoxHastaBilgisi.SuspendLayout();
            this.gBoxRandevuBilgisi.SuspendLayout();
            this.gBoxRandevuGecmisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridRandevuGecmisi)).BeginInit();
            this.gBoxAktifRandevular.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridAktifRandevular)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxHastaBilgisi
            // 
            this.gBoxHastaBilgisi.Controls.Add(this.lblAdSoyadDegeri);
            this.gBoxHastaBilgisi.Controls.Add(this.lblTCDegeri);
            this.gBoxHastaBilgisi.Controls.Add(this.lblAdSoyad);
            this.gBoxHastaBilgisi.Controls.Add(this.lblTCKimlik);
            this.gBoxHastaBilgisi.Location = new System.Drawing.Point(12, 12);
            this.gBoxHastaBilgisi.Name = "gBoxHastaBilgisi";
            this.gBoxHastaBilgisi.Size = new System.Drawing.Size(322, 142);
            this.gBoxHastaBilgisi.TabIndex = 0;
            this.gBoxHastaBilgisi.TabStop = false;
            this.gBoxHastaBilgisi.Text = "Hasta Bilgisi";
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
            // gBoxRandevuBilgisi
            // 
            this.gBoxRandevuBilgisi.Controls.Add(this.tBoxRandevuId);
            this.gBoxRandevuBilgisi.Controls.Add(this.lblId);
            this.gBoxRandevuBilgisi.Controls.Add(this.lnkLblBilgileriDuzenle);
            this.gBoxRandevuBilgisi.Controls.Add(this.btnRandevuAl);
            this.gBoxRandevuBilgisi.Controls.Add(this.rTBoxSikayet);
            this.gBoxRandevuBilgisi.Controls.Add(this.cBoxDoktor);
            this.gBoxRandevuBilgisi.Controls.Add(this.lblSikayet);
            this.gBoxRandevuBilgisi.Controls.Add(this.lblDoktor);
            this.gBoxRandevuBilgisi.Controls.Add(this.lblBrans);
            this.gBoxRandevuBilgisi.Controls.Add(this.cBoxBrans);
            this.gBoxRandevuBilgisi.Location = new System.Drawing.Point(12, 160);
            this.gBoxRandevuBilgisi.Name = "gBoxRandevuBilgisi";
            this.gBoxRandevuBilgisi.Size = new System.Drawing.Size(322, 363);
            this.gBoxRandevuBilgisi.TabIndex = 1;
            this.gBoxRandevuBilgisi.TabStop = false;
            this.gBoxRandevuBilgisi.Text = "Randevu Bilgisi";
            // 
            // lnkLblBilgileriDuzenle
            // 
            this.lnkLblBilgileriDuzenle.AutoSize = true;
            this.lnkLblBilgileriDuzenle.Location = new System.Drawing.Point(6, 335);
            this.lnkLblBilgileriDuzenle.Name = "lnkLblBilgileriDuzenle";
            this.lnkLblBilgileriDuzenle.Size = new System.Drawing.Size(150, 25);
            this.lnkLblBilgileriDuzenle.TabIndex = 7;
            this.lnkLblBilgileriDuzenle.TabStop = true;
            this.lnkLblBilgileriDuzenle.Text = "Bilgileri Düzenle";
            this.lnkLblBilgileriDuzenle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnRandevuAl
            // 
            this.btnRandevuAl.Location = new System.Drawing.Point(92, 274);
            this.btnRandevuAl.Name = "btnRandevuAl";
            this.btnRandevuAl.Size = new System.Drawing.Size(207, 36);
            this.btnRandevuAl.TabIndex = 6;
            this.btnRandevuAl.Text = "Randevu Al";
            this.btnRandevuAl.UseVisualStyleBackColor = true;
            this.btnRandevuAl.Click += new System.EventHandler(this.btnRandevuAl_Click);
            // 
            // rTBoxSikayet
            // 
            this.rTBoxSikayet.Location = new System.Drawing.Point(92, 158);
            this.rTBoxSikayet.Name = "rTBoxSikayet";
            this.rTBoxSikayet.Size = new System.Drawing.Size(207, 110);
            this.rTBoxSikayet.TabIndex = 5;
            this.rTBoxSikayet.Text = "";
            // 
            // cBoxDoktor
            // 
            this.cBoxDoktor.FormattingEnabled = true;
            this.cBoxDoktor.Location = new System.Drawing.Point(92, 119);
            this.cBoxDoktor.Name = "cBoxDoktor";
            this.cBoxDoktor.Size = new System.Drawing.Size(207, 33);
            this.cBoxDoktor.TabIndex = 4;
            this.cBoxDoktor.SelectedIndexChanged += new System.EventHandler(this.cBoxDoktor_SelectedIndexChanged);
            // 
            // lblSikayet
            // 
            this.lblSikayet.AutoSize = true;
            this.lblSikayet.Location = new System.Drawing.Point(2, 158);
            this.lblSikayet.Name = "lblSikayet";
            this.lblSikayet.Size = new System.Drawing.Size(83, 25);
            this.lblSikayet.TabIndex = 3;
            this.lblSikayet.Text = "Şikayet:";
            // 
            // lblDoktor
            // 
            this.lblDoktor.AutoSize = true;
            this.lblDoktor.Location = new System.Drawing.Point(10, 119);
            this.lblDoktor.Name = "lblDoktor";
            this.lblDoktor.Size = new System.Drawing.Size(75, 25);
            this.lblDoktor.TabIndex = 2;
            this.lblDoktor.Text = "Doktor:";
            // 
            // lblBrans
            // 
            this.lblBrans.AutoSize = true;
            this.lblBrans.Location = new System.Drawing.Point(16, 72);
            this.lblBrans.Name = "lblBrans";
            this.lblBrans.Size = new System.Drawing.Size(69, 25);
            this.lblBrans.TabIndex = 1;
            this.lblBrans.Text = "Branş:";
            // 
            // cBoxBrans
            // 
            this.cBoxBrans.FormattingEnabled = true;
            this.cBoxBrans.Location = new System.Drawing.Point(92, 72);
            this.cBoxBrans.Name = "cBoxBrans";
            this.cBoxBrans.Size = new System.Drawing.Size(207, 33);
            this.cBoxBrans.TabIndex = 0;
            this.cBoxBrans.SelectedIndexChanged += new System.EventHandler(this.cBoxBrans_SelectedIndexChanged);
            // 
            // gBoxRandevuGecmisi
            // 
            this.gBoxRandevuGecmisi.Controls.Add(this.dGridRandevuGecmisi);
            this.gBoxRandevuGecmisi.Location = new System.Drawing.Point(340, 12);
            this.gBoxRandevuGecmisi.Name = "gBoxRandevuGecmisi";
            this.gBoxRandevuGecmisi.Size = new System.Drawing.Size(830, 210);
            this.gBoxRandevuGecmisi.TabIndex = 2;
            this.gBoxRandevuGecmisi.TabStop = false;
            this.gBoxRandevuGecmisi.Text = "Randevu Geçmişi";
            // 
            // dGridRandevuGecmisi
            // 
            this.dGridRandevuGecmisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridRandevuGecmisi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGridRandevuGecmisi.Location = new System.Drawing.Point(3, 26);
            this.dGridRandevuGecmisi.Name = "dGridRandevuGecmisi";
            this.dGridRandevuGecmisi.RowHeadersWidth = 51;
            this.dGridRandevuGecmisi.RowTemplate.Height = 24;
            this.dGridRandevuGecmisi.Size = new System.Drawing.Size(824, 181);
            this.dGridRandevuGecmisi.TabIndex = 0;
            // 
            // gBoxAktifRandevular
            // 
            this.gBoxAktifRandevular.Controls.Add(this.dGridAktifRandevular);
            this.gBoxAktifRandevular.Location = new System.Drawing.Point(340, 228);
            this.gBoxAktifRandevular.Name = "gBoxAktifRandevular";
            this.gBoxAktifRandevular.Size = new System.Drawing.Size(830, 295);
            this.gBoxAktifRandevular.TabIndex = 3;
            this.gBoxAktifRandevular.TabStop = false;
            this.gBoxAktifRandevular.Text = "Aktif Randevular";
            // 
            // dGridAktifRandevular
            // 
            this.dGridAktifRandevular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridAktifRandevular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGridAktifRandevular.Location = new System.Drawing.Point(3, 26);
            this.dGridAktifRandevular.Name = "dGridAktifRandevular";
            this.dGridAktifRandevular.RowHeadersWidth = 51;
            this.dGridAktifRandevular.RowTemplate.Height = 24;
            this.dGridAktifRandevular.Size = new System.Drawing.Size(824, 266);
            this.dGridAktifRandevular.TabIndex = 0;
            this.dGridAktifRandevular.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridAktifRandevular_CellClick);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(51, 32);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(34, 25);
            this.lblId.TabIndex = 8;
            this.lblId.Text = "Id:";
            // 
            // tBoxRandevuId
            // 
            this.tBoxRandevuId.Enabled = false;
            this.tBoxRandevuId.Location = new System.Drawing.Point(92, 32);
            this.tBoxRandevuId.Name = "tBoxRandevuId";
            this.tBoxRandevuId.Size = new System.Drawing.Size(207, 30);
            this.tBoxRandevuId.TabIndex = 9;
            // 
            // FrmHastaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1182, 549);
            this.Controls.Add(this.gBoxAktifRandevular);
            this.Controls.Add(this.gBoxRandevuGecmisi);
            this.Controls.Add(this.gBoxRandevuBilgisi);
            this.Controls.Add(this.gBoxHastaBilgisi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmHastaDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Detay Paneli";
            this.Load += new System.EventHandler(this.FrmHastaDetay_Load);
            this.gBoxHastaBilgisi.ResumeLayout(false);
            this.gBoxHastaBilgisi.PerformLayout();
            this.gBoxRandevuBilgisi.ResumeLayout(false);
            this.gBoxRandevuBilgisi.PerformLayout();
            this.gBoxRandevuGecmisi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridRandevuGecmisi)).EndInit();
            this.gBoxAktifRandevular.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridAktifRandevular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxHastaBilgisi;
        private System.Windows.Forms.Label lblTCKimlik;
        private System.Windows.Forms.GroupBox gBoxRandevuBilgisi;
        private System.Windows.Forms.GroupBox gBoxRandevuGecmisi;
        private System.Windows.Forms.GroupBox gBoxAktifRandevular;
        private System.Windows.Forms.Label lblAdSoyadDegeri;
        private System.Windows.Forms.Label lblTCDegeri;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.DataGridView dGridRandevuGecmisi;
        private System.Windows.Forms.DataGridView dGridAktifRandevular;
        private System.Windows.Forms.Button btnRandevuAl;
        private System.Windows.Forms.RichTextBox rTBoxSikayet;
        private System.Windows.Forms.ComboBox cBoxDoktor;
        private System.Windows.Forms.Label lblSikayet;
        private System.Windows.Forms.Label lblDoktor;
        private System.Windows.Forms.Label lblBrans;
        private System.Windows.Forms.ComboBox cBoxBrans;
        private System.Windows.Forms.LinkLabel lnkLblBilgileriDuzenle;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox tBoxRandevuId;
    }
}