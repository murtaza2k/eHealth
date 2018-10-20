using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHealth.Model
{
    class clsInsuranceQuery
    {
        private Int32 iQueryId;
        private string sQuery;
        private DateTime datetimeReceived;
        private DateTime datetimeSent;

        public clsInsuranceQuery(Int32 iRow)
        {
            iQueryId = iRow;
        }
        public clsInsuranceQuery()
        {
            ///

        }


        public Int32 QueryId
        {
            get { return iQueryId; }
            set { iQueryId = value; }
        }


        public string Query
        {
            get { return sQuery; }
            set { sQuery = value; }
        }

        public DateTime ReceivedDate
        {
            get { return datetimeReceived; }
            set { datetimeReceived = value; }
        }

        public DateTime SentDate
        {
            get { return datetimeSent; }
            set { datetimeSent = value; }
        }
    }
}
