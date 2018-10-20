using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace eHealth.Model
{
    class clsEmailTemplates
    {

        public string TemplateId { get; set; }
        public string TemplateDescription { get; set; }
        public string TemplateForCaseType { get; set; }
        public string TemplateFile { get; set; }

        public List<clsEmailTemplates> getEmailTemplatesFromXML(string sXMLPath)
        {
            DataSet Dts = new DataSet();
            List<clsEmailTemplates> listTemplates = new List<clsEmailTemplates>();
            Dts.ReadXml(sXMLPath + "\\XML\\" + "EmailTemplate.xml");
            foreach (System.Data.DataRow dr in Dts.Tables[0].Rows)
            {
                clsEmailTemplates cls = new clsEmailTemplates();
                cls.TemplateId = dr[0].ToString();
                cls.TemplateDescription = dr[1].ToString();
                cls.TemplateForCaseType = dr[2].ToString();
                cls.TemplateFile = dr[3].ToString();

                listTemplates.Add(cls);
            }
            //cboStatus.DataSource = Dts.Tables[0];
            //cboStatus.ValueMember = "StatusID";
            //cboStatus.DisplayMember = "StatusDesc";

            return listTemplates;

        }
    }
}
