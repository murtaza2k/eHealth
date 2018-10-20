using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using eHealth.Connection;
using eHealth.Model;


namespace eHealth.BusinessLogic
{
    public class BLManager : IBLManager
    {
        DBHelper _helper;

        public BLManager()
        {
            _helper = new DBHelper();
        }
            

        public List<clsLocationMaster> getProviderDetails()
        {
            List<clsLocationMaster> listProvider = null;

            string sSQLQuery = string.Empty;
            try
            {
                sSQLQuery = " SELECT SourceLocation , SQLConnection , FacilityId , FacilityPassword,LicenseCode " +
                            " From [LocationConnections]";


                DataSet ds = _helper.ExecuteDataSet(sSQLQuery);


                listProvider = new List<clsLocationMaster>();
                foreach (DataRow dR in ds.Tables[0].Rows)
                {
                    clsLocationMaster cls = new clsLocationMaster();

                    cls.SourceLocation = dR[0].ToString();

                    cls.SQLConnection = dR[1].ToString();

                   // cls.FacilityID = dR[2].ToString();

                    cls.FacilityPassword = dR[3].ToString();

                    cls.LicenseCode = dR[4].ToString();

                    listProvider.Add(cls);
                }
            }
            catch (Exception ex)
            {

                listProvider = null;
                throw ex;
            }
            finally
            {

            }

            return listProvider;
        }

    }
}
