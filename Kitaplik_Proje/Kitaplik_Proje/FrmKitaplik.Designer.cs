namespace Kitaplik_Proje
{
    partial class FrmKitaplik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKitaplik));
            this.lblKitapId = new System.Windows.Forms.Label();
            this.lblKitapAd = new System.Windows.Forms.Label();
            this.lblYazar = new System.Windows.Forms.Label();
            this.lblSayfa = new System.Windows.Forms.Label();
            this.lblTur = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.rBtnSifir = new System.Windows.Forms.RadioButton();
            this.rBtnKullanilmis = new System.Windows.Forms.RadioButton();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.tBoxKitapId = new System.Windows.Forms.TextBox();
            this.tBoxKitapAd = new System.Windows.Forms.TextBox();
            this.tBoxYazar = new System.Windows.Forms.TextBox();
            this.tBoxSayfa = new System.Windows.Forms.TextBox();
            this.cBoxTur = new System.Windows.Forms.ComboBox();
            this.dGridKitaplik = new System.Windows.Forms.DataGridView();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tBoxKitapArama = new System.Windows.Forms.TextBox();
            this.lblKitapArama = new System.Windows.Forms.Label();
            this.btnKitapBul = new System.Windows.Forms.Button();
            this.btnHarflereGoreBul = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGridKitaplik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKitapId
            // 
            this.lblKitapId.AutoSize = true;
            this.lblKitapId.Location = new System.Drawing.Point(367, 83);
            this.lblKitapId.Name = "lblKitapId";
            this.lblKitapId.Size = new System.Drawing.Size(84, 25);
            this.lblKitapId.TabIndex = 0;
            this.lblKitapId.Text = "Kitap Id:";
            // 
            // lblKitapAd
            // 
            this.lblKitapAd.AutoSize = true;
            this.lblKitapAd.Location = new System.Drawing.Point(358, 122);
            this.lblKitapAd.Name = "lblKitapAd";
            this.lblKitapAd.Size = new System.Drawing.Size(93, 25);
            this.lblKitapAd.TabIndex = 1;
            this.lblKitapAd.Text = "Kitap Ad:";
            // 
            // lblYazar
            // 
            this.lblYazar.AutoSize = true;
            this.lblYazar.Location = new System.Drawing.Point(382, 158);
            this.lblYazar.Name = "lblYazar";
            this.lblYazar.Size = new System.Drawing.Size(69, 25);
            this.lblYazar.TabIndex = 2;
            this.lblYazar.Text = "Yazar:";
            // 
            // lblSayfa
            // 
            this.lblSayfa.AutoSize = true;
            this.lblSayfa.Location = new System.Drawing.Point(382, 191);
            this.lblSayfa.Name = "lblSayfa";
            this.lblSayfa.Size = new System.Drawing.Size(69, 25);
            this.lblSayfa.TabIndex = 3;
            this.lblSayfa.Text = "Sayfa:";
            // 
            // lblTur
            // 
            this.lblTur.AutoSize = true;
            this.lblTur.Location = new System.Drawing.Point(403, 227);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(48, 25);
            this.lblTur.TabIndex = 4;
            this.lblTur.Text = "Tür:";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(375, 268);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(76, 25);
            this.lblDurum.TabIndex = 5;
            this.lblDurum.Text = "Durum:";
            // 
            // rBtnSifir
            // 
            this.rBtnSifir.AutoSize = true;
            this.rBtnSifir.Location = new System.Drawing.Point(468, 266);
            this.rBtnSifir.Name = "rBtnSifir";
            this.rBtnSifir.Size = new System.Drawing.Size(66, 29);
            this.rBtnSifir.TabIndex = 6;
            this.rBtnSifir.TabStop = true;
            this.rBtnSifir.Text = "Sıfır";
            this.rBtnSifir.UseVisualStyleBackColor = true;
            this.rBtnSifir.CheckedChanged += new System.EventHandler(this.rBtnSifir_CheckedChanged);
            // 
            // rBtnKullanilmis
            // 
            this.rBtnKullanilmis.AutoSize = true;
            this.rBtnKullanilmis.Location = new System.Drawing.Point(571, 266);
            this.rBtnKullanilmis.Name = "rBtnKullanilmis";
            this.rBtnKullanilmis.Size = new System.Drawing.Size(126, 29);
            this.rBtnKullanilmis.TabIndex = 7;
            this.rBtnKullanilmis.TabStop = true;
            this.rBtnKullanilmis.Text = "Kullanılmış";
            this.rBtnKullanilmis.UseVisualStyleBackColor = true;
            this.rBtnKullanilmis.CheckedChanged += new System.EventHandler(this.rBtnKullanilmis_CheckedChanged);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(717, 81);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(138, 40);
            this.btnListele.TabIndex = 8;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(717, 127);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(138, 40);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(717, 173);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(138, 40);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(717, 219);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(138, 40);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // tBoxKitapId
            // 
            this.tBoxKitapId.Enabled = false;
            this.tBoxKitapId.Location = new System.Drawing.Point(457, 83);
            this.tBoxKitapId.Name = "tBoxKitapId";
            this.tBoxKitapId.Size = new System.Drawing.Size(240, 30);
            this.tBoxKitapId.TabIndex = 1;
            // 
            // tBoxKitapAd
            // 
            this.tBoxKitapAd.Location = new System.Drawing.Point(457, 119);
            this.tBoxKitapAd.Name = "tBoxKitapAd";
            this.tBoxKitapAd.Size = new System.Drawing.Size(240, 30);
            this.tBoxKitapAd.TabIndex = 2;
            // 
            // tBoxYazar
            // 
            this.tBoxYazar.Location = new System.Drawing.Point(457, 155);
            this.tBoxYazar.Name = "tBoxYazar";
            this.tBoxYazar.Size = new System.Drawing.Size(240, 30);
            this.tBoxYazar.TabIndex = 3;
            // 
            // tBoxSayfa
            // 
            this.tBoxSayfa.Location = new System.Drawing.Point(457, 191);
            this.tBoxSayfa.Name = "tBoxSayfa";
            this.tBoxSayfa.Size = new System.Drawing.Size(240, 30);
            this.tBoxSayfa.TabIndex = 4;
            // 
            // cBoxTur
            // 
            this.cBoxTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxTur.FormattingEnabled = true;
            this.cBoxTur.Items.AddRange(new object[] {
            "Hikaye",
            "Roman",
            "Şiir",
            "Tiyatro"});
            this.cBoxTur.Location = new System.Drawing.Point(457, 227);
            this.cBoxTur.Name = "cBoxTur";
            this.cBoxTur.Size = new System.Drawing.Size(240, 33);
            this.cBoxTur.TabIndex = 5;
            // 
            // dGridKitaplik
            // 
            this.dGridKitaplik.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridKitaplik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridKitaplik.Location = new System.Drawing.Point(12, 320);
            this.dGridKitaplik.Name = "dGridKitaplik";
            this.dGridKitaplik.RowHeadersWidth = 51;
            this.dGridKitaplik.RowTemplate.Height = 24;
            this.dGridKitaplik.Size = new System.Drawing.Size(1158, 217);
            this.dGridKitaplik.TabIndex = 12;
            this.dGridKitaplik.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridKitaplik_CellClick);
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(447, 9);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(297, 55);
            this.lblBaslik.TabIndex = 18;
            this.lblBaslik.Text = "Kitaplık Projesi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // tBoxKitapArama
            // 
            this.tBoxKitapArama.Location = new System.Drawing.Point(930, 83);
            this.tBoxKitapArama.Name = "tBoxKitapArama";
            this.tBoxKitapArama.Size = new System.Drawing.Size(240, 30);
            this.tBoxKitapArama.TabIndex = 20;
            // 
            // lblKitapArama
            // 
            this.lblKitapArama.AutoSize = true;
            this.lblKitapArama.Location = new System.Drawing.Point(994, 55);
            this.lblKitapArama.Name = "lblKitapArama";
            this.lblKitapArama.Size = new System.Drawing.Size(120, 25);
            this.lblKitapArama.TabIndex = 21;
            this.lblKitapArama.Text = "Kitap Arama";
            // 
            // btnKitapBul
            // 
            this.btnKitapBul.Location = new System.Drawing.Point(976, 119);
            this.btnKitapBul.Name = "btnKitapBul";
            this.btnKitapBul.Size = new System.Drawing.Size(138, 40);
            this.btnKitapBul.TabIndex = 22;
            this.btnKitapBul.Text = "Kitap Bul";
            this.btnKitapBul.UseVisualStyleBackColor = true;
            this.btnKitapBul.Click += new System.EventHandler(this.btnKitapBul_Click);
            // 
            // btnHarflereGoreBul
            // 
            this.btnHarflereGoreBul.Location = new System.Drawing.Point(976, 165);
            this.btnHarflereGoreBul.Name = "btnHarflereGoreBul";
            this.btnHarflereGoreBul.Size = new System.Drawing.Size(138, 65);
            this.btnHarflereGoreBul.TabIndex = 23;
            this.btnHarflereGoreBul.Text = "Harflere Göre Bul";
            this.btnHarflereGoreBul.UseVisualStyleBackColor = true;
            this.btnHarflereGoreBul.Click += new System.EventHandler(this.btnHarflereGoreBul_Click);
            // 
            // FrmKitaplik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1182, 549);
            this.Controls.Add(this.btnHarflereGoreBul);
            this.Controls.Add(this.btnKitapBul);
            this.Controls.Add(this.lblKitapArama);
            this.Controls.Add(this.tBoxKitapArama);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.dGridKitaplik);
            this.Controls.Add(this.cBoxTur);
            this.Controls.Add(this.tBoxSayfa);
            this.Controls.Add(this.tBoxYazar);
            this.Controls.Add(this.tBoxKitapAd);
            this.Controls.Add(this.tBoxKitapId);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.rBtnKullanilmis);
            this.Controls.Add(this.rBtnSifir);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblTur);
            this.Controls.Add(this.lblSayfa);
            this.Controls.Add(this.lblYazar);
            this.Controls.Add(this.lblKitapAd);
            this.Controls.Add(this.lblKitapId);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmKitaplik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitaplık Projesi Ana Pencere";
            this.Load += new System.EventHandler(this.FrmKitaplik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridKitaplik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKitapId;
        private System.Windows.Forms.Label lblKitapAd;
        private System.Windows.Forms.Label lblYazar;
        private System.Windows.Forms.Label lblSayfa;
        private System.Windows.Forms.Label lblTur;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.RadioButton rBtnSifir;
        private System.Windows.Forms.RadioButton rBtnKullanilmis;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox tBoxKitapId;
        private System.Windows.Forms.TextBox tBoxKitapAd;
        private System.Windows.Forms.TextBox tBoxYazar;
        private System.Windows.Forms.TextBox tBoxSayfa;
        private System.Windows.Forms.ComboBox cBoxTur;
        private System.Windows.Forms.DataGridView dGridKitaplik;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tBoxKitapArama;
        private System.Windows.Forms.Label lblKitapArama;
        private System.Windows.Forms.Button btnKitapBul;
        private System.Windows.Forms.Button btnHarflereGoreBul;
    }
}

