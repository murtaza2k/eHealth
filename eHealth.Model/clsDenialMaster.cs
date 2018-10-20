using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace eHealth.Model
{
    public class clsDenialMaster
    {
        private string DenialCode;
        private string Description;
        private string Category;

        private Dictionary<string, string> DenialList;

        public clsDenialMaster(string sXMLPath)
        {
            DenialList = new Dictionary<string, string>();

            DataSet Dts = new DataSet();
            Dts.ReadXml(sXMLPath + "\\XML\\" + "DenialMaster.xml");
            foreach (System.Data.DataRow dr in Dts.Tables[0].Rows)
            {
                if (DenialList.ContainsKey(dr[0].ToString()) == false)
                {
                    DenialList.Add(dr[0].ToString(), dr[1].ToString());
                }
            }

        }

        public string getDenialReasonByCode(string code)
        {
            string returnv = string.Empty;
            if (DenialList.ContainsKey(code))
            {
                returnv = DenialList[code].ToString();

            }
            return returnv;
        }

    }
}
