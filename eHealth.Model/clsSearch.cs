using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace eHealth.Model
{
    public class clsSearch
    {

        public string tblFieldId { get; set; }
        public string TextDescription { get; set; }
        public string DefaultValue { get; set; }




        public List<clsSearch> getStatus(string sXMLPath)
        {
            DataSet Dts = new DataSet();
            List<clsSearch> listStatus = new List<clsSearch>();
            Dts.ReadXml(sXMLPath + "\\XML\\" + "Search.xml");
            foreach (System.Data.DataRow dr in Dts.Tables[0].Rows)
            {
                clsSearch cls = new clsSearch();
                cls.tblFieldId = dr[0].ToString();
                cls.TextDescription = dr[1].ToString();
                cls.DefaultValue = dr[2].ToString();
                listStatus.Add(cls);
            }
            //cboStatus.DataSource = Dts.Tables[0];
            //cboStatus.ValueMember = "StatusID";
            //cboStatus.DisplayMember = "StatusDesc";

            return listStatus;
        }


        public List<HISServiceMaster> listSerivces = null;
        public SortedDictionary<string, HISServiceMaster> dicServiceMasterSortedDictionary;
        public SortedDictionary<string, string> dicServicesSortedDictionary;


        public void fillServiceMasterFromHIS()
        {

            AutoCompleteStringCollection colMRN = new AutoCompleteStringCollection();
            dicServiceMasterSortedDictionary = new SortedDictionary<string, HISServiceMaster>();
            dicServicesSortedDictionary = new SortedDictionary<string, string>();

            Application.DoEvents();
            Application.DoEvents();

            try
            {
              //  listSerivces = new HISServiceMaster().getServices();
                //   this.Cursor = Cursors.WaitCursor;
                for (Int32 ri = 0; ri <= listSerivces.Count - 1; ri++)
                {
                    colMRN.Add(listSerivces[ri].CPTCode);
                    dicServiceMasterSortedDictionary.Add(listSerivces[ri].CPTCode, listSerivces[ri]);
                    dicServicesSortedDictionary.Add(listSerivces[ri].CPTCode, listSerivces[ri].CPTCode);
                }

                //txtMRNNo.Invoke(new EventHandler(delegate
                //{
                //    txtMRNNo.AutoCompleteMode = AutoCompleteMode.Suggest;
                //    txtMRNNo.AutoCompleteSource = AutoCompleteSource.CustomSource;
                //    txtMRNNo.AutoCompleteCustomSource = colMRN;
                //}));

            }
            catch (Exception ex)
            {
                // this.Cursor = cr;


            }
        }
    }
}
