using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHealth.Model
{
    public class clsRole
    {
        private string _RoleID = string.Empty;
        private string _Right = string.Empty;
        private bool _Add = false;
        private bool _Edit = false;
        private bool _Delete = false;
        private bool _Approval = false;

        private bool _DocumentAdd = false;
        private bool _DocumentEdit = false;
        private bool _DocumentDelete = false;




        public string RoleId
        {
            set { _RoleID = value; }
            get { return _RoleID; }
        }

        public string Right
        {
            set { _Right = value; }
            get { return _Right; }
        }

        public bool Add
        {
            set { _Add = value; }
            get { return _Add; }
        }

        public bool Edit
        {
            set { _Edit = value; }
            get { return _Edit; }
        }

        public bool Delete
        {
            set { _Delete = value; }
            get { return _Delete; }
        }

        public bool Approval
        {
            set { _Approval = value; }
            get { return _Approval; }
        }

        public bool DocumentAdd
        {
            set { _DocumentAdd = value; }
            get { return _DocumentAdd; }
        }

        public bool DocumentEdit
        {
            set { _DocumentEdit = value; }
            get { return _DocumentEdit; }
        }
        public bool DocumentDelete
        {
            set { _DocumentDelete = value; }
            get { return _DocumentDelete; }
        }


    }
}
