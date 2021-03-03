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
    public partial class TumEmanetlerListesi : Form
    {
        public TumEmanetlerListesi()
        {
            InitializeComponent();
            dataGridViewTumEmanetler.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            dataGridViewTumEmanetler.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
        }

        private void TumEmanetlerListesi_Load(object sender, EventArgs e)
        {
            
        }
    }
}
