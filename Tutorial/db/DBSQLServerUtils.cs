using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Tutorial.db
{
    public class DBSQLServerUtils
    {
        public static SqlConnection
                 GetDBConnection(string datasource)
        {
            //
            // Data Source=DESKTOP-QHJ7A4Q;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
            //
            string connString = @"Data Source=" + datasource + ";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            SqlConnection conn = new SqlConnection(connString);

            return conn;
        }
    }
}
