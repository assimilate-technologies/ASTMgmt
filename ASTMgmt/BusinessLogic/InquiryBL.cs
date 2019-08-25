
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
using System.Web.Http.ModelBinding;
using System.Net.Http;
using System.Net;

namespace ASTMgmt.BusinessLogic
{
    public class InquiryBL
    {
        internal InquiryViewModel AddInquiry(InquiryViewModel inquiryViewModel)
        {
            using (IUnitOfWork<SqlConnection, SqlTransaction> unitOfWork = new SQLUnitOfWork())
            {
                inquiryViewModel.studId = new StudentRepository(unitOfWork).Add(new StudentMapper().GetStudent(inquiryViewModel));

                inquiryViewModel.ID = new InquiryRepository(unitOfWork).Add(new InquiryMapper().GetInquiry(inquiryViewModel));

                unitOfWork.SaveChanges();
            }
            if (inquiryViewModel.studId.ToString().Trim() == string.Empty || inquiryViewModel.ID.ToString().Trim() == string.Empty)
            {
                inquiryViewModel.RequestMessage.CreateErrorResponse(HttpStatusCode.InternalServerError, "Input data not a valid data");
            }
            return inquiryViewModel;
        }

        internal InquiryViewModel CreateDataNotValidResponse(ModelStateDictionary modelState, InquiryViewModel inquiryViewModel)
        {
             inquiryViewModel.RequestMessage.CreateErrorResponse(HttpStatusCode.InternalServerError, "Input data not a valid data");
            return inquiryViewModel;
        }
    }
}