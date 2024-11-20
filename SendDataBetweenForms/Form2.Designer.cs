namespace SendDataBetweenForms
{
    partial class Form2
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
            this.lblGelDeg = new System.Windows.Forms.Label();
            this.cBoxGelDeg = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnForm1Don = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGelDeg
            // 
            this.lblGelDeg.AutoSize = true;
            this.lblGelDeg.Location = new System.Drawing.Point(12, 86);
            this.lblGelDeg.Name = "lblGelDeg";
            this.lblGelDeg.Size = new System.Drawing.Size(264, 25);
            this.lblGelDeg.TabIndex = 7;
            this.lblGelDeg.Text = "Form 1\'den gelen değerler";
            // 
            // cBoxGelDeg
            // 
            this.cBoxGelDeg.FormattingEnabled = true;
            this.cBoxGelDeg.Location = new System.Drawing.Point(12, 114);
            this.cBoxGelDeg.Name = "cBoxGelDeg";
            this.cBoxGelDeg.Size = new System.Drawing.Size(264, 33);
            this.cBoxGelDeg.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(53, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "FORM 2";
            // 
            // btnForm1Don
            // 
            this.btnForm1Don.Location = new System.Drawing.Point(61, 199);
            this.btnForm1Don.Name = "btnForm1Don";
            this.btnForm1Don.Size = new System.Drawing.Size(164, 43);
            this.btnForm1Don.TabIndex = 4;
            this.btnForm1Don.Text = "Form 1\'e Dön";
            this.btnForm1Don.UseVisualStyleBackColor = true;
            this.btnForm1Don.Click += new System.EventHandler(this.btnForm1Don_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(288, 253);
            this.Controls.Add(this.lblGelDeg);
            this.Controls.Add(this.cBoxGelDeg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnForm1Don);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGelDeg;
        public System.Windows.Forms.ComboBox cBoxGelDeg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnForm1Don;
    }
}