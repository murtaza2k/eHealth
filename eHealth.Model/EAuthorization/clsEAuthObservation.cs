using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eHealth.DHPO.Schema.PriorRequest;

namespace eHealth.Model
{
    class clsEAuthObservation
    {
        
        public ObservationType EAuthObservationType { get; set; }
        public string ObservationCode { get; set; }
        public string ObservationValue { get; set; }
        public string ObservationValueType { get; set; }
        public string ObservationId { get; set; }
    }
}
