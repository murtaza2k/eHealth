using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHealth.Model
{
   public class clsCategoryMaster
    {
        public string CategoryCode { get; set; }
        public string CategoryDescription { get; set; }
        public string IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDateTime { get; set; }


    }
}
