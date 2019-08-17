using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASTMGMTDS.Interfaces;

namespace ASTMGMTDS.Entity { 
    public class Inquiry:IEntity<int>
    {
        
     
        public string Reference{ get; set; }
        public string Course{ get; set; }
        public int StudId{ get; set; }

        public int ID { get ; set ; }

    }
}
