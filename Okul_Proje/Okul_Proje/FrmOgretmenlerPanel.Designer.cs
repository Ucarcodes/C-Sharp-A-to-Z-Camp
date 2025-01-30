namespace Okul_Proje
{
    partial class FrmOgretmenlerPanel
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
            this.tBoxBrans = new System.Windows.Forms.TextBox();
            this.tBoxOgretmenId = new System.Windows.Forms.TextBox();
            this.lblBrans = new System.Windows.Forms.Label();
            this.lblOgretmenId = new System.Windows.Forms.Label();
            this.dGridOgretmenler = new System.Windows.Forms.DataGridView();
            this.lblOgretmenAdSoyad = new System.Windows.Forms.Label();
            this.tBoxOgretmenAdSoyad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGridOgretmenler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(701, 299);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(109, 37);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(586, 299);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(109, 37);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(586, 256);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(109, 37);
            this.btnListele.TabIndex = 4;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(701, 256);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(109, 37);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // tBoxBrans
            // 
            this.tBoxBrans.Location = new System.Drawing.Point(256, 303);
            this.tBoxBrans.Name = "tBoxBrans";
            this.tBoxBrans.Size = new System.Drawing.Size(324, 30);
            this.tBoxBrans.TabIndex = 2;
            // 
            // tBoxOgretmenId
            // 
            this.tBoxOgretmenId.Enabled = false;
            this.tBoxOgretmenId.Location = new System.Drawing.Point(257, 256);
            this.tBoxOgretmenId.Name = "tBoxOgretmenId";
            this.tBoxOgretmenId.Size = new System.Drawing.Size(323, 30);
            this.tBoxOgretmenId.TabIndex = 1;
            // 
            // lblBrans
            // 
            this.lblBrans.AutoSize = true;
            this.lblBrans.Location = new System.Drawing.Point(182, 308);
            this.lblBrans.Name = "lblBrans";
            this.lblBrans.Size = new System.Drawing.Size(69, 25);
            this.lblBrans.TabIndex = 20;
            this.lblBrans.Text = "Branş:";
            // 
            // lblOgretmenId
            // 
            this.lblOgretmenId.AutoSize = true;
            this.lblOgretmenId.Location = new System.Drawing.Point(125, 256);
            this.lblOgretmenId.Name = "lblOgretmenId";
            this.lblOgretmenId.Size = new System.Drawing.Size(126, 25);
            this.lblOgretmenId.TabIndex = 19;
            this.lblOgretmenId.Text = "Öğretmen Id:";
            // 
            // dGridOgretmenler
            // 
            this.dGridOgretmenler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridOgretmenler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridOgretmenler.Location = new System.Drawing.Point(12, 20);
            this.dGridOgretmenler.Name = "dGridOgretmenler";
            this.dGridOgretmenler.RowHeadersWidth = 51;
            this.dGridOgretmenler.RowTemplate.Height = 24;
            this.dGridOgretmenler.Size = new System.Drawing.Size(858, 209);
            this.dGridOgretmenler.TabIndex = 18;
            this.dGridOgretmenler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridOgretmenler_CellClick);
            // 
            // lblOgretmenAdSoyad
            // 
            this.lblOgretmenAdSoyad.AutoSize = true;
            this.lblOgretmenAdSoyad.Location = new System.Drawing.Point(54, 358);
            this.lblOgretmenAdSoyad.Name = "lblOgretmenAdSoyad";
            this.lblOgretmenAdSoyad.Size = new System.Drawing.Size(197, 25);
            this.lblOgretmenAdSoyad.TabIndex = 27;
            this.lblOgretmenAdSoyad.Text = "Öğretmen Ad Soyad:";
            // 
            // tBoxOgretmenAdSoyad
            // 
            this.tBoxOgretmenAdSoyad.Location = new System.Drawing.Point(257, 353);
            this.tBoxOgretmenAdSoyad.Name = "tBoxOgretmenAdSoyad";
            this.tBoxOgretmenAdSoyad.Size = new System.Drawing.Size(324, 30);
            this.tBoxOgretmenAdSoyad.TabIndex = 3;
            // 
            // FrmOgretmenlerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(882, 422);
            this.Controls.Add(this.tBoxOgretmenAdSoyad);
            this.Controls.Add(this.lblOgretmenAdSoyad);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.tBoxBrans);
            this.Controls.Add(this.tBoxOgretmenId);
            this.Controls.Add(this.lblBrans);
            this.Controls.Add(this.lblOgretmenId);
            this.Controls.Add(this.dGridOgretmenler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmOgretmenlerPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğretmenler Paneli";
            this.Load += new System.EventHandler(this.FrmOgretmenlerPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridOgretmenler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox tBoxBrans;
        private System.Windows.Forms.TextBox tBoxOgretmenId;
        private System.Windows.Forms.Label lblBrans;
        private System.Windows.Forms.Label lblOgretmenId;
        private System.Windows.Forms.DataGridView dGridOgretmenler;
        private System.Windows.Forms.Label lblOgretmenAdSoyad;
        private System.Windows.Forms.TextBox tBoxOgretmenAdSoyad;
    }
}