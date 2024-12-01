namespace TextFileReading
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
            this.lBoxMetin = new System.Windows.Forms.ListBox();
            this.btnMetinOku = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lBoxMetin
            // 
            this.lBoxMetin.FormattingEnabled = true;
            this.lBoxMetin.ItemHeight = 25;
            this.lBoxMetin.Location = new System.Drawing.Point(147, 40);
            this.lBoxMetin.Name = "lBoxMetin";
            this.lBoxMetin.Size = new System.Drawing.Size(318, 204);
            this.lBoxMetin.TabIndex = 0;
            // 
            // btnMetinOku
            // 
            this.btnMetinOku.Location = new System.Drawing.Point(211, 250);
            this.btnMetinOku.Name = "btnMetinOku";
            this.btnMetinOku.Size = new System.Drawing.Size(189, 35);
            this.btnMetinOku.TabIndex = 1;
            this.btnMetinOku.Text = "Metin Belgesi Oku";
            this.btnMetinOku.UseVisualStyleBackColor = true;
            this.btnMetinOku.Click += new System.EventHandler(this.btnMetinOku_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(616, 347);
            this.Controls.Add(this.btnMetinOku);
            this.Controls.Add(this.lBoxMetin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text File Reading";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lBoxMetin;
        private System.Windows.Forms.Button btnMetinOku;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

