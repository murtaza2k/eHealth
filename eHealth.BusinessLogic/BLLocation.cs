using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eHealth.Model;
using eHealth.Connection;
using System.Data;
using AutoMapper;
using System.Data.Common;

namespace eHealth.BusinessLogic
{
  public class BLLocation
    {
       

      
        public List<clsLocationMaster> getProviderDetails()
        {
            List<clsLocationMaster> listProvider = null;

            string sSQLQuery = string.Empty;
            try
            {
                sSQLQuery = " SELECT SourceLocation , SQLConnection , FacilityId , FacilityPassword,LicenseCode " +
                            " From [LocationConnections]";


              

                //DataManager dataAccess = new DataManager();
                //dataAccess.DBManager(DataProviderType.SqlServer, contextInfo.DefaultConnection.ToString());
                //DataSet ds = dataAccess.getDataSet(sSQLQuery,null);
                DBHelper _DbHelper = new DBHelper();
                DataSet ds = _DbHelper.ExecuteDataSet(sSQLQuery);

                
                

                listProvider = new List<clsLocationMaster>();

                


                foreach (DataRow dR in ds.Tables[0].Rows)
                {
                    clsLocationMaster cls = new clsLocationMaster();

                    cls.SourceLocation = dR[0].ToString();

                    cls.SQLConnection = dR[1].ToString();

                    cls.FacilityId = dR[2].ToString();

                    cls.FacilityPassword = dR[3].ToString();

                    cls.LicenseCode = dR[4].ToString();

                    listProvider.Add(cls);
                }
            }
            catch (Exception ex)
            {

                listProvider = null;
           //     throw ex;
            }
            finally
            {

            }

           return listProvider;
        }

        //public Boolean insertService(string sSQLConnection)
        //{
        //    string sSQLQuery = string.Empty;
        //    Boolean returnOutput = false;
        //    try
        //    {
        //        sSQLQuery = "sp_ExecuteItemInsertFromHIS ";

        //        DataManager dataAccess = new DataManager();
        //        dataAccess.DBManager(DataProviderType.SqlServer, sSQLConnection);
        //        dataAccess.executeSQLCommand(sSQLQuery, CommandType.StoredProcedure, null);
        //        returnOutput = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        returnOutput = false;
        //        throw ex;
        //    }

        //    return returnOutput;
        //}


        public  void setFacilityDetails(string location)
        {
            string sSQLQuery = "";
            IDataReader dataReader = null;
            clsLocationMaster sLocation = null;
            
            
            try
            {
                sSQLQuery = "Select   SQLConnection , FacilityId ,FacilityPassword,LicenseCode From LocationConnections Where SourceLocation='" + location + "'";
                DBHelper _helpder = new DBHelper();

                dataReader = _helpder.ExecuteDataReader(sSQLQuery, null);
                
                while (dataReader.Read())
                {
                    sLocation = new clsLocationMaster();
                    sLocation.SQLConnection = dataReader.GetString(0);
                    sLocation.FacilityId = dataReader.GetString(1).ToString();
                    sLocation.FacilityPassword = dataReader.GetString(2).ToString();
                    sLocation.LicenseCode = dataReader.GetString(3).ToString();
                    
                }
                dataReader.Close();
                
            }

            catch (Exception ex)
            {                
                sLocation = null; 
                
            }
            finally
            {
             
            }

        }
    }
}
