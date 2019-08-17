using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASTMGMTDS.DataAccess;
using ASTMGMTDS.Entity;
using ASTMGMTDS.Interfaces;

namespace ASTMGMTDS.Repositories
{
    public class StudentRepository : RepositoryBase, IGenericRepository<Student,int>
    {
        IUnitOfWork<SqlConnection, SqlTransaction> _unitOfWork;
        public StudentRepository(IUnitOfWork<SqlConnection, SqlTransaction> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public int Add(Student t)
        {
            
                //SqlParameterCollection sqlParameterCollection = new SqlParameterCollection();
                //sqlParameterCollection.Add("@FirstName", SqlDbType.VarChar).Value = t.FirstName;
                //sqlParameterCollection.Add("@LastName", SqlDbType.VarChar).Value = t.LastName;

              return ExecuteNonQuery("sp_Add_Inquiry", CommandType.StoredProcedure, _unitOfWork.Connection, null);
                       
        }

        public void Delete(Student t)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetAll()
        {
            DataTable dt = ExecuteSelect("select * from tblStudent", CommandType.Text, _unitOfWork.Connection, null);
            List<Student> studentList = dt.AsEnumerable().Select(row => new Student()
            {
                studId = row.Field<int>("studId"),
                studName = row.Field<string>("studName"),
                studPhoneNo = row.Field<long>("studPhoneNo"),
                studEmail = row.Field<string>("studEmail"),
                studAadharCardNo = row.Field<long>("studAadharCardNo"),
                studPassport = row.Field<string>("studPassport"),
                studPanCardNo = row.Field<string>("studPanCardNo"),
                studCreatedBy = row.Field<string>("studCreatedBy"),
                studCreatedDate = row.Field<DateTime>("studCreatedDate"),
                studModifiedBy = row.Field<string>("studModifiedBy"),
                studModifiedDate = row.Field<DateTime>("studModifiedDate"),
                isDeleted = row.Field<Boolean>("isDeleted"),
                studDOB = row.Field<DateTime?>("studDOB") is DBNull ? null : row.Field<DateTime?>("studDOB")
            }).ToList();

            return studentList;
        }

        public IEnumerable<Student> GetAllPageWise(int PageIndex, int RecordPerPage)
        {
            throw new NotImplementedException();
        }

        public Student GetByID(Student t)
        {
            throw new NotImplementedException();
        }

        public void Update(Student t)
        {
            throw new NotImplementedException();
        }
    }
}
