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
    public class CalisanBLL
    {
        private CalisanDAL calisanDAL;
        //Yapıcı metot ile DAL katmanından bir nesne üretilir
        public CalisanBLL()
        {
            calisanDAL = new CalisanDAL();
        }

        //Çalışan Ekle metodunun bilgi giriş kontrollerini yapar
        public void CalisanEkle(CalisanBilgileri calisan)
        {
            //Girilen TCKNO ile kayıt araması yapılır var ise bir alttaki if ile kontrol sağlanır
            int CalisanNo = calisanDAL.CalisanAraNo(calisan);

            //Aynı TCKNO ile birden fazla kayıt oluşturulmasını engeller
            if (CalisanNo > 0)
                throw new Exception("Bu TCKNO ile zaten bir kayıt oluşturulmuş!");

            //TCKNO numarasının hane sayısını kontrol eder
            if (calisan.CALISAN_TCKNO.Length != 11)
                throw new Exception("Lütfen geçerli bir TCKNO giriniz!");

            //Şifrenin en az 6 karakter olması sağlanır
            if (calisan.CALISAN_SIFRE.Length <= 6)
                throw new Exception("Şifreniz 6 karakterden daha uzun olmalıdır!");

            calisanDAL.CalisanEkle(calisan); //DAL katmanından asıl metot çağırılır
        }

        public CalisanBilgileri CalisanAra(CalisanBilgileri calisan)
        {
            //TCKNO numarasının hane sayısını kontrol eder
            if(calisan.CALISAN_TCKNO.Length!=11)
                throw new Exception("Lütfen geçerli bir TCKNO giriniz!");

            //Şifrenin en az 6 karakter girilmesi sağlanır
            if(calisan.CALISAN_SIFRE.Length<6)
                throw new Exception("Lütfen şifrenizi kontrol ediniz");

            return calisanDAL.CalisanAra(calisan);
        }

        //Çalışan Numara araması yapılır herhangi bir kontrole ihtiyaç yoktur, başka bir metotta kullanılmak üzere yazılmıştır
        public int CalisanAraNo(CalisanBilgileri calisan)
        {
            return calisanDAL.CalisanAraNo(calisan);
        }
    }
}
