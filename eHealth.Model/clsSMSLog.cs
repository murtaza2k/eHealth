using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHealth.Model
{
    class clsSMSLog
    {
        #region Private Variables

        private int _TransId;
        private string _RequestStatus;
        private string _Comment;
        private DateTime _SMSRequestDateTime;
        private string _UserID = string.Empty;
        #endregion

        #region Property

       


        public Int32 TransactionId
        {
            get { return _TransId; }
            set { _TransId = value; }
        }

        public string RequestStatus
        {
            get { return _RequestStatus; }
            set { _RequestStatus = value; }
        }

        public string Comment
        {
            get { return _Comment; }
            set { _Comment = value; }
        }

        public string UserName
        {
            get { return _UserID; }
            set { _UserID = value; }
        }
        public DateTime SMSDatetime
        {
            get { return _SMSRequestDateTime; }
            set { _SMSRequestDateTime = value; }
        }


        #endregion
    }
}
