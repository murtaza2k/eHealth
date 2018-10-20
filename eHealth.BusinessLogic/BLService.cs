using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eHealth.Model;
using eHealth.Connection;
using System.Data;
using System.Data.Common;
using eHealth.Utility;

namespace eHealth.BusinessLogic
{
    public class BLService
    {

        DBHelper _helper;

        public BLService()
        {
            _helper = new DBHelper();
        }

        public List<clsServiceMaster> getServiceMaster(string sCaseType = "")
        {
           clsServiceMaster clsService =null;
           IDataReader dataReader =null;
           List<clsServiceMaster> _List = null;

            try
            {
               
                string sSQLQuery = "SELECT  ServiceId , Upper(ServiceName) , CaseType From ServiceMaster Where (CaseType='B' OR CaseType='" + sCaseType + "' ) AND IsNull(Status,'Y') ='Y' Order By ServiceName";

                
                dataReader =   _helper.ExecuteDataReader(sSQLQuery,null);                                
               
                _List = new List<clsServiceMaster>();
                _List.Clear();


                while (dataReader.Read())
                {
                    clsService = new clsServiceMaster();
                    clsService.ServiceID = dataReader.GetInt32(0);
                    clsService.ServiceName = dataReader.GetString(1).ToString();
                    clsService.ServiceCaseType = dataReader.GetString(2).ToString();
                    _List.Add(clsService);
                    clsService = null;
                }
                dataReader.Close();

            }
            catch (Exception ex)
            {
                _List = null;
                throw ex;
            }
            finally
            {
                dataReader.Dispose();
            }
           return _List;
            
        }
        public List<clsServiceMaster> getServiceMaster(string sCaseType = "", string slocation = "")
        {
            clsServiceMaster clsService = null;
            IDataReader dataReader = null;
            List<clsServiceMaster> _List = null;

            try
            {

                string sSQLQuery = "SELECT  ServiceId , Upper(ServiceName) , CaseType From ServiceMaster Where (CaseType='B' OR CaseType='" + sCaseType + "' ) AND IsNull(Status,'Y') ='Y' Order By ServiceName";


                dataReader = _helper.ExecuteDataReader(sSQLQuery, null);

                _List = new List<clsServiceMaster>();
                _List.Clear();


                while (dataReader.Read())
                {
                    clsService = new clsServiceMaster();
                    clsService.ServiceID = dataReader.GetInt32(0);
                    clsService.ServiceName = dataReader.GetString(1).ToString();
                    clsService.ServiceCaseType = dataReader.GetString(2).ToString();
                    _List.Add(clsService);
                    clsService = null;
                }
                dataReader.Close();

            }
            catch (Exception ex)
            {
                _List = null;
                throw ex;
            }
            finally
            {
                dataReader.Dispose();
            }
            return _List;
            

        }

        public List<clsServiceMaster> getServiceMaster()
        {

             clsServiceMaster clsService = null;
            IDataReader dataReader = null;
            List<clsServiceMaster> _List = null;

            try
            {

                string sSQLQuery = "SELECT  * From ServiceMaster WHERE IsNull(Status,'Y') ='D'";

                dataReader = _helper.ExecuteDataReader(sSQLQuery, null);
                
                _List = new List<clsServiceMaster>();
                _List.Clear();


                while (dataReader.Read())
                {
                    clsService = new clsServiceMaster();
                    clsService.ServiceID = dataReader.GetInt32(0);
                    clsService.ServiceName = dataReader.GetString(1).ToString();
                    clsService.ServiceCaseType = dataReader.GetString(2).ToString();
                    _List.Add(clsService);
                    clsService = null;
                }
                dataReader.Close();
                
            }
            catch (Exception ex)
            {
                clsUtility.WriteLogs("GetServiceMaster", "Error", DateTime.Now, ex.ToString());

                _List = null;
                throw ex;
            }
            finally
            {
                
                if (dataReader != null)
                    dataReader.Dispose();
                dataReader = null;                
            }
            return _List;
        }


        //public bool InsertServices(clsServiceMaster obj)
        //{

        //    bool inTrans = false;
        //    try
        //    {

        //        result = false;

        //         con = new SqlConnection(clsMisc.getSQLConnection());
        //        con.Open();
        //        trn = con.BeginTransaction(IsolationLevel.ReadCommitted);
        //        inTrans = true;
        //        com = new SqlCommand();
        //        com.Connection = con;
        //        com.CommandType = CommandType.Text;

        //        com.CommandText = "INSERT INTO ServiceMaster([ServiceName],[CaseType],[Status],CreatedBy,CreatedDt) " +
        //            "VALUES " +
        //                        "(@Name,@CaseType,@Status,@CreatedBy,@CreatedDt)";


        //        com.Parameters.Add("@Name", SqlDbType.VarChar, 100).Value = obj.ServiceName.ToString().Trim();
        //        com.Parameters.Add("@CaseType", SqlDbType.VarChar, 1).Value = obj.ServiceCaseType;
        //        com.Parameters.Add("@Status", SqlDbType.VarChar, 1).Value = "Y";
        //        com.Parameters.Add("@CreatedBy", SqlDbType.VarChar, 10).Value = Environment.UserName.ToString();
        //        com.Parameters.Add("@CreatedDt", SqlDbType.DateTime).Value = DateTime.Today;

        //        com.Transaction = trn;
        //        com.ExecuteNonQuery();

        //        com.Parameters.Clear();
        //        com.Cancel();
        //        com.Dispose();
        //        trn.Commit();
        //        result = true;


        //    }
        //    catch (Exception ex)
        //    {
        //        if (inTrans == true)
        //            trn.Rollback();

        //        result = false;
        //        throw ex;
        //    }
        //    finally
        //    {
        //        if (com != null)
        //            com.Dispose();

        //        if (con != null)
        //            con.Dispose();

        //        com = null;
        //        con = null;
        //    }

        //    return result;



        //}

    }
}
