using ASTMGMTDS.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASTMGMTDS.Repositories;
using ASTMgmt.ViewModels;
using ASTMgmt.Mapper;
using System.Data.SqlClient;
using ASTMGMTDS.Interfaces;
using ASTMGMTDS.DataAccess;

namespace ASTMgmt.BusinessLogic
{
    public class StudentBL
    {
        public IEnumerable<Student> GetAll()
        {
            using (IUnitOfWork<SqlConnection, SqlTransaction> unitOfWork = new SQLUnitOfWork())
            {
                return new StudentRepository(unitOfWork).GetAll();
            }
        }
    }
}