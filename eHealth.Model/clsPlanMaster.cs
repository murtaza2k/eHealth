using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHealth.Model
{
    class clsPlanMaster
    {
        public Int32 InsuranceID { get; set; }
        public string OrganisationCode { get; set; }
        public string PlanCode { get; set; }
        public string PlanName { get; set; }
        public bool IsEAuth { get; set; }
        public string PayerID { get; set; }
        public string Status { get; set; }
        public string UserID { get; set; }

    
        //   private SqlDataAdapter dapter = null;
        //     private DataSet dset = null;
        private bool result = false;
    }
}
