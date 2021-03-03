using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutuphaneEntity
{
    public class Emanet
    {
        public Emanet()
        {
            //burada atama yaptığın için hata alabilirsin unutma!
            EMANET_TARIHI = DateTime.Today.Date.ToString();
            TESLIM_DURUMU = "BEKLEMEDE";
            TESLIM_TARIHI = Convert.ToDateTime("1.01.1111").ToString();
            SON_TESLIM_TARIHI = DateTime.Today.Date.AddDays(14).ToString();
            KITAP_DURUMU = "EMANETTE";
        }
        public int EMANET_NO { get; set; }
        public string UYE_TCKNO { get; set; }
        public string UYE_AD { get; set; }
        public string UYE_SOYAD { get; set; }
        public int KITAP_NO { get; set; }
        public string KITAP_ADI { get; set; }
        public string KITAP_YAZAR { get; set; }
        public string KITAP_DURUMU { get; set; }
        public string EMANET_TARIHI { get; set; }
        public string SON_TESLIM_TARIHI { get; set; }
        public string TESLIM_TARIHI { get; set; }
        public string TESLIM_DURUMU { get; set; }
        public int BORC { get; set; }
    }
}
