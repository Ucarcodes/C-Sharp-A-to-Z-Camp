namespace NumericalOperations
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
            this.gBoxIslemYapalim = new System.Windows.Forms.GroupBox();
            this.gBoxSonuclar = new System.Windows.Forms.GroupBox();
            this.cBoxIslem = new System.Windows.Forms.ComboBox();
            this.lblSayi3 = new System.Windows.Forms.Label();
            this.lblSayi2 = new System.Windows.Forms.Label();
            this.tBoxSayi2 = new System.Windows.Forms.TextBox();
            this.lblSayi1 = new System.Windows.Forms.Label();
            this.tBoxSayi1 = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblYapilanIslem = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.tBoxYapilanIslem = new System.Windows.Forms.TextBox();
            this.tBoxSonuc = new System.Windows.Forms.TextBox();
            this.gBoxIslemYapalim.SuspendLayout();
            this.gBoxSonuclar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxIslemYapalim
            // 
            this.gBoxIslemYapalim.BackColor = System.Drawing.Color.DarkGray;
            this.gBoxIslemYapalim.Controls.Add(this.btnHesapla);
            this.gBoxIslemYapalim.Controls.Add(this.cBoxIslem);
            this.gBoxIslemYapalim.Controls.Add(this.lblSayi3);
            this.gBoxIslemYapalim.Controls.Add(this.lblSayi2);
            this.gBoxIslemYapalim.Controls.Add(this.tBoxSayi2);
            this.gBoxIslemYapalim.Controls.Add(this.lblSayi1);
            this.gBoxIslemYapalim.Controls.Add(this.tBoxSayi1);
            this.gBoxIslemYapalim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gBoxIslemYapalim.Location = new System.Drawing.Point(0, 0);
            this.gBoxIslemYapalim.Name = "gBoxIslemYapalim";
            this.gBoxIslemYapalim.Size = new System.Drawing.Size(378, 291);
            this.gBoxIslemYapalim.TabIndex = 0;
            this.gBoxIslemYapalim.TabStop = false;
            this.gBoxIslemYapalim.Text = "İşlem Yapalım";
            // 
            // gBoxSonuclar
            // 
            this.gBoxSonuclar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.gBoxSonuclar.Controls.Add(this.lblYapilanIslem);
            this.gBoxSonuclar.Controls.Add(this.lblSonuc);
            this.gBoxSonuclar.Controls.Add(this.tBoxYapilanIslem);
            this.gBoxSonuclar.Controls.Add(this.tBoxSonuc);
            this.gBoxSonuclar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gBoxSonuclar.Location = new System.Drawing.Point(384, 0);
            this.gBoxSonuclar.Name = "gBoxSonuclar";
            this.gBoxSonuclar.Size = new System.Drawing.Size(286, 291);
            this.gBoxSonuclar.TabIndex = 1;
            this.gBoxSonuclar.TabStop = false;
            this.gBoxSonuclar.Text = "Sonuçlar";
            // 
            // cBoxIslem
            // 
            this.cBoxIslem.FormattingEnabled = true;
            this.cBoxIslem.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cBoxIslem.Location = new System.Drawing.Point(12, 202);
            this.cBoxIslem.Name = "cBoxIslem";
            this.cBoxIslem.Size = new System.Drawing.Size(348, 33);
            this.cBoxIslem.TabIndex = 11;
            // 
            // lblSayi3
            // 
            this.lblSayi3.AutoSize = true;
            this.lblSayi3.Location = new System.Drawing.Point(12, 174);
            this.lblSayi3.Name = "lblSayi3";
            this.lblSayi3.Size = new System.Drawing.Size(63, 25);
            this.lblSayi3.TabIndex = 10;
            this.lblSayi3.Text = "İşlem";
            // 
            // lblSayi2
            // 
            this.lblSayi2.AutoSize = true;
            this.lblSayi2.Location = new System.Drawing.Point(12, 102);
            this.lblSayi2.Name = "lblSayi2";
            this.lblSayi2.Size = new System.Drawing.Size(73, 25);
            this.lblSayi2.TabIndex = 9;
            this.lblSayi2.Text = "Sayı 2";
            // 
            // tBoxSayi2
            // 
            this.tBoxSayi2.Location = new System.Drawing.Point(12, 129);
            this.tBoxSayi2.Name = "tBoxSayi2";
            this.tBoxSayi2.Size = new System.Drawing.Size(348, 30);
            this.tBoxSayi2.TabIndex = 8;
            // 
            // lblSayi1
            // 
            this.lblSayi1.AutoSize = true;
            this.lblSayi1.Location = new System.Drawing.Point(12, 41);
            this.lblSayi1.Name = "lblSayi1";
            this.lblSayi1.Size = new System.Drawing.Size(73, 25);
            this.lblSayi1.TabIndex = 7;
            this.lblSayi1.Text = "Sayı 1";
            // 
            // tBoxSayi1
            // 
            this.tBoxSayi1.Location = new System.Drawing.Point(12, 68);
            this.tBoxSayi1.Name = "tBoxSayi1";
            this.tBoxSayi1.Size = new System.Drawing.Size(348, 30);
            this.tBoxSayi1.TabIndex = 6;
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.White;
            this.btnHesapla.Location = new System.Drawing.Point(220, 241);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(140, 36);
            this.btnHesapla.TabIndex = 12;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblYapilanIslem
            // 
            this.lblYapilanIslem.AutoSize = true;
            this.lblYapilanIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYapilanIslem.Location = new System.Drawing.Point(6, 41);
            this.lblYapilanIslem.Name = "lblYapilanIslem";
            this.lblYapilanIslem.Size = new System.Drawing.Size(141, 25);
            this.lblYapilanIslem.TabIndex = 7;
            this.lblYapilanIslem.Text = "Yapılan İşlem";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(6, 102);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(74, 25);
            this.lblSonuc.TabIndex = 9;
            this.lblSonuc.Text = "Sonuç";
            // 
            // tBoxYapilanIslem
            // 
            this.tBoxYapilanIslem.Location = new System.Drawing.Point(6, 69);
            this.tBoxYapilanIslem.Name = "tBoxYapilanIslem";
            this.tBoxYapilanIslem.Size = new System.Drawing.Size(269, 30);
            this.tBoxYapilanIslem.TabIndex = 6;
            // 
            // tBoxSonuc
            // 
            this.tBoxSonuc.Location = new System.Drawing.Point(6, 129);
            this.tBoxSonuc.Name = "tBoxSonuc";
            this.tBoxSonuc.Size = new System.Drawing.Size(269, 30);
            this.tBoxSonuc.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(682, 303);
            this.Controls.Add(this.gBoxSonuclar);
            this.Controls.Add(this.gBoxIslemYapalim);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numerical Operations";
            this.gBoxIslemYapalim.ResumeLayout(false);
            this.gBoxIslemYapalim.PerformLayout();
            this.gBoxSonuclar.ResumeLayout(false);
            this.gBoxSonuclar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxIslemYapalim;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.ComboBox cBoxIslem;
        private System.Windows.Forms.Label lblSayi3;
        private System.Windows.Forms.Label lblSayi2;
        private System.Windows.Forms.TextBox tBoxSayi2;
        private System.Windows.Forms.Label lblSayi1;
        private System.Windows.Forms.TextBox tBoxSayi1;
        private System.Windows.Forms.GroupBox gBoxSonuclar;
        private System.Windows.Forms.Label lblYapilanIslem;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.TextBox tBoxYapilanIslem;
        private System.Windows.Forms.TextBox tBoxSonuc;
    }
}

