namespace LoginCodeGenerator
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
            this.btnKontrolEt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tBoxKod = new System.Windows.Forms.TextBox();
            this.tBoxOlusanKod = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKontrolEt
            // 
            this.btnKontrolEt.BackColor = System.Drawing.Color.White;
            this.btnKontrolEt.Location = new System.Drawing.Point(234, 236);
            this.btnKontrolEt.Name = "btnKontrolEt";
            this.btnKontrolEt.Size = new System.Drawing.Size(138, 36);
            this.btnKontrolEt.TabIndex = 16;
            this.btnKontrolEt.Text = "Kontrol Et";
            this.btnKontrolEt.UseVisualStyleBackColor = false;
            this.btnKontrolEt.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(145, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Oluşturulan Kod";
            // 
            // tBoxKod
            // 
            this.tBoxKod.Location = new System.Drawing.Point(150, 185);
            this.tBoxKod.Name = "tBoxKod";
            this.tBoxKod.Size = new System.Drawing.Size(222, 30);
            this.tBoxKod.TabIndex = 14;
            // 
            // tBoxOlusanKod
            // 
            this.tBoxOlusanKod.Enabled = false;
            this.tBoxOlusanKod.Location = new System.Drawing.Point(150, 112);
            this.tBoxOlusanKod.Name = "tBoxOlusanKod";
            this.tBoxOlusanKod.Size = new System.Drawing.Size(222, 30);
            this.tBoxOlusanKod.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(530, 353);
            this.Controls.Add(this.btnKontrolEt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBoxKod);
            this.Controls.Add(this.tBoxOlusanKod);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Code Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKontrolEt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBoxKod;
        private System.Windows.Forms.TextBox tBoxOlusanKod;
    }
}

