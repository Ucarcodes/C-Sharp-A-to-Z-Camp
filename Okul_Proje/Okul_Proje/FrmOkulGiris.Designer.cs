namespace Okul_Proje
{
    partial class FrmOkulGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOkulGiris));
            this.pBoxOgrenci = new System.Windows.Forms.PictureBox();
            this.pBoxOgretmen = new System.Windows.Forms.PictureBox();
            this.lblOgrenci = new System.Windows.Forms.Label();
            this.lblOgretmen = new System.Windows.Forms.Label();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.tBoxOgrenciNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxOgrenci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxOgretmen)).BeginInit();
            this.SuspendLayout();
            // 
            // pBoxOgrenci
            // 
            this.pBoxOgrenci.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBoxOgrenci.Image = ((System.Drawing.Image)(resources.GetObject("pBoxOgrenci.Image")));
            this.pBoxOgrenci.Location = new System.Drawing.Point(236, 99);
            this.pBoxOgrenci.Name = "pBoxOgrenci";
            this.pBoxOgrenci.Size = new System.Drawing.Size(200, 200);
            this.pBoxOgrenci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxOgrenci.TabIndex = 0;
            this.pBoxOgrenci.TabStop = false;
            this.pBoxOgrenci.Click += new System.EventHandler(this.pBoxOgrenci_Click);
            // 
            // pBoxOgretmen
            // 
            this.pBoxOgretmen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBoxOgretmen.Image = ((System.Drawing.Image)(resources.GetObject("pBoxOgretmen.Image")));
            this.pBoxOgretmen.Location = new System.Drawing.Point(486, 99);
            this.pBoxOgretmen.Name = "pBoxOgretmen";
            this.pBoxOgretmen.Size = new System.Drawing.Size(200, 200);
            this.pBoxOgretmen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxOgretmen.TabIndex = 1;
            this.pBoxOgretmen.TabStop = false;
            this.pBoxOgretmen.Click += new System.EventHandler(this.pBoxOgretmen_Click);
            // 
            // lblOgrenci
            // 
            this.lblOgrenci.AutoSize = true;
            this.lblOgrenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrenci.Location = new System.Drawing.Point(292, 302);
            this.lblOgrenci.Name = "lblOgrenci";
            this.lblOgrenci.Size = new System.Drawing.Size(88, 25);
            this.lblOgrenci.TabIndex = 2;
            this.lblOgrenci.Text = "Öğrenci";
            // 
            // lblOgretmen
            // 
            this.lblOgretmen.AutoSize = true;
            this.lblOgretmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgretmen.Location = new System.Drawing.Point(537, 302);
            this.lblOgretmen.Name = "lblOgretmen";
            this.lblOgretmen.Size = new System.Drawing.Size(107, 25);
            this.lblOgretmen.TabIndex = 3;
            this.lblOgretmen.Text = "Öğretmen";
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(287, 25);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(345, 55);
            this.lblBaslik.TabIndex = 5;
            this.lblBaslik.Text = "Okul Giriş Sayfası";
            // 
            // tBoxOgrenciNo
            // 
            this.tBoxOgrenciNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tBoxOgrenciNo.Location = new System.Drawing.Point(236, 330);
            this.tBoxOgrenciNo.Name = "tBoxOgrenciNo";
            this.tBoxOgrenciNo.Size = new System.Drawing.Size(200, 30);
            this.tBoxOgrenciNo.TabIndex = 6;
            this.tBoxOgrenciNo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tBoxOgrenciNo_MouseClick);
            // 
            // FrmOkulGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.tBoxOgrenciNo);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.lblOgretmen);
            this.Controls.Add(this.lblOgrenci);
            this.Controls.Add(this.pBoxOgretmen);
            this.Controls.Add(this.pBoxOgrenci);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "FrmOkulGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Okul Giriş Paneli";
            this.Load += new System.EventHandler(this.FrmOkulGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxOgrenci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxOgretmen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxOgrenci;
        private System.Windows.Forms.PictureBox pBoxOgretmen;
        private System.Windows.Forms.Label lblOgrenci;
        private System.Windows.Forms.Label lblOgretmen;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.TextBox tBoxOgrenciNo;
    }
}

