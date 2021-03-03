using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace kutuphaneUI
{
    public partial class KitapSecimPaneli : Form
    {
        public KitapSecimPaneli()
        {
            InitializeComponent();
            //Font değişiklikleri
            dataGridKitapSecim.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            dataGridKitapSecim.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
        }
        
        private void KitapSecimPaneli_Load(object sender, EventArgs e)
        {
            
        }

        //Emanet Kaydı Kitap Seçim Tablosu
        public void dataGridKitapSecim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Tablo üzerinden seçim yapıldığında Emanet Formuna veri akışı sağlar
                DataGridViewRow row = this.dataGridKitapSecim.Rows[e.RowIndex];
                EmanetPaneli emanetPaneli = (EmanetPaneli)Application.OpenForms["emanetPaneli"]; //Veri akışının önemli parçası (aradaki bağlantıyı sağlar)
                emanetPaneli.txtKitapAd.Text = row.Cells["KITAP_ADI"].Value.ToString();
                emanetPaneli.txtYazar.Text = row.Cells["KITAP_YAZAR"].Value.ToString();
                emanetPaneli.txtYayinevi.Text = row.Cells["KITAP_YAYINEVI"].Value.ToString();
                emanetPaneli.kitapNoLabel.Text = row.Cells["KITAP_NO"].Value.ToString();
            }
        }
    }
}
