using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASTMGMTDS.Interfaces;

namespace ASTMGMTDS.DataAccess
{
    public class SQLUnitOfWork : IUnitOfWork<SqlConnection, SqlTransaction>
    {
        SqlTransaction _transation;
        SqlConnection _Connection;
        private bool disposed = false;

        public SqlConnection Connection { get => _Connection;  }
        public SqlTransaction Transaction { get => _transation;  }

        public SQLUnitOfWork()
        {
            _Connection = DataHelper.getSqlconnection();
            _transation = _Connection.BeginTransaction();
        }
        

        public void SaveChanges()
        {
            _transation.Commit();
        }

        public void Rollback()
        {
            _transation.Rollback();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    if (_transation != null)  _transation.Rollback();                    
                    _transation.Dispose();
                    _Connection.Dispose();
                    _transation  = null;
                    _Connection = null;
                }

                // TO DO: clean up unmanaged objects

                disposed = true;
            }
        }
    }
}
