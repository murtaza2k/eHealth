using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using eHealth.Model;
using eHealth.Connection;

namespace eHealth.BusinessLogic
{
    class Diagnosis : eHealth.Model.clsDiagnosisMaster
    {
        DBHelper _helper;

        public Diagnosis()
        {
            _helper = new DBHelper();
        }
       

        public clsDiagnosisMaster SaveDiagnosis(string sSQLConnection)
        {
            clsDiagnosisMaster returnValue = null;
            bool inTrans = false;
            try
            {

                
                #region CheckInsuranceExits

                
                string chkSQL = "SELECT [DiagnosisCode],[DiagnosisName],[IsActive] FROM [DiagnosisMaster] WHERE DiagnosisCode=@DiagnosisCode";


                DBParameter sqlParam = new DBParameter("@DiagnosisCode", DiagnosisCode);
                
                DBParameterCollection paramCollection=null;
                paramCollection.Add(sqlParam);


                DataSet ds = _helper.ExecuteDataSet(chkSQL, paramCollection);

                

                foreach (DataRow dRow in ds.Tables[0].Rows)
                {
                        returnValue = new clsDiagnosisMaster();
                        returnValue.DiagnosisCode = dRow[0].ToString();
                        returnValue.DiagnosisName = dRow[1].ToString();
                        returnValue.DiagnosisIsActive =(Boolean) dRow[2];
                }

                #endregion

                #region "InsertDoctor"
                if (returnValue == null)
                {

                    
                    chkSQL = "INSERT INTO DiagnosisMaster([DiagnosisCode],[DiagnosisName],[IsActive]) " +
                        "VALUES " +
                                    "(@DiagnosisCode,@DiagnosisName,@IsActive)";

                    DBParameter paramDiagnosisCode = new DBParameter("@DiagnosisCode",DiagnosisCode,DbType.String);
                    DBParameter paramDiagnosisName = new DBParameter("@DiagnosisName", DiagnosisName, DbType.String);
                    DBParameter paramIsActive = new DBParameter("@IsActive", DiagnosisIsActive, DbType.Boolean);


                    paramCollection = null;
                    paramCollection.Add(paramDiagnosisCode);
                    paramCollection.Add(paramDiagnosisName);
                    paramCollection.Add(paramIsActive);
                    

                    

                    _helper.ExecuteNonQuery(chkSQL,paramCollection ,CommandType.Text);

                    returnValue = new clsDiagnosisMaster();
                    returnValue.DiagnosisCode = DiagnosisCode.ToString().Trim();
                    returnValue.DiagnosisName = DiagnosisName.ToString().Trim();
                    returnValue.DiagnosisIsActive = DiagnosisIsActive;
                }
                #endregion

            }
            catch (Exception ex)
            {
                
                returnValue = null;
                throw ex;
            }
            finally
            {
                
            }

            return returnValue;


        }


        //public clsDiagnosisMaster getDiagnosis(string code)
        //{
        //    clsDiagnosisMaster returnValue = null;
        //    bool inTrans = false;
        //    try
        //    {

        //        result = false;
        //        string chkSQL = string.Empty;
        //        con = new SqlConnection(clsMisc.getSQLConnection());
        //        con.Open();
        //        trn = con.BeginTransaction(IsolationLevel.ReadCommitted);

        //        #region CheckInsuranceExits

        //        com = new SqlCommand();
        //        com.Connection = con;
        //        com.CommandType = CommandType.Text;

        //        chkSQL = "SELECT [DiagnosisCode],[DiagnosisName],[IsActive] FROM [DiagnosisMaster] WHERE DiagnosisCode=@DiagnosisCode";
        //        com.CommandText = chkSQL;
        //        com.Parameters.Add("@DiagnosisCode", SqlDbType.VarChar, 10).Value = code;


        //        com.Transaction = trn;
        //        SqlDataReader sqlData = com.ExecuteReader();
        //        if (sqlData != null)
        //        {
        //            while (sqlData.Read())
        //            {
        //                returnValue = new clsDiagnosisMaster();
        //                returnValue.DiagnosisCode = clsMisc.SafeGetString(sqlData, 0);
        //                returnValue.DiagnosisName = clsMisc.SafeGetString(sqlData, 1);
        //                returnValue.DiagnosisIsActive = clsMisc.SafeGetBoolean(sqlData, 2);

        //            }
        //            sqlData.Close();
        //        }

        //        com.Parameters.Clear();
        //        com.Cancel();
        //        com.Dispose();
        //        trn.Commit();
        //        #endregion
        //    }
        //    catch (Exception ex)
        //    {
        //        if (inTrans == true)
        //            trn.Rollback();

        //        returnValue = null;
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

        //    return returnValue;


        //}

        //public List<clsDiagnosisMaster> getAllDiagnosis()
        //{
        //    clsDiagnosisMaster returnValue = null;
        //    List<clsDiagnosisMaster> returnList = null;
        //    bool inTrans = false;
        //    try
        //    {

        //        result = false;
        //        string chkSQL = string.Empty;
        //        con = new SqlConnection(clsMisc.getSQLConnection());
        //        con.Open();
        //        trn = con.BeginTransaction(IsolationLevel.ReadCommitted);

        //        #region CheckInsuranceExits

        //        com = new SqlCommand();
        //        com.Connection = con;
        //        com.CommandType = CommandType.Text;

