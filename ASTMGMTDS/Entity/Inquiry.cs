using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASTMGMTDS.Interfaces;

namespace ASTMGMTDS.Entity { 
    public class Inquiry:IEntity<int>
    {
        
        public string FirstName { get; set; }
        public string LastName  { get; set; }
        public string EmailID { get; set; }
        public string Mobile { get; set; }
        public string AlternateMobile { get; set; }
        public string AlternateEMail { get; set; }
        public string CurrentAcademicStandard { get; set; }
        public string AddressLine1{ get; set; }
        public string AddressLine2{ get; set; }
        public string AddressLine3{ get; set; }
        public string City { get; set; }
        public string Reference{ get; set; }
        public DateTime DateOfBirth { get; set; }
        public int ID { get ; set ; }
    }
}
