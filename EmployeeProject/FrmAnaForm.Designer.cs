namespace EmployeeProject
{
    partial class FrmAnaForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gBoxKayitlar = new System.Windows.Forms.GroupBox();
            this.dGridPersonel = new System.Windows.Forms.DataGridView();
            this.tblEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBEmployeeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_EmployeeDataSet = new EmployeeProject.DB_EmployeeDataSet();
            this.gBoxIslemler = new System.Windows.Forms.GroupBox();
            this.btnRaporlar = new System.Windows.Forms.Button();
            this.btnGrafikler = new System.Windows.Forms.Button();
            this.btnIstatistikler = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.gBoxPersonelBilgileri = new System.Windows.Forms.GroupBox();
            this.tBoxMeslek = new System.Windows.Forms.TextBox();
            this.maskTBoxMaas = new System.Windows.Forms.MaskedTextBox();
            this.tBoxSehir = new System.Windows.Forms.TextBox();
            this.rButtonBekar = new System.Windows.Forms.RadioButton();
            this.rButtonEvli = new System.Windows.Forms.RadioButton();
            this.tBoxSoyad = new System.Windows.Forms.TextBox();
            this.tBoxAd = new System.Windows.Forms.TextBox();
            this.tBoxPersonelId = new System.Windows.Forms.TextBox();
            this.lblPersMeslek = new System.Windows.Forms.Label();
            this.lblPersDurum = new System.Windows.Forms.Label();
            this.lblPersMaas = new System.Windows.Forms.Label();
            this.lblPersSehir = new System.Windows.Forms.Label();
            this.lblPersSoyad = new System.Windows.Forms.Label();
            this.lblPersAd = new System.Windows.Forms.Label();
            this.lblPersID = new System.Windows.Forms.Label();
            this.tbl_EmployeeTableAdapter = new EmployeeProject.DB_EmployeeDataSetTableAdapters.Tbl_EmployeeTableAdapter();
            this.lblPersonelDurum = new System.Windows.Forms.Label();
            this.persIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.persMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gBoxKayitlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridPersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBEmployeeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EmployeeDataSet)).BeginInit();
            this.gBoxIslemler.SuspendLayout();
            this.gBoxPersonelBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxKayitlar
            // 
            this.gBoxKayitlar.Controls.Add(this.dGridPersonel);
            this.gBoxKayitlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gBoxKayitlar.Location = new System.Drawing.Point(12, 487);
            this.gBoxKayitlar.Name = "gBoxKayitlar";
            this.gBoxKayitlar.Size = new System.Drawing.Size(1158, 281);
            this.gBoxKayitlar.TabIndex = 20;
            this.gBoxKayitlar.TabStop = false;
            this.gBoxKayitlar.Text = "Kayıtlar";
            // 
            // dGridPersonel
            // 
            this.dGridPersonel.AutoGenerateColumns = false;
            this.dGridPersonel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGridPersonel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGridPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridPersonel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.persIdDataGridViewTextBoxColumn,
            this.persAdDataGridViewTextBoxColumn,
            this.persSoyadDataGridViewTextBoxColumn,
            this.persSehirDataGridViewTextBoxColumn,
            this.persMaasDataGridViewTextBoxColumn,
            this.persDurumDataGridViewCheckBoxColumn,
            this.persMeslekDataGridViewTextBoxColumn});
            this.dGridPersonel.DataSource = this.tblEmployeeBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGridPersonel.DefaultCellStyle = dataGridViewCellStyle4;
            this.dGridPersonel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGridPersonel.EnableHeadersVisualStyles = false;
            this.dGridPersonel.Location = new System.Drawing.Point(3, 26);
            this.dGridPersonel.Name = "dGridPersonel";
            this.dGridPersonel.RowHeadersWidth = 51;
            this.dGridPersonel.RowTemplate.Height = 24;
            this.dGridPersonel.Size = new System.Drawing.Size(1152, 252);
            this.dGridPersonel.TabIndex = 18;
            this.dGridPersonel.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridPersonel_CellDoubleClick);
            // 
            // tblEmployeeBindingSource
            // 
            this.tblEmployeeBindingSource.DataMember = "Tbl_Employee";
            this.tblEmployeeBindingSource.DataSource = this.dBEmployeeDataSetBindingSource;
            // 
            // dBEmployeeDataSetBindingSource
            // 
            this.dBEmployeeDataSetBindingSource.DataSource = this.dB_EmployeeDataSet;
            this.dBEmployeeDataSetBindingSource.Position = 0;
            // 
            // dB_EmployeeDataSet
            // 
            this.dB_EmployeeDataSet.DataSetName = "DB_EmployeeDataSet";
            this.dB_EmployeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gBoxIslemler
            // 
            this.gBoxIslemler.Controls.Add(this.btnRaporlar);
            this.gBoxIslemler.Controls.Add(this.btnGrafikler);
            this.gBoxIslemler.Controls.Add(this.btnIstatistikler);
            this.gBoxIslemler.Controls.Add(this.btnTemizle);
            this.gBoxIslemler.Controls.Add(this.btnGuncelle);
            this.gBoxIslemler.Controls.Add(this.btnSil);
            this.gBoxIslemler.Controls.Add(this.btnKaydet);
            this.gBoxIslemler.Controls.Add(this.btnListele);
            this.gBoxIslemler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gBoxIslemler.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gBoxIslemler.Location = new System.Drawing.Point(617, 8);
            this.gBoxIslemler.Name = "gBoxIslemler";
            this.gBoxIslemler.Size = new System.Drawing.Size(550, 426);
            this.gBoxIslemler.TabIndex = 19;
            this.gBoxIslemler.TabStop = false;
            this.gBoxIslemler.Text = "İşlemler";
            // 
            // btnRaporlar
            // 
            this.btnRaporlar.BackColor = System.Drawing.Color.White;
            this.btnRaporlar.Location = new System.Drawing.Point(186, 351);
            this.btnRaporlar.Name = "btnRaporlar";
            this.btnRaporlar.Size = new System.Drawing.Size(185, 39);
            this.btnRaporlar.TabIndex = 17;
            this.btnRaporlar.Text = "Raporlar";
            this.btnRaporlar.UseVisualStyleBackColor = false;
            this.btnRaporlar.Click += new System.EventHandler(this.btnRaporlar_Click);
            // 
            // btnGrafikler
            // 
            this.btnGrafikler.BackColor = System.Drawing.Color.White;
            this.btnGrafikler.Location = new System.Drawing.Point(186, 306);
            this.btnGrafikler.Name = "btnGrafikler";
            this.btnGrafikler.Size = new System.Drawing.Size(185, 39);
            this.btnGrafikler.TabIndex = 16;
            this.btnGrafikler.Text = "Grafikler";
            this.btnGrafikler.UseVisualStyleBackColor = false;
            this.btnGrafikler.Click += new System.EventHandler(this.btnGrafikler_Click);
            // 
            // btnIstatistikler
            // 
            this.btnIstatistikler.BackColor = System.Drawing.Color.White;
            this.btnIstatistikler.Location = new System.Drawing.Point(186, 261);
            this.btnIstatistikler.Name = "btnIstatistikler";
            this.btnIstatistikler.Size = new System.Drawing.Size(185, 39);
            this.btnIstatistikler.TabIndex = 15;
            this.btnIstatistikler.Text = "İstatistikler";
            this.btnIstatistikler.UseVisualStyleBackColor = false;
            this.btnIstatistikler.Click += new System.EventHandler(this.btnIstatistikler_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(186, 218);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(185, 39);
            this.btnTemizle.TabIndex = 14;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Gold;
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(186, 173);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(185, 39);
            this.btnGuncelle.TabIndex = 13;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(186, 128);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(185, 39);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.ForestGreen;
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(186, 83);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(185, 39);
            this.btnKaydet.TabIndex = 11;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.White;
            this.btnListele.Location = new System.Drawing.Point(186, 38);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(185, 39);
            this.btnListele.TabIndex = 10;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // gBoxPersonelBilgileri
            // 
            this.gBoxPersonelBilgileri.Controls.Add(this.tBoxMeslek);
            this.gBoxPersonelBilgileri.Controls.Add(this.maskTBoxMaas);
            this.gBoxPersonelBilgileri.Controls.Add(this.tBoxSehir);
            this.gBoxPersonelBilgileri.Controls.Add(this.rButtonBekar);
            this.gBoxPersonelBilgileri.Controls.Add(this.rButtonEvli);
            this.gBoxPersonelBilgileri.Controls.Add(this.tBoxSoyad);
            this.gBoxPersonelBilgileri.Controls.Add(this.tBoxAd);
            this.gBoxPersonelBilgileri.Controls.Add(this.tBoxPersonelId);
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
            this.gBoxPersonelBilgileri.Size = new System.Drawing.Size(550, 426);
            this.gBoxPersonelBilgileri.TabIndex = 18;
            this.gBoxPersonelBilgileri.TabStop = false;
            this.gBoxPersonelBilgileri.Text = "Personel Bilgileri";
            // 
            // tBoxMeslek
            // 
            this.tBoxMeslek.Location = new System.Drawing.Point(202, 298);
            this.tBoxMeslek.Name = "tBoxMeslek";
            this.tBoxMeslek.Size = new System.Drawing.Size(227, 30);
            this.tBoxMeslek.TabIndex = 8;
            // 
            // maskTBoxMaas
            // 
            this.maskTBoxMaas.Location = new System.Drawing.Point(202, 226);
            this.maskTBoxMaas.Mask = "0000000";
            this.maskTBoxMaas.Name = "maskTBoxMaas";
            this.maskTBoxMaas.Size = new System.Drawing.Size(227, 30);
            this.maskTBoxMaas.TabIndex = 5;
            this.maskTBoxMaas.ValidatingType = typeof(int);
            // 
            // tBoxSehir
            // 
            this.tBoxSehir.Location = new System.Drawing.Point(202, 190);
            this.tBoxSehir.Name = "tBoxSehir";
            this.tBoxSehir.Size = new System.Drawing.Size(227, 30);
            this.tBoxSehir.TabIndex = 4;
            // 
            // rButtonBekar
            // 
            this.rButtonBekar.AutoSize = true;
            this.rButtonBekar.Location = new System.Drawing.Point(340, 263);
            this.rButtonBekar.Name = "rButtonBekar";
            this.rButtonBekar.Size = new System.Drawing.Size(89, 29);
            this.rButtonBekar.TabIndex = 6;
            this.rButtonBekar.TabStop = true;
            this.rButtonBekar.Text = "Bekar";
            this.rButtonBekar.UseVisualStyleBackColor = true;
            this.rButtonBekar.CheckedChanged += new System.EventHandler(this.rButtonBekar_CheckedChanged);
            // 
            // rButtonEvli
            // 
            this.rButtonEvli.AutoSize = true;
            this.rButtonEvli.Location = new System.Drawing.Point(202, 263);
            this.rButtonEvli.Name = "rButtonEvli";
            this.rButtonEvli.Size = new System.Drawing.Size(68, 29);
            this.rButtonEvli.TabIndex = 7;
            this.rButtonEvli.TabStop = true;
            this.rButtonEvli.Text = "Evli";
            this.rButtonEvli.UseVisualStyleBackColor = true;
            this.rButtonEvli.CheckedChanged += new System.EventHandler(this.rButtonEvli_CheckedChanged);
            // 
            // tBoxSoyad
            // 
            this.tBoxSoyad.Location = new System.Drawing.Point(202, 154);
            this.tBoxSoyad.Name = "tBoxSoyad";
            this.tBoxSoyad.Size = new System.Drawing.Size(227, 30);
            this.tBoxSoyad.TabIndex = 3;
            // 
            // tBoxAd
            // 
            this.tBoxAd.Location = new System.Drawing.Point(202, 118);
            this.tBoxAd.Name = "tBoxAd";
            this.tBoxAd.Size = new System.Drawing.Size(227, 30);
            this.tBoxAd.TabIndex = 2;
            // 
            // tBoxPersonelId
            // 
            this.tBoxPersonelId.Location = new System.Drawing.Point(202, 82);
            this.tBoxPersonelId.Name = "tBoxPersonelId";
            this.tBoxPersonelId.Size = new System.Drawing.Size(227, 30);
            this.tBoxPersonelId.TabIndex = 1;
            // 
            // lblPersMeslek
            // 
            this.lblPersMeslek.AutoSize = true;
            this.lblPersMeslek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersMeslek.Location = new System.Drawing.Point(115, 301);
            this.lblPersMeslek.Name = "lblPersMeslek";
            this.lblPersMeslek.Size = new System.Drawing.Size(81, 25);
            this.lblPersMeslek.TabIndex = 16;
            this.lblPersMeslek.Text = "Meslek:";
            // 
            // lblPersDurum
            // 
            this.lblPersDurum.AutoSize = true;
            this.lblPersDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersDurum.Location = new System.Drawing.Point(120, 263);
            this.lblPersDurum.Name = "lblPersDurum";
            this.lblPersDurum.Size = new System.Drawing.Size(76, 25);
            this.lblPersDurum.TabIndex = 15;
            this.lblPersDurum.Text = "Durum:";
            // 
            // lblPersMaas
            // 
            this.lblPersMaas.AutoSize = true;
            this.lblPersMaas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersMaas.Location = new System.Drawing.Point(129, 226);
            this.lblPersMaas.Name = "lblPersMaas";
            this.lblPersMaas.Size = new System.Drawing.Size(67, 25);
            this.lblPersMaas.TabIndex = 14;
            this.lblPersMaas.Text = "Maaş:";
            // 
            // lblPersSehir
            // 
            this.lblPersSehir.AutoSize = true;
            this.lblPersSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersSehir.Location = new System.Drawing.Point(132, 193);
            this.lblPersSehir.Name = "lblPersSehir";
            this.lblPersSehir.Size = new System.Drawing.Size(64, 25);
            this.lblPersSehir.TabIndex = 13;
            this.lblPersSehir.Text = "Şehir:";
            // 
            // lblPersSoyad
            // 
            this.lblPersSoyad.AutoSize = true;
            this.lblPersSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersSoyad.Location = new System.Drawing.Point(121, 154);
            this.lblPersSoyad.Name = "lblPersSoyad";
            this.lblPersSoyad.Size = new System.Drawing.Size(75, 25);
            this.lblPersSoyad.TabIndex = 12;
            this.lblPersSoyad.Text = "Soyad:";
            // 
            // lblPersAd
            // 
            this.lblPersAd.AutoSize = true;
            this.lblPersAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersAd.Location = new System.Drawing.Point(153, 123);
            this.lblPersAd.Name = "lblPersAd";
            this.lblPersAd.Size = new System.Drawing.Size(43, 25);
            this.lblPersAd.TabIndex = 11;
            this.lblPersAd.Text = "Ad:";
            // 
            // lblPersID
            // 
            this.lblPersID.AutoSize = true;
            this.lblPersID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersID.Location = new System.Drawing.Point(77, 87);
            this.lblPersID.Name = "lblPersID";
            this.lblPersID.Size = new System.Drawing.Size(119, 25);
            this.lblPersID.TabIndex = 10;
            this.lblPersID.Text = "Personel ID:";
            // 
            // tbl_EmployeeTableAdapter
            // 
            this.tbl_EmployeeTableAdapter.ClearBeforeFill = true;
            // 
            // lblPersonelDurum
            // 
            this.lblPersonelDurum.AutoSize = true;
            this.lblPersonelDurum.Location = new System.Drawing.Point(1012, 459);
            this.lblPersonelDurum.Name = "lblPersonelDurum";
            this.lblPersonelDurum.Size = new System.Drawing.Size(156, 25);
            this.lblPersonelDurum.TabIndex = 21;
            this.lblPersonelDurum.Text = "personelDurumu";
            this.lblPersonelDurum.Visible = false;
            // 
            // persIdDataGridViewTextBoxColumn
            // 
            this.persIdDataGridViewTextBoxColumn.DataPropertyName = "persId";
            this.persIdDataGridViewTextBoxColumn.HeaderText = "Personel ID";
            this.persIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.persIdDataGridViewTextBoxColumn.Name = "persIdDataGridViewTextBoxColumn";
            this.persIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // persAdDataGridViewTextBoxColumn
            // 
            this.persAdDataGridViewTextBoxColumn.DataPropertyName = "persAd";
            this.persAdDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.persAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.persAdDataGridViewTextBoxColumn.Name = "persAdDataGridViewTextBoxColumn";
            // 
            // persSoyadDataGridViewTextBoxColumn
            // 
            this.persSoyadDataGridViewTextBoxColumn.DataPropertyName = "persSoyad";
            this.persSoyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.persSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.persSoyadDataGridViewTextBoxColumn.Name = "persSoyadDataGridViewTextBoxColumn";
            // 
            // persSehirDataGridViewTextBoxColumn
            // 
            this.persSehirDataGridViewTextBoxColumn.DataPropertyName = "persSehir";
            this.persSehirDataGridViewTextBoxColumn.HeaderText = "Şehir";
            this.persSehirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.persSehirDataGridViewTextBoxColumn.Name = "persSehirDataGridViewTextBoxColumn";
            // 
            // persMaasDataGridViewTextBoxColumn
            // 
            this.persMaasDataGridViewTextBoxColumn.DataPropertyName = "persMaas";
            this.persMaasDataGridViewTextBoxColumn.HeaderText = "Maaş";
            this.persMaasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.persMaasDataGridViewTextBoxColumn.Name = "persMaasDataGridViewTextBoxColumn";
            // 
            // persDurumDataGridViewCheckBoxColumn
            // 
            this.persDurumDataGridViewCheckBoxColumn.DataPropertyName = "persDurum";
            this.persDurumDataGridViewCheckBoxColumn.HeaderText = "Medeni Durum";
            this.persDurumDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.persDurumDataGridViewCheckBoxColumn.Name = "persDurumDataGridViewCheckBoxColumn";
            // 
            // persMeslekDataGridViewTextBoxColumn
            // 
            this.persMeslekDataGridViewTextBoxColumn.DataPropertyName = "persMeslek";
            this.persMeslekDataGridViewTextBoxColumn.HeaderText = "Meslek";
            this.persMeslekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.persMeslekDataGridViewTextBoxColumn.Name = "persMeslekDataGridViewTextBoxColumn";
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1182, 776);
            this.Controls.Add(this.lblPersonelDurum);
            this.Controls.Add(this.gBoxKayitlar);
            this.Controls.Add(this.gBoxIslemler);
            this.Controls.Add(this.gBoxPersonelBilgileri);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "FrmAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Bilgi Ekranı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gBoxKayitlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridPersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBEmployeeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EmployeeDataSet)).EndInit();
            this.gBoxIslemler.ResumeLayout(false);
            this.gBoxPersonelBilgileri.ResumeLayout(false);
            this.gBoxPersonelBilgileri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxKayitlar;
        private System.Windows.Forms.DataGridView dGridPersonel;
        private System.Windows.Forms.GroupBox gBoxIslemler;
        private System.Windows.Forms.Button btnGrafikler;
        private System.Windows.Forms.Button btnIstatistikler;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.GroupBox gBoxPersonelBilgileri;
        private System.Windows.Forms.TextBox tBoxMeslek;
        private System.Windows.Forms.MaskedTextBox maskTBoxMaas;
        private System.Windows.Forms.TextBox tBoxSehir;
        private System.Windows.Forms.RadioButton rButtonBekar;
        private System.Windows.Forms.RadioButton rButtonEvli;
        private System.Windows.Forms.TextBox tBoxSoyad;
        private System.Windows.Forms.TextBox tBoxAd;
        private System.Windows.Forms.TextBox tBoxPersonelId;
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
        private System.Windows.Forms.Label lblPersonelDurum;
        private System.Windows.Forms.Button btnRaporlar;
        private System.Windows.Forms.DataGridViewTextBoxColumn persIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn persAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn persSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn persSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn persMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn persDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn persMeslekDataGridViewTextBoxColumn;
    }
}

