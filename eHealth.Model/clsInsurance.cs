using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHealth.Model
{
    public class clsInsurance
    {

        public string InsuranceId { get; set; }
        public string InsuranceAlias { get; set; }
        public string InsuranceName { get; set; }
        public string ReceiverHAAD { get; set; }
        public string ReceiverDHA { get; set; }
        public string InsuranceType { get; set; }
        public string Address { get; set; }
        public string CityId { get; set; }
        public string CountryId { get; set; }
        public string POBox { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string IntegrationCode { get; set; }
        public bool IsSelfPaying { get; set; }
        public bool IsEAuth { get; set; }
        public bool IsERX { get; set; }
        public bool IsActive { get; set; }
        public string AccountCode { get; set; }
        public int PreApprovalValidityDays { get; set; }
        public bool IsApprovalRequiredForAdmission { get; set; }
        public bool IsRegFeeApplicable { get; set; }
        public int CreditDays { get; set; }
        public string VATTrn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDateTime { get; set; }
 

 


       
    }
}
