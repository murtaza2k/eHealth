using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHealth.Model
{
    public class clsSpecialityMaster
    {

        private Int32 m_Specialityid;
        public Int32 SpecialityID
        {
            get { return m_Specialityid; }
            set { m_Specialityid = value; }
        }
        private string m_SpecialityName;
        public string SpecialityName
        {
            get { return m_SpecialityName; }
            set { m_SpecialityName = value; }
        }
    }
}
