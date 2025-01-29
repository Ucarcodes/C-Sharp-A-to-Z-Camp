namespace Proje_Hastane
{
    partial class FrmBransIslemleri
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
            this.lblHastaGirisPaneli = new System.Windows.Forms.Label();
            this.dGridBransIslemleri = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.btnBilgileriGuncelle = new System.Windows.Forms.Button();
            this.tBoxBransAdi = new System.Windows.Forms.TextBox();
            this.tBoxBransId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGridBransIslemleri)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHastaGirisPaneli
            // 
            this.lblHastaGirisPaneli.AutoSize = true;
            this.lblHastaGirisPaneli.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastaGirisPaneli.Location = new System.Drawing.Point(460, 86);
            this.lblHastaGirisPaneli.Name = "lblHastaGirisPaneli";
            this.lblHastaGirisPaneli.Size = new System.Drawing.Size(411, 55);
            this.lblHastaGirisPaneli.TabIndex = 60;
            this.lblHastaGirisPaneli.Text = "Branş İşlemleri Paneli";
            // 
            // dGridBransIslemleri
            // 
            this.dGridBransIslemleri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridBransIslemleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridBransIslemleri.Location = new System.Drawing.Point(371, 144);
            this.dGridBransIslemleri.Name = "dGridBransIslemleri";
            this.dGridBransIslemleri.RowHeadersWidth = 51;
            this.dGridBransIslemleri.RowTemplate.Height = 24;
            this.dGridBransIslemleri.Size = new System.Drawing.Size(795, 163);
            this.dGridBransIslemleri.TabIndex = 74;
            this.dGridBransIslemleri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridBransIslemleri_CellClick);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSil.Location = new System.Drawing.Point(282, 233);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(83, 34);
            this.btnSil.TabIndex = 73;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.ForestGreen;
            this.btnEkle.Location = new System.Drawing.Point(151, 233);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(83, 34);
            this.btnEkle.TabIndex = 72;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(36, 180);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(103, 25);
            this.lblSoyad.TabIndex = 69;
            this.lblSoyad.Text = "Branş Adı:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(49, 147);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(90, 25);
            this.lblAd.TabIndex = 68;
            this.lblAd.Text = "Branş Id:";
            // 
            // btnBilgileriGuncelle
            // 
            this.btnBilgileriGuncelle.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBilgileriGuncelle.Location = new System.Drawing.Point(151, 273);
            this.btnBilgileriGuncelle.Name = "btnBilgileriGuncelle";
            this.btnBilgileriGuncelle.Size = new System.Drawing.Size(214, 34);
            this.btnBilgileriGuncelle.TabIndex = 67;
            this.btnBilgileriGuncelle.Text = "Bilgileri Güncelle";
            this.btnBilgileriGuncelle.UseVisualStyleBackColor = false;
            this.btnBilgileriGuncelle.Click += new System.EventHandler(this.btnBilgileriGuncelle_Click);
            // 
            // tBoxBransAdi
            // 
            this.tBoxBransAdi.Location = new System.Drawing.Point(151, 180);
            this.tBoxBransAdi.Name = "tBoxBransAdi";
            this.tBoxBransAdi.Size = new System.Drawing.Size(214, 30);
            this.tBoxBransAdi.TabIndex = 66;
            // 
            // tBoxBransId
            // 
            this.tBoxBransId.Enabled = false;
            this.tBoxBransId.Location = new System.Drawing.Point(151, 144);
            this.tBoxBransId.Name = "tBoxBransId";
            this.tBoxBransId.Size = new System.Drawing.Size(214, 30);
            this.tBoxBransId.TabIndex = 65;
            // 
            // FrmBransIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1178, 453);
            this.Controls.Add(this.dGridBransIslemleri);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.btnBilgileriGuncelle);
            this.Controls.Add(this.tBoxBransAdi);
            this.Controls.Add(this.tBoxBransId);
            this.Controls.Add(this.lblHastaGirisPaneli);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmBransIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Branş İşlemleri Paneli";
            this.Load += new System.EventHandler(this.FrmBransIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridBransIslemleri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHastaGirisPaneli;
        private System.Windows.Forms.DataGridView dGridBransIslemleri;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Button btnBilgileriGuncelle;
        private System.Windows.Forms.TextBox tBoxBransAdi;
        private System.Windows.Forms.TextBox tBoxBransId;
    }
}