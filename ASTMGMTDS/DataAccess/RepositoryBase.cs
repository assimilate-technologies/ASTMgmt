using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTMGMTDS.DataAccess
{
    public class RepositoryBase
    {
       public DataSet ExecuteSelects(string commandText, CommandType commandType, 
            SqlConnection sqlConnection,SqlParameterCollection sqlParameterCollection)
        {
            using (SqlCommand command = DataHelper.getCommand(commandText, commandType, sqlConnection))
            {
                if (sqlParameterCollection != null)
                {
                    foreach( SqlParameter parameter in sqlParameterCollection)
                    {
                        command.Parameters.Add(parameter);
                    }
                }
                DataSet ds = new DataSet();
                //todo need to think if this is right place to open connection
                if (command.Connection.State == ConnectionState.Closed) command.Connection.Open();
                DataHelper.getAdapter(command).Fill(ds);
                return ds;
            }
        }

        public DataTable ExecuteSelect(string commandText, CommandType commandType,
            SqlConnection sqlConnection, SqlParameterCollection sqlParameterCollection)
        {
            return ExecuteSelects(commandText, commandType,sqlConnection, 
                sqlParameterCollection).Tables[0];
        }
        public DataTable ExecuteNonQuery(string commandText, CommandType commandType,
            SqlConnection sqlConnection, SqlParameterCollection sqlParameterCollection)
        {
            return ExecuteSelects(commandText, commandType, sqlConnection,
                sqlParameterCollection).Tables[0];
        }


    }
}
