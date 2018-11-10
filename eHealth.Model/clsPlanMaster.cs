using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHealth.Model
{
    class clsPlanMaster
    {
        public Int32 InsuranceID { get; set; }
        public string OrganisationCode { get; set; }
        public string PlanCode { get; set; }
        public string PlanName { get; set; }
        public bool IsEAuth { get; set; }
        public string PayerID { get; set; }
        public string Status { get; set; }
        public string UserID { get; set; }

    
        //   private SqlDataAdapter dapter = null;
        //     private DataSet dset = null;
        private bool result = false;
    }
   public  class PlanMaster
    {
        public string  PlanId {get;set;}
        public string   InsuranceId{get;set;}
        public string  PlanAlias{get;set;}
        public string  PlanName{get;set;}
        public string  PayerHAAD{get;set;}
        public string  PayerDHA{get;set;}
        public string   PlanType{get;set;}
        public string   IntegrationCode{get;set;}
        public bool  IsSelfPaying{get;set;}
        public bool  IsEAuth{get;set;}
        public bool   IsERX{get;set;}
        public bool  IsERXSubmission{get;set;}
        public bool  IsEClaim{get;set;}
        public bool  PreApprovalOP{get;set;}
        public bool  PreApprovalIP{get;set;}
        public bool  PreApprovalAE{get;set;}
        public bool  PreApprovalEX{get;set;}
        public bool  IsApprovalRequiredForAdmission{get;set;}
        public bool  IsSelfERX{get;set;}
        public bool  IsApplicableForOP{get;set;}
        public bool   IsApplicableForIP{get;set;}
        public bool  IsApplicableForAE{get;set;}
        public string  CreatedBy{get;set;}
        public DateTime CreatedDateTime{get;set;}
        public string  ModifiedBy{get;set;}
        public DateTime ModifiedDateTime { get; set; }
    }
}
