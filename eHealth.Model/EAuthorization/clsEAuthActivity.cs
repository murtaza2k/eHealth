using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHealth.Model
{
    class clsEAuthActivity : clsHISItemMaster
    {
        #region StartVariables
        public Int32 TransId { set; get; }
        public string VisitNo;
        public string AcitivityID { set; get; }
        public string ClinicianLicense { set; get; }
        public string Status { set; get; }
        public Int64 RequestQty { set; get; }
        public Decimal Rate { set; get; }
        public DateTime StartDate { set; get; }
        public Int64 ReceivedQty { set; get; }
        public string DenialCode { set; get; }
        public Decimal PatientShare { set; get; }

        public Decimal PaymentAmount { set; get; }
        public Decimal Net { set; get; }
        public Decimal List { set; get; }

        public List<clsEAuthObservation> Observation;

        public Decimal ApprovedAmount { set; get; }
        public Decimal DenialAmount { set; get; }
        public Decimal ApprovalCode { set; get; }




        public DateTime ApprovalReceivedDate { set; get; }
        public DateTime DenialReceiveDate { set; get; }

        public string Source { set; get; }

        // private string   _ServiceCode;
        // private string   _ServiceType;
        #endregion
    }
}
