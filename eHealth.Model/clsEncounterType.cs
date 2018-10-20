using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace eHealth.Model
{
    class clsEncounterType
    {

        public string EncounterType { get; set; }
        public string EncounterTypeDescription { get; set; }

        public List<clsEncounterType> getEncounterType(string sXMLPath)
        {
            DataSet Dts = new DataSet();
            List<clsEncounterType> listStatus = new List<clsEncounterType>();
            Dts.ReadXml(sXMLPath + "\\XML\\" + "EncounterType.xml");
            foreach (System.Data.DataRow dr in Dts.Tables[0].Rows)
            {
                clsEncounterType cls = new clsEncounterType();
                cls.EncounterType = dr[0].ToString();
                cls.EncounterTypeDescription = dr[1].ToString();
                listStatus.Add(cls);
            }
            //cboStatus.DataSource = Dts.Tables[0];
            //cboStatus.ValueMember = "StatusID";
            //cboStatus.DisplayMember = "StatusDesc";

            return listStatus;
        }
    }
}
