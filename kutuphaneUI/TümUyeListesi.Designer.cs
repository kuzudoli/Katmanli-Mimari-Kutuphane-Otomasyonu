namespace kutuphaneUI
{
    partial class TümUyeListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TümUyeListesi));
            this.dataGridTumUyeler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTumUyeler)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridTumUyeler
            // 
            this.dataGridTumUyeler.AllowUserToAddRows = false;
            this.dataGridTumUyeler.AllowUserToDeleteRows = false;
            this.dataGridTumUyeler.BackgroundColor = System.Drawing.Color.White;
            this.dataGridTumUyeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTumUyeler.Location = new System.Drawing.Point(15, 13);
            this.dataGridTumUyeler.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridTumUyeler.MultiSelect = false;
            this.dataGridTumUyeler.Name = "dataGridTumUyeler";
            this.dataGridTumUyeler.ReadOnly = true;
            this.dataGridTumUyeler.RowTemplate.Height = 24;
            this.dataGridTumUyeler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTumUyeler.Size = new System.Drawing.Size(1125, 490);
            this.dataGridTumUyeler.TabIndex = 0;
            // 
            // TümUyeListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 515);
            this.Controls.Add(this.dataGridTumUyeler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "TümUyeListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tüm Üyelerin Listesi";
            this.Load += new System.EventHandler(this.TümUyeListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTumUyeler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridTumUyeler;

    }
}