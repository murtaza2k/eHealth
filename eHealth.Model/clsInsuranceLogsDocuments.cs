using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHealth.Model
{
    class clsInsuranceLogsDocuments
    {

        public clsInsuranceLogsDocuments(Int32 iRow)
        {
            m_DocumentNumber = iRow;
        }
        public clsInsuranceLogsDocuments()
        {

        }

        #region "Private Variables ....."

        private Int32 m_DocumentNumber;
        private string m_DocumentName = string.Empty;
        private string m_filetype = string.Empty;
        private string m_fileext = string.Empty;
        private string m_path = string.Empty;
        private string m_addstatus = string.Empty;
        private string m_filename = string.Empty;
        private string m_IsRequired = string.Empty;
        private string m_add = "Add";
        private string m_view = "View";
        private string m_remove = "Remove";
        private Byte[] m_documentdata;



        private string m_CurrentWindowsUser = Environment.UserDomainName.ToString() + "\\" + Environment.UserName.ToString();
        private string m_Status = "Y";
        // private List<ClsDocumentDetails> _detaillist = null;
        private string m_userid;
        #endregion


        public Int32 DocumentNumber
        {

            get { return m_DocumentNumber; }
            set { m_DocumentNumber = value; }

        }
        public string DocumentName
        {
            get { return m_DocumentName; }
            set { m_DocumentName = value; }
        }

        public string Filetype
        {
            get { return m_filetype; }
            set { m_filetype = value; }
        }
        public string FileExtention
        {
            get { return m_fileext; }
            set { m_fileext = value; }
        }
        public string DocumnetPath
        {
            get { return m_path; }
            set { m_path = value; }
        }
        public string TypeStatus
        {
            get { return m_addstatus; }
            set { m_addstatus = value; }
        }
        public string FileName
        {
            get { return m_filename; }
            set { m_filename = value; }
        }
        public string Add
        {
            get { return m_add; }
        }
        public string View
        {
            get { return m_view; }
        }
        public string Remove
        {
            get { return m_remove; }
            set { m_remove = value; }
        }
        public string IsRequired
        {
            get { return m_IsRequired; }
            set { m_IsRequired = value; }
        }
        //public List<ClsDocumentDetails> DetailList
        //{
        //    get { return _detaillist; }
        //    set { _detaillist = value; }
        //}


        public string UserID
        {
            get { return m_userid; }
            set { m_userid = value; }
        }



        public string WindowsUser
        {
            get { return m_CurrentWindowsUser; }
            //  set { m_userid = value; }
        }
        public string Status
        {
            get { return m_Status; }
            set { m_Status = value; }
        }
        private Byte[] Documentdata
        {
            get { return m_documentdata; }
            set { m_documentdata = value; }
        }

    }
}
