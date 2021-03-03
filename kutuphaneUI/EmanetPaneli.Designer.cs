namespace kutuphaneUI
{
    partial class EmanetPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmanetPaneli));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kitapNoLabel = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnKitapSec = new System.Windows.Forms.Button();
            this.txtYayinevi = new System.Windows.Forms.TextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.txtKitapAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTCKNO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAraTckno = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.dataGridViewAra = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTeslimEt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTumEmanetler = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAra)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kitapNoLabel);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.btnKitapSec);
            this.groupBox1.Controls.Add(this.txtYayinevi);
            this.groupBox1.Controls.Add(this.txtYazar);
            this.groupBox1.Controls.Add(this.txtKitapAd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTCKNO);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1446, 175);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Emanet Kayıt";
            // 
            // kitapNoLabel
            // 
            this.kitapNoLabel.AutoSize = true;
            this.kitapNoLabel.Location = new System.Drawing.Point(443, 27);
            this.kitapNoLabel.Name = "kitapNoLabel";
            this.kitapNoLabel.Size = new System.Drawing.Size(0, 20);
            this.kitapNoLabel.TabIndex = 7;
            this.kitapNoLabel.Visible = false;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.AliceBlue;
            this.btnEkle.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnEkle.FlatAppearance.BorderSize = 2;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnEkle.Location = new System.Drawing.Point(1141, 67);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(174, 45);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Kaydet";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnKitapSec
            // 
            this.btnKitapSec.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnKitapSec.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnKitapSec.FlatAppearance.BorderSize = 2;
            this.btnKitapSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitapSec.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnKitapSec.Location = new System.Drawing.Point(109, 93);
            this.btnKitapSec.Name = "btnKitapSec";
            this.btnKitapSec.Size = new System.Drawing.Size(287, 45);
            this.btnKitapSec.TabIndex = 5;
            this.btnKitapSec.Text = "Kitap Seç";
            this.btnKitapSec.UseVisualStyleBackColor = false;
            this.btnKitapSec.Click += new System.EventHandler(this.btnKitapSec_Click);
            // 
            // txtYayinevi
            // 
            this.txtYayinevi.Enabled = false;
            this.txtYayinevi.Location = new System.Drawing.Point(921, 102);
            this.txtYayinevi.Name = "txtYayinevi";
            this.txtYayinevi.Size = new System.Drawing.Size(153, 27);
            this.txtYayinevi.TabIndex = 1;
            // 
            // txtYazar
            // 
            this.txtYazar.Enabled = false;
            this.txtYazar.Location = new System.Drawing.Point(541, 102);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(253, 27);
            this.txtYazar.TabIndex = 1;
            // 
            // txtKitapAd
            // 
            this.txtKitapAd.Enabled = false;
            this.txtKitapAd.Location = new System.Drawing.Point(541, 51);
            this.txtKitapAd.Name = "txtKitapAd";
            this.txtKitapAd.Size = new System.Drawing.Size(533, 27);
            this.txtKitapAd.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(818, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Yayınevi:";
            // 
            // txtTCKNO
            // 
            this.txtTCKNO.Location = new System.Drawing.Point(237, 51);
            this.txtTCKNO.MaxLength = 11;
            this.txtTCKNO.Name = "txtTCKNO";
            this.txtTCKNO.Size = new System.Drawing.Size(159, 27);
            this.txtTCKNO.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(439, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Yazar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(439, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kitap Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(105, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Üye TCKNO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(325, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Üye TCKNO:";
            // 
            // txtAraTckno
            // 
            this.txtAraTckno.Location = new System.Drawing.Point(458, 35);
            this.txtAraTckno.MaxLength = 11;
            this.txtAraTckno.Name = "txtAraTckno";
            this.txtAraTckno.Size = new System.Drawing.Size(200, 27);
            this.txtAraTckno.TabIndex = 1;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnAra.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnAra.FlatAppearance.BorderSize = 2;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnAra.Location = new System.Drawing.Point(691, 29);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(126, 39);
            this.btnAra.TabIndex = 5;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // dataGridViewAra
            // 
            this.dataGridViewAra.AllowUserToAddRows = false;
            this.dataGridViewAra.AllowUserToDeleteRows = false;
            this.dataGridViewAra.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAra.Location = new System.Drawing.Point(13, 93);
            this.dataGridViewAra.MultiSelect = false;
            this.dataGridViewAra.Name = "dataGridViewAra";
            this.dataGridViewAra.ReadOnly = true;
            this.dataGridViewAra.RowTemplate.Height = 24;
            this.dataGridViewAra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAra.Size = new System.Drawing.Size(1416, 291);
            this.dataGridViewAra.TabIndex = 6;
            this.dataGridViewAra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAra_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTeslimEt);
            this.groupBox2.Controls.Add(this.dataGridViewAra);
            this.groupBox2.Controls.Add(this.btnAra);
            this.groupBox2.Controls.Add(this.txtAraTckno);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox2.Location = new System.Drawing.Point(12, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1446, 398);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Emanet İşlemleri";
            // 
            // btnTeslimEt
            // 
            this.btnTeslimEt.BackColor = System.Drawing.Color.Honeydew;
            this.btnTeslimEt.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnTeslimEt.FlatAppearance.BorderSize = 2;
            this.btnTeslimEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeslimEt.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnTeslimEt.Location = new System.Drawing.Point(849, 29);
            this.btnTeslimEt.Name = "btnTeslimEt";
            this.btnTeslimEt.Size = new System.Drawing.Size(139, 39);
            this.btnTeslimEt.TabIndex = 7;
            this.btnTeslimEt.Text = "Teslim Et";
            this.btnTeslimEt.UseVisualStyleBackColor = false;
            this.btnTeslimEt.Click += new System.EventHandler(this.btnTeslimEt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(1081, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(348, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "*Lütfen teslim etmek istediğiniz kitabı tablodan seçiniz.";
            // 
            // btnTumEmanetler
            // 
            this.btnTumEmanetler.BackColor = System.Drawing.Color.MintCream;
            this.btnTumEmanetler.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.btnTumEmanetler.FlatAppearance.BorderSize = 2;
            this.btnTumEmanetler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTumEmanetler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTumEmanetler.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnTumEmanetler.Location = new System.Drawing.Point(234, 617);
            this.btnTumEmanetler.Name = "btnTumEmanetler";
            this.btnTumEmanetler.Size = new System.Drawing.Size(997, 56);
            this.btnTumEmanetler.TabIndex = 12;
            this.btnTumEmanetler.Text = "Tüm Emanetlerin Listesini Görmek İçin Tıklayınız";
            this.btnTumEmanetler.UseVisualStyleBackColor = false;
            this.btnTumEmanetler.Click += new System.EventHandler(this.btnTumEmanetler_Click);
            // 
            // EmanetPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1470, 699);
            this.Controls.Add(this.btnTumEmanetler);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EmanetPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emanet İşlemleri";
            this.Load += new System.EventHandler(this.EmanetPaneli_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAra)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTCKNO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKitapSec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEkle;
        public System.Windows.Forms.TextBox txtYayinevi;
        public System.Windows.Forms.TextBox txtYazar;
        public System.Windows.Forms.TextBox txtKitapAd;
        public System.Windows.Forms.Label kitapNoLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAraTckno;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.DataGridView dataGridViewAra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTeslimEt;
        private System.Windows.Forms.Button btnTumEmanetler;
    }
}