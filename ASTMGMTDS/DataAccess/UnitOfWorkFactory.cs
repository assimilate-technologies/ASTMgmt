using ASTMGMTDS.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Web.Configuration;



namespace ASTMGMTDS.DataAccess
{
    public static class UnitOfWorkFactory
    {
        public static object GetIunitofwork()
        {
            if (WebConfigurationManager.AppSettings["PreferredDataBase"] == "SQL")
                return (IUnitOfWork < SqlConnection, SqlTransaction > ) new SQLUnitOfWork();

            return (IUnitOfWork<SqlConnection, SqlTransaction>)new MDBUnitOfWork();
        }
    }
}
