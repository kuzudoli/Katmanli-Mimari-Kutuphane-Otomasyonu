namespace kutuphaneUI
{
    partial class CalisanKayitFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalisanKayitFormu));
            this.btnKayit = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtTCKNO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelGiris = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKayit
            // 
            this.btnKayit.BackColor = System.Drawing.Color.Yellow;
            this.btnKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayit.ForeColor = System.Drawing.Color.Black;
            this.btnKayit.Location = new System.Drawing.Point(153, 276);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(146, 43);
            this.btnKayit.TabIndex = 7;
            this.btnKayit.Text = "KAYIT OL";
            this.btnKayit.UseVisualStyleBackColor = false;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(169, 189);
            this.txtSifre.MaxLength = 12;
            this.txtSifre.Multiline = true;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(205, 30);
            this.txtSifre.TabIndex = 5;
            // 
            // txtTCKNO
            // 
            this.txtTCKNO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTCKNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTCKNO.Location = new System.Drawing.Point(169, 118);
            this.txtTCKNO.MaxLength = 11;
            this.txtTCKNO.Multiline = true;
            this.txtTCKNO.Name = "txtTCKNO";
            this.txtTCKNO.Size = new System.Drawing.Size(205, 30);
            this.txtTCKNO.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(68, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "ŞİFRE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(68, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "TCKNO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(69, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "*Şifreniz en az 7 karakter olmalıdır";
            // 
            // labelGiris
            // 
            this.labelGiris.AutoSize = true;
            this.labelGiris.BackColor = System.Drawing.Color.Yellow;
            this.labelGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGiris.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelGiris.Location = new System.Drawing.Point(178, 379);
            this.labelGiris.Name = "labelGiris";
            this.labelGiris.Size = new System.Drawing.Size(88, 20);
            this.labelGiris.TabIndex = 8;
            this.labelGiris.Text = "Giriş Yap !";
            this.labelGiris.Click += new System.EventHandler(this.labelGiris_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(175, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 38);
            this.label4.TabIndex = 9;
            this.label4.Text = "KAYIT";
            // 
            // CalisanKayitFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(471, 408);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelGiris);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtTCKNO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CalisanKayitFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Ol";
            this.Load += new System.EventHandler(this.CalisanKayitFormu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtTCKNO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelGiris;
        private System.Windows.Forms.Label label4;

    }
}