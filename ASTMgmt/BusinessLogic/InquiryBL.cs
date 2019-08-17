
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASTMGMTDS.Entity;
using ASTMGMTDS.Repositories;
using ASTMgmt.ViewModels;
using ASTMgmt.Mapper;
using System.Data.SqlClient;
using ASTMGMTDS.Interfaces;
using ASTMGMTDS.DataAccess;
namespace ASTMgmt.BusinessLogic
{
    public class InquiryBL
    {
        void AddInquiry(InquiryViewModel inquiryViewModel)
        {
            using (IUnitOfWork<SqlConnection, SqlTransaction> unitOfWork = new SQLUnitOfWork())
            {
                inquiryViewModel.studId = new StudentRepository(unitOfWork).Add(new StudentMapper().GetStudent(inquiryViewModel));
                
                new InquiryRepository(unitOfWork).Add(new InquiryMapper().GetInquiry(inquiryViewModel));

                unitOfWork.SaveChanges();
            }
        }
    }
}