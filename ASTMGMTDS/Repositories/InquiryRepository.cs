using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASTMGMTDS.Entity;
using ASTMGMTDS.Interfaces;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using ASTMGMTDS.DataAccess;

namespace ASTMGMTDS.Repositories
{
    public class InquiryRepository : RepositoryBase, IGenericRepository<Inquiry,int>
    {
        IUnitOfWork<SqlConnection, SqlTransaction> _unitOfWork;
        public InquiryRepository(IUnitOfWork<SqlConnection,SqlTransaction> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public int Add(Inquiry t)
        {
                //SqlParameterCollection sqlParameterCollection = new SqlParameterCollection();
                //sqlParameterCollection.Add("@FirstName", SqlDbType.VarChar).Value = t.FirstName;
                //sqlParameterCollection.Add("@LastName", SqlDbType.VarChar).Value = t.LastName;

             return ExecuteNonQuery("sp_Add_Inquiry", CommandType.StoredProcedure, _unitOfWork.Connection, null);                         
        }

        public void Delete(Inquiry t)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Inquiry> GetAll()
        {
           DataTable dt= ExecuteSelect("getAllInquiry", CommandType.StoredProcedure, DataHelper.getSqlconnection(),null);
            var inquiryList = new List<Inquiry>();
            return inquiryList;
        }

        public IEnumerable<Inquiry> GetAllPageWise(int PageIndex, int RecordPerPage)
        {
            throw new NotImplementedException();
        }

        public Inquiry GetByID(Inquiry t)
        {
            throw new NotImplementedException();
        }

        public void Update(Inquiry t)
        {
            throw new NotImplementedException();
        }

       
       
    }
}
