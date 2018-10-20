using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHealth.Model
{
 public class clsServiceMaster
    {

        private Int32 m_Serviceid;
        public Int32 ServiceID
        {
            get { return m_Serviceid; }
            set { m_Serviceid = value; }
        }
        private string m_ServiceName;
        public string ServiceName
        {
            get { return m_ServiceName; }
            set { m_ServiceName = value; }
        }
        private string m_CaseType;
        public string ServiceCaseType
        {
            get { return m_CaseType; }
            set { m_CaseType = value; }
        }




        private clsServiceMaster _Customer = null;
        private List<clsServiceMaster> _List = null;


        //private SqlConnection con = null;
        //private SqlCommand com = null;
        //private SqlTransaction trn = null;
        //private SqlDataReader reader = null;
        ////  private SqlDataAdapter dapter = null;
        ////  private DataSet dset = null;
        private bool result = false;

        //public List<clsServiceMaster> getServiceMaster(string sCaseType = "")
        //{
        //    _Customer = null;

        //    try
        //    {
        //        con = new SqlConnection(clsMisc.getSQLConnection());
        //        con.Open();

        //        com = new SqlCommand();
        //        com.CommandType = CommandType.Text;
        //        com.CommandText = "SELECT  ServiceId , Upper(ServiceName) , CaseType From ServiceMaster Where (CaseType='B' OR CaseType='" + sCaseType + "' ) AND IsNull(Status,'Y') ='Y' Order By ServiceName";
        //        com.Connection = con;
        //        reader = com.ExecuteReader();

        //        _List = new List<clsServiceMaster>();
        //        _List.Clear();


        //        while (reader.Read())
        //        {
        //            _Customer = new clsServiceMaster();
        //            _Customer.ServiceID = reader.GetInt32(0);
        //            _Customer.ServiceName = reader.GetString(1).ToString();
        //            _Customer.ServiceCaseType = reader.GetString(2).ToString();
        //            _List.Add(_Customer);
        //            _Customer = null;
        //        }
        //        reader.Close();

        //    }
        //    catch (Exception ex)
        //    {
        //        _List = null;
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
        //    return _List;
        //}
        //public List<clsServiceMaster> getServiceMaster(string sCaseType="" ,string slocation="")
        //{
        //    _Customer = null;

        //    try
        //    {
        //        con = new SqlConnection(clsMisc.getSQLConnection(slocation));
        //        con.Open();

        //        com = new SqlCommand();
        //        com.CommandType = CommandType.Text;
        //        com.CommandText = "SELECT  ServiceId , Upper(ServiceName) , CaseType From ServiceMaster Where (CaseType='B' OR CaseType='" + sCaseType + "' ) AND IsNull(Status,'Y') ='Y' Order By ServiceName";
        //        com.Connection = con;
        //        reader = com.ExecuteReader();

        //        _List = new List<clsServiceMaster>();
        //        _List.Clear();


        //        while (reader.Read())
        //        {
        //            _Customer = new clsServiceMaster();
        //            _Customer.ServiceID = reader.GetInt32(0);
        //            _Customer.ServiceName = reader.GetString(1).ToString();
        //            _Customer.ServiceCaseType = reader.GetString(2).ToString();
        //            _List.Add(_Customer);
        //            _Customer = null;
        //        }
        //        reader.Close();
                
        //    }
        //    catch (Exception ex)
        //    {
        //        _List = null;
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
        //    return _List;
        //}

        //public List<clsServiceMaster> getServiceMaster()
        //{
        //    _Customer = null;

        //    try
        //    {
        //        con = new SqlConnection(clsMisc.getSQLConnection());
        //        con.Open();

        //        com = new SqlCommand();
        //        com.CommandType = CommandType.Text;
        //        com.CommandText = "SELECT  * From ServiceMaster WHERE IsNull(Status,'Y') ='D'";
        //        com.Connection = con;
        //        reader = com.ExecuteReader();

        //        _List = new List<clsServiceMaster>();
        //        _List.Clear();


        //        while (reader.Read())
        //        {
        //            _Customer = new clsServiceMaster();
        //            _Customer.ServiceID = reader.GetInt32(0);
        //            _Customer.ServiceName = reader.GetString(1).ToString();
        //            _Customer.ServiceCaseType = reader.GetString(2).ToString();
        //            _List.Add(_Customer);
        //            _Customer = null;
        //        }
        //        reader.Close();

        //    }
        //    catch (Exception ex)
        //    {
        //        clsMisc.WriteLogs("GetServiceMaster", "Error", DateTime.Now, ex.ToString());

        //        _List = null;
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
        //    return _List;
        //}


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

    public class HISServiceMaster
    {
      //  Oracle.DataAccess.Client.OracleConnection conn;
        private string OracleLocation = string.Empty;
        public string CPTCode ;
        public string CPTDescription ;
        public string ServiceCode;
        public string ServiceName;        
        public string Tariff;
        public string ServiceType;
     
        //   public List<HISServiceMaster> getServices(string query)
        //{
        //    HISServiceMaster cls=null;
        //    List<HISServiceMaster> list=null;
        //    OracleDataAdapter oDAP=null;
        //    System.Data.DataTable dt=null;
        //    String OracleLocation = ConfigurationManager.AppSettings["Location"].ToString();
        //    string connectionString=string.Empty;
        //    //Connection Information	


            
        //    try
        //    {

        //        if (OracleLocation == "MCH")
        //        //username
        //        {

        //            connectionString =

        //            "User Id=" + ConnectionParams.Username +

        //                       //password
        //                       ";Password=" + ConnectionParams.Password +

        //                       //replace with your datasource value (TNSnames)
        //                       ";Data Source=" + ConnectionParams.Datasource;

        //        }
        //        else if (OracleLocation == "MWH")
        //        {

        //            connectionString =

        //           "User Id=" + ConnectionParamsMWH.Username +

        //                      //password
        //                      ";Password=" + ConnectionParamsMWH.Password +

        //                      //replace with your datasource value (TNSnames)
        //                      ";Data Source=" + ConnectionParamsMWH.Datasource;

        //        }

        //        //Connection to datasource, using connection parameters given above
                
        //        conn = new Oracle.DataAccess.Client.OracleConnection(connectionString);

        //        clsMisc.WriteLogs("fillPatientFromHIS_Conn", "Info", DateTime.Now, connectionString);

        //       // oDAP = new OracleDataAdapter("SELECT MRN,PatientFirstName,PatientLastName ,Mobile,PlanExpiryDate FROM welcarefo.VIEW_PATIENTS_TCH_INSURANCE WHERE MRN='" + sMRNNo + "'", conn);

        //        if (OracleLocation=="MCH")
        //        oDAP = new OracleDataAdapter("SELECT * FROM welcarefo.VIEW_PATIENTS_INS_TARIFFMASTER WHERE  " + query , conn);
        //        else if (OracleLocation=="MWH")
        //            oDAP = new OracleDataAdapter("SELECT * FROM welcarefo.VIEW_PATIENTS_INS_TARIFFMASTER WHERE  " + query, conn);


        //        dt = new System.Data.DataTable();
        //        oDAP.Fill(dt);
        //        if (list == null)
        //            list = new List<HISServiceMaster>();
        //        if (dt != null)
        //        {
        //            if (dt.Rows.Count > 0)
        //            {
        //                foreach (System.Data.DataRow dRow in dt.Rows)
        //                {
        //                    try
        //                    {
                               
        //                    cls = new HISServiceMaster();
        //                    cls.ServiceCode = dRow[0].ToString();
        //                    cls.ServiceName = dRow[1].ToString();
        //                    cls.Tariff = dRow[2].ToString();
        //                    cls.CPTCode = dRow[3].ToString();
        //                    cls.CPTDescription = dRow[4].ToString();
                            
        //                    list.Add(cls);
                              
        //                    }
                            
        //                    catch (Exception ex)
        //                    {
        //                        clsMisc.WriteLogs("fillTariffNMaster", "Error", DateTime.Now, ex.ToString());                                
        //                    }
        //                    //break;
        //                }
        //            }
        //        }


        //    }
        //    catch (Exception ex)
        //    {
        //        clsMisc.WriteLogs("fillHISServiceMaster", "Error", DateTime.Now, ex.ToString());
        //        cls = null;
        //    }
        //    finally
        //    {
        //        if (conn != null)
        //        {
        //            if (conn.State == System.Data.ConnectionState.Open)
        //            {
        //                oDAP.Dispose();
        //                dt.Dispose();
        //                conn.Close();
        //                conn = null;
                        
        //            }
        //            if (conn.State == System.Data.ConnectionState.Closed)
        //            {
        //                oDAP.Dispose();
        //                dt.Dispose();
        //                conn.Dispose();
        //                conn = null;
        //            }
        //        }
                
        //    }

        //    return list;
        //}

        //   public List<HISServiceMaster> getServices()
        //   {
        //       HISServiceMaster cls = null;
        //       List<HISServiceMaster> list = null;
        //       OracleDataAdapter oDAP = null;
        //       System.Data.DataTable dt = null;
        //       String OracleLocation = ConfigurationManager.AppSettings["Location"].ToString();
        //       string connectionString = string.Empty;
        //       //Connection Information	



        //       try
        //       {

        //           if (OracleLocation == "MCH")
        //           //username
        //           {

        //               connectionString =

        //               "User Id=" + ConnectionParams.Username +

        //                          //password
        //                          ";Password=" + ConnectionParams.Password +

        //                          //replace with your datasource value (TNSnames)
        //                          ";Data Source=" + ConnectionParams.Datasource;

        //           }
        //           else if (OracleLocation == "MWH")
        //           {

        //               connectionString =

        //              "User Id=" + ConnectionParamsMWH.Username +

        //                         //password
        //                         ";Password=" + ConnectionParamsMWH.Password +

        //                         //replace with your datasource value (TNSnames)
        //                         ";Data Source=" + ConnectionParamsMWH.Datasource;

        //           }

        //           //Connection to datasource, using connection parameters given above

        //           conn = new Oracle.DataAccess.Client.OracleConnection(connectionString);

        //           clsMisc.WriteLogs("fillPatientFromHIS_Conn", "Info", DateTime.Now, connectionString);

        //           // oDAP = new OracleDataAdapter("SELECT MRN,PatientFirstName,PatientLastName ,Mobile,PlanExpiryDate FROM welcarefo.VIEW_PATIENTS_TCH_INSURANCE WHERE MRN='" + sMRNNo + "'", conn);

        //           if (OracleLocation == "MCH")
        //               oDAP = new OracleDataAdapter("SELECT * FROM welcarefo.VIEW_PATIENTS_INS_TARIFFMASTER ", conn);
        //           else if (OracleLocation == "MWH")
        //               oDAP = new OracleDataAdapter("SELECT * FROM welcarefo.VIEW_PATIENTS_INS_TARIFFMASTER ", conn);


        //           dt = new System.Data.DataTable();
        //           oDAP.Fill(dt);
        //           if (list == null)
        //               list = new List<HISServiceMaster>();
        //           if (dt != null)
        //           {
        //               if (dt.Rows.Count > 0)
        //               {
        //                   foreach (System.Data.DataRow dRow in dt.Rows)
        //                   {
        //                       try
        //                       {

        //                           cls = new HISServiceMaster();
        //                           cls.ServiceCode = dRow[0].ToString();
        //                           cls.ServiceName = dRow[1].ToString();
        //                           cls.Tariff = dRow[2].ToString();
        //                           cls.CPTCode = dRow[3].ToString();
        //                           cls.CPTDescription = dRow[4].ToString();

        //                           list.Add(cls);

        //                       }

        //                       catch (Exception ex)
        //                       {
        //                           clsMisc.WriteLogs("fillTariffNMaster", "Error", DateTime.Now, ex.ToString());
        //                       }
        //                       //break;
        //                   }
        //               }
        //           }


        //       }
        //       catch (Exception ex)
        //       {
        //           clsMisc.WriteLogs("fillHISServiceMaster", "Error", DateTime.Now, ex.ToString());
        //           cls = null;
        //       }
        //       finally
        //       {
        //           if (conn != null)
        //           {
        //               if (conn.State == System.Data.ConnectionState.Open)
        //               {
        //                   oDAP.Dispose();
        //                   dt.Dispose();
        //                   conn.Close();
        //                   conn = null;

        //               }
        //               if (conn.State == System.Data.ConnectionState.Closed)
        //               {
        //                   oDAP.Dispose();
        //                   dt.Dispose();
        //                   conn.Dispose();
        //                   conn = null;
        //               }
        //           }

        //       }

        //       return list;
        //   }

    }

    public class ConnectionParams
    {
        //Parameters for database connection
        //Change the values to those applicable to your database

        //Replace with Connect String as TNSNames

        public static string Datasource = "TCHHIS";

        public static string Username = "pdausers";      //Username
        public static string Password = "pda";      //Password
    }

}
