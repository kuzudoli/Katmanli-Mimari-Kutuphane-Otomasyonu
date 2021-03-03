using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kutuphaneDAL;
using kutuphaneEntity;
using System.Data.OleDb;
using System.Net.Mail; //Email adresi kontrolünü sağlamak için kullanılır
namespace kutuphaneBLL
{
    public class UyeBLL
    {
        private UyeDAL uyeDAL;
        //Yapıcı metot ile DAL katmanından bir nesne üretilir
        public UyeBLL()
        {
            uyeDAL = new UyeDAL();
        }

        //Kullanıcının bir email girmesini sağlar
        //Girdi email ise "true" değil ise "false" return eder
        public bool emailKontrol(Uye uye)
        {
            try
            {
                MailAddress mail = new MailAddress(uye.EMAIL);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Tüm üyelerin listesi için kullanılır herhangi bir kontrole ihtiyaç yoktur
        public List<Uye> TumUyeleriListele()
        {
            return uyeDAL.TumUyeleriListele();
        }

        //Üye kaydı araması için gerekli kontrolleri yapar
        public List<Uye> UyeAra(Uye uye)
        {
            //TCKNO numarasının hane sayısını kontrol eder
            if (uye.UYE_TCKNO.Length !=11)
            {
                throw new Exception("Lütfen geçerli bir TC Kimlik Numarası giriniz!");
            }

            return uyeDAL.UyeAra(uye);
        }

        //Üye kaydı araması için gerekli kontrolleri yapar
        //Üye nesnesi return eder
        public Uye UyeAra2(Uye uye)
        {
            //TCKNO numarasının hane sayısını kontrol eder
            if (uye.UYE_TCKNO.Length != 11)
            {
                throw new Exception("Lütfen geçerli bir TC Kimlik Numarası giriniz!");
            }

            return uyeDAL.UyeAra2(uye);
        }

        //Üye kaydı için gerekli kontrolleri yapar
        public void UyeEkle(Uye uye)
        {
            //TCKNO numarasının hane sayısını kontrol eder
            if (uye.UYE_TCKNO.Length != 11)
                throw new Exception("Lütfen geçerli bir 'TC Kimlik Numarası' giriniz!");
            //Telefon numarasının hane sayısını kontrol eder
            if (uye.TELEFON.Length != 11)
               throw new Exception("Lütfen geçerli bir 'Telefon Numarası' giriniz!");
            //Email adresini kontrol eder
            if (emailKontrol(uye) == false)
                throw new Exception("Lütfen geçerli bir 'E-Mail' giriniz!");

            uyeDAL.UyeEkle(uye);
        }

        //Üye silme işlemi için gerekli kontrolleri yapar
        public void UyeSil(Uye uye)
        {
            //TCKNO numarasının hane sayısını kontrol eder
            if (uye.UYE_TCKNO.Length != 11)
                throw new Exception("Lütfen geçerli bir 'TC Kimlik Numarası' giriniz!");
            
            uyeDAL.UyeSil(uye);
        }

        //Üye bilgileri güncelleme işlemi için gerekli kontrolleri yapar
        public void UyeGuncelle(Uye uye)
        {
            //TCKNO numarasının hane sayısını kontrol eder
            if (uye.TELEFON.Length != 11)
                throw new Exception("Eksik bilgi, lütfen bilgileri tekrar kontrol ediniz!");
            //Telefon numarasının hane sayısını kontrol eder
            if (emailKontrol(uye) == false)
                throw new Exception("Lütfen geçerli bir 'E-Mail' giriniz!");
            else
                uyeDAL.UyeGuncelle(uye);

        }

    }
}
