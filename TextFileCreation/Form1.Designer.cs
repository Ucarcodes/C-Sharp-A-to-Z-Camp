﻿namespace TextFileCreation
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxDosyaYolu = new System.Windows.Forms.TextBox();
            this.tBoxDosyaAdi = new System.Windows.Forms.TextBox();
            this.btnYolSec = new System.Windows.Forms.Button();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dosya Yolu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dosya Adı:";
            // 
            // tBoxDosyaYolu
            // 
            this.tBoxDosyaYolu.Enabled = false;
            this.tBoxDosyaYolu.Location = new System.Drawing.Point(136, 60);
            this.tBoxDosyaYolu.Name = "tBoxDosyaYolu";
            this.tBoxDosyaYolu.Size = new System.Drawing.Size(247, 30);
            this.tBoxDosyaYolu.TabIndex = 2;
            // 
            // tBoxDosyaAdi
            // 
            this.tBoxDosyaAdi.Location = new System.Drawing.Point(136, 12);
            this.tBoxDosyaAdi.Name = "tBoxDosyaAdi";
            this.tBoxDosyaAdi.Size = new System.Drawing.Size(247, 30);
            this.tBoxDosyaAdi.TabIndex = 3;
            // 
            // btnYolSec
            // 
            this.btnYolSec.Location = new System.Drawing.Point(390, 10);
            this.btnYolSec.Name = "btnYolSec";
            this.btnYolSec.Size = new System.Drawing.Size(109, 32);
            this.btnYolSec.TabIndex = 4;
            this.btnYolSec.Text = "Yol Seç";
            this.btnYolSec.UseVisualStyleBackColor = true;
            this.btnYolSec.Click += new System.EventHandler(this.btnYolSec_Click);
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(390, 59);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(109, 34);
            this.btnOlustur.TabIndex = 5;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(516, 129);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.btnYolSec);
            this.Controls.Add(this.tBoxDosyaAdi);
            this.Controls.Add(this.tBoxDosyaYolu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text File Creation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxDosyaYolu;
        private System.Windows.Forms.TextBox tBoxDosyaAdi;
        private System.Windows.Forms.Button btnYolSec;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

