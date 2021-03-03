namespace kutuphaneUI
{
    partial class KitapPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapPaneli));
            this.btnTumKitaplar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.dataGridViewSil = new System.Windows.Forms.DataGridView();
            this.btnAraSil = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtKitapNoSil = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.comboTurGuncelle = new System.Windows.Forms.ComboBox();
            this.btnKitapGetir = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtYayineviGuncelle = new System.Windows.Forms.TextBox();
            this.txtKitapNoGuncelleme = new System.Windows.Forms.TextBox();
            this.txtBasimYiliGuncelle = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAdGuncelle = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtYazarGuncelle = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSayfaGuncelle = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewAra = new System.Windows.Forms.DataGridView();
            this.btnAra = new System.Windows.Forms.Button();
            this.labelYayinevi = new System.Windows.Forms.Label();
            this.labelYazar = new System.Windows.Forms.Label();
            this.labelAd = new System.Windows.Forms.Label();
            this.txtYayineviAra = new System.Windows.Forms.TextBox();
            this.txtYazarAra = new System.Windows.Forms.TextBox();
            this.txtAdAra = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboTur = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtYayinevi = new System.Windows.Forms.TextBox();
            this.txtBasimYili = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.txtSayfa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSil)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAra)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTumKitaplar
            // 
            this.btnTumKitaplar.BackColor = System.Drawing.Color.MintCream;
            this.btnTumKitaplar.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.btnTumKitaplar.FlatAppearance.BorderSize = 2;
            this.btnTumKitaplar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTumKitaplar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTumKitaplar.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnTumKitaplar.Location = new System.Drawing.Point(199, 808);
            this.btnTumKitaplar.Name = "btnTumKitaplar";
            this.btnTumKitaplar.Size = new System.Drawing.Size(1077, 55);
            this.btnTumKitaplar.TabIndex = 9;
            this.btnTumKitaplar.Text = "Tüm Kitapların Listesini Görmek İçin Tıklayınız";
            this.btnTumKitaplar.UseVisualStyleBackColor = false;
            this.btnTumKitaplar.Click += new System.EventHandler(this.btnTumKitaplar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSil);
            this.groupBox4.Controls.Add(this.dataGridViewSil);
            this.groupBox4.Controls.Add(this.btnAraSil);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.txtKitapNoSil);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox4.Location = new System.Drawing.Point(12, 634);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1425, 168);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kitap Sil";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.MistyRose;
            this.btnSil.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSil.FlatAppearance.BorderSize = 2;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.ForeColor = System.Drawing.Color.Red;
            this.btnSil.Location = new System.Drawing.Point(138, 98);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(113, 45);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dataGridViewSil
            // 
            this.dataGridViewSil.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSil.Location = new System.Drawing.Point(274, 40);
            this.dataGridViewSil.Name = "dataGridViewSil";
            this.dataGridViewSil.RowTemplate.Height = 24;
            this.dataGridViewSil.Size = new System.Drawing.Size(1138, 103);
            this.dataGridViewSil.TabIndex = 6;
            // 
            // btnAraSil
            // 
            this.btnAraSil.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnAraSil.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnAraSil.FlatAppearance.BorderSize = 2;
            this.btnAraSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAraSil.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnAraSil.Location = new System.Drawing.Point(12, 98);
            this.btnAraSil.Name = "btnAraSil";
            this.btnAraSil.Size = new System.Drawing.Size(113, 45);
            this.btnAraSil.TabIndex = 5;
            this.btnAraSil.Text = "Ara";
            this.btnAraSil.UseVisualStyleBackColor = false;
            this.btnAraSil.Click += new System.EventHandler(this.btnAraSil_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(8, 43);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 20);
            this.label17.TabIndex = 0;
            this.label17.Text = "Kitap No:";
            // 
            // txtKitapNoSil
            // 
            this.txtKitapNoSil.Location = new System.Drawing.Point(109, 40);
            this.txtKitapNoSil.Name = "txtKitapNoSil";
            this.txtKitapNoSil.Size = new System.Drawing.Size(142, 27);
            this.txtKitapNoSil.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGuncelle);
            this.groupBox3.Controls.Add(this.comboTurGuncelle);
            this.groupBox3.Controls.Add(this.btnKitapGetir);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtYayineviGuncelle);
            this.groupBox3.Controls.Add(this.txtKitapNoGuncelleme);
            this.groupBox3.Controls.Add(this.txtBasimYiliGuncelle);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtAdGuncelle);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtYazarGuncelle);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtSayfaGuncelle);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(12, 367);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1425, 261);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kitap Güncelle";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Honeydew;
            this.btnGuncelle.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnGuncelle.FlatAppearance.BorderSize = 2;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnGuncelle.Location = new System.Drawing.Point(1148, 131);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(210, 51);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // comboTurGuncelle
            // 
            this.comboTurGuncelle.FormattingEnabled = true;
            this.comboTurGuncelle.Items.AddRange(new object[] {
            "AİLE",
            "ANTOLOJİ",
            "ARAŞTIRMA-İNCELEME",
            "AŞK",
            "BİLGİSAYAR-İNTERNET",
            "BİLİM KURGU",
            "BİYOGRAFİ",
            "BİLİM-TEKNOLOJİ-MÜHENDİSLİK",
            "ÇOCUK",
            "DERGİ",
            "DİNİ",
            "EDEBİYAT",
            "EFSANELER-DESTANLAR",
            "EĞİTİM",
            "EĞLENCE-MİZAH",
            "EKONOMİ",
            "FANTASTİK",
            "FELSEFE",
            "GEZİ",
            "HİKAYE (ÖYKÜ)",
            "HOBİ",
            "HUKUK",
            "İLETİŞİM-MEDYA",
            "KİŞİSEL GELİŞİM",
            "KORKU-GERİLİM",
            "MACERA-AKSİYON",
            "MANGA",
            "MASAL",
            "MODA",
            "MÜZİK",
            "POLİSİYE",
            "PSİKOLOJİ",
            "ROMAN",
            "SAĞLIK-TIP",
            "SANAT",
            "SENARYO-OYUN",
            "ŞİİR",
            "SİNEMA",
            "SİYASET-POLİTİKA",
            "SOSYOLOJİ",
            "SÖZLÜK-ANSİKLOPEDİ",
            "SPOR",
            "TARİH",
            "TİYATRO",
            "TÜRK KLASİKLERİ",
            "YEMEK",
            "YERALTI EDEBİYATI"});
            this.comboTurGuncelle.Location = new System.Drawing.Point(520, 177);
            this.comboTurGuncelle.Name = "comboTurGuncelle";
            this.comboTurGuncelle.Size = new System.Drawing.Size(176, 28);
            this.comboTurGuncelle.TabIndex = 6;
            // 
            // btnKitapGetir
            // 
            this.btnKitapGetir.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnKitapGetir.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnKitapGetir.FlatAppearance.BorderSize = 2;
            this.btnKitapGetir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitapGetir.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnKitapGetir.Location = new System.Drawing.Point(785, 26);
            this.btnKitapGetir.Name = "btnKitapGetir";
            this.btnKitapGetir.Size = new System.Drawing.Size(138, 38);
            this.btnKitapGetir.TabIndex = 5;
            this.btnKitapGetir.Text = "Kitabı Getir";
            this.btnKitapGetir.UseVisualStyleBackColor = false;
            this.btnKitapGetir.Click += new System.EventHandler(this.btnKitapGetir_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(500, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 20);
            this.label16.TabIndex = 0;
            this.label16.Text = "Kitap No:";
            // 
            // txtYayineviGuncelle
            // 
            this.txtYayineviGuncelle.Location = new System.Drawing.Point(899, 113);
            this.txtYayineviGuncelle.MaxLength = 20;
            this.txtYayineviGuncelle.Name = "txtYayineviGuncelle";
            this.txtYayineviGuncelle.Size = new System.Drawing.Size(176, 27);
            this.txtYayineviGuncelle.TabIndex = 1;
            // 
            // txtKitapNoGuncelleme
            // 
            this.txtKitapNoGuncelleme.Location = new System.Drawing.Point(603, 32);
            this.txtKitapNoGuncelleme.MaxLength = 20;
            this.txtKitapNoGuncelleme.Name = "txtKitapNoGuncelleme";
            this.txtKitapNoGuncelleme.Size = new System.Drawing.Size(159, 27);
            this.txtKitapNoGuncelleme.TabIndex = 1;
            // 
            // txtBasimYiliGuncelle
            // 
            this.txtBasimYiliGuncelle.Location = new System.Drawing.Point(176, 184);
            this.txtBasimYiliGuncelle.MaxLength = 4;
            this.txtBasimYiliGuncelle.Name = "txtBasimYiliGuncelle";
            this.txtBasimYiliGuncelle.Size = new System.Drawing.Size(159, 27);
            this.txtBasimYiliGuncelle.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(763, 116);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Yayınevi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(68, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Kitap Adı:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(399, 116);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Yazar:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAdGuncelle
            // 
            this.txtAdGuncelle.Location = new System.Drawing.Point(176, 113);
            this.txtAdGuncelle.Name = "txtAdGuncelle";
            this.txtAdGuncelle.Size = new System.Drawing.Size(159, 27);
            this.txtAdGuncelle.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(68, 187);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Basım Yılı:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(763, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Sayfa Sayısı:";
            // 
            // txtYazarGuncelle
            // 
            this.txtYazarGuncelle.Location = new System.Drawing.Point(520, 113);
            this.txtYazarGuncelle.Name = "txtYazarGuncelle";
            this.txtYazarGuncelle.Size = new System.Drawing.Size(176, 27);
            this.txtYazarGuncelle.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(402, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tür:";
            // 
            // txtSayfaGuncelle
            // 
            this.txtSayfaGuncelle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSayfaGuncelle.Location = new System.Drawing.Point(899, 179);
            this.txtSayfaGuncelle.MaxLength = 10;
            this.txtSayfaGuncelle.Name = "txtSayfaGuncelle";
            this.txtSayfaGuncelle.Size = new System.Drawing.Size(176, 27);
            this.txtSayfaGuncelle.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewAra);
            this.groupBox2.Controls.Add(this.btnAra);
            this.groupBox2.Controls.Add(this.labelYayinevi);
            this.groupBox2.Controls.Add(this.labelYazar);
            this.groupBox2.Controls.Add(this.labelAd);
            this.groupBox2.Controls.Add(this.txtYayineviAra);
            this.groupBox2.Controls.Add(this.txtYazarAra);
            this.groupBox2.Controls.Add(this.txtAdAra);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox2.Location = new System.Drawing.Point(12, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1425, 168);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap Bul";
            // 
            // dataGridViewAra
            // 
            this.dataGridViewAra.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAra.Location = new System.Drawing.Point(406, 39);
            this.dataGridViewAra.Name = "dataGridViewAra";
            this.dataGridViewAra.RowTemplate.Height = 24;
            this.dataGridViewAra.Size = new System.Drawing.Size(1007, 113);
            this.dataGridViewAra.TabIndex = 6;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnAra.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnAra.FlatAppearance.BorderSize = 2;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnAra.Location = new System.Drawing.Point(332, 39);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(68, 113);
            this.btnAra.TabIndex = 5;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // labelYayinevi
            // 
            this.labelYayinevi.AutoSize = true;
            this.labelYayinevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelYayinevi.Location = new System.Drawing.Point(9, 128);
            this.labelYayinevi.Name = "labelYayinevi";
            this.labelYayinevi.Size = new System.Drawing.Size(84, 20);
            this.labelYayinevi.TabIndex = 0;
            this.labelYayinevi.Text = "Yayınevi:";
            // 
            // labelYazar
            // 
            this.labelYazar.AutoSize = true;
            this.labelYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelYazar.Location = new System.Drawing.Point(9, 85);
            this.labelYazar.Name = "labelYazar";
            this.labelYazar.Size = new System.Drawing.Size(63, 20);
            this.labelYazar.TabIndex = 0;
            this.labelYazar.Text = "Yazar:";
            // 
            // labelAd
            // 
            this.labelAd.AutoSize = true;
            this.labelAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAd.Location = new System.Drawing.Point(9, 42);
            this.labelAd.Name = "labelAd";
            this.labelAd.Size = new System.Drawing.Size(91, 20);
            this.labelAd.TabIndex = 0;
            this.labelAd.Text = "Kitap Adı:";
            // 
            // txtYayineviAra
            // 
            this.txtYayineviAra.Location = new System.Drawing.Point(135, 125);
            this.txtYayineviAra.MaxLength = 100;
            this.txtYayineviAra.Name = "txtYayineviAra";
            this.txtYayineviAra.Size = new System.Drawing.Size(191, 27);
            this.txtYayineviAra.TabIndex = 1;
            this.txtYayineviAra.TextChanged += new System.EventHandler(this.txtYayineviAra_TextChanged);
            // 
            // txtYazarAra
            // 
            this.txtYazarAra.Location = new System.Drawing.Point(135, 82);
            this.txtYazarAra.MaxLength = 100;
            this.txtYazarAra.Name = "txtYazarAra";
            this.txtYazarAra.Size = new System.Drawing.Size(191, 27);
            this.txtYazarAra.TabIndex = 1;
            this.txtYazarAra.TextChanged += new System.EventHandler(this.txtYazarAra_TextChanged);
            // 
            // txtAdAra
            // 
            this.txtAdAra.Location = new System.Drawing.Point(135, 39);
            this.txtAdAra.MaxLength = 100;
            this.txtAdAra.Name = "txtAdAra";
            this.txtAdAra.Size = new System.Drawing.Size(191, 27);
            this.txtAdAra.TabIndex = 1;
            this.txtAdAra.TextChanged += new System.EventHandler(this.txtAdAra_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.comboTur);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.txtYayinevi);
            this.groupBox1.Controls.Add(this.txtBasimYili);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtYazar);
            this.groupBox1.Controls.Add(this.txtSayfa);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1425, 167);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Ekle";
            // 
            // comboTur
            // 
            this.comboTur.FormattingEnabled = true;
            this.comboTur.Items.AddRange(new object[] {
            "AİLE",
            "ANTOLOJİ",
            "ARAŞTIRMA-İNCELEME",
            "AŞK",
            "BİLGİSAYAR-İNTERNET",
            "BİLİM KURGU",
            "BİYOGRAFİ",
            "BİLİM-TEKNOLOJİ-MÜHENDİSLİK",
            "ÇOCUK",
            "DERGİ",
            "DİNİ",
            "EDEBİYAT",
            "EFSANELER-DESTANLAR",
            "EĞİTİM",
            "EĞLENCE-MİZAH",
            "EKONOMİ",
            "FANTASTİK",
            "FELSEFE",
            "GEZİ",
            "HİKAYE (ÖYKÜ)",
            "HOBİ",
            "HUKUK",
            "İLETİŞİM-MEDYA",
            "KİŞİSEL GELİŞİM",
            "KORKU-GERİLİM",
            "MACERA-AKSİYON",
            "MANGA",
            "MASAL",
            "MODA",
            "MÜZİK",
            "POLİSİYE",
            "PSİKOLOJİ",
            "ROMAN",
            "SAĞLIK-TIP",
            "SANAT",
            "SENARYO-OYUN",
            "ŞİİR",
            "SİNEMA",
            "SİYASET-POLİTİKA",
            "SOSYOLOJİ",
            "SÖZLÜK-ANSİKLOPEDİ",
            "SPOR",
            "TARİH",
            "TİYATRO",
            "TÜRK KLASİKLERİ",
            "YEMEK",
            "YERALTI EDEBİYATI"});
            this.comboTur.Location = new System.Drawing.Point(520, 107);
            this.comboTur.Name = "comboTur";
            this.comboTur.Size = new System.Drawing.Size(176, 28);
            this.comboTur.TabIndex = 6;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.AliceBlue;
            this.btnEkle.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnEkle.FlatAppearance.BorderSize = 2;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnEkle.Location = new System.Drawing.Point(1148, 61);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(210, 51);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Kitap Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtYayinevi
            // 
            this.txtYayinevi.Location = new System.Drawing.Point(899, 43);
            this.txtYayinevi.MaxLength = 20;
            this.txtYayinevi.Name = "txtYayinevi";
            this.txtYayinevi.Size = new System.Drawing.Size(176, 27);
            this.txtYayinevi.TabIndex = 1;
            // 
            // txtBasimYili
            // 
            this.txtBasimYili.Location = new System.Drawing.Point(176, 114);
            this.txtBasimYili.MaxLength = 4;
            this.txtBasimYili.Name = "txtBasimYili";
            this.txtBasimYili.Size = new System.Drawing.Size(159, 27);
            this.txtBasimYili.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(763, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Yayınevi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(399, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Yazar:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(68, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Basım Yılı:";
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(520, 43);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(176, 27);
            this.txtYazar.TabIndex = 1;
            // 
            // txtSayfa
            // 
            this.txtSayfa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSayfa.Location = new System.Drawing.Point(899, 109);
            this.txtSayfa.MaxLength = 10;
            this.txtSayfa.Name = "txtSayfa";
            this.txtSayfa.Size = new System.Drawing.Size(176, 27);
            this.txtSayfa.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(402, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tür:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(763, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sayfa Sayısı:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(176, 43);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(159, 27);
            this.txtAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(68, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adı:";
            // 
            // KitapPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1470, 904);
            this.Controls.Add(this.btnTumKitaplar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "KitapPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap İşlemleri";
            this.Load += new System.EventHandler(this.KitapPaneli_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSil)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAra)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTumKitaplar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dataGridViewSil;
        private System.Windows.Forms.Button btnAraSil;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtKitapNoSil;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnKitapGetir;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtKitapNoGuncelleme;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewAra;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label labelAd;
        private System.Windows.Forms.TextBox txtAdAra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtBasimYili;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.TextBox txtSayfa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboTur;
        private System.Windows.Forms.TextBox txtYayinevi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelYazar;
        private System.Windows.Forms.TextBox txtYazarAra;
        private System.Windows.Forms.Label labelYayinevi;
        private System.Windows.Forms.TextBox txtYayineviAra;
        private System.Windows.Forms.ComboBox comboTurGuncelle;
        private System.Windows.Forms.TextBox txtYayineviGuncelle;
        private System.Windows.Forms.TextBox txtBasimYiliGuncelle;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAdGuncelle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtYazarGuncelle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSayfaGuncelle;
        private System.Windows.Forms.Button btnGuncelle;
    }
}