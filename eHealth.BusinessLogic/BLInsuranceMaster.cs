using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eHealth.Connection;
using eHealth.Model;
using System.Data;


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
                             " POBox= ='{7}',Email ='{8}',Phone ='{9}',Fax ='{10}',IntegrationCode='{11}', " +
                             " IsSelfPaying ={12},IsEAuth ={13},IsERX={14},IsActive={15},AccountCode='{16}', " +
                             " PreApprovalValidityDays='{17}',IsApprovalRequiredForAdmission={18}, " +
                             " IsRegFeeApplicable={19},CreditDays='{20}',VATTrn='{21}',ModifiedBy='{22}',ModifiedDateTime='{23}' ,Address ='{24}'   WHERE InsuranceId=='{25}'";

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
    }
}
