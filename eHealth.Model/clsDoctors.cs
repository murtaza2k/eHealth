using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHealth.Model
{
    class clsDoctors
    {
        #region Variable Declaration
        private int _DoctorId = 0;
        private string _DoctorName = string.Empty;
        private string _DoctorType = string.Empty;
        private string _DoctorEmail = string.Empty;
        private int _SpecialityId = 0;
        private string _Speciality = string.Empty;
        private string _UserID = string.Empty;


        private string _DoctorEmpCode = string.Empty;
        private string _DoctorDHCCLicenseCode = string.Empty;
        private string _DoctorDHALicenseCode = string.Empty;
        private bool _DoctorIsActive = true;
        private string _DoctorLocation = string.Empty;



        #endregion

        #region Property

        public Int32 DoctorId
        {
            get { return _DoctorId; }
            set { _DoctorId = value; }
        }

        public string DoctorName
        {
            get { return _DoctorName; }
            set { _DoctorName = value; }
        }

        public Int32 SpecialityId
        {
            get { return _SpecialityId; }
            set { _SpecialityId = value; }
        }

        public string UserID
        {
            get { return _UserID; }
            set { _UserID = value; }
        }

        public string DoctorType
        {
            get { return _DoctorType; }
            set { _DoctorType = value; }
        }

        public string doctorEmailAddress
        {
            get { return _DoctorEmail; }
            set { _DoctorEmail = value; }
        }

        public string DoctorHIMSCode
        {
            get { return _DoctorEmpCode; }
            set { _DoctorEmpCode = value; }
        }
        public string DHCCLicenseNo
        {
            get { return _DoctorDHCCLicenseCode; }
            set { _DoctorDHCCLicenseCode = value; }
        }

        public string DHALicenseNo
        {
            get { return _DoctorDHALicenseCode; }
            set { _DoctorDHALicenseCode = value; }
        }

        public bool IsActive
        {
            get { return _DoctorIsActive; }
            set { _DoctorIsActive = value; }
        }

        public string DoctorLocation
        {
            get { return _DoctorLocation; }
            set { _DoctorLocation = value; }
        }


        #endregion


    }
}
