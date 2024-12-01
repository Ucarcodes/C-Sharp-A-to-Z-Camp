namespace FileOperations
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
            this.btnOFD = new System.Windows.Forms.Button();
            this.btnSFD = new System.Windows.Forms.Button();
            this.btnFBD = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnOFD
            // 
            this.btnOFD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOFD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOFD.Location = new System.Drawing.Point(284, 105);
            this.btnOFD.Name = "btnOFD";
            this.btnOFD.Size = new System.Drawing.Size(212, 58);
            this.btnOFD.TabIndex = 0;
            this.btnOFD.Text = "OpenFileDialog";
            this.btnOFD.UseVisualStyleBackColor = false;
            this.btnOFD.Click += new System.EventHandler(this.btnOFD_Click);
            // 
            // btnSFD
            // 
            this.btnSFD.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSFD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSFD.Location = new System.Drawing.Point(284, 187);
            this.btnSFD.Name = "btnSFD";
            this.btnSFD.Size = new System.Drawing.Size(212, 58);
            this.btnSFD.TabIndex = 1;
            this.btnSFD.Text = "SaveFileDialog";
            this.btnSFD.UseVisualStyleBackColor = false;
            this.btnSFD.Click += new System.EventHandler(this.btnSFD_Click);
            // 
            // btnFBD
            // 
            this.btnFBD.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnFBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFBD.Location = new System.Drawing.Point(284, 264);
            this.btnFBD.Name = "btnFBD";
            this.btnFBD.Size = new System.Drawing.Size(212, 58);
            this.btnFBD.TabIndex = 2;
            this.btnFBD.Text = "FolderBrowserDialog";
            this.btnFBD.UseVisualStyleBackColor = false;
            this.btnFBD.Click += new System.EventHandler(this.btnFBD_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFBD);
            this.Controls.Add(this.btnSFD);
            this.Controls.Add(this.btnOFD);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Operations";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOFD;
        private System.Windows.Forms.Button btnSFD;
        private System.Windows.Forms.Button btnFBD;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

