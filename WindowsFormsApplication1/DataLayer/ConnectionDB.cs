using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DataLayer
{
    public class ConnectionDB
    {
        public static string connstr
        {
            get
            {
                SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder(ConfigurationManager.ConnectionStrings["stg"].ConnectionString);
                sb.ConnectTimeout = (conntime > 0) ? conntime : sb.ConnectTimeout;
                sb.ApplicationName = (appname != null) ? appname : sb.ApplicationName;

                return sb.ToString();

            }

        }

        public static int conntime { get; set; }
        public static string appname { get; set; }

        public static SqlConnection getConnection()
        {
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            return conn;
        }
    }
}
