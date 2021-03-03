using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutuphaneEntity
{
    public class Kitap
    {
        public Kitap()
        {
            KITAP_DURUMU = "HAZIR";
        }
        public int KITAP_NO { get; set; }
        public string KITAP_ADI { get; set; }
        public string KITAP_YAZAR { get; set; }
        public string TUR { get; set; }
        public string SAYFA_SAYISI { get; set; }
        public string BASIM_YILI { get; set; }
        public string KITAP_YAYINEVI { get; set; }
        public string KITAP_DURUMU { get; set; }

        public int ToplamKitap{get;set;}
        public int HazirKitapSayisi { get; set; }
        public int HazirOlmayanKitapSayisi { get; set; }
    }
}
