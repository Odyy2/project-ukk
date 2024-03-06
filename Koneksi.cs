using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1
using System.Data.SqlClient;
namespace AppKasir
{
    internal class Koneksi
    {
        //2
        public SqlConnection GetConn()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = "Data source=COE17;initial catalog=Aplikasi_Kasir" +
                "; integrated security=true";
            return Conn;
        }

    }
}
