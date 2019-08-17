using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASTMgmt.ViewModels;
using ASTMGMTDS.Entity;




namespace ASTMgmt.Mapper
{
    public class InquiryMapper
    {
        public Inquiry GetInquiry(InquiryViewModel inquiryViewModel)
        {
            return new Inquiry
            {
                Reference = inquiryViewModel.Reference,
                Course = inquiryViewModel.Course,
                StudId = inquiryViewModel.studId,
                ID = inquiryViewModel.ID
            };
        }
    }
}