using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHealth.Model
{
    class clsInsuranceQueryLogs : clsQuery
    {
        private Int32 iTransId;
        private DateTime dReceivedDate;
        private DateTime dSentDate;
        private string sUserName;

        public Int32 TransId
        {
            get { return iTransId; }
            set { iTransId = value; }
        }
        public DateTime ReceivedDate
        {
            get { return dReceivedDate; }
            set { dReceivedDate = value; }
        }
        public DateTime SentDate
        {
            get { return dSentDate; }
            set { dSentDate = value; }
        }

        public string UserName
        {
            get { return sUserName; }
            set { sUserName = value; }
        }
        public clsInsuranceQueryLogs()
        {

            sUserName = Environment.UserName.ToString();
        }


    }
  
}
