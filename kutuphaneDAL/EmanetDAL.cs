using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kutuphaneEntity;
using System.Data.OleDb;
namespace kutuphaneDAL
{
    public class EmanetDAL
    {
        private DBConnection dbConnection;
        //Yapıcı metot ile bağlantı kuruluyor
        public EmanetDAL()
        {
            dbConnection = new DBConnection();
        }

        //Tüm emanetlerin listesini return eder
        public List<Emanet> TumEmanetleriListele()
        {
            OleDbCommand cmd = dbConnection.GetOleDbCommand();
            //INNER JOIN ile tablolarda bütünlük sağlandı, gerekli bilgilere ulaşıldı
            cmd.CommandText = "SELECT EMANET.EMANET_NO,EMANET.UYE_TCKNO, UYE.UYE_AD, UYE.UYE_SOYAD, KITAP.KITAP_NO, KITAP.KITAP_ADI,KITAP.KITAP_YAZAR, EMANET.EMANET_TARIHI, EMANET.SON_TESLIM_TARIHI, EMANET.TESLIM_TARIHI, EMANET.TESLIM_DURUMU, EMANET.BORC"
                + " FROM ( (EMANET INNER JOIN KITAP ON EMANET.KITAP_NO = KITAP.KITAP_NO) INNER JOIN UYE ON EMANET.UYE_TCKNO = UYE.UYE_TCKNO )";

            List<Emanet> emanetler = new List<Emanet>();
            //DataReader ile tablo kolonlarındaki veriler okunarak oluşturulan nesne alanlarına atandı
            OleDbDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Emanet emanet = new Emanet();
                emanet.EMANET_NO = Convert.ToInt32(rdr["EMANET_NO"]);
                emanet.UYE_TCKNO = rdr["UYE_TCKNO"].ToString();
                emanet.UYE_AD = rdr["UYE_AD"].ToString();
                emanet.UYE_SOYAD = rdr["UYE_SOYAD"].ToString();
                emanet.KITAP_NO = Convert.ToInt32(rdr["KITAP_NO"]);
                emanet.KITAP_ADI = rdr["KITAP_ADI"].ToString();
                emanet.KITAP_YAZAR = rdr["KITAP_YAZAR"].ToString();
                emanet.EMANET_TARIHI = rdr["EMANET_TARIHI"].ToString();
                emanet.SON_TESLIM_TARIHI = rdr["SON_TESLIM_TARIHI"].ToString();
                emanet.TESLIM_TARIHI = rdr["TESLIM_TARIHI"].ToString();
                emanet.TESLIM_DURUMU = rdr["TESLIM_DURUMU"].ToString();
                emanet.BORC = Convert.ToInt32(rdr["BORC"]);

                emanetler.Add(emanet);
            }
            return emanetler;
        }
        
