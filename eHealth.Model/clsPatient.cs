using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHealth.Model
{
    class clsPatient
    {
        public Int32 Patientid { get; set; }
        public string MRN { get; set; }
        public string Suffix { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientMiddleName { get; set; }
        public string PatientLastName { get; set; }
        public string PatientType { get; set; }
        public string MotherMaidenName { get; set; }
        public string RegistrationType { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfDeath { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string NationalityId { get; set; }
        public string RegistrationSite { get; set; }
        public string BirthPlace { get; set; }
        public bool IsNewBorn { get; set; }
        public bool IsResident { get; set; }
        public bool IsDeath { get; set; }
        public clsCountryMaster ResidentCountry {get; set; }

        public string MergedMRN { get; set; }
        public string IntegrationCode { get; set; }
        public DateTime RegistrationDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDateTime { get; set; }

        public List<clsPatientInsurance> PatientInsuranceList  { get; set; }
        public List<clsPatientContacts> PatientContactList { get; set; }
    }
}
