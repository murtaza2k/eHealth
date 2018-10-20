using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHealth.Model
{
    class clsEAuthEncounter
    {
        private string _FacilityId;
        private string _Type;

        public string FacilityId
        {
            get { return _FacilityId; }
            set { _FacilityId = value; }
        }
        public string Type
        {
            get { return _Type; }
            set { _Type = value; }
        }

    }
}
