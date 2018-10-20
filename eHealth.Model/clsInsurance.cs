using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHealth.Model
{
    class clsInsurance
    {

        #region Variable Declaration
        private Int32 _InsuranceId = 0;
        private string _InsuranceName = string.Empty;
        private string _ContactMode = string.Empty;
        private string _ContactNo = string.Empty;
        private string _FaxNo = string.Empty;
        private string _EmailAddress = string.Empty;
        private int _OPCaseValidity = 0;


        private string _OrganisationCode = string.Empty;
        private bool _IsEAuth = false;
        private string _ReceiverID = string.Empty;
        private bool _IsRequiredInternalCode = false;

        private string _Status = "Y";
        private string _UserID = string.Empty;

        private clsInsurance _ClsPosition = null;
        private List<clsInsurance> _List = null;


        #endregion

        #region Property

        public Int32 InsuranceId
        {
            get { return _InsuranceId; }
            set { _InsuranceId = value; }
        }

        public string InsuranceName
        {
            get { return _InsuranceName; }
            set { _InsuranceName = value; }
        }



        public string ContactMode
        {
            get { return _ContactMode; }
            set { _ContactMode = value; }
        }

        public string ContactNo
        {
            get { return _ContactNo; }
            set { _ContactNo = value; }
        }
        public string FaxNo
        {
            get { return _FaxNo; }
            set { _FaxNo = value; }
        }
        public string EmailAddress
        {
            get { return _EmailAddress; }
            set { _EmailAddress = value; }
        }


        public Int32 OPCaseValidity
        {
            get { return _OPCaseValidity; }
            set { _OPCaseValidity = value; }
        }

        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }


        public string UserID
        {
            get { return _UserID; }
            set { _UserID = value; }
        }

        public string OrganisationCode
        {
            get { return _OrganisationCode; }
            set { _OrganisationCode = value; }
        }



        public string ReceiverId
        {
            get { return _ReceiverID; }
            set { _ReceiverID = value; }
        }

        public bool IsEAuth
        {
            get { return _IsEAuth; }
            set { _IsEAuth = value; }
        }

        //_IsRequiredInternalCode

        public bool IsRequiredInternalCode
        {
            get { return _IsRequiredInternalCode; }
            set { _IsRequiredInternalCode = value; }
        }

        #endregion
    }
}
