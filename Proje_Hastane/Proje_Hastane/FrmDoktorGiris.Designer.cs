namespace Proje_Hastane
{
    partial class FrmDoktorGiris
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
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.tBoxSifre = new System.Windows.Forms.TextBox();
            this.maskTboxTC = new System.Windows.Forms.MaskedTextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblTCKimlik = new System.Windows.Forms.Label();
            this.lblHastaGirisPaneli = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(418, 266);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(102, 48);
            this.btnGirisYap.TabIndex = 3;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // tBoxSifre
            // 
            this.tBoxSifre.Location = new System.Drawing.Point(306, 230);
            this.tBoxSifre.Name = "tBoxSifre";
            this.tBoxSifre.PasswordChar = '*';
            this.tBoxSifre.Size = new System.Drawing.Size(214, 30);
            this.tBoxSifre.TabIndex = 2;
            // 
            // maskTboxTC
            // 
            this.maskTboxTC.Location = new System.Drawing.Point(306, 194);
            this.maskTboxTC.Mask = "00000000000";
            this.maskTboxTC.Name = "maskTboxTC";
            this.maskTboxTC.Size = new System.Drawing.Size(214, 30);
            this.maskTboxTC.TabIndex = 1;
            this.maskTboxTC.ValidatingType = typeof(int);
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(242, 234);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(58, 25);
            this.lblSifre.TabIndex = 9;
            this.lblSifre.Text = "Şifre:";
            // 
            // lblTCKimlik
            // 
            this.lblTCKimlik.AutoSize = true;
            this.lblTCKimlik.Location = new System.Drawing.Point(167, 194);
            this.lblTCKimlik.Name = "lblTCKimlik";
            this.lblTCKimlik.Size = new System.Drawing.Size(133, 25);
            this.lblTCKimlik.TabIndex = 8;
            this.lblTCKimlik.Text = "TC Kimlik No:";
            // 
            // lblHastaGirisPaneli
            // 
            this.lblHastaGirisPaneli.AutoSize = true;
            this.lblHastaGirisPaneli.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastaGirisPaneli.Location = new System.Drawing.Point(162, 114);
            this.lblHastaGirisPaneli.Name = "lblHastaGirisPaneli";
            this.lblHastaGirisPaneli.Size = new System.Drawing.Size(369, 55);
            this.lblHastaGirisPaneli.TabIndex = 7;
            this.lblHastaGirisPaneli.Text = "Doktor Giriş Paneli";
            // 
            // FrmDoktorGiris
            // 
            this.AcceptButton = this.btnGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.tBoxSifre);
            this.Controls.Add(this.maskTboxTC);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblTCKimlik);
            this.Controls.Add(this.lblHastaGirisPaneli);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmDoktorGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Giriş Paneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.TextBox tBoxSifre;
        private System.Windows.Forms.MaskedTextBox maskTboxTC;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblTCKimlik;
        private System.Windows.Forms.Label lblHastaGirisPaneli;
    }
}