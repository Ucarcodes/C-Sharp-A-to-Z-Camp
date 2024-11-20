namespace SendDataBetweenForms
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
            this.tBoxGonDeg3 = new System.Windows.Forms.TextBox();
            this.tBoxGonDeg2 = new System.Windows.Forms.TextBox();
            this.tBoxGonDeg1 = new System.Windows.Forms.TextBox();
            this.lblGonDeg3 = new System.Windows.Forms.Label();
            this.lblGonDeg2 = new System.Windows.Forms.Label();
            this.lblGonDeg1 = new System.Windows.Forms.Label();
            this.btnForm2Ac = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tBoxGonDeg3
            // 
            this.tBoxGonDeg3.Location = new System.Drawing.Point(16, 235);
            this.tBoxGonDeg3.Name = "tBoxGonDeg3";
            this.tBoxGonDeg3.Size = new System.Drawing.Size(217, 30);
            this.tBoxGonDeg3.TabIndex = 15;
            // 
            // tBoxGonDeg2
            // 
            this.tBoxGonDeg2.Location = new System.Drawing.Point(16, 163);
            this.tBoxGonDeg2.Name = "tBoxGonDeg2";
            this.tBoxGonDeg2.Size = new System.Drawing.Size(217, 30);
            this.tBoxGonDeg2.TabIndex = 14;
            // 
            // tBoxGonDeg1
            // 
            this.tBoxGonDeg1.Location = new System.Drawing.Point(16, 102);
            this.tBoxGonDeg1.Name = "tBoxGonDeg1";
            this.tBoxGonDeg1.Size = new System.Drawing.Size(217, 30);
            this.tBoxGonDeg1.TabIndex = 13;
            // 
            // lblGonDeg3
            // 
            this.lblGonDeg3.AutoSize = true;
            this.lblGonDeg3.Location = new System.Drawing.Point(11, 207);
            this.lblGonDeg3.Name = "lblGonDeg3";
            this.lblGonDeg3.Size = new System.Drawing.Size(221, 25);
            this.lblGonDeg3.TabIndex = 12;
            this.lblGonDeg3.Text = "Gönderilecek Değer 3";
            // 
            // lblGonDeg2
            // 
            this.lblGonDeg2.AutoSize = true;
            this.lblGonDeg2.Location = new System.Drawing.Point(11, 135);
            this.lblGonDeg2.Name = "lblGonDeg2";
            this.lblGonDeg2.Size = new System.Drawing.Size(221, 25);
            this.lblGonDeg2.TabIndex = 11;
            this.lblGonDeg2.Text = "Gönderilecek Değer 2";
            // 
            // lblGonDeg1
            // 
            this.lblGonDeg1.AutoSize = true;
            this.lblGonDeg1.Location = new System.Drawing.Point(11, 73);
            this.lblGonDeg1.Name = "lblGonDeg1";
            this.lblGonDeg1.Size = new System.Drawing.Size(221, 25);
            this.lblGonDeg1.TabIndex = 10;
            this.lblGonDeg1.Text = "Gönderilecek Değer 1";
            // 
            // btnForm2Ac
            // 
            this.btnForm2Ac.BackColor = System.Drawing.Color.White;
            this.btnForm2Ac.Location = new System.Drawing.Point(51, 294);
            this.btnForm2Ac.Name = "btnForm2Ac";
            this.btnForm2Ac.Size = new System.Drawing.Size(161, 48);
            this.btnForm2Ac.TabIndex = 9;
            this.btnForm2Ac.Text = "Form 2\'yi Aç";
            this.btnForm2Ac.UseVisualStyleBackColor = false;
            this.btnForm2Ac.Click += new System.EventHandler(this.btnForm2Ac_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 46);
            this.label1.TabIndex = 8;
            this.label1.Text = "FORM 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(244, 353);
            this.Controls.Add(this.tBoxGonDeg3);
            this.Controls.Add(this.tBoxGonDeg2);
            this.Controls.Add(this.tBoxGonDeg1);
            this.Controls.Add(this.lblGonDeg3);
            this.Controls.Add(this.lblGonDeg2);
            this.Controls.Add(this.lblGonDeg1);
            this.Controls.Add(this.btnForm2Ac);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxGonDeg3;
        private System.Windows.Forms.TextBox tBoxGonDeg2;
        private System.Windows.Forms.TextBox tBoxGonDeg1;
        private System.Windows.Forms.Label lblGonDeg3;
        private System.Windows.Forms.Label lblGonDeg2;
        private System.Windows.Forms.Label lblGonDeg1;
        private System.Windows.Forms.Button btnForm2Ac;
        private System.Windows.Forms.Label label1;
    }
}

