namespace Proje_Hastane
{
    partial class FrmHastaGiris
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
            this.lblTCKimlik = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.maskTboxTC = new System.Windows.Forms.MaskedTextBox();
            this.tBoxSifre = new System.Windows.Forms.TextBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.LnkUyeOl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblHastaGirisPaneli
            // 
            this.lblHastaGirisPaneli.AutoSize = true;
            this.lblHastaGirisPaneli.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastaGirisPaneli.Location = new System.Drawing.Point(170, 96);
            this.lblHastaGirisPaneli.Name = "lblHastaGirisPaneli";
            this.lblHastaGirisPaneli.Size = new System.Drawing.Size(345, 55);
            this.lblHastaGirisPaneli.TabIndex = 0;
            this.lblHastaGirisPaneli.Text = "Hasta Giriş Paneli";
            // 
            // lblTCKimlik
            // 
            this.lblTCKimlik.AutoSize = true;
            this.lblTCKimlik.Location = new System.Drawing.Point(175, 176);
            this.lblTCKimlik.Name = "lblTCKimlik";
            this.lblTCKimlik.Size = new System.Drawing.Size(133, 25);
            this.lblTCKimlik.TabIndex = 1;
            this.lblTCKimlik.Text = "TC Kimlik No:";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(250, 216);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(58, 25);
            this.lblSifre.TabIndex = 2;
            this.lblSifre.Text = "Şifre:";
            // 
            // maskTboxTC
            // 
            this.maskTboxTC.Location = new System.Drawing.Point(314, 176);
            this.maskTboxTC.Mask = "00000000000";
            this.maskTboxTC.Name = "maskTboxTC";
            this.maskTboxTC.Size = new System.Drawing.Size(214, 30);
            this.maskTboxTC.TabIndex = 1;
            this.maskTboxTC.ValidatingType = typeof(int);
            // 
            // tBoxSifre
            // 
            this.tBoxSifre.Location = new System.Drawing.Point(314, 212);
            this.tBoxSifre.Name = "tBoxSifre";
            this.tBoxSifre.PasswordChar = '*';
            this.tBoxSifre.Size = new System.Drawing.Size(214, 30);
            this.tBoxSifre.TabIndex = 2;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(426, 273);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(102, 48);
            this.btnGirisYap.TabIndex = 4;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // LnkUyeOl
            // 
            this.LnkUyeOl.AutoSize = true;
            this.LnkUyeOl.Location = new System.Drawing.Point(456, 245);
            this.LnkUyeOl.Name = "LnkUyeOl";
            this.LnkUyeOl.Size = new System.Drawing.Size(72, 25);
            this.LnkUyeOl.TabIndex = 3;
            this.LnkUyeOl.TabStop = true;
            this.LnkUyeOl.Text = "Üye Ol";
            this.LnkUyeOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkUyeOl_LinkClicked);
            // 
            // FrmHastaGiris
            // 
            this.AcceptButton = this.btnGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.LnkUyeOl);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.tBoxSifre);
            this.Controls.Add(this.maskTboxTC);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblTCKimlik);
            this.Controls.Add(this.lblHastaGirisPaneli);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmHastaGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Giriş Paneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHastaGirisPaneli;
        private System.Windows.Forms.Label lblTCKimlik;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.MaskedTextBox maskTboxTC;
        private System.Windows.Forms.TextBox tBoxSifre;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.LinkLabel LnkUyeOl;
    }
}