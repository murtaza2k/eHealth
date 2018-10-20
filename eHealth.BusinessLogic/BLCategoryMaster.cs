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
   public class BLCategoryMaster
    {
           DBHelper _helper;

       public BLCategoryMaster()
        {
        _helper = new DBHelper();
        }

       public  Boolean checkCodeExists(string stringCategoryCode)
        {
            string sSQLQuery = "";
            IDataReader dataReader = null;
        
            clsCategoryMaster categoryExists = null;
            Boolean returnValue = false;

            try
            {
                sSQLQuery = "SELECT * FROM ehealth.categorymaster='" + stringCategoryCode + "'";
                DBHelper _helpder = new DBHelper();

                dataReader = _helpder.ExecuteDataReader(sSQLQuery, null);

                while (dataReader.Read())
                {
                    categoryExists = new clsCategoryMaster();
                        categoryExists.CategoryCode = dataReader.GetString(0);
                        categoryExists.CategoryDescription = dataReader.GetString(1);
                        categoryExists.IsActive = dataReader.GetString(2);

                        returnValue = true;
                        
                }
                dataReader.Close();

            }
            catch (Exception ex)
            {
                categoryExists = null;
                returnValue = false;

            }
            finally
            {

            }

            return returnValue;


        }
     
       public Boolean insert(string stringCategoryCode,string stringCategoryDescription,string stringIsActive,string stringCreatedBy)
        {
            string sSQLQuery = "";
            Boolean returnValue =false;
            IDbTransaction transaction = null;

            try
            {
                sSQLQuery = "INSERT INTO  ehealth.categorymaster (Code,Description,IsActive,CreatedBy,CreatedDateTime) VALUES " +
                            "(@Code,@Description,@IsActive,@CreatedBy,@CreatedDateTime)";
                DBHelper _helpder = new DBHelper();

                DBParameter paramCode = new DBParameter("@Code", stringCategoryCode);
                DBParameter paramDescription = new DBParameter("@Description", stringCategoryDescription);
                DBParameter paramIsActive = new DBParameter("@IsActive", stringIsActive);
                DBParameter paramCreatedBy = new DBParameter("@CreatedBy", stringCreatedBy);
                DBParameter paramCreatedDateTime = new DBParameter("@CreatedDateTime", DateTime.Now.ToString("yyyy-MM-dd hh:mm"));

                DBParameterCollection paramCollection = new DBParameterCollection();
                paramCollection.Add(paramCode);
                paramCollection.Add(paramDescription);
                paramCollection.Add(paramIsActive);
                paramCollection.Add(paramCreatedBy);
                paramCollection.Add(paramCreatedDateTime);

                transaction = _helpder.BeginTransaction();

                
                    _helpder.ExecuteScalar(sSQLQuery, paramCollection, transaction);
                transaction.Commit();

                returnValue = true;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                returnValue = false;
            }
            finally
            {
                transaction.Dispose();

            }
            return returnValue;
        }
    
       public DataSet getAllCategoryMaster()
        {
            string sSQLQuery;
            DataSet  dt=new DataSet();
            try
            {
                sSQLQuery = "SELECT Code,Description,IsActive FROM ehealth.categorymaster";

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
    
       public DataSet getAllCategoryMaster(string searchString)
        {
            string sSQLQuery;
            DataSet dt = new DataSet();
            try
            {
                sSQLQuery = "SELECT Code,Description,IsActive FROM ehealth.categorymaster Where " + searchString;

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
       
       public List<clsSearch> getCategorySearchFields(string sXMLPath)
    {
        DataSet Dts = new DataSet();
        List<clsSearch> listStatus = new List<clsSearch>();
        Dts.ReadXml(sXMLPath + "\\Search Config\\" + "CategoryMasterSearchConfig.xml");
        foreach (System.Data.DataRow dr in Dts.Tables[0].Rows)
        {
            clsSearch cls = new clsSearch();
            cls.tblFieldId = dr[0].ToString();
            cls.TextDescription = dr[1].ToString();
            cls.DefaultValue = dr[2].ToString();
            listStatus.Add(cls);
        }
        return listStatus;
    }
    }
}
