using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace eHealth.Model
{
    class clsQuery
    {
        private string sQueryID;
        private string sStatusDesc;
        private string sCaseType;

        public string QueryID
        {
            get { return sQueryID; }
            set { sQueryID = value; }
        }

        public string StatusDesc
        {
            get { return sStatusDesc; }
            set { sStatusDesc = value; }
        }

        private string CaseType
        {
            get { return sCaseType; }
            set { sCaseType = value; }
        }

        public List<clsQuery> getQuery(string sXMLPath)
        {
            DataSet Dts = new DataSet();
            List<clsQuery> listQuery = new List<clsQuery>();
            Dts.ReadXml(sXMLPath + "\\XML\\" + "Query.xml");
            foreach (System.Data.DataRow dr in Dts.Tables[0].Rows)
            {
                clsQuery cls = new clsQuery();
                cls.QueryID = dr[0].ToString();
                listQuery.Add(cls);
            }
            //cboStatus.DataSource = Dts.Tables[0];
            //cboStatus.ValueMember = "StatusID";
            //cboStatus.DisplayMember = "StatusDesc";

            return listQuery;
        }

    }
}
