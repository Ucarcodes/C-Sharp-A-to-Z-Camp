namespace EmployeeProject
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
            this.components = new System.ComponentModel.Container();
            this.gBoxKayitlar = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gBoxIslemler = new System.Windows.Forms.GroupBox();
            this.btnGrafikler = new System.Windows.Forms.Button();
            this.btnIstatistikler = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.gBoxPersonelBilgileri = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rButtonEvli = new System.Windows.Forms.RadioButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPersMeslek = new System.Windows.Forms.Label();
            this.lblPersDurum = new System.Windows.Forms.Label();
            this.lblPersMaas = new System.Windows.Forms.Label();
            this.lblPersSehir = new System.Windows.Forms.Label();
            this.lblPersSoyad = new System.Windows.Forms.Label();
            this.lblPersAd = new System.Windows.Forms.Label();
            this.lblPersID = new System.Windows.Forms.Label();
            this.dB_EmployeeDataSet = new EmployeeProject.DB_EmployeeDataSet();
            this.dBEmployeeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_EmployeeTableAdapter = new EmployeeProject.DB_EmployeeDataSetTableAdapters.Tbl_EmployeeTableAdapter();
            this.persIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.persMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gBoxKayitlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gBoxIslemler.SuspendLayout();
            this.gBoxPersonelBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EmployeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBEmployeeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxKayitlar
            // 
            this.gBoxKayitlar.Controls.Add(this.dataGridView1);
            this.gBoxKayitlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gBoxKayitlar.Location = new System.Drawing.Point(12, 487);
            this.gBoxKayitlar.Name = "gBoxKayitlar";
            this.gBoxKayitlar.Size = new System.Drawing.Size(1158, 281);
            this.gBoxKayitlar.TabIndex = 20;
            this.gBoxKayitlar.TabStop = false;
            this.gBoxKayitlar.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.persIdDataGridViewTextBoxColumn,
            this.persAdDataGridViewTextBoxColumn,
            this.persSoyadDataGridViewTextBoxColumn,
            this.persSehirDataGridViewTextBoxColumn,
            this.persMaasDataGridViewTextBoxColumn,
            this.persDurumDataGridViewCheckBoxColumn,
            this.persMeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblEmployeeBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1152, 252);
            this.dataGridView1.TabIndex = 18;
            // 
            // gBoxIslemler
            // 
            this.gBoxIslemler.Controls.Add(this.btnGrafikler);
            this.gBoxIslemler.Controls.Add(this.btnIstatistikler);
            this.gBoxIslemler.Controls.Add(this.btnTemizle);
            this.gBoxIslemler.Controls.Add(this.btnGuncelle);
            this.gBoxIslemler.Controls.Add(this.btnSil);
            this.gBoxIslemler.Controls.Add(this.btnKaydet);
            this.gBoxIslemler.Controls.Add(this.btnListele);
            this.gBoxIslemler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gBoxIslemler.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gBoxIslemler.Location = new System.Drawing.Point(744, 8);
            this.gBoxIslemler.Name = "gBoxIslemler";
            this.gBoxIslemler.Size = new System.Drawing.Size(426, 426);
            this.gBoxIslemler.TabIndex = 19;
            this.gBoxIslemler.TabStop = false;
            this.gBoxIslemler.Text = "İşlemler";
            // 
            // btnGrafikler
            // 
            this.btnGrafikler.BackColor = System.Drawing.Color.White;
            this.btnGrafikler.Location = new System.Drawing.Point(127, 314);
            this.btnGrafikler.Name = "btnGrafikler";
            this.btnGrafikler.Size = new System.Drawing.Size(185, 39);
            this.btnGrafikler.TabIndex = 16;
            this.btnGrafikler.Text = "Grafikler";
            this.btnGrafikler.UseVisualStyleBackColor = false;
            // 
            // btnIstatistikler
            // 
            this.btnIstatistikler.BackColor = System.Drawing.Color.White;
            this.btnIstatistikler.Location = new System.Drawing.Point(127, 269);
            this.btnIstatistikler.Name = "btnIstatistikler";
            this.btnIstatistikler.Size = new System.Drawing.Size(185, 39);
            this.btnIstatistikler.TabIndex = 15;
            this.btnIstatistikler.Text = "İstatistikler";
            this.btnIstatistikler.UseVisualStyleBackColor = false;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(127, 226);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(185, 39);
            this.btnTemizle.TabIndex = 14;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(127, 181);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(185, 39);
            this.btnGuncelle.TabIndex = 13;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(127, 136);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(185, 39);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(127, 91);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(185, 39);
            this.btnKaydet.TabIndex = 11;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.White;
            this.btnListele.Location = new System.Drawing.Point(127, 46);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(185, 39);
            this.btnListele.TabIndex = 10;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // gBoxPersonelBilgileri
            // 
            this.gBoxPersonelBilgileri.Controls.Add(this.textBox5);
            this.gBoxPersonelBilgileri.Controls.Add(this.maskedTextBox1);
            this.gBoxPersonelBilgileri.Controls.Add(this.textBox4);
            this.gBoxPersonelBilgileri.Controls.Add(this.radioButton1);
            this.gBoxPersonelBilgileri.Controls.Add(this.rButtonEvli);
            this.gBoxPersonelBilgileri.Controls.Add(this.textBox3);
            this.gBoxPersonelBilgileri.Controls.Add(this.textBox2);
            this.gBoxPersonelBilgileri.Controls.Add(this.textBox1);
            this.gBoxPersonelBilgileri.Controls.Add(this.lblPersMeslek);
            this.gBoxPersonelBilgileri.Controls.Add(this.lblPersDurum);
            this.gBoxPersonelBilgileri.Controls.Add(this.lblPersMaas);
            this.gBoxPersonelBilgileri.Controls.Add(this.lblPersSehir);
            this.gBoxPersonelBilgileri.Controls.Add(this.lblPersSoyad);
            this.gBoxPersonelBilgileri.Controls.Add(this.lblPersAd);
            this.gBoxPersonelBilgileri.Controls.Add(this.lblPersID);
            this.gBoxPersonelBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gBoxPersonelBilgileri.Location = new System.Drawing.Point(12, 8);
            this.gBoxPersonelBilgileri.Name = "gBoxPersonelBilgileri";
            this.gBoxPersonelBilgileri.Size = new System.Drawing.Size(426, 426);
            this.gBoxPersonelBilgileri.TabIndex = 18;
            this.gBoxPersonelBilgileri.TabStop = false;
            this.gBoxPersonelBilgileri.Text = "Personel Bilgileri";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(151, 298);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(227, 30);
            this.textBox5.TabIndex = 8;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(151, 226);
            this.maskedTextBox1.Mask = "0000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(227, 30);
            this.maskedTextBox1.TabIndex = 5;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(151, 190);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(227, 30);
            this.textBox4.TabIndex = 4;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(151, 263);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(89, 29);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Bekar";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rButtonEvli
            // 
            this.rButtonEvli.AutoSize = true;
            this.rButtonEvli.Location = new System.Drawing.Point(310, 261);
            this.rButtonEvli.Name = "rButtonEvli";
            this.rButtonEvli.Size = new System.Drawing.Size(68, 29);
            this.rButtonEvli.TabIndex = 7;
            this.rButtonEvli.TabStop = true;
            this.rButtonEvli.Text = "Evli";
            this.rButtonEvli.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(151, 154);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(227, 30);
            this.textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(151, 118);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(227, 30);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 30);
            this.textBox1.TabIndex = 1;
            // 
            // lblPersMeslek
            // 
            this.lblPersMeslek.AutoSize = true;
            this.lblPersMeslek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersMeslek.Location = new System.Drawing.Point(64, 301);
            this.lblPersMeslek.Name = "lblPersMeslek";
            this.lblPersMeslek.Size = new System.Drawing.Size(81, 25);
            this.lblPersMeslek.TabIndex = 16;
            this.lblPersMeslek.Text = "Meslek:";
            // 
            // lblPersDurum
            // 
            this.lblPersDurum.AutoSize = true;
            this.lblPersDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersDurum.Location = new System.Drawing.Point(69, 263);
            this.lblPersDurum.Name = "lblPersDurum";
            this.lblPersDurum.Size = new System.Drawing.Size(76, 25);
            this.lblPersDurum.TabIndex = 15;
            this.lblPersDurum.Text = "Durum:";
            // 
            // lblPersMaas
            // 
            this.lblPersMaas.AutoSize = true;
            this.lblPersMaas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersMaas.Location = new System.Drawing.Point(78, 226);
            this.lblPersMaas.Name = "lblPersMaas";
            this.lblPersMaas.Size = new System.Drawing.Size(67, 25);
            this.lblPersMaas.TabIndex = 14;
            this.lblPersMaas.Text = "Maaş:";
            // 
            // lblPersSehir
            // 
            this.lblPersSehir.AutoSize = true;
            this.lblPersSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersSehir.Location = new System.Drawing.Point(81, 193);
            this.lblPersSehir.Name = "lblPersSehir";
            this.lblPersSehir.Size = new System.Drawing.Size(64, 25);
            this.lblPersSehir.TabIndex = 13;
            this.lblPersSehir.Text = "Şehir:";
            // 
            // lblPersSoyad
            // 
            this.lblPersSoyad.AutoSize = true;
            this.lblPersSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersSoyad.Location = new System.Drawing.Point(70, 154);
            this.lblPersSoyad.Name = "lblPersSoyad";
            this.lblPersSoyad.Size = new System.Drawing.Size(75, 25);
            this.lblPersSoyad.TabIndex = 12;
            this.lblPersSoyad.Text = "Soyad:";
            // 
            // lblPersAd
            // 
            this.lblPersAd.AutoSize = true;
            this.lblPersAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersAd.Location = new System.Drawing.Point(102, 123);
            this.lblPersAd.Name = "lblPersAd";
            this.lblPersAd.Size = new System.Drawing.Size(43, 25);
            this.lblPersAd.TabIndex = 11;
            this.lblPersAd.Text = "Ad:";
            // 
            // lblPersID
            // 
            this.lblPersID.AutoSize = true;
            this.lblPersID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersID.Location = new System.Drawing.Point(26, 87);
            this.lblPersID.Name = "lblPersID";
            this.lblPersID.Size = new System.Drawing.Size(119, 25);
            this.lblPersID.TabIndex = 10;
            this.lblPersID.Text = "Personel ID:";
            // 
            // dB_EmployeeDataSet
            // 
            this.dB_EmployeeDataSet.DataSetName = "DB_EmployeeDataSet";
            this.dB_EmployeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBEmployeeDataSetBindingSource
            // 
            this.dBEmployeeDataSetBindingSource.DataSource = this.dB_EmployeeDataSet;
            this.dBEmployeeDataSetBindingSource.Position = 0;
            // 
            // tblEmployeeBindingSource
            // 
            this.tblEmployeeBindingSource.DataMember = "Tbl_Employee";
            this.tblEmployeeBindingSource.DataSource = this.dBEmployeeDataSetBindingSource;
            // 
            // tbl_EmployeeTableAdapter
            // 
            this.tbl_EmployeeTableAdapter.ClearBeforeFill = true;
            // 
            // persIdDataGridViewTextBoxColumn
            // 
            this.persIdDataGridViewTextBoxColumn.DataPropertyName = "persId";
            this.persIdDataGridViewTextBoxColumn.HeaderText = "persId";
            this.persIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.persIdDataGridViewTextBoxColumn.Name = "persIdDataGridViewTextBoxColumn";
            this.persIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.persIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // persAdDataGridViewTextBoxColumn
            // 
            this.persAdDataGridViewTextBoxColumn.DataPropertyName = "persAd";
            this.persAdDataGridViewTextBoxColumn.HeaderText = "persAd";
            this.persAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.persAdDataGridViewTextBoxColumn.Name = "persAdDataGridViewTextBoxColumn";
            this.persAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // persSoyadDataGridViewTextBoxColumn
            // 
            this.persSoyadDataGridViewTextBoxColumn.DataPropertyName = "persSoyad";
            this.persSoyadDataGridViewTextBoxColumn.HeaderText = "persSoyad";
            this.persSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.persSoyadDataGridViewTextBoxColumn.Name = "persSoyadDataGridViewTextBoxColumn";
            this.persSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // persSehirDataGridViewTextBoxColumn
            // 
            this.persSehirDataGridViewTextBoxColumn.DataPropertyName = "persSehir";
            this.persSehirDataGridViewTextBoxColumn.HeaderText = "persSehir";
            this.persSehirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.persSehirDataGridViewTextBoxColumn.Name = "persSehirDataGridViewTextBoxColumn";
            this.persSehirDataGridViewTextBoxColumn.Width = 125;
            // 
            // persMaasDataGridViewTextBoxColumn
            // 
            this.persMaasDataGridViewTextBoxColumn.DataPropertyName = "persMaas";
            this.persMaasDataGridViewTextBoxColumn.HeaderText = "persMaas";
            this.persMaasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.persMaasDataGridViewTextBoxColumn.Name = "persMaasDataGridViewTextBoxColumn";
            this.persMaasDataGridViewTextBoxColumn.Width = 125;
            // 
            // persDurumDataGridViewCheckBoxColumn
            // 
            this.persDurumDataGridViewCheckBoxColumn.DataPropertyName = "persDurum";
            this.persDurumDataGridViewCheckBoxColumn.HeaderText = "persDurum";
            this.persDurumDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.persDurumDataGridViewCheckBoxColumn.Name = "persDurumDataGridViewCheckBoxColumn";
            this.persDurumDataGridViewCheckBoxColumn.Width = 125;
            // 
            // persMeslekDataGridViewTextBoxColumn
            // 
            this.persMeslekDataGridViewTextBoxColumn.DataPropertyName = "persMeslek";
            this.persMeslekDataGridViewTextBoxColumn.HeaderText = "persMeslek";
            this.persMeslekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.persMeslekDataGridViewTextBoxColumn.Name = "persMeslekDataGridViewTextBoxColumn";
            this.persMeslekDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1182, 776);
            this.Controls.Add(this.gBoxKayitlar);
            this.Controls.Add(this.gBoxIslemler);
            this.Controls.Add(this.gBoxPersonelBilgileri);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Screen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gBoxKayitlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gBoxIslemler.ResumeLayout(false);
            this.gBoxPersonelBilgileri.ResumeLayout(false);
            this.gBoxPersonelBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EmployeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBEmployeeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxKayitlar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gBoxIslemler;
        private System.Windows.Forms.Button btnGrafikler;
        private System.Windows.Forms.Button btnIstatistikler;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.GroupBox gBoxPersonelBilgileri;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rButtonEvli;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPersMeslek;
        private System.Windows.Forms.Label lblPersDurum;
        private System.Windows.Forms.Label lblPersMaas;
        private System.Windows.Forms.Label lblPersSehir;
        private System.Windows.Forms.Label lblPersSoyad;
        private System.Windows.Forms.Label lblPersAd;
        private System.Windows.Forms.Label lblPersID;
        private System.Windows.Forms.BindingSource dBEmployeeDataSetBindingSource;
        private DB_EmployeeDataSet dB_EmployeeDataSet;
        private System.Windows.Forms.BindingSource tblEmployeeBindingSource;
        private DB_EmployeeDataSetTableAdapters.Tbl_EmployeeTableAdapter tbl_EmployeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn persIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn persAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn persSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn persSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn persMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn persDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn persMeslekDataGridViewTextBoxColumn;
    }
}

