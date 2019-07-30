using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASTMGMTDS.Interfaces;

namespace ASTMGMTDS.DataAccess
{
    class UnitOfWork : IUnitOfWork ,IDisposable
    {
        SqlTransaction _transation;
        private bool disposed = false;
        public UnitOfWork()
        {
            _transation = DataHelper.getSqlconnection().BeginTransaction();
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
                    // TO DO: clean up managed objects
                }

                // TO DO: clean up unmanaged objects

                disposed = true;
            }
        }
    }
}
