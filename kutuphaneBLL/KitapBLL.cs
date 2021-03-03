using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kutuphaneDAL;
using kutuphaneEntity;
namespace kutuphaneBLL
{
    public class KitapBLL
    {
        private KitapDAL kitapDAL;
        //Yapıcı metot ile DAL katmanından bir nesne üretilir
        public KitapBLL()
        {
            kitapDAL = new KitapDAL();
        }
        //Tüm kitapların listesi için kullanılır herhangi bir kontrole ihtiyaç yoktur
        public List<Kitap> TumKitaplarıListele()
        {
            return kitapDAL.TumKitaplarıListele();
        }

        //Emanet verilmeye hazır olan kitapların listesi için kullanılır herhangi bir kontrole ihtiyaç yoktur
        public List<Kitap> HazırKitaplariListele()
        {
            return kitapDAL.HazırKitaplariListele();
        }
        
        //Kitap Adı ile arama için gerekli kontrolleri yapar
        public List<Kitap> KitapAra(Kitap kitap)
        {
            //Kitap Adı girilmesini sağlar
            if(kitap.KITAP_ADI=="")
                throw new Exception("Lütfen bir kitap adı giriniz!");

            return kitapDAL.KitapAra(kitap);
        }

        //Kitap No ile arama için gerekli kontrolleri yapar
        public Kitap KitapAraNo(Kitap kitap)
        {
            //Kitap No girilmesini sağlar
            if(kitap.KITAP_NO==null)
                throw new Exception("Lütfen bir 'Kitap Numarası' giriniz!");

            return kitapDAL.KitapAraNo(kitap);
        }

        //Yazar Adı ile arama için gerekli kontrolleri yapar
        public List<Kitap> KitapAraYazar(Kitap kitap)
        {
            //Yazar Adı girilmesi sağlanır
            if (kitap.KITAP_YAZAR=="")
                throw new Exception("Lütfen bir 'Yazar Adı' giriniz!");

            return kitapDAL.KitapAraYazar(kitap);

        }

        //Yayınevi ile arama için gerekli kontrolleri yapar
        public List<Kitap> KitapAraYayinevi(Kitap kitap)
        {
            //Yayınevi girilmesi sağlanır
            if (kitap.KITAP_YAYINEVI=="")
                throw new Exception("Lütfen bir 'Yayınevi' giriniz!");

            return kitapDAL.KitapAraYayinevi(kitap);

        }

        //Kitap kaydı için gerekli kontrolleri yapar
        public void KitapEkle(Kitap kitap)
        {
            //Kitap Adı girilmesini sağlar
            if (kitap.KITAP_ADI.Length == 0)
                throw new Exception("Lütfen kitap adı giriniz!");
            //Yazar Adı girilmesini sağlar
            if (kitap.KITAP_YAZAR.Length == 0)
                throw new Exception("Lütfen yazar adı giriniz!");
            //Basım Yılı girilmesini sağlar
            if (kitap.BASIM_YILI.Length != 4)
                throw new Exception("Lütfen geçerli bir yıl giriniz!");
            //Yayınevi girilmesini sağlar
            if (kitap.KITAP_YAYINEVI.Length == 0)
                throw new Exception("Lütfen yayınevi adı giriniz!");

            kitapDAL.KitapEkle(kitap);
        }

        //Kitap silme için gerekli kontrolleri yapar
        public void KitapSil(Kitap kitap)
        {
            //Kitap No girilmesini sağlar
            if(kitap.KITAP_NO==null)
                throw new Exception("Lütfen bir 'Kitap No' giriniz!");

            kitapDAL.KitapSil(kitap);
        }

        //Kitap bilgisi güncelleme için gerekli kontrolleri yapar
        public void KitapGuncelle(Kitap kitap)
        {
            //Kitap Adı girilmesini sağlar
            if (kitap.KITAP_ADI.Length == 0)
                throw new Exception("Lütfen kitap adı giriniz!");
            //Yazar Adı girilmesini sağlar
            if (kitap.KITAP_YAZAR.Length == 0)
                throw new Exception("Lütfen yazar adı giriniz!");
            //Basım Yılı girilmesini sağlar
            if (kitap.BASIM_YILI.Length != 4)
                throw new Exception("Lütfen geçerli bir yıl giriniz!");
            //Yayınevi girilmesini sağlar
            if (kitap.KITAP_YAYINEVI.Length == 0)
                throw new Exception("Lütfen yayınevi adı giriniz!");

            kitapDAL.KitapGuncelle(kitap);
        }

        //
        public void GrafikHesap(Kitap kitap)
        {
            kitapDAL.GrafikHesap(kitap);
        }

    }
}
