using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHealth.Model
{
    class clsEauthAuthorization
    {
        #region StartVariables

        private Int32 _TransId;
        private string _VisitNumber;
        private clsEAuthEnums.AuthorizationType _AuthorizationType;
        private string _ReferenceNumber;
        private string _MemberId;
        private string _PayerID;
        private string _PayerCode;
        private string _EmiratesId;
        private DateTime _DateOrdered;
        private string _SenderID;
        private string _ResultStatus;
        private string _PayerComment;
        private string _StartDate;
        private string _EndDate;
        private string _FacilityId;
        private string _DenialCode;
        private string _IDPayer;

        public clsEAuthEncounter eAuthEncounter;
        public List<clsEAuthDiagosisDetails> eAuthDiagnosisDetails;
        public List<clsEAuthActivity> eAuthActivity;

        #endregion


        public string ResultStatus
        {
            get { return _ResultStatus; }
            set { _ResultStatus = value; }
        }

        public string PayerComment
        {
            get { return _PayerComment; }
            set { _PayerComment = value; }
        }
        public string SenderID
        {
            get { return _SenderID; }
            set { _SenderID = value; }
        }
        public Int32 TransID
        {
            get { return _TransId; }
            set { _TransId = value; }
        }
        public string VisitNumber
        {
            get { return _VisitNumber; }
            set { _VisitNumber = value; }
        }
        public clsEAuthEnums.AuthorizationType AuthorizationType
        {
            get { return _AuthorizationType; }
            set { _AuthorizationType = value; }
        }

        public string ReferenceNumber
        {
            get { return _ReferenceNumber; }
            set { _ReferenceNumber = value; }
        }

        public string MemberId
        {
            get { return _MemberId; }
            set { _MemberId = value; }
        }

        public string PayerID
        {
            get { return _PayerID; }
            set { _PayerID = value; }
        }
        public string EmiratesId
        {
            get { return _EmiratesId; }
            set { _EmiratesId = value; }
        }
        public DateTime DateOrdered
        {
            get { return _DateOrdered; }
            set { _DateOrdered = value; }
        }
        public string PlanCode
        {
            get { return _PayerCode; }
            set { _PayerCode = value; }
        }
        public string StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }
        public string EndDate
        {
            get { return _EndDate; }
            set { _EndDate = value; }
        }
        public string ApprovalLocation
        {
            get { return _FacilityId; }
            set { _FacilityId = value; }
        }
        public string DenialCode
        {
            get { return _DenialCode; }
            set { _DenialCode = value; }
        }
        public string IDPayer
        {
            get { return _IDPayer; }
            set { _IDPayer = value; }
        }
    }
}
