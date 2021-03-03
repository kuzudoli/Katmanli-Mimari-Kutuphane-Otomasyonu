using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using kutuphaneEntity;
namespace kutuphaneDAL
{
    public class KitapDAL
    {
        private DBConnection dbConnection;
        //Yapıcı metot ile bağlantı kuruluyor
        public KitapDAL()
        {
            dbConnection = new DBConnection();
        }

        //Tüm kitapların listesini return eder
        public List<Kitap> TumKitaplarıListele()
        {
            OleDbCommand cmd = dbConnection.GetOleDbCommand();
            cmd.CommandText = "SELECT * FROM KITAP";

            List<Kitap> kitaplar = new List<Kitap>();
            //DataReader oluşturularak kolon adları yardımıyla veriler okunarak bir listede tutuluyor ve return ediliyor
            OleDbDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Kitap kitap = new Kitap();
                kitap.KITAP_NO = Convert.ToInt32(rdr["KITAP_NO"]);
                kitap.KITAP_ADI = rdr["KITAP_ADI"].ToString();
                kitap.KITAP_YAZAR = rdr["KITAP_YAZAR"].ToString();
                kitap.TUR = rdr["TUR"].ToString();
                kitap.SAYFA_SAYISI = rdr["SAYFA_SAYISI"].ToString();
                kitap.BASIM_YILI = rdr["BASIM_YILI"].ToString();
                kitap.KITAP_YAYINEVI = rdr["KITAP_YAYINEVI"].ToString();
                kitap.KITAP_DURUMU = rdr["KITAP_DURUMU"].ToString();

                kitaplar.Add(kitap);
            }
            return kitaplar;
        }

