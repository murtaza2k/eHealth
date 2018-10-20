using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace eHealth.Model
{
    public class clsStatus
    {
        private string sStatusID;
        private string sStatusDesc;
        private string sCaseType;
        private string sCommentRequired;
        private string sDefaultDocumentTitle = string.Empty;

        public string StatusID
        {
            get { return sStatusID; }
            set { sStatusID = value; }
        }

        public string StatusDesc
        {
            get { return sStatusDesc; }
            set { sStatusDesc = value; }
        }

        public string CaseType
        {
            get { return sCaseType; }
            set { sCaseType = value; }
        }

        public string CommentRequired
        {
            get { return sCommentRequired; }
            set { sCommentRequired = value; }
        }
        public string DefaultDocumentTitle
        {
            get { return sDefaultDocumentTitle; }
            set { sDefaultDocumentTitle = value; }
        }

        public List<clsStatus> getStatus(string sXMLPath)
        {
            DataSet Dts = new DataSet();
            List<clsStatus> listStatus = new List<clsStatus>();
            Dts.ReadXml(sXMLPath + "\\XML\\" + "Status.xml");
            foreach (System.Data.DataRow dr in Dts.Tables[0].Rows)
            {
                clsStatus cls = new clsStatus();
                cls.StatusID = dr[0].ToString();
                cls.StatusDesc = dr[1].ToString();
                cls.CaseType = dr[2].ToString();
                cls.CommentRequired = dr[3].ToString();
                cls.DefaultDocumentTitle = dr[4].ToString();
                listStatus.Add(cls);
            }
            //cboStatus.DataSource = Dts.Tables[0];
            //cboStatus.ValueMember = "StatusID";
            //cboStatus.DisplayMember = "StatusDesc";

            return listStatus;
        }


    }

    
}
