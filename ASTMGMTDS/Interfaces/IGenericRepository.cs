using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTMGMTDS.Interfaces
{
    interface IGenericRepository<T> where T: class
    {
        void Add(T t);
        void Update(T t);
        void Delete(T t);

        IEnumerable<T> GetAllPageWise(int PageIndex, int RecordPerPage);
        IEnumerable<T> GetAll();

        T GetByID(T t);

    }
}