        //Tüm emanet alınmaya hazır kitapların listesini return eder
        public List<Kitap> HazırKitaplariListele()
        {
            OleDbCommand cmd = dbConnection.GetOleDbCommand();
            cmd.CommandText = "SELECT * FROM KITAP WHERE KITAP_DURUMU='HAZIR'";

            List<Kitap> kitaplar = new List<Kitap>();
            //DataReader oluşturularak kolon adları yardımıyla veriler okunarak bir listede tutuluyor ve return ediliyor
            OleDbDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Kitap kitap = new Kitap();
                kitap.KITAP_NO = Convert.ToInt32(rdr["KITAP_NO"]);
                kitap.KITAP_ADI = rdr["KITAP_ADI"].ToString();
                kitap.KITAP_YAZAR = rdr["KITAP_YAZAR"].ToString();
                kitap.TUR = rdr["TUR"].ToString();
                kitap.SAYFA_SAYISI = rdr["SAYFA_SAYISI"].ToString();
                kitap.BASIM_YILI = rdr["BASIM_YILI"].ToString();
                kitap.KITAP_YAYINEVI = rdr["KITAP_YAYINEVI"].ToString();

                kitaplar.Add(kitap);
            }
            return kitaplar;
        }

        //Kitap Adı ile arama
        public List<Kitap> KitapAra(Kitap kitap1)
        {
            OleDbCommand cmd = dbConnection.GetOleDbCommand();
            cmd.CommandText = "SELECT * FROM KITAP WHERE KITAP_ADI='" + kitap1.KITAP_ADI + "'";

            List<Kitap> kitaplar = new List<Kitap>();
            //DataReader oluşturularak kolon adları yardımıyla veriler okunarak bir listede tutuluyor ve return ediliyors
            OleDbDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Kitap kitap = new Kitap();
                kitap.KITAP_NO = Convert.ToInt32(rdr["KITAP_NO"]);
                kitap.KITAP_ADI = rdr["KITAP_ADI"].ToString();
                kitap.KITAP_YAZAR = rdr["KITAP_YAZAR"].ToString();
                kitap.TUR = rdr["TUR"].ToString();
                kitap.SAYFA_SAYISI = rdr["SAYFA_SAYISI"].ToString();
                kitap.BASIM_YILI = rdr["BASIM_YILI"].ToString();
                kitap.KITAP_YAYINEVI = rdr["KITAP_YAYINEVI"].ToString();
                kitap.KITAP_DURUMU = rdr["KITAP_DURUMU"].ToString();

                kitaplar.Add(kitap);
            }
            return kitaplar;
        }
        
        //Kitap No ile arama (Tek kitap döneceği için liste yerine Kitap nesnesi tercih edildi)
        public Kitap KitapAraNo(Kitap kitap)
        {
            OleDbCommand cmd = dbConnection.GetOleDbCommand();
            cmd.CommandText = "SELECT * FROM KITAP WHERE KITAP_NO=" + kitap.KITAP_NO;
            //DataReader oluşturularak kolon adları yardımıyla veriler okunarak nesneye aktarılıyor ve nesne return ediliyor
            OleDbDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                kitap.KITAP_NO = Convert.ToInt32(rdr["KITAP_NO"]);
                kitap.KITAP_ADI = rdr["KITAP_ADI"].ToString();
                kitap.KITAP_YAZAR = rdr["KITAP_YAZAR"].ToString();
                kitap.TUR = rdr["TUR"].ToString();
                kitap.SAYFA_SAYISI = rdr["SAYFA_SAYISI"].ToString();
                kitap.BASIM_YILI = rdr["BASIM_YILI"].ToString();
                kitap.KITAP_YAYINEVI = rdr["KITAP_YAYINEVI"].ToString();
                kitap.KITAP_DURUMU = rdr["KITAP_DURUMU"].ToString();
            }
            return kitap;
        }

        //Yazar Adı ile arama
        public List<Kitap> KitapAraYazar(Kitap kitap1)
        {
            OleDbCommand cmd = dbConnection.GetOleDbCommand();
            cmd.CommandText = "SELECT * FROM KITAP WHERE KITAP_YAZAR='" + kitap1.KITAP_YAZAR + "'";

            List<Kitap> kitaplar = new List<Kitap>();
            //DataReader oluşturularak kolon adları yardımıyla veriler okunarak bir listede tutuluyor ve return ediliyor
            OleDbDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Kitap kitap = new Kitap();
                kitap.KITAP_NO = Convert.ToInt32(rdr["KITAP_NO"]);
                kitap.KITAP_ADI = rdr["KITAP_ADI"].ToString();
                kitap.KITAP_YAZAR = rdr["KITAP_YAZAR"].ToString();
                kitap.TUR = rdr["TUR"].ToString();
                kitap.SAYFA_SAYISI = rdr["SAYFA_SAYISI"].ToString();
                kitap.BASIM_YILI = rdr["BASIM_YILI"].ToString();
                kitap.KITAP_YAYINEVI = rdr["KITAP_YAYINEVI"].ToString();
                kitap.KITAP_DURUMU = rdr["KITAP_DURUMU"].ToString();

                kitaplar.Add(kitap);
            }
            return kitaplar;
        }

        //Yayinevi ile arama
        public List<Kitap> KitapAraYayinevi(Kitap kitap1)
        {
            OleDbCommand cmd = dbConnection.GetOleDbCommand();
            cmd.CommandText = "SELECT * FROM KITAP WHERE KITAP_YAYINEVI='" + kitap1.KITAP_YAYINEVI + "'";

            List<Kitap> kitaplar = new List<Kitap>();
            //DataReader oluşturularak kolon adları yardımıyla veriler okunarak bir listede tutuluyor ve return ediliyor
            OleDbDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Kitap kitap = new Kitap();
                kitap.KITAP_NO = Convert.ToInt32(rdr["KITAP_NO"]);
                kitap.KITAP_ADI = rdr["KITAP_ADI"].ToString();
                kitap.KITAP_YAZAR = rdr["KITAP_YAZAR"].ToString();
                kitap.TUR = rdr["TUR"].ToString();
                kitap.SAYFA_SAYISI = rdr["SAYFA_SAYISI"].ToString();
                kitap.BASIM_YILI = rdr["BASIM_YILI"].ToString();
                kitap.KITAP_YAYINEVI = rdr["KITAP_YAYINEVI"].ToString();
                kitap.KITAP_DURUMU = rdr["KITAP_DURUMU"].ToString();

                kitaplar.Add(kitap);
            }
            return kitaplar;
        }

        //Yeni kitap kaydı oluşturur
        public void KitapEkle(Kitap kitap)
        {
            string cmdText = "INSERT INTO KITAP (KITAP_ADI,KITAP_YAZAR,TUR,SAYFA_SAYISI,BASIM_YILI,KITAP_YAYINEVI,KITAP_DURUMU)";
            //String.Format yardımıyla parametreler sayı ile belirtilerek düzen oluşturulur
            cmdText += String.Format(" VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                kitap.KITAP_ADI,
                kitap.KITAP_YAZAR,
                kitap.TUR,
                kitap.SAYFA_SAYISI,
                kitap.BASIM_YILI,
                kitap.KITAP_YAYINEVI,
                kitap.KITAP_DURUMU
                );
            OleDbCommand cmd = dbConnection.GetOleDbCommand();
            cmd.CommandText = cmdText;

            cmd.ExecuteNonQuery();
        }

        //Kitap No ile kitap kaydı siler
        public void KitapSil(Kitap kitap)
        {
            OleDbCommand cmd = dbConnection.GetOleDbCommand();
            cmd.CommandText = String.Format("DELETE FROM KITAP WHERE KITAP_NO=" + kitap.KITAP_NO);

            cmd.ExecuteNonQuery();
        }

        //Kitap No ile kitap bilgilerini günceller
        public void KitapGuncelle(Kitap kitap)
        {
            OleDbCommand cmd = dbConnection.GetOleDbCommand();
            cmd.CommandText = "UPDATE KITAP SET KITAP_ADI=@ad,KITAP_YAZAR=@yazarAdi,TUR=@tur,SAYFA_SAYISI=@sayfa, BASIM_YILI=@basimYili,KITAP_YAYINEVI=@yayineviAdi WHERE KITAP_NO=" + kitap.KITAP_NO;
            //AddWithValue ile 6 parametreyi cmd nesnemize ekledik, böylece sorgu çalıştığında kullanılabilecek
            cmd.Parameters.AddWithValue("@ad", kitap.KITAP_ADI);
            cmd.Parameters.AddWithValue("@yazarAdi", kitap.KITAP_YAZAR);
            cmd.Parameters.AddWithValue("@tur", kitap.TUR);
            cmd.Parameters.AddWithValue("@sayfa", kitap.SAYFA_SAYISI);
            cmd.Parameters.AddWithValue("@basimYili", kitap.BASIM_YILI);
            cmd.Parameters.AddWithValue("@yayineviAdi", kitap.KITAP_YAYINEVI);

            cmd.ExecuteNonQuery();
        }

        //Grafik Paneli için gerekli hesaplamalar
        public void GrafikHesap(Kitap kitap)
        {
            OleDbCommand cmd = dbConnection.GetOleDbCommand();
            cmd.CommandText = "SELECT KITAP_ADI FROM KITAP";
            //Kitap adlarını sayarak toplam kitap sayısını elde ediyor
            List<Kitap> kitaplar = new List<Kitap>();
            OleDbDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Kitap kitapoku = new Kitap();
                kitapoku.KITAP_ADI = rdr["KITAP_ADI"].ToString();
                kitaplar.Add(kitapoku);
            }
            rdr.Close();

            for (int i = 0; i < kitaplar.Count; i++)
            {
                //Toplam sayı arttırılıyor
                kitap.ToplamKitap = kitap.ToplamKitap + 1;
            }

            ///////////////////////////////////////////////////////////

            OleDbCommand cmd2 = dbConnection.GetOleDbCommand();
            cmd2.CommandText = "SELECT KITAP_DURUMU FROM KITAP";

            List<Kitap> kitaplar2 = new List<Kitap>();
            OleDbDataReader rdr2 = cmd2.ExecuteReader();
            while (rdr2.Read())
            {
                Kitap kitapoku2 = new Kitap();
                kitapoku2.KITAP_DURUMU = rdr2["KITAP_DURUMU"].ToString();
                //Verilmeye hazır kitapların sayısı elde ediliyor
                if (kitapoku2.KITAP_DURUMU == "HAZIR")
                {

                    kitap.HazirKitapSayisi = kitap.HazirKitapSayisi + 1;
                }
                kitaplar2.Add(kitapoku2);
            }
            rdr2.Close();

            ////////////////////////////////////////////////////////////

            OleDbCommand cmd3 = dbConnection.GetOleDbCommand();
            cmd3.CommandText = "SELECT KITAP_DURUMU FROM KITAP";

            List<Kitap> kitaplar3 = new List<Kitap>();
            OleDbDataReader rdr3 = cmd3.ExecuteReader();
            while (rdr3.Read())
            {
                Kitap kitapoku3 = new Kitap();
                kitapoku3.KITAP_DURUMU = rdr3["KITAP_DURUMU"].ToString();
                //Emanette (verilmiş) olan kitapların sayısı elde ediliyor
                if (kitapoku3.KITAP_DURUMU == "EMANETTE")
                {
                    kitap.HazirOlmayanKitapSayisi = kitap.HazirOlmayanKitapSayisi + 1;
                }
                kitaplar3.Add(kitapoku3);
            }
            rdr3.Close();
        }
    }
}
