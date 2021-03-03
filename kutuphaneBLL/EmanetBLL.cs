using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kutuphaneDAL;
using kutuphaneEntity;
using System.Data.OleDb;
namespace kutuphaneBLL
{
    public class EmanetBLL
    {
        private EmanetDAL emanetDAL;
        //Yapıcı metot ile DAL katmanından bir nesne üretilir
        public EmanetBLL()
        {
            emanetDAL = new EmanetDAL();
        }

        //Günlük borç hesabı için kullanılır herhangi bir kontrole ihtiyaç yoktur
        public void EmanetGunlukGuncelleme()
        {
            emanetDAL.EmanetGunlukGuncelleme();
        }

        //Tüm emanetlerin listesi için kullanılır herhangi bir kontrole ihtiyaç yoktur
        public List<Emanet> TumEmanetleriListele()
        {
            return emanetDAL.TumEmanetleriListele();
        }

        //Emanet kaydı için gerekli kontrolleri yapar
        public void EmanetEkle(Emanet emanet)
        {
            //Kitap seçimi yapması sağlanır
            if (emanet.KITAP_NO == null)
                throw new Exception("Lütfen bir kitap seçiniz!");

            //TCKNO numarasının hane sayısını kontrol eder
            if(emanet.UYE_TCKNO.Length != 11)
                throw new Exception("Lütfen geçerli bir TCKNO giriniz!");

            emanetDAL.EmanetEkle(emanet);
        }

        //Kitap teslim için gerekli kontrolleri yapar
        public void EmanetTeslim(Emanet emanet)
        {
            //Teslim edilmek istenen emanet kaydının seçilmesini sağlar
            if (emanet.EMANET_NO == null)
            {
                throw new Exception("Lütfen işlem gerçekleştirmek için tablodan bir emanet kaydı seçiniz!");
            }
            emanetDAL.EmanetTeslim(emanet);
        }

        //Kitap alışveriş durumu için kullanılır herhangi bir kontrole ihtiyaç yoktur
        public void EmanetKitapGuncelleme(Emanet emanet)
        {
            emanetDAL.EmanetKitapGuncelleme(emanet);
        }

        //Emanet kaydı araması için gerekli kontrolleri yapar
        public List<Emanet> EmanetAra(Emanet emanet)
        {
            //TCKNO numarasının hane sayısını kontrol eder
            if (emanet.UYE_TCKNO.Length != 11)
                throw new Exception("Lütfen geçerli bir TCKNO giriniz!");

            return emanetDAL.EmanetAra(emanet);
        }
    }
}
