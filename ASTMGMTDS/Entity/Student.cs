using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTMGMTDS.Entity
{
    public class Student
    {
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
