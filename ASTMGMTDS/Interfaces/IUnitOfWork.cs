using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTMGMTDS.Interfaces
{
    public interface IUnitOfWork <c,t> : IDisposable 
    {

        void SaveChanges();
        void Rollback();

        c Connection {get; }
        t Transaction { get; }
    }

   }
