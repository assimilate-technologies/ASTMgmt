using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASTMgmt.ViewModels;
using ASTMGMTDS.Entity;


namespace ASTMgmt.Mapper
{
    public class StudentMapper
    {

        public Student GetStudent(InquiryViewModel inquiryViewModel)
        {
            return new Student
            {
                studId = inquiryViewModel.studId,
                studName = inquiryViewModel.studName,
                studPhoneNo = inquiryViewModel.studPhoneNo,
                studEmail = inquiryViewModel.studEmail,
                studAadharCardNo = inquiryViewModel.studAadharCardNo,
                studPassport = inquiryViewModel.studPassport,
                studPanCardNo = inquiryViewModel.studPanCardNo,
                studCreatedBy = inquiryViewModel.studCreatedBy,
                studCreatedDate = inquiryViewModel.studCreatedDate,
                studModifiedBy = inquiryViewModel.studModifiedBy,
                studModifiedDate = inquiryViewModel.studModifiedDate,
                isDeleted = inquiryViewModel.isDeleted,
                studDOB = inquiryViewModel.studDOB
            };
        }

    }
}