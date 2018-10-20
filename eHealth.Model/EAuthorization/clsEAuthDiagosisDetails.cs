using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHealth.Model
{
    class clsEAuthDiagosisDetails
    {
        public Int32 TransID { get; set; }
        public string MRNNo { get; set; }
        public string VisitNo { get; set; }
        public string DIagnosisTypeCode { get; set; }
        public string DIagnosisStatus { get; set; }
        public string Source { set; get; }

    }
}
