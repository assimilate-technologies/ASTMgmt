using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASTMgmt.ViewModels
{
    public class InquiryViewModel
    {
        public string Reference { get; set; }
        public string Course { get; set; }
        public int ID { get; set; }

        public int studId { get; set; }
        public string studName { get; set; }
        public long studPhoneNo { get; set; }
        public string studEmail { get; set; }
        public long studAadharCardNo { get; set; }
        public string studPassport { get; set; }
        public string studPanCardNo { get; set; }
        public string studCreatedBy { get; set; }
        public DateTime studCreatedDate { get; set; }
        public string studModifiedBy { get; set; }
        public DateTime studModifiedDate { get; set; }
        public bool isDeleted { get; set; }
        public DateTime? studDOB { get; set; }

    }
}