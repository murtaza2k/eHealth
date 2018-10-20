using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHealth.Model
{
    class clsProvider
    {

        public string SourceLocation { get; set; }
        public string SQLConnectionString { get; set; }
        public string FacilityID { get; set; }
        public string FacilityPassword { get; set; }
        public string IsEAuth { get; set; }
        public string LicenseCode { get; set; }
        private bool result = false;

    }
}
