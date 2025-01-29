namespace Proje_Hastane
{
    partial class FrmGirisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            this.btnHasta = new System.Windows.Forms.Button();
            this.btnDoktor = new System.Windows.Forms.Button();
            this.btnSekreter = new System.Windows.Forms.Button();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDoktor = new System.Windows.Forms.Label();
            this.lblSekreter = new System.Windows.Forms.Label();
            this.pBoxHastaneGif = new System.Windows.Forms.PictureBox();
            this.lblHastaneGirisPaneli = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxHastaneGif)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHasta
            // 
            this.btnHasta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHasta.BackgroundImage")));
            this.btnHasta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHasta.Location = new System.Drawing.Point(29, 243);
            this.btnHasta.Name = "btnHasta";
            this.btnHasta.Size = new System.Drawing.Size(162, 162);
            this.btnHasta.TabIndex = 1;
            this.btnHasta.UseVisualStyleBackColor = true;
            this.btnHasta.Click += new System.EventHandler(this.btnHasta_Click);
            // 
            // btnDoktor
            // 
            this.btnDoktor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDoktor.BackgroundImage")));
            this.btnDoktor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoktor.Location = new System.Drawing.Point(265, 243);
            this.btnDoktor.Name = "btnDoktor";
            this.btnDoktor.Size = new System.Drawing.Size(162, 162);
            this.btnDoktor.TabIndex = 2;
            this.btnDoktor.UseVisualStyleBackColor = true;
            this.btnDoktor.Click += new System.EventHandler(this.btnDoktor_Click);
            // 
            // btnSekreter
            // 
            this.btnSekreter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSekreter.BackgroundImage")));
            this.btnSekreter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSekreter.Location = new System.Drawing.Point(499, 243);
            this.btnSekreter.Name = "btnSekreter";
            this.btnSekreter.Size = new System.Drawing.Size(162, 162);
            this.btnSekreter.TabIndex = 3;
            this.btnSekreter.UseVisualStyleBackColor = true;
            this.btnSekreter.Click += new System.EventHandler(this.btnSekreter_Click);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(80, 408);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(63, 25);
            this.lblHasta.TabIndex = 3;
            this.lblHasta.Text = "Hasta";
            // 
            // lblDoktor
            // 
            this.lblDoktor.AutoSize = true;
            this.lblDoktor.Location = new System.Drawing.Point(316, 408);
            this.lblDoktor.Name = "lblDoktor";
            this.lblDoktor.Size = new System.Drawing.Size(69, 25);
            this.lblDoktor.TabIndex = 4;
            this.lblDoktor.Text = "Doktor";
            // 
            // lblSekreter
            // 
            this.lblSekreter.AutoSize = true;
            this.lblSekreter.Location = new System.Drawing.Point(541, 408);
            this.lblSekreter.Name = "lblSekreter";
            this.lblSekreter.Size = new System.Drawing.Size(86, 25);
            this.lblSekreter.TabIndex = 5;
            this.lblSekreter.Text = "Sekreter";
            // 
            // pBoxHastaneGif
            // 
            this.pBoxHastaneGif.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBoxHastaneGif.BackgroundImage")));
            this.pBoxHastaneGif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoxHastaneGif.Location = new System.Drawing.Point(265, 12);
            this.pBoxHastaneGif.Name = "pBoxHastaneGif";
            this.pBoxHastaneGif.Size = new System.Drawing.Size(162, 162);
            this.pBoxHastaneGif.TabIndex = 6;
            this.pBoxHastaneGif.TabStop = false;
            // 
            // lblHastaneGirisPaneli
            // 
            this.lblHastaneGirisPaneli.AutoSize = true;
            this.lblHastaneGirisPaneli.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastaneGirisPaneli.Location = new System.Drawing.Point(151, 183);
            this.lblHastaneGirisPaneli.Name = "lblHastaneGirisPaneli";
            this.lblHastaneGirisPaneli.Size = new System.Drawing.Size(387, 55);
            this.lblHastaneGirisPaneli.TabIndex = 7;
            this.lblHastaneGirisPaneli.Text = "Hastane Giriş Paneli";
            // 
            // FrmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.lblHastaneGirisPaneli);
            this.Controls.Add(this.pBoxHastaneGif);
            this.Controls.Add(this.lblSekreter);
            this.Controls.Add(this.lblDoktor);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.btnSekreter);
            this.Controls.Add(this.btnDoktor);
            this.Controls.Add(this.btnHasta);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmGirisler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hastane Giriş Paneli";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxHastaneGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHasta;
        private System.Windows.Forms.Button btnDoktor;
        private System.Windows.Forms.Button btnSekreter;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDoktor;
        private System.Windows.Forms.Label lblSekreter;
        private System.Windows.Forms.PictureBox pBoxHastaneGif;
        private System.Windows.Forms.Label lblHastaneGirisPaneli;
    }
}

