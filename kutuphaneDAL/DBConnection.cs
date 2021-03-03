using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
namespace kutuphaneDAL
{
    public class DBConnection
    {
        private readonly string _connectionString;
        public DBConnection()
        {
            //DB path
            _connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kutuphaneDB.accdb";
        }

        //Bağlantıyı kurar
        private OleDbConnection GetDBConnection()
        {
            OleDbConnection cnn = new OleDbConnection(_connectionString);
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
                cnn.Open();
            }
            else
            {
                cnn.Open();
            }
            return cnn;
        }

        //Sorgu için gerekli bağlantıyı sağlar
        public OleDbCommand GetOleDbCommand()
        {
            //Sorgu komut nesnesi oluşturur
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = GetDBConnection();
            return cmd;
        }
    }
}
