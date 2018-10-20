using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHealth.Model
{
    class clsInsuranceLogs
    {
        #region Variable Declaration


        private string _UserID = string.Empty;


        private int _TransId;
        private string _MRNNo;
        private string _PatientName;
        private int _DoctorId;
        private string _TransType;
        private DateTime _DateOfRequest;
        private string _CaseType;
        private DateTime _DateOfRequstIns;
        private DateTime _DateOfApproval;
        private int _InsuranceId;
        private DateTime _PatientInsuranceExpiry;
        private int _PhysiotherapistId;
        private int _ApprovedSession;
        private DateTime _ApprovedValidity;
        private int _SessionCompleted;
        private int _SessionPending;
        private string _UserEntryBy;
        private DateTime _DateOfEntry;
        private string _UserModifiedBy;
        private DateTime _DateOfMod;
        private string _Status;

        private string _ApprovalCode;
        private int _ServiceId;
        private Decimal _RequestedCost;
        private Decimal _DeinedCost;
        private Decimal _ApprovedCost;
        private DateTime _AddmissionDate;
        private DateTime _DischargeDate;
        private String _Comments;
        private DateTime _VisitDate;
        private int _ApprovedDays;
        private bool _IsAdmitted;
        private bool _Urgent;
        private bool _IsEAuth = false;

        private string _DRGCode = string.Empty;
        private string _DRGWeight = "0.00";

        private DateTime _BarcodeScanDateTime;


        private clsInsuranceLogs _ClsIns = null;
        private List<clsInsuranceLogs> _List = null;
        ////private List<clsInsuranceQuery> colInsuranceQuery;
        ////private List<clsInsuranceLogsDocuments> colInsuranceDocuments;
        ////private List<clsInsuranceServiceLogs> colInsuranceServiceLogs;

        ////private SqlConnection con = null;
        ////private SqlCommand com = null;
        ////private SqlTransaction trn = null;
        ////private SqlDataReader reader = null;
        ////private SqlDataAdapter dapter = null;
        ////private DataSet dset = null;
        ////private bool result = false;

        #endregion

        #region Property


        public int TransId
        {
            get { return _TransId; }
            set { _TransId = value; }
        }

        public string EnteredBy
        {
            get { return _UserEntryBy; }
            set { _UserEntryBy = value; }
        }

        public string MRNNo
        {
            get { return _MRNNo; }
            set { _MRNNo = value; }
        }

        public string PatientName
        {
            get { return _PatientName; }
            set { _PatientName = value; }
        }

        public Int32 DoctorId
        {
            get { return _DoctorId; }
            set { _DoctorId = value; }
        }

        public string TransType
        {
            get { return _TransType; }
            set { _TransType = value; }
        }


        public DateTime DateOfRequest
        {
            get { return _DateOfRequest; }
            set { _DateOfRequest = value; }
        }
        public DateTime PatientInsuranceExpiry
        {
            get { return _PatientInsuranceExpiry; }
            set { _PatientInsuranceExpiry = value; }
        }


        public string CaseType
        {
            get { return _CaseType; }
            set { _CaseType = value; }
        }


        public DateTime DateOfRequstIns
        {
            get { return _DateOfRequstIns; }
            set { _DateOfRequstIns = value; }
        }

        public DateTime DateOfApproval
        {
            get { return _DateOfApproval; }
            set { _DateOfApproval = value; }
        }


        public Int32 InsuranceId
        {
            get { return _InsuranceId; }
            set { _InsuranceId = value; }
        }


        public Int32 Physiotherapist
        {
            get { return _PhysiotherapistId; }
            set { _PhysiotherapistId = value; }
        }

        public Int32 ApprovedSession
        {
            get { return _ApprovedSession; }
            set { _ApprovedSession = value; }
        }

        public Int32 SessionCompleted
        {
            get { return _SessionCompleted; }
            set { _SessionCompleted = value; }
        }

        public Int32 SessionPending
        {
            get { return _SessionPending; }
            set { _SessionPending = value; }
        }



        public DateTime ApprovedValidity
        {
            get { return _ApprovedValidity; }
            set { _ApprovedValidity = value; }
        }


        public string UserID
        {
            get { return _UserID; }
            set { _UserID = value; }
        }

        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        public string ApprovalCode
        {
            get { return _ApprovalCode; }
            set { _ApprovalCode = value; }
        }

        public int ServiceId
        {
            get { return _ServiceId; }
            set { _ServiceId = value; }
        }

        public Decimal RequestedCost
        {
            get { return _RequestedCost; }
            set { _RequestedCost = value; }
        }
        public Decimal ApprovedCost
        {
            get { return _ApprovedCost; }
            set { _ApprovedCost = value; }
        }
        public Decimal DeinedCost
        {
            get { return _DeinedCost; }
            set { _DeinedCost = value; }
        }

        public DateTime AdmissionDate
        {
            get { return _AddmissionDate; }
            set { _AddmissionDate = value; }
        }

        public DateTime DischargeDate
        {
            get { return _DischargeDate; }
            set { _DischargeDate = value; }
        }

        public DateTime VisitDate
        {
            get { return _VisitDate; }
            set { _VisitDate = value; }
        }
        public string Comment
        {
            get { return _Comments; }
            set { _Comments = value; }
        }

        //public List<clsInsuranceQuery> InsuranceQuery
        //{
        //    get { return colInsuranceQuery; }
        //    set { colInsuranceQuery = value; }
        //}

        //public List<clsInsuranceLogsDocuments> InsuranceDocuments
        //{
        //    get { return colInsuranceDocuments; }
        //    set { colInsuranceDocuments = value; }
        //}

        //public List<clsInsuranceServiceLogs> InsuranceServices
        //{
        //    get { return colInsuranceServiceLogs; }
        //    set { colInsuranceServiceLogs = value; }
        //}

        public int ApprovedDays
        {
            get { return _ApprovedDays; }
            set { _ApprovedDays = value; }
        }
        //_IsAdmitted
        public bool IsAdmitted
        {
            get { return _IsAdmitted; }
            set { _IsAdmitted = value; }
        }
        public bool Urgent
        {
            get { return _Urgent; }
            set { _Urgent = value; }
        }

        public bool IsEAuth
        {
            get { return _IsEAuth; }
            set { _IsEAuth = value; }
        }

        public string DRGCode
        {
            get { return _DRGCode; }
            set { _DRGCode = value; }
        }
        public string DRGWeight
        {
            get { return _DRGWeight; }
            set { _DRGWeight = value; }
        }
        public DateTime BarcodeScanDateTime
        {
            get { return _BarcodeScanDateTime; }
            set { _BarcodeScanDateTime = value; }
        }


        #endregion

    }
}
