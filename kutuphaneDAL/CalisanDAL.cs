using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kutuphaneEntity;
using System.Data.OleDb;
namespace kutuphaneDAL
{
    public class CalisanDAL
    {
        private DBConnection dbConnection;
        //Yapıcı metot ile bağlantı sağlanır
        public CalisanDAL()
        {
            dbConnection = new DBConnection();
        }
        //Çalışan(Personel) ekle metodu
        public void CalisanEkle(CalisanBilgileri calisan)
        {
            string cmdText = "INSERT INTO CALISAN_BILGILERI (CALISAN_TCKNO,CALISAN_SIFRE)";
            cmdText += String.Format(" VALUES ('{0}','{1}')",
                calisan.CALISAN_TCKNO,
                calisan.CALISAN_SIFRE
                );
            OleDbCommand cmd = dbConnection.GetOleDbCommand();
            cmd.CommandText = cmdText;

            cmd.ExecuteNonQuery();
        }

        //Login sayfasında girilen bilgileri aratır
        public CalisanBilgileri CalisanAra(CalisanBilgileri calisan)
        {
            OleDbCommand cmd = dbConnection.GetOleDbCommand();
            cmd.CommandText = "SELECT * FROM CALISAN_BILGILERI WHERE CALISAN_TCKNO='" + calisan.CALISAN_TCKNO + "' AND CALISAN_SIFRE='"+calisan.CALISAN_SIFRE+"'";

            OleDbDataReader rdr = cmd.ExecuteReader();
            
            while (rdr.Read())
            {
                calisan.CALISAN_NO = Convert.ToInt32(rdr["CALISAN_NO"]);
                calisan.CALISAN_TCKNO = rdr["CALISAN_TCKNO"].ToString();
                calisan.CALISAN_SIFRE = rdr["CALISAN_SIFRE"].ToString();
            }
            return calisan;
        }
        
        //Login sayfası için gerekli Çalışan No return eden bir metot
        public int CalisanAraNo(CalisanBilgileri calisan)
        {
            OleDbCommand cmd = dbConnection.GetOleDbCommand();
            cmd.CommandText = "SELECT CALISAN_NO FROM CALISAN_BILGILERI WHERE CALISAN_TCKNO='" + calisan.CALISAN_TCKNO + "' AND CALISAN_SIFRE='" + calisan.CALISAN_SIFRE + "'";

            OleDbDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                calisan.CALISAN_NO = Convert.ToInt32(rdr["CALISAN_NO"]);
            }
            return calisan.CALISAN_NO;
        }
    }
}
