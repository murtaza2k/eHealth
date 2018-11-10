using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eHealth.Connection;
using eHealth.Model;
using System.Data;
using System.Windows;

namespace eHealth.BusinessLogic
{
   public  class BLInsuranceMaster
    {
        DBHelper _helper;

        public BLInsuranceMaster()
        {
            _helper = new DBHelper();
        }

        public bool insert(clsInsurance obj, out string output)
        {
            string sSQLQuery = "";
           Boolean returnValue = false;
           IDbTransaction transaction = null;
          
           
           try
           {

               transaction = _helper.BeginTransaction();
               obj.InsuranceId =    KeyCounter.getPrimaryKey("insurancemaster", "InsuranceId", _helper, transaction);

            sSQLQuery = "INSERT INTO insurancemaster (InsuranceId,InsuranceAlias,InsuranceName,ReceiverHAAD, " +
                         " ReceiverDHA,InsuranceType,Address,CityId,CountryId,POBox,Email,Phone,Fax,IntegrationCode, " +
                         " IsSelfPaying,IsEAuth,IsERX,IsActive,AccountCode,PreApprovalValidityDays,IsApprovalRequiredForAdmission, " +
                         " IsRegFeeApplicable,CreditDays,VATTrn,CreatedBy,CreatedDateTime) " +
                         " VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}',{14} " +
                         ",{15},{16},{17},'{18}','{19}',{20},{21},'{22}','{23}','{24}','{25}')";

            string sqlCommand = string.Format(sSQLQuery, new object[] { obj.InsuranceId,obj.InsuranceAlias,obj.InsuranceName,
                                     obj.ReceiverHAAD,obj.ReceiverDHA,obj.InsuranceType,obj.Address,obj.CityId,obj.CountryId,obj.POBox,
                                     obj.Email,obj.Phone,obj.Fax,obj.IntegrationCode,obj.IsSelfPaying,obj.IsEAuth,obj.IsERX,
                                     obj.IsActive,obj.AccountCode,obj.PreApprovalValidityDays,obj.IsApprovalRequiredForAdmission,obj.IsRegFeeApplicable,
                                     obj.CreditDays,obj.VATTrn,obj.CreatedBy,obj.CreatedDateTime.ToString("yyyy-MM-dd HH:mm:ss")
            });

            _helper.ExecuteScalar(sqlCommand, transaction);
           if ( KeyCounter.updatePrimaryKey("insurancemaster", "InsuranceId", _helper, transaction)==true)
                    _helper.CommitTransaction(transaction);

            output = string.Empty;
            returnValue = true;
          //  _helper.RollbackTransaction(transaction);
           }
           catch (Exception ex)
           {
               _helper.RollbackTransaction(transaction);
               returnValue = false;
              
               output = ex.ToString();

           }
           return returnValue;
        }
        public bool update(clsInsurance obj, out string output)
        {
            string sSQLQuery = "";
            Boolean returnValue = false;
            IDbTransaction transaction = null;


            try
            {

                transaction = _helper.BeginTransaction();
                ///obj.InsuranceId = KeyCounter.getPrimaryKey("insurancemaster", "InsuranceId", _helper, transaction);

                sSQLQuery = "UPDATE insurancemaster set InsuranceAlias ='{0}',InsuranceName  ='{1}',ReceiverHAAD  ='{2}', " +
                             " ReceiverDHA  ='{3}',InsuranceType  ='{4}',CityId  ='{5}',CountryId  ='{6}'," +
                             " POBox= '{7}',Email ='{8}',Phone ='{9}',Fax ='{10}',IntegrationCode='{11}', " +
                             " IsSelfPaying ={12},IsEAuth ={13},IsERX={14},IsActive={15},AccountCode='{16}', " +
                             " PreApprovalValidityDays='{17}',IsApprovalRequiredForAdmission={18}, " +
                             " IsRegFeeApplicable={19},CreditDays='{20}',VATTrn='{21}',ModifiedBy='{22}',ModifiedDateTime='{23}' ,Address ='{24}' WHERE InsuranceId='{25}'";

                string sqlCommand = string.Format(sSQLQuery, new object[] {obj.InsuranceAlias,obj.InsuranceName,
                                     obj.ReceiverHAAD,obj.ReceiverDHA,obj.InsuranceType,obj.CityId,obj.CountryId,obj.POBox,
                                     obj.Email,obj.Phone,obj.Fax,obj.IntegrationCode,obj.IsSelfPaying,obj.IsEAuth,obj.IsERX,
                                     obj.IsActive,obj.AccountCode,obj.PreApprovalValidityDays,obj.IsApprovalRequiredForAdmission,obj.IsRegFeeApplicable,
                                     obj.CreditDays,obj.VATTrn,obj.CreatedBy,obj.CreatedDateTime.ToString("yyyy-MM-dd HH:mm:ss"),obj.Address,obj.InsuranceId
            });

                _helper.ExecuteScalar(sqlCommand, transaction);
             //   if (KeyCounter.updatePrimaryKey("insurancemaster", "InsuranceId", _helper, transaction) == true)
                    _helper.CommitTransaction(transaction);

                output = string.Empty;
                returnValue = true;
                //  _helper.RollbackTransaction(transaction);
            }
            catch (Exception ex)
            {
                _helper.RollbackTransaction(transaction);
                returnValue = false;

                output = ex.ToString();

            }
            return returnValue;
        }
        public System.Windows.Forms.AutoCompleteStringCollection getInsuranceList()
        {
            System.Windows.Forms.AutoCompleteStringCollection list = null; 
            string sSQLQuery;
            DataSet ds = new DataSet();
            clsInsurance clsIns;
            try
            {
                sSQLQuery = "SELECT InsuranceId , InsuranceName  FROM insurancemaster  WHERE IsActive =1 ;";

                ds = _helper.ExecuteDataSet(sSQLQuery);

                list = new System.Windows.Forms.AutoCompleteStringCollection();
                foreach (DataRow dRow in ds.Tables[0].Rows)
                {
                    clsIns = new clsInsurance();
                    clsIns.InsuranceId = dRow[0].ToString();
                    clsIns.InsuranceName = dRow[1].ToString();
                    list.Add(clsIns.InsuranceName + "#" + clsIns.InsuranceId.ToString());

                }

            }
            catch (Exception ex)
            {
                ds = null;

            }
            finally
            {

            }
            return list;

        }

