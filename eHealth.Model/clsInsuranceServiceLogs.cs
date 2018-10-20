using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHealth.Model
{
    class clsInsuranceServiceLogs : clsServiceMaster
    {
        private Int32 _InsuranceId;
        public Int32 TransId
        {
            get { return _InsuranceId; }
            set { _InsuranceId = value; }
        }
        private bool _RequestedtoInsurance;
        public bool RequestToInsurance
        {
            get { return _RequestedtoInsurance; }
            set { _RequestedtoInsurance = value; }
        }

        private bool _Approved;
        public bool Approved
        {
            get { return _Approved; }
            set { _Approved = value; }
        }

        private bool _Denied;  //DENIED

        public bool Denied
        {
            get { return _Denied; }
            set { _Denied = value; }
        }

        private bool _PartiallyApproved;

        public bool PartiallyApproved
        {
            get { return _PartiallyApproved; }
            set { _PartiallyApproved = value; }
        }
    
    }
}
