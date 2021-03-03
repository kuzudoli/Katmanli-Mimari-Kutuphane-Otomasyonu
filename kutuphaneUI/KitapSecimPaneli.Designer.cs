namespace kutuphaneUI
{
    partial class KitapSecimPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapSecimPaneli));
            this.dataGridKitapSecim = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKitapSecim)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridKitapSecim
            // 
            this.dataGridKitapSecim.BackgroundColor = System.Drawing.Color.White;
            this.dataGridKitapSecim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridKitapSecim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridKitapSecim.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridKitapSecim.Location = new System.Drawing.Point(12, 12);
            this.dataGridKitapSecim.Name = "dataGridKitapSecim";
            this.dataGridKitapSecim.ReadOnly = true;
            this.dataGridKitapSecim.RowTemplate.Height = 24;
            this.dataGridKitapSecim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridKitapSecim.Size = new System.Drawing.Size(1362, 539);
            this.dataGridKitapSecim.TabIndex = 0;
            this.dataGridKitapSecim.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridKitapSecim_CellContentClick);
            // 
            // KitapSecimPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1386, 563);
            this.Controls.Add(this.dataGridKitapSecim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KitapSecimPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Listesi";
            this.Load += new System.EventHandler(this.KitapSecimPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKitapSecim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridKitapSecim;

    }
}