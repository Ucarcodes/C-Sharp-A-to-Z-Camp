namespace TextFileCreation2
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
            this.rTBoxMetin = new System.Windows.Forms.RichTextBox();
            this.btnMetinOlustur = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // rTBoxMetin
            // 
            this.rTBoxMetin.Location = new System.Drawing.Point(176, 31);
            this.rTBoxMetin.Name = "rTBoxMetin";
            this.rTBoxMetin.Size = new System.Drawing.Size(424, 226);
            this.rTBoxMetin.TabIndex = 0;
            this.rTBoxMetin.Text = "";
            // 
            // btnMetinOlustur
            // 
            this.btnMetinOlustur.Location = new System.Drawing.Point(270, 282);
            this.btnMetinOlustur.Name = "btnMetinOlustur";
            this.btnMetinOlustur.Size = new System.Drawing.Size(235, 56);
            this.btnMetinOlustur.TabIndex = 1;
            this.btnMetinOlustur.Text = "Metin Belgesini Oluştur";
            this.btnMetinOlustur.UseVisualStyleBackColor = true;
            this.btnMetinOlustur.Click += new System.EventHandler(this.btnMetinOlustur_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMetinOlustur);
            this.Controls.Add(this.rTBoxMetin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text File Creation-2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTBoxMetin;
        private System.Windows.Forms.Button btnMetinOlustur;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

