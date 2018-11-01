using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eHealth.Model;
using eHealth.BusinessLogic;
using System.Data;
using eHealth.Connection;

namespace eHealth.BusinessLogic
{
   public  class BLCountry
    {

       DBHelper _helper;

       public BLCountry()
       {
           _helper = new DBHelper ();
       }

       public DataSet getAllCountry()
        {
            string sSQLQuery;
            DataSet dt = new DataSet();
            try
            {
                sSQLQuery = "SELECT CountryCode , CountryName  FROM countrymaster";

                dt = _helper.ExecuteDataSet(sSQLQuery);
                //      _helper.ExecuteDataReader(sSQLQuery, null);
            }
            catch (Exception ex)
            {
                dt = null;

            }
            finally
            {

            }
            return dt;
        }
    
    }
}
