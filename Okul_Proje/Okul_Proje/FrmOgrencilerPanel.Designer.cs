namespace Okul_Proje
{
    partial class FrmOgrencilerPanel
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
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.tBoxOgrenciAd = new System.Windows.Forms.TextBox();
            this.tBoxOgrenciId = new System.Windows.Forms.TextBox();
            this.lblOgrenciAd = new System.Windows.Forms.Label();
            this.lblOgrenciId = new System.Windows.Forms.Label();
            this.dGridOgrenciler = new System.Windows.Forms.DataGridView();
            this.tBoxOgrenciSoyad = new System.Windows.Forms.TextBox();
            this.lblOgrenciSoyad = new System.Windows.Forms.Label();
            this.tBoxOgrenciKulup = new System.Windows.Forms.TextBox();
            this.lblOgrenciKulup = new System.Windows.Forms.Label();
            this.tBoxOgrenciCinsiyet = new System.Windows.Forms.TextBox();
            this.lblOgrenciCinsiyet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGridOgrenciler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(701, 296);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(109, 37);
            this.btnSil.TabIndex = 26;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(586, 296);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(109, 37);
            this.btnEkle.TabIndex = 25;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(586, 253);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(109, 37);
            this.btnListele.TabIndex = 24;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(701, 253);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(109, 37);
            this.btnGuncelle.TabIndex = 23;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // tBoxOgrenciAd
            // 
            this.tBoxOgrenciAd.Location = new System.Drawing.Point(256, 299);
            this.tBoxOgrenciAd.Name = "tBoxOgrenciAd";
            this.tBoxOgrenciAd.Size = new System.Drawing.Size(324, 30);
            this.tBoxOgrenciAd.TabIndex = 22;
            // 
            // tBoxOgrenciId
            // 
            this.tBoxOgrenciId.Enabled = false;
            this.tBoxOgrenciId.Location = new System.Drawing.Point(257, 256);
            this.tBoxOgrenciId.Name = "tBoxOgrenciId";
            this.tBoxOgrenciId.Size = new System.Drawing.Size(323, 30);
            this.tBoxOgrenciId.TabIndex = 21;
            // 
            // lblOgrenciAd
            // 
            this.lblOgrenciAd.AutoSize = true;
            this.lblOgrenciAd.Location = new System.Drawing.Point(134, 302);
            this.lblOgrenciAd.Name = "lblOgrenciAd";
            this.lblOgrenciAd.Size = new System.Drawing.Size(117, 25);
            this.lblOgrenciAd.TabIndex = 20;
            this.lblOgrenciAd.Text = "Öğrenci Ad:";
            // 
            // lblOgrenciId
            // 
            this.lblOgrenciId.AutoSize = true;
            this.lblOgrenciId.Location = new System.Drawing.Point(143, 256);
            this.lblOgrenciId.Name = "lblOgrenciId";
            this.lblOgrenciId.Size = new System.Drawing.Size(108, 25);
            this.lblOgrenciId.TabIndex = 19;
            this.lblOgrenciId.Text = "Öğrenci Id:";
            // 
            // dGridOgrenciler
            // 
            this.dGridOgrenciler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridOgrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridOgrenciler.Location = new System.Drawing.Point(12, 20);
            this.dGridOgrenciler.Name = "dGridOgrenciler";
            this.dGridOgrenciler.RowHeadersWidth = 51;
            this.dGridOgrenciler.RowTemplate.Height = 24;
            this.dGridOgrenciler.Size = new System.Drawing.Size(858, 209);
            this.dGridOgrenciler.TabIndex = 18;
            this.dGridOgrenciler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridOgrenciler_CellClick);
            // 
            // tBoxOgrenciSoyad
            // 
            this.tBoxOgrenciSoyad.Location = new System.Drawing.Point(256, 348);
            this.tBoxOgrenciSoyad.Name = "tBoxOgrenciSoyad";
            this.tBoxOgrenciSoyad.Size = new System.Drawing.Size(324, 30);
            this.tBoxOgrenciSoyad.TabIndex = 28;
            // 
            // lblOgrenciSoyad
            // 
            this.lblOgrenciSoyad.AutoSize = true;
            this.lblOgrenciSoyad.Location = new System.Drawing.Point(102, 348);
            this.lblOgrenciSoyad.Name = "lblOgrenciSoyad";
            this.lblOgrenciSoyad.Size = new System.Drawing.Size(149, 25);
            this.lblOgrenciSoyad.TabIndex = 27;
            this.lblOgrenciSoyad.Text = "Öğrenci Soyad:";
            // 
            // tBoxOgrenciKulup
            // 
            this.tBoxOgrenciKulup.Location = new System.Drawing.Point(256, 395);
            this.tBoxOgrenciKulup.Name = "tBoxOgrenciKulup";
            this.tBoxOgrenciKulup.Size = new System.Drawing.Size(324, 30);
            this.tBoxOgrenciKulup.TabIndex = 30;
            // 
            // lblOgrenciKulup
            // 
            this.lblOgrenciKulup.AutoSize = true;
            this.lblOgrenciKulup.Location = new System.Drawing.Point(108, 395);
            this.lblOgrenciKulup.Name = "lblOgrenciKulup";
            this.lblOgrenciKulup.Size = new System.Drawing.Size(143, 25);
            this.lblOgrenciKulup.TabIndex = 29;
            this.lblOgrenciKulup.Text = "Öğrenci Kulüp:";
            // 
            // tBoxOgrenciCinsiyet
            // 
            this.tBoxOgrenciCinsiyet.Location = new System.Drawing.Point(257, 439);
            this.tBoxOgrenciCinsiyet.Name = "tBoxOgrenciCinsiyet";
            this.tBoxOgrenciCinsiyet.Size = new System.Drawing.Size(324, 30);
            this.tBoxOgrenciCinsiyet.TabIndex = 32;
            // 
            // lblOgrenciCinsiyet
            // 
            this.lblOgrenciCinsiyet.AutoSize = true;
            this.lblOgrenciCinsiyet.Location = new System.Drawing.Point(89, 439);
            this.lblOgrenciCinsiyet.Name = "lblOgrenciCinsiyet";
            this.lblOgrenciCinsiyet.Size = new System.Drawing.Size(162, 25);
            this.lblOgrenciCinsiyet.TabIndex = 31;
            this.lblOgrenciCinsiyet.Text = "Öğrenci Cinsiyet:";
            // 
            // FrmOgrencilerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(882, 492);
            this.Controls.Add(this.tBoxOgrenciCinsiyet);
            this.Controls.Add(this.lblOgrenciCinsiyet);
            this.Controls.Add(this.tBoxOgrenciKulup);
            this.Controls.Add(this.lblOgrenciKulup);
            this.Controls.Add(this.tBoxOgrenciSoyad);
            this.Controls.Add(this.lblOgrenciSoyad);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.tBoxOgrenciAd);
            this.Controls.Add(this.tBoxOgrenciId);
            this.Controls.Add(this.lblOgrenciAd);
            this.Controls.Add(this.lblOgrenciId);
            this.Controls.Add(this.dGridOgrenciler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmOgrencilerPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenciler Paneli";
            this.Load += new System.EventHandler(this.FrmOgrencilerPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridOgrenciler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox tBoxOgrenciAd;
        private System.Windows.Forms.TextBox tBoxOgrenciId;
        private System.Windows.Forms.Label lblOgrenciAd;
        private System.Windows.Forms.Label lblOgrenciId;
        private System.Windows.Forms.DataGridView dGridOgrenciler;
        private System.Windows.Forms.TextBox tBoxOgrenciSoyad;
        private System.Windows.Forms.Label lblOgrenciSoyad;
        private System.Windows.Forms.TextBox tBoxOgrenciKulup;
        private System.Windows.Forms.Label lblOgrenciKulup;
        private System.Windows.Forms.TextBox tBoxOgrenciCinsiyet;
        private System.Windows.Forms.Label lblOgrenciCinsiyet;
    }
}