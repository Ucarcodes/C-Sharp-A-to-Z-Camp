namespace Okul_Proje
{
    partial class FrmDersler
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
            this.tBoxDersAdi = new System.Windows.Forms.TextBox();
            this.tBoxDersId = new System.Windows.Forms.TextBox();
            this.lblDersAdi = new System.Windows.Forms.Label();
            this.lblDersId = new System.Windows.Forms.Label();
            this.dGridDersler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGridDersler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(701, 296);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(109, 37);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(586, 296);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(109, 37);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(586, 253);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(109, 37);
            this.btnListele.TabIndex = 3;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(701, 253);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(109, 37);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // tBoxDersAdi
            // 
            this.tBoxDersAdi.Location = new System.Drawing.Point(256, 303);
            this.tBoxDersAdi.Name = "tBoxDersAdi";
            this.tBoxDersAdi.Size = new System.Drawing.Size(324, 30);
            this.tBoxDersAdi.TabIndex = 2;
            // 
            // tBoxDersId
            // 
            this.tBoxDersId.Enabled = false;
            this.tBoxDersId.Location = new System.Drawing.Point(257, 256);
            this.tBoxDersId.Name = "tBoxDersId";
            this.tBoxDersId.Size = new System.Drawing.Size(323, 30);
            this.tBoxDersId.TabIndex = 1;
            // 
            // lblDersAdi
            // 
            this.lblDersAdi.AutoSize = true;
            this.lblDersAdi.Location = new System.Drawing.Point(147, 308);
            this.lblDersAdi.Name = "lblDersAdi";
            this.lblDersAdi.Size = new System.Drawing.Size(93, 25);
            this.lblDersAdi.TabIndex = 11;
            this.lblDersAdi.Text = "Ders Adı:";
            // 
            // lblDersId
            // 
            this.lblDersId.AutoSize = true;
            this.lblDersId.Location = new System.Drawing.Point(160, 256);
            this.lblDersId.Name = "lblDersId";
            this.lblDersId.Size = new System.Drawing.Size(80, 25);
            this.lblDersId.TabIndex = 10;
            this.lblDersId.Text = "Ders Id:";
            // 
            // dGridDersler
            // 
            this.dGridDersler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridDersler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridDersler.Location = new System.Drawing.Point(12, 20);
            this.dGridDersler.Name = "dGridDersler";
            this.dGridDersler.RowHeadersWidth = 51;
            this.dGridDersler.RowTemplate.Height = 24;
            this.dGridDersler.Size = new System.Drawing.Size(858, 209);
            this.dGridDersler.TabIndex = 9;
            this.dGridDersler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridDersler_CellClick);
            // 
            // FrmDersler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(882, 353);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.tBoxDersAdi);
            this.Controls.Add(this.tBoxDersId);
            this.Controls.Add(this.lblDersAdi);
            this.Controls.Add(this.lblDersId);
            this.Controls.Add(this.dGridDersler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmDersler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dersler Paneli";
            this.Load += new System.EventHandler(this.FrmOgrenciler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridDersler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox tBoxDersAdi;
        private System.Windows.Forms.TextBox tBoxDersId;
        private System.Windows.Forms.Label lblDersAdi;
        private System.Windows.Forms.Label lblDersId;
        private System.Windows.Forms.DataGridView dGridDersler;
    }
}