        //        chkSQL = "SELECT [DiagnosisCode],[DiagnosisName],[IsActive] FROM [DiagnosisMaster]";// WHERE";// DiagnosisCode=@DiagnosisCode";
        //        com.CommandText = chkSQL;
        //        //com.Parameters.Add("@DiagnosisCode", SqlDbType.VarChar, 10).Value = code;


        //        com.Transaction = trn;
        //        SqlDataReader sqlData = com.ExecuteReader();
        //        if (sqlData != null)
        //        {
        //            returnList = new List<clsDiagnosisMaster>();
        //            while (sqlData.Read())
        //            {
        //                returnValue = new clsDiagnosisMaster();
        //                returnValue.DiagnosisCode = clsMisc.SafeGetString(sqlData, 0);
        //                returnValue.DiagnosisName = clsMisc.SafeGetString(sqlData, 1);
        //                returnValue.DiagnosisIsActive = clsMisc.SafeGetBoolean(sqlData, 2);
        //                returnList.Add(returnValue);
        //            }
        //            sqlData.Close();
        //        }

        //        com.Parameters.Clear();
        //        com.Cancel();
        //        com.Dispose();
        //        trn.Commit();
        //        #endregion
        //    }
        //    catch (Exception ex)
        //    {
        //        if (inTrans == true)
        //            trn.Rollback();

        //        returnList = null;
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

        //    return returnList;


        //}

        //public System.Windows.Forms.AutoCompleteStringCollection getAllDiagnosisName()
        //{
        //    clsDiagnosisMaster returnValue = null;
        //    System.Windows.Forms.AutoCompleteStringCollection returnList = null;
        //    bool inTrans = false;
        //    try
        //    {

        //        result = false;
        //        string chkSQL = string.Empty;
        //        con = new SqlConnection(clsMisc.getSQLConnection());
        //        con.Open();
        //        trn = con.BeginTransaction(IsolationLevel.ReadCommitted);

        //        #region CheckInsuranceExits

        //        com = new SqlCommand();
        //        com.Connection = con;
        //        com.CommandType = CommandType.Text;

        //        chkSQL = "SELECT [DiagnosisCode],[DiagnosisName],[IsActive] FROM [DiagnosisMaster]";// WHERE";// DiagnosisCode=@DiagnosisCode";
        //        com.CommandText = chkSQL;
        //        //com.Parameters.Add("@DiagnosisCode", SqlDbType.VarChar, 10).Value = code;


        //        com.Transaction = trn;
        //        SqlDataReader sqlData = com.ExecuteReader();
        //        if (sqlData != null)
        //        {
        //            returnList = new System.Windows.Forms.AutoCompleteStringCollection();
        //            while (sqlData.Read())
        //            {
        //                returnValue = new clsDiagnosisMaster();
        //                returnValue.DiagnosisCode = clsMisc.SafeGetString(sqlData, 0);
        //                returnValue.DiagnosisName = clsMisc.SafeGetString(sqlData, 1);
        //                returnValue.DiagnosisIsActive = clsMisc.SafeGetBoolean(sqlData, 2);
        //                returnList.Add(returnValue.DiagnosisName);
        //            }
        //            sqlData.Close();
        //        }

        //        com.Parameters.Clear();
        //        com.Cancel();
        //        com.Dispose();
        //        trn.Commit();
        //        #endregion
        //    }
        //    catch (Exception ex)
        //    {
        //        if (inTrans == true)
        //            trn.Rollback();

        //        returnList = null;
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

        //    return returnList;


        //}

        //public clsDiagnosisMaster getDiagnosisCodeByName(string DiagName)
        //{
        //    clsDiagnosisMaster returnValue = null;
        //    bool inTrans = false;
        //    try
        //    {

        //        result = false;
        //        string chkSQL = string.Empty;
        //        con = new SqlConnection(clsMisc.getSQLConnection());
        //        con.Open();
        //        trn = con.BeginTransaction(IsolationLevel.ReadCommitted);

        //        #region CheckInsuranceExits

        //        com = new SqlCommand();
        //        com.Connection = con;
        //        com.CommandType = CommandType.Text;

        //        chkSQL = "SELECT [DiagnosisCode],[DiagnosisName],[IsActive] FROM [DiagnosisMaster] WHERE DiagnosisName=@DiagName";
        //        com.CommandText = chkSQL;
        //        com.Parameters.Add("@DiagName", SqlDbType.VarChar, 500).Value = DiagName;


        //        com.Transaction = trn;
        //        SqlDataReader sqlData = com.ExecuteReader();
        //        if (sqlData != null)
        //        {
        //            while (sqlData.Read())
        //            {
        //                returnValue = new clsDiagnosisMaster();
        //                returnValue.DiagnosisCode = clsMisc.SafeGetString(sqlData, 0);
        //                returnValue.DiagnosisName = clsMisc.SafeGetString(sqlData, 1);
        //                returnValue.DiagnosisIsActive = clsMisc.SafeGetBoolean(sqlData, 2);

        //            }
        //            sqlData.Close();
        //        }

        //        com.Parameters.Clear();
        //        com.Cancel();
        //        com.Dispose();
        //        trn.Commit();
        //        #endregion
        //    }
        //    catch (Exception ex)
        //    {
        //        if (inTrans == true)
        //            trn.Rollback();

        //        returnValue = null;
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

        //    return returnValue;


        //}
    
    }
}