        public clsInsurance getInsuranceForEdit(string sInsuranceId)
        {
      
            string sSQLQuery;
            IDataReader reader = null ;
            clsInsurance clsIns = null; ;
             
            try
            {
                sSQLQuery = "SELECT InsuranceId, " +
                            " InsuranceAlias,InsuranceName,ReceiverHAAD,ReceiverDHA,InsuranceType," +
                            " Address,CityId,CountryId,POBox,Email,Phone,Fax," +
                            " IntegrationCode,IsSelfPaying,IsEAuth,IsERX,IsActive," +
                            " AccountCode,PreApprovalValidityDays,IsApprovalRequiredForAdmission,IsRegFeeApplicable," +
                            " CreditDays,VATTrn,CreatedBy,CreatedDateTime,ModifiedBy,ModifiedDateTime" +
                            " FROM insurancemaster WHERE InsuranceId=@InsuranceId"; 


               

                DBParameter paramInsuranceId = new DBParameter("@InsuranceId", sInsuranceId);
              
                DBParameterCollection paramCollection = new DBParameterCollection();
                paramCollection.Add(paramInsuranceId);

                IDbConnection conn = _helper.GetConnObject();

                reader = _helper.ExecuteDataReader(sSQLQuery, conn, paramInsuranceId);

                while (reader.Read())
                {
                    clsIns = new clsInsurance();
                    clsIns.InsuranceId = reader[0].ToString();clsIns.InsuranceAlias = reader[1].ToString();
                    clsIns.InsuranceName = reader[2].ToString();clsIns.ReceiverHAAD = reader[3].ToString();
                    clsIns.ReceiverDHA = reader[4].ToString(); clsIns.InsuranceType = reader[5].ToString();
                    clsIns.Address = reader[6].ToString(); clsIns.CityId = reader[7].ToString(); clsIns.CountryId = reader[8].ToString();
                    clsIns.POBox = reader[9].ToString(); clsIns.Email = reader[10].ToString(); clsIns.Phone = reader[11].ToString();
                    clsIns.Fax = reader[12].ToString(); clsIns.IntegrationCode = reader[13].ToString(); clsIns.IsSelfPaying = reader.GetBoolean(14);
                    clsIns.IsEAuth = reader.GetBoolean(15); clsIns.IsERX = reader.GetBoolean(16); clsIns.IsActive = reader.GetBoolean(17);
                    clsIns.AccountCode = reader[18].ToString(); clsIns.PreApprovalValidityDays =reader.GetInt32(19); clsIns.IsApprovalRequiredForAdmission =reader.GetBoolean(20);
                    clsIns.IsRegFeeApplicable = reader.GetBoolean(21); clsIns.CreditDays = reader.GetInt32(22); clsIns.VATTrn = reader[23].ToString();
                }

            }
            catch (Exception ex)
            {
                
                clsIns = null;
            }
            finally
            {
                reader.Close();
                reader.Dispose();
            }
            return clsIns;

        }
    }
}
