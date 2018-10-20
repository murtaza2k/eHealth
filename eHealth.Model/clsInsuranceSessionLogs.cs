using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHealth.Model
{
    class clsInsuranceSessionLogs
    {

        #region Variable Declaration


        private string _UserID = string.Empty;
        private int _TransId;
        private string _MRNNo;
        private int _CurrentSession;
        private DateTime _SessionDate;
        private string _UserEntryBy;
        private DateTime _DateOfEntry;
        private string _UserModifiedBy;
        private DateTime _DateOfMod;
        private string _Status;




        private clsInsuranceSessionLogs _ClsIns = null;
        private List<clsInsuranceSessionLogs> _List = null;

        private bool result = false;

        #endregion

        #region Property


        public int TransId
        {
            get { return _TransId; }
            set { _TransId = value; }
        }


        public string MRNNo
        {
            get { return _MRNNo; }
            set { _MRNNo = value; }
        }

        public Int32 CurrentSession
        {
            get { return _CurrentSession; }
            set { _CurrentSession = value; }
        }


        public DateTime SessionDate
        {
            get { return _SessionDate; }
            set { _SessionDate = value; }
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

        #endregion


    }
}
