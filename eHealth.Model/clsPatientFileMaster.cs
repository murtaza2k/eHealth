using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHealth.Model
{
    public class clsPatientFileMaster
    {

        private bool result = false;

        private string m_MRNNo;
        public string MRNNo
        {
            get { return m_MRNNo; }
            set { m_MRNNo = value; }
        }

        private string m_PatientName;
        public string PatientName
        {
            get { return m_PatientName; }
            set { m_PatientName = value; }
        }

        private DateTime m_DOB = DateTime.MinValue;
        public DateTime DOB
        {
            get { return m_DOB; }
            set { m_DOB = value; }
        }

        private DateTime m_PatientInsuranceExpiry = DateTime.MinValue;
        public DateTime PatientInsuranceExpiry
        {
            get { return m_PatientInsuranceExpiry; }
            set { m_PatientInsuranceExpiry = value; }
        }

        private string m_Gender;
        public string Gender
        {
            get { return m_Gender; }
            set { m_Gender = value; }
        }
        private string m_CurrentLocation;
        public string CurrentLocation
        {
            get { return m_CurrentLocation; }
            set { m_CurrentLocation = value; }
        }
        private int m_CurrentInsuranceId;
        public int CurrentInsuranceId
        {
            get { return m_CurrentInsuranceId; }
            set { m_CurrentInsuranceId = value; }
        }

        private string m_mobileNumber;
        public string MobileNumber
        {
            get { return m_mobileNumber; }
            set { m_mobileNumber = value; }
        }

        private string m_PolicyNumber;
        public string PolicyNumber
        {
            get { return m_PolicyNumber; }
            set { m_PolicyNumber = value; }
        }
        private string m_PlanName;
        public string PlanName
        {
            get { return m_PlanName; }
            set { m_PlanName = value; }
        }

        private string _EmiratesID;
        public string EmiratesID
        {
            get { return _EmiratesID; }
            set { _EmiratesID = value; }
        }
    }
}
