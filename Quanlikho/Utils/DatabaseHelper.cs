using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlikho.Utils
{
    internal class DatabaseHelper
    {
        public static String serverName ;
        public static String dbName;
        public static String userDb;
        public static String password;
        public static SqlConnection getConnection()
        {
            String strCnn = "server =" + serverName +
                "; Initial Catalog =" + dbName +
                "; uid = " + userDb +
                "; pwd =" + password;
            return new SqlConnection(strCnn);

        }

    }
}
