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
    public partial class TümUyeListesi : Form
    {
        public TümUyeListesi()
        {
            InitializeComponent();
            dataGridTumUyeler.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            dataGridTumUyeler.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
        }

        private void TümUyeListesi_Load(object sender, EventArgs e)
        {

        }
    }
}
