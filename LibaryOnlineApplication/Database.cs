using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace LibaryOnlineApplication
{
    internal class Database
    {

        protected static string getStrConnection()
        {
            string strConnection = @"Data Source=DESKTOP-2I9J2G7\THANHTRIEU;Initial Catalog=LibaryOnline;Integrated Security=True";
            return strConnection;
        }

        public static SqlConnection getConnection()
        {
            string strConnection = Database.getStrConnection();
            SqlConnection conn = new SqlConnection(strConnection);
            return conn;
        }
    }
}
