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
   public  class BLGeneralMaster
    {
       DBHelper _helper;
       public BLGeneralMaster()
       {
           _helper = new DBHelper();
       }

       public Boolean insert(string stringGeneralMasterCode, string stringGeneralDescription, string stringCategoryCode, bool boolIsActive, string stringCreatedBy, out string output)
       {
           string sSQLQuery = "";
           Boolean returnValue = false;
           IDbTransaction transaction = null;

           try
           {
               sSQLQuery = "INSERT INTO  generalmaster (Code,Description,CategoryCode,IsActive,CreatedBy,CreatedDateTime) VALUES " +
                           "(@Code,@Description,@CategoryCode,@IsActive,@CreatedBy,@CreatedDateTime)";
               DBHelper _helpder = new DBHelper();

               DBParameter paramCode = new DBParameter("@Code", stringGeneralMasterCode);
               DBParameter paramDescription = new DBParameter("@Description", stringGeneralDescription);
               DBParameter paramCategoryCode = new DBParameter("@CategoryCode", stringCategoryCode);
               DBParameter paramIsActive = new DBParameter("@IsActive", boolIsActive, DbType.Boolean);
               DBParameter paramCreatedBy = new DBParameter("@CreatedBy", stringCreatedBy);
               DBParameter paramCreatedDateTime = new DBParameter("@CreatedDateTime", DateTime.Now.ToString("yyyy-MM-dd hh:mm"));

               DBParameterCollection paramCollection = new DBParameterCollection();
               paramCollection.Add(paramCode);
               paramCollection.Add(paramDescription);
               paramCollection.Add(paramCategoryCode);
               paramCollection.Add(paramIsActive);
               paramCollection.Add(paramCreatedBy);
               paramCollection.Add(paramCreatedDateTime);

               transaction = _helpder.BeginTransaction();


               _helpder.ExecuteScalar(sSQLQuery, paramCollection, transaction);
               transaction.Commit();
               output = string.Empty;
               returnValue = true;
               
           }
           catch (Exception ex)
           {
               output = ex.ToString();
               transaction.Rollback();
               returnValue = false;
           }
           finally
           {
               transaction.Dispose();

           }
           return returnValue;
       }

       public Boolean update(string stringGeneralMasterCode, string stringGeneralDescription, string stringCategoryCode, bool boolIsActive, string stringCreatedBy, out string output)
       {
           string sSQLQuery = "";
           Boolean returnValue = false;
           IDbTransaction transaction = null;

           try
           {
               sSQLQuery = "UPDATE   generalmaster set Description=@Description,CategoryCode=@CategoryCode,IsActive=@IsActive,UpdatedBy=@UpdatedBy,UpdatedDateTime=@UpdatedDateTime " +
                           " WHERE Code =@Code";
               DBHelper _helpder = new DBHelper();

               DBParameter paramCode = new DBParameter("@Code", stringGeneralMasterCode);
               DBParameter paramDescription = new DBParameter("@Description", stringGeneralDescription);
               DBParameter paramCategoryCode = new DBParameter("@CategoryCode", stringCategoryCode);
               DBParameter paramIsActive = new DBParameter("@IsActive", boolIsActive, DbType.Boolean);
               DBParameter paramCreatedBy = new DBParameter("@UpdatedBy", stringCreatedBy);
               DBParameter paramCreatedDateTime = new DBParameter("@UpdatedDateTime", DateTime.Now.ToString("yyyy-MM-dd hh:mm"));

               DBParameterCollection paramCollection = new DBParameterCollection();
               paramCollection.Add(paramCode);
               paramCollection.Add(paramDescription);
               paramCollection.Add(paramCategoryCode);
               paramCollection.Add(paramIsActive);
               paramCollection.Add(paramCreatedBy);
               paramCollection.Add(paramCreatedDateTime);

               transaction = _helpder.BeginTransaction();


               _helpder.ExecuteScalar(sSQLQuery, paramCollection, transaction);
               transaction.Commit();
               output = string.Empty;
               returnValue = true;
           }
           catch (Exception ex)
           {
               output = ex.ToString();
               transaction.Rollback();
               returnValue = false;
           }
           finally
           {
               transaction.Dispose();

           }
           return returnValue;
       }

       public DataSet getAllGeneralMaster()
       {
           string sSQLQuery;
           DataSet dt = new DataSet();
           try
           {
               sSQLQuery = "SELECT gm.Code,gm.Description,gm.CategoryCode,cm.Description,gm.IsActive FROM generalmaster gm INNER JOIN categorymaster cm on gm.CategoryCode = cm.Code;";

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

       public DataSet getSponsorType()
       {
           string sSQLQuery;
           DataSet dt = new DataSet();
           try
           {
               sSQLQuery = "SELECT gm.Code,gm.Description,gm.CategoryCode,cm.Description,gm.IsActive FROM generalmaster gm INNER JOIN categorymaster cm on gm.CategoryCode = cm.Code WHERE gm.IsActive =1  and  cm.Code ='INSTYPE' ;";

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
       public DataSet getNationalities()
       {
           string sSQLQuery;
           DataSet dt = new DataSet();
           try
           {
               sSQLQuery = "SELECT gm.Code,gm.Description,gm.CategoryCode,cm.Description,gm.IsActive FROM generalmaster gm INNER JOIN categorymaster cm on gm.CategoryCode = cm.Code WHERE gm.IsActive =1  and  cm.Code ='NAT' ;";

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
