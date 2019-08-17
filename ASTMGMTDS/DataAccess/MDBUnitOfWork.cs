using ASTMGMTDS.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTMGMTDS.DataAccess
{
    class MDBUnitOfWork : IUnitOfWork<SqlConnection, SqlTransaction>
    {
        public SqlConnection Connection => throw new NotImplementedException();

        public SqlTransaction Transaction => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Rollback()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
