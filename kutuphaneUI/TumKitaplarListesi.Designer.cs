namespace kutuphaneUI
{
    partial class TumKitaplarListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TumKitaplarListesi));
            this.dataGridViewTumKitaplar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTumKitaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTumKitaplar
            // 
            this.dataGridViewTumKitaplar.AllowUserToAddRows = false;
            this.dataGridViewTumKitaplar.AllowUserToDeleteRows = false;
            this.dataGridViewTumKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewTumKitaplar.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTumKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTumKitaplar.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewTumKitaplar.MultiSelect = false;
            this.dataGridViewTumKitaplar.Name = "dataGridViewTumKitaplar";
            this.dataGridViewTumKitaplar.ReadOnly = true;
            this.dataGridViewTumKitaplar.RowTemplate.Height = 24;
            this.dataGridViewTumKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTumKitaplar.Size = new System.Drawing.Size(1362, 539);
            this.dataGridViewTumKitaplar.TabIndex = 0;
            // 
            // TumKitaplarListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 563);
            this.Controls.Add(this.dataGridViewTumKitaplar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TumKitaplarListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tüm Kitapların Listesi";
            this.Load += new System.EventHandler(this.TumKitaplarListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTumKitaplar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewTumKitaplar;

    }
}