        //Üye TCKNO ile emanet arama
        public List<Emanet> EmanetAra(Emanet emanet)
        {
            OleDbCommand cmd = dbConnection.GetOleDbCommand();
            //INNER JOIN ile tablolarda bütünlük sağlandı, gerekli bilgilere ulaşıldı
            cmd.CommandText = "SELECT EMANET.EMANET_NO, UYE.UYE_TCKNO, UYE.UYE_AD, UYE.UYE_SOYAD, KITAP.KITAP_NO, KITAP.KITAP_ADI,KITAP.KITAP_YAZAR, EMANET.EMANET_TARIHI, EMANET.SON_TESLIM_TARIHI, EMANET.TESLIM_TARIHI,EMANET.TESLIM_DURUMU,EMANET.BORC"
                + " FROM ( (EMANET INNER JOIN KITAP ON EMANET.KITAP_NO = KITAP.KITAP_NO) INNER JOIN UYE ON EMANET.UYE_TCKNO = UYE.UYE_TCKNO ) WHERE EMANET.UYE_TCKNO='"+emanet.UYE_TCKNO+"'";

            List<Emanet> emanetler = new List<Emanet>();
            //DataReader ile tablo kolonlarındaki veriler okunarak oluşturulan nesne alanlarına atandı
            OleDbDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Emanet yeniEmanet = new Emanet();
                yeniEmanet.EMANET_NO = Convert.ToInt32(rdr["EMANET_NO"]);
                yeniEmanet.UYE_TCKNO = rdr["UYE_TCKNO"].ToString();
                yeniEmanet.UYE_AD = rdr["UYE_AD"].ToString();
                yeniEmanet.UYE_SOYAD = rdr["UYE_SOYAD"].ToString();
                yeniEmanet.KITAP_NO = Convert.ToInt32(rdr["KITAP_NO"]);
                yeniEmanet.KITAP_ADI = rdr["KITAP_ADI"].ToString();
                yeniEmanet.KITAP_YAZAR = rdr["KITAP_YAZAR"].ToString();
                yeniEmanet.EMANET_TARIHI = rdr["EMANET_TARIHI"].ToString();
                yeniEmanet.SON_TESLIM_TARIHI = rdr["SON_TESLIM_TARIHI"].ToString();
                yeniEmanet.TESLIM_TARIHI = rdr["TESLIM_TARIHI"].ToString();
                yeniEmanet.TESLIM_DURUMU = rdr["TESLIM_DURUMU"].ToString();
                yeniEmanet.BORC = Convert.ToInt32(rdr["BORC"]);

                emanetler.Add(yeniEmanet);

            }
            return emanetler;
        }

        //Yeni emanet kaydı oluşturur
        public void EmanetEkle(Emanet emanet)
        {
            string cmdText = "INSERT INTO EMANET (UYE_TCKNO, KITAP_NO, EMANET_TARIHI, SON_TESLIM_TARIHI, TESLIM_TARIHI, TESLIM_DURUMU)";
            //String.Format yardımıyla parametreler sayı ile belirtilerek düzen oluşturulur
            cmdText += String.Format(" VALUES ('{0}',{1},'{2}','{3}','{4}','{5}')",
                emanet.UYE_TCKNO,
                emanet.KITAP_NO,
                emanet.EMANET_TARIHI,
                emanet.SON_TESLIM_TARIHI,
                emanet.TESLIM_TARIHI,
                emanet.TESLIM_DURUMU
                );
            OleDbCommand cmd = dbConnection.GetOleDbCommand();
            cmd.CommandText = cmdText;

            cmd.ExecuteNonQuery();
        }

        //Emanet teslim işlemi yapar
        public void EmanetTeslim(Emanet emanet)
        {
            OleDbCommand cmd = dbConnection.GetOleDbCommand();
            cmd.CommandText = "UPDATE EMANET SET TESLIM_TARIHI=@teslimTarihi,TESLIM_DURUMU=@teslimDurumu WHERE EMANET_NO="+emanet.EMANET_NO;

            //AddWithValue ile iki adet parametreyi cmd nesnemize ekledik, böylece sorgu çalıştığında kullanılabilecek
            cmd.Parameters.AddWithValue("@teslimTarihi", emanet.TESLIM_TARIHI);
            cmd.Parameters.AddWithValue("@teslimDurumu", emanet.TESLIM_DURUMU);

            cmd.ExecuteNonQuery();

        }

        //Emanet alışverişi sırasındaki kitap durumlarını günceller (Kitabın kütüphanede hazır olması veya emanette olması)
        public void EmanetKitapGuncelleme(Emanet emanet)
        {
            OleDbCommand cmd = dbConnection.GetOleDbCommand();
            cmd.CommandText = "UPDATE KITAP SET KITAP_DURUMU=@kitapDurumu WHERE KITAP_NO=" + emanet.KITAP_NO;
            //AddWithValue ile bir parametreyi cmd nesnemize ekledik, böylece sorgu çalıştığında kullanılabilecek
            cmd.Parameters.AddWithValue("@kitapDurumu", emanet.KITAP_DURUMU);

            cmd.ExecuteNonQuery();
        }

        //Emanet listesini baştan aşağı kontrol ederek teslim tarihi geçmiş emanet kayıtlarının borç bilgisini günceller
        public void EmanetGunlukGuncelleme()
        {
            OleDbCommand cmd = dbConnection.GetOleDbCommand();
            cmd.CommandText = "SELECT EMANET_NO,EMANET_TARIHI,SON_TESLIM_TARIHI,TESLIM_DURUMU,BORC FROM EMANET";

            //Önce veri tabanından okunan verileri bir listede toplar
            List<Emanet> emanetler = new List<Emanet>();
            OleDbDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Emanet emanet = new Emanet();
                emanet.EMANET_NO = Convert.ToInt32(rdr["EMANET_NO"]);
                emanet.EMANET_TARIHI = rdr["EMANET_TARIHI"].ToString();
                emanet.SON_TESLIM_TARIHI = rdr["SON_TESLIM_TARIHI"].ToString();
                emanet.TESLIM_DURUMU = rdr["TESLIM_DURUMU"].ToString();
                emanet.BORC = Convert.ToInt32(rdr["BORC"]);
                
                emanetler.Add(emanet);
            }
            rdr.Close();
            
            //Oluşturulan bu listeden "TESLIM DURUMU = TESLİM EDİLMEDİ" olan emanetlerin borç bilgilerini tarihsel düzeyde hesaplar
            
            for (int i = 0; i < emanetler.Count; i++)
            {
                if (emanetler[i].TESLIM_DURUMU == "TESLİM EDİLMEDİ")
                {
                    TimeSpan tarihHesap;
                    DateTime SistemTarihi = DateTime.Now.Date; //Sistem tarihi
                    tarihHesap = SistemTarihi - Convert.ToDateTime(emanetler[i].SON_TESLIM_TARIHI); //Sistem Tarihi - Son Teslim Tarihi

                    emanetler[i].BORC = Convert.ToInt32(tarihHesap.TotalDays) * 1; //TotalDays ile hesaplanan tarihin gün sayısını elde ederek borç hesaplanır
                    
                    //Borç negatif yönlüyse bu "KİTAP DURUMU = BEKLEMEDE" olması halidir. Bu yüzden borç sıfırlanır yani ceza işlenmez
                    if (emanetler[i].BORC < 0)
                        emanetler[i].BORC = 0;

                    //Yeni cmd nesnesi oluşturulmazsa verilere aynı değeri atıyor
                    //Console.Write("calisti-");
                    OleDbCommand cmdUpdate = dbConnection.GetOleDbCommand();
                    cmdUpdate.CommandText = "UPDATE EMANET SET BORC=" + emanetler[i].BORC + " WHERE EMANET_NO=" + emanetler[i].EMANET_NO;

                    //İşlenen emanete borç güncellemesi yapılıyor
                    cmdUpdate.ExecuteNonQueryAsync();
                }
            } 
            
        }
    }
}
