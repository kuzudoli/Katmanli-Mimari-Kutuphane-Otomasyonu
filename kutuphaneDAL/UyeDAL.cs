using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kutuphaneEntity;
using System.Data.OleDb;
namespace kutuphaneDAL
{
    public class UyeDAL
    {
        private DBConnection dbConnection;
        //Yapıcı metot ile bağlantı kuruluyor
        public UyeDAL()
        {
            dbConnection = new DBConnection();
        }

        //Tüm üyelerin listesini return eder
        public List<Uye> TumUyeleriListele()
        {
            OleDbCommand cmd = dbConnection.GetOleDbCommand();
            cmd.CommandText = "SELECT *FROM UYE";

            List<Uye> uyeler = new List<Uye>();
            //DataReader oluşturularak kolon adları yardımıyla veriler okunarak bir listede tutuluyor ve return ediliyor
            OleDbDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Uye uye = new Uye();
                uye.UYE_TCKNO = rdr["UYE_TCKNO"].ToString();
                uye.UYE_AD = rdr["UYE_AD"].ToString();
                uye.UYE_SOYAD = rdr["UYE_SOYAD"].ToString();
                uye.CINSIYET = rdr["CINSIYET"].ToString();
                uye.DOGUM_TARIHI = rdr["DOGUM_TARIHI"].ToString();
                uye.TELEFON = rdr["TELEFON"].ToString();
                uye.EMAIL = rdr["EMAIL"].ToString();

                uyeler.Add(uye);
            }
            return uyeler;
        }

        //Üye TCKNO ile üye arama metodu
        public List<Uye> UyeAra(Uye uye)
        {
            OleDbCommand cmd = dbConnection.GetOleDbCommand();
            cmd.CommandText = "SELECT *FROM UYE WHERE UYE_TCKNO='" + uye.UYE_TCKNO + "'"; //String parametreler sorgu sırasında tırnak içinde yazılmalıdır

            List<Uye> yeniUye = new List<Uye>();
            OleDbDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                uye.UYE_TCKNO = rdr["UYE_TCKNO"].ToString();
                uye.UYE_AD = rdr["UYE_AD"].ToString();
                uye.UYE_SOYAD = rdr["UYE_SOYAD"].ToString();
                uye.CINSIYET = rdr["CINSIYET"].ToString();
                uye.DOGUM_TARIHI = rdr["DOGUM_TARIHI"].ToString();
                uye.TELEFON = rdr["TELEFON"].ToString();
                uye.EMAIL = rdr["EMAIL"].ToString();

                yeniUye.Add(uye);
            }
            return yeniUye;
        }

        //Üye TCKNO ile üye arama metodu
        //Nesne aktarma işleminde kullanılmak için yazılmıştır
        public Uye UyeAra2(Uye uye)
        {
            OleDbCommand cmd = dbConnection.GetOleDbCommand();
            cmd.CommandText = "SELECT *FROM UYE WHERE UYE_TCKNO='" + uye.UYE_TCKNO + "'";

            OleDbDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                uye.UYE_TCKNO = rdr["UYE_TCKNO"].ToString();
                uye.UYE_AD = rdr["UYE_AD"].ToString();
                uye.UYE_SOYAD = rdr["UYE_SOYAD"].ToString();
                uye.CINSIYET = rdr["CINSIYET"].ToString();
                uye.DOGUM_TARIHI = rdr["DOGUM_TARIHI"].ToString();
                uye.TELEFON = rdr["TELEFON"].ToString();
                uye.EMAIL = rdr["EMAIL"].ToString();
            }
            return uye;
        }

        //Yeni üye kaydı oluşturur
        public void UyeEkle(Uye uye)
        {
            string cmdText = "INSERT INTO UYE (UYE_TCKNO,UYE_AD,UYE_SOYAD,CINSIYET,DOGUM_TARIHI,TELEFON,EMAIL)";
            //String.Format yardımıyla parametreler sayı ile belirtilerek düzen oluşturulur
            cmdText += String.Format(" VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                uye.UYE_TCKNO,
                uye.UYE_AD,
                uye.UYE_SOYAD,
                uye.CINSIYET,
                uye.DOGUM_TARIHI,
                uye.TELEFON,
                uye.EMAIL
                );
            OleDbCommand cmd = dbConnection.GetOleDbCommand();
            cmd.CommandText = cmdText;

            cmd.ExecuteNonQuery();
        }

        //Üye kaydı siler
        public void UyeSil(Uye uye)
        {
            OleDbCommand cmd = dbConnection.GetOleDbCommand();
            cmd.CommandText = String.Format("DELETE FROM UYE WHERE UYE_TCKNO='" + uye.UYE_TCKNO+"'");

            cmd.ExecuteNonQuery();
        }

        //Üye kaydı günceller
        public void UyeGuncelle(Uye uye)
        {
            OleDbCommand cmd = dbConnection.GetOleDbCommand();
            cmd.CommandText = "UPDATE UYE SET UYE_AD=@ad, UYE_SOYAD=@soyad,CINSIYET=@cinsiyet,DOGUM_TARIHI=@dogumTarihi,TELEFON=@telefon,EMAIL=@email WHERE UYE_TCKNO='"+uye.UYE_TCKNO+"'";
            //AddWithValue ile 6 parametreyi cmd nesnemize ekledik, böylece sorgu çalıştığında kullanılabilecek            
            cmd.Parameters.AddWithValue("@ad", uye.UYE_AD);
            cmd.Parameters.AddWithValue("@soyad", uye.UYE_SOYAD);
            cmd.Parameters.AddWithValue("@cinsiyet", uye.CINSIYET);
            cmd.Parameters.AddWithValue("@dogumTarihi", uye.DOGUM_TARIHI);
            cmd.Parameters.AddWithValue("@telefon", uye.TELEFON);
            cmd.Parameters.AddWithValue("@email", uye.EMAIL);

            cmd.ExecuteNonQuery();
        }

    }
}
