using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHealth.Model
{
    class clsHISItemMaster
    {

        public string ServiceCode { get; set; }
        public string SeviceName { get; set; }
        public string HISCode { get; set; }
        public string HISServiceName { get; set; }
        public string ServiceGroup { get; set; }
        public Decimal Tariff { get; set; }
        public string ServiceType { get; set; }

    }
}
