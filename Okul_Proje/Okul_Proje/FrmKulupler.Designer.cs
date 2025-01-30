namespace Okul_Proje
{
    partial class FrmKulupler
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
            this.dGridKulupIslemleri = new System.Windows.Forms.DataGridView();
            this.lblKulupId = new System.Windows.Forms.Label();
            this.lblKulupAdi = new System.Windows.Forms.Label();
            this.tBoxKulupId = new System.Windows.Forms.TextBox();
            this.tBoxKulupAdi = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGridKulupIslemleri)).BeginInit();
            this.SuspendLayout();
            // 
            // dGridKulupIslemleri
            // 
            this.dGridKulupIslemleri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridKulupIslemleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridKulupIslemleri.Location = new System.Drawing.Point(12, 12);
            this.dGridKulupIslemleri.Name = "dGridKulupIslemleri";
            this.dGridKulupIslemleri.RowHeadersWidth = 51;
            this.dGridKulupIslemleri.RowTemplate.Height = 24;
            this.dGridKulupIslemleri.Size = new System.Drawing.Size(858, 209);
            this.dGridKulupIslemleri.TabIndex = 0;
            this.dGridKulupIslemleri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridKulupIslemleri_CellClick);
            // 
            // lblKulupId
            // 
            this.lblKulupId.AutoSize = true;
            this.lblKulupId.Location = new System.Drawing.Point(160, 248);
            this.lblKulupId.Name = "lblKulupId";
            this.lblKulupId.Size = new System.Drawing.Size(90, 25);
            this.lblKulupId.TabIndex = 1;
            this.lblKulupId.Text = "Kulüp Id:";
            // 
            // lblKulupAdi
            // 
            this.lblKulupAdi.AutoSize = true;
            this.lblKulupAdi.Location = new System.Drawing.Point(147, 300);
            this.lblKulupAdi.Name = "lblKulupAdi";
            this.lblKulupAdi.Size = new System.Drawing.Size(103, 25);
            this.lblKulupAdi.TabIndex = 2;
            this.lblKulupAdi.Text = "Kulüp Adı:";
            // 
            // tBoxKulupId
            // 
            this.tBoxKulupId.Enabled = false;
            this.tBoxKulupId.Location = new System.Drawing.Point(257, 248);
            this.tBoxKulupId.Name = "tBoxKulupId";
            this.tBoxKulupId.Size = new System.Drawing.Size(323, 30);
            this.tBoxKulupId.TabIndex = 1;
            // 
            // tBoxKulupAdi
            // 
            this.tBoxKulupAdi.Location = new System.Drawing.Point(256, 295);
            this.tBoxKulupAdi.Name = "tBoxKulupAdi";
            this.tBoxKulupAdi.Size = new System.Drawing.Size(324, 30);
            this.tBoxKulupAdi.TabIndex = 2;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(701, 245);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(109, 37);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(586, 245);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(109, 37);
            this.btnListele.TabIndex = 3;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(586, 288);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(109, 37);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(701, 288);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(109, 37);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // FrmKulupler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(882, 349);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.tBoxKulupAdi);
            this.Controls.Add(this.tBoxKulupId);
            this.Controls.Add(this.lblKulupAdi);
            this.Controls.Add(this.lblKulupId);
            this.Controls.Add(this.dGridKulupIslemleri);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmKulupler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kulüp İşlemleri Paneli";
            this.Load += new System.EventHandler(this.FrmKulupler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridKulupIslemleri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGridKulupIslemleri;
        private System.Windows.Forms.Label lblKulupId;
        private System.Windows.Forms.Label lblKulupAdi;
        private System.Windows.Forms.TextBox tBoxKulupId;
        private System.Windows.Forms.TextBox tBoxKulupAdi;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
    }
}