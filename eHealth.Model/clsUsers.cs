using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHealth.Model
{
    public abstract class clsUsers
    {
        protected string _userid = string.Empty;
        protected string _username = string.Empty;
        protected string _password = string.Empty;
        protected bool _never = false;
        protected DateTime _todate = DateTime.Today;
        protected DateTime _create = DateTime.Today;
        protected Int16 _validDays = 0;
        protected DateTime _expired = DateTime.Today;
        protected string _Role = string.Empty;

        public abstract string UserID { get; set; }
        public abstract string UserName { get; set; }
        public abstract string PassWord { get; set; }
        public abstract bool Never { get; set; }
        public abstract DateTime TodayDate { get; set; }
        public abstract DateTime CreateDate { get; set; }
        public abstract Int16 ValidDays { get; set; }
        public abstract DateTime ExpireDate { get; set; }
        public abstract string UserRole { get; set; }
    }
}
