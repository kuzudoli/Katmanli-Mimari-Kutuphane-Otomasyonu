namespace kutuphaneUI
{
    partial class TumEmanetlerListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TumEmanetlerListesi));
            this.dataGridViewTumEmanetler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTumEmanetler)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTumEmanetler
            // 
            this.dataGridViewTumEmanetler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTumEmanetler.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTumEmanetler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTumEmanetler.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewTumEmanetler.Name = "dataGridViewTumEmanetler";
            this.dataGridViewTumEmanetler.ReadOnly = true;
            this.dataGridViewTumEmanetler.RowTemplate.Height = 24;
            this.dataGridViewTumEmanetler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTumEmanetler.Size = new System.Drawing.Size(1398, 627);
            this.dataGridViewTumEmanetler.TabIndex = 0;
            // 
            // TumEmanetlerListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 651);
            this.Controls.Add(this.dataGridViewTumEmanetler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TumEmanetlerListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tüm Emanetlerin Listesi";
            this.Load += new System.EventHandler(this.TumEmanetlerListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTumEmanetler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewTumEmanetler;

    }
}