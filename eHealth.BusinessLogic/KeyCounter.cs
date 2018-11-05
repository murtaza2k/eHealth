using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eHealth.Connection;
using System.Data;

namespace eHealth.BusinessLogic
{
    public static class KeyCounter
    {

        public  static string getPrimaryKey(string tableName, string fieldName ,DBHelper dbHelper , IDbTransaction transaction )
        {

            string sSQLQuery = "";
            Boolean returnValue = false;
            string stringPrefix = string.Empty;
            Int32 intLastValue = 0;
            string output = string.Empty;
            IDataReader dataR = null;
            try
            {
                sSQLQuery = "SELECT  TableName, FieldId , Prefix , LastValue FROM counter " +
                            " WHERE TableName=@TableName AND FieldId =@FieldName";

                DBParameter paramTableName = new DBParameter("@TableName", tableName);
                DBParameter paramFieldId = new DBParameter("@FieldName", fieldName);
               
                DBParameterCollection paramCollection = new DBParameterCollection();
                paramCollection.Add(paramTableName);
                paramCollection.Add(paramFieldId);

                 dataR =  dbHelper.ExecuteDataReader(sSQLQuery, paramCollection,transaction);

                 while (dataR.Read())
                 {
                     intLastValue = dataR.GetInt32(3);
                     stringPrefix = dataR.GetString(2);

                 }
                 intLastValue++;
                 output = stringPrefix + Convert.ToString((intLastValue));
                 dataR.Close();
                // transaction.Commit();
              
               
            }
            catch (Exception ex)
            {
                output = string.Empty;
               
                
            }
            finally
            {
                dataR = null;
          
            }
            return output;

        }

        public static bool updatePrimaryKey(string tableName, string fieldName, DBHelper dbHelper, IDbTransaction transaction)
        {

            string sSQLQuery = "";
       
            string stringPrefix = string.Empty;
           
            bool output = false;
         
            try
            {
                sSQLQuery = "UPDATE counter set LastValue=LastValue+1 " +
                            " WHERE TableName=@TableName AND FieldId =@FieldName";

                DBParameter paramTableName = new DBParameter("@TableName", tableName);
                DBParameter paramFieldId = new DBParameter("@FieldName", fieldName);

                DBParameterCollection paramCollection = new DBParameterCollection();
                paramCollection.Add(paramTableName);
                paramCollection.Add(paramFieldId);

               dbHelper.ExecuteNonQuery(sSQLQuery, paramCollection, transaction);
               output = true;
           

            }
            catch (Exception ex)
            {
                output = false;
            }
            finally
            {
               

            }
            return output;

        }

    }
}
