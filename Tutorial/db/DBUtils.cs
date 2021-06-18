using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Tutorial.db
{
    public class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = "DESKTOP-QHJ7A4Q";

            return DBSQLServerUtils.GetDBConnection(datasource);
        }
    }
}
