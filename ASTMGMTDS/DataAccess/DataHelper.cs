using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;


namespace ASTMGMTDS.DataAccess
{
    static class DataHelper
    {
        public static SqlConnection getSqlconnection()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["DTAppCon"].ConnectionString);

        }

        public static SqlCommand getCommand(string commandText, CommandType commandType,SqlConnection sqlConnection)
        {
            return new SqlCommand
            {
                CommandText = commandText,
                Connection = sqlConnection,
                CommandType = commandType
            };
        }

        public static SqlDataAdapter getAdapter(SqlCommand sqlCommand)
        {
            return new SqlDataAdapter(sqlCommand);
        }
    }

    
}
