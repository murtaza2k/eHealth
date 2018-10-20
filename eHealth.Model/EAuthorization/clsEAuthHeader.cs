using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHealth.Model
{
    class clsEAuthHeader
    {


        private Int32 _TransId;
        private string _VisitNumber;
        private string _SenderID;
        private string _ReceiverID;
        private Int32 _RecordCount;
        private clsEAuthEnums.HeaderDispositionFlag _DispositionFlag;
        private DateTime? _TransactionDate;

        private DateTime? _RequestUploadDateTime = null;
        private DateTime? _RequestDownloadDateTime = null;
        private DateTime? _RequestCancelDateTime = null;
        private string _UploadStatus = string.Empty;
        private string _DownloadStatus = string.Empty;
        private string _PayerComment = string.Empty;
        private int _UploadCount = 1;

        private string _ErrorMessage = string.Empty;

        public clsEauthAuthorization eAuthAuthorization;



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
        public string SenderID
        {
            get { return _SenderID; }
            set { _SenderID = value; }
        }
        public string ReceiverId
        {
            get { return _ReceiverID; }
            set { _ReceiverID = value; }
        }
        public Int32 RecordCount
        {
            get { return _RecordCount; }
            set { _RecordCount = value; }
        }
        public clsEAuthEnums.HeaderDispositionFlag DispositionFlag
        {
            get { return _DispositionFlag; }
            set { _DispositionFlag = value; }
        }
        public DateTime? TransactionDate
        {
            get { return _TransactionDate; }
            set { _TransactionDate = value; }
        }
        public DateTime? RequestUploadDateTime
        {
            get { return _RequestUploadDateTime; }
            set { _RequestUploadDateTime = value; }
        }
        public DateTime? RequestDownloadDateTime
        {
            get { return _RequestDownloadDateTime; }
            set { _RequestDownloadDateTime = value; }
        }
        public DateTime? RequestCancelDateTime
        {
            get { return _RequestCancelDateTime; }
            set { _RequestCancelDateTime = value; }
        }

        public string UploadStatus
        {
            get { return _UploadStatus; }
            set { _UploadStatus = value; }
        }
        public string ErrorMessage
        {
            get { return _ErrorMessage; }
            set { _ErrorMessage = value; }
        }

        public string DownloadStatus
        {
            get { return _DownloadStatus; }
            set { _DownloadStatus = value; }
        }
        public string PayerComment
        {
            get { return _PayerComment; }
            set { _PayerComment = value; }
        }
        public Int32 UploadCount
        {
            get { return _UploadCount; }
            set { _UploadCount = value; }
        }

    }
}
