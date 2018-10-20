using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHealth.Model
{
    class clsActivityType
    {
        public string ActivityTypeCode { get; set; }
        public string ActivityTypeDesc { get; set; }


        public List<clsActivityType> getActivityType()
        {

            List<clsActivityType> List = new List<clsActivityType>();
            clsActivityType cls = new clsActivityType();
            cls.ActivityTypeCode = "3";
            cls.ActivityTypeDesc = "CPT";
            List.Add(cls);

            cls = new clsActivityType();
            cls.ActivityTypeCode = "4";
            cls.ActivityTypeDesc = "HCPCS";
            List.Add(cls);

            cls = new clsActivityType();
            cls.ActivityTypeCode = "5";
            cls.ActivityTypeDesc = "DRUG";
            List.Add(cls);

            cls = new clsActivityType();
            cls.ActivityTypeCode = "6";
            cls.ActivityTypeDesc = "DENTAL";
            List.Add(cls);

            cls = new clsActivityType();
            cls.ActivityTypeCode = "8";
            cls.ActivityTypeDesc = "SERVICE CODE";
            List.Add(cls);


            cls = new clsActivityType();
            cls.ActivityTypeCode = "8";
            cls.ActivityTypeDesc = "SCIENTIFIC CODE";
            List.Add(cls);

            return List;
        }
    }
}
