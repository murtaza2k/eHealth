using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eHealth.BusinessLogic;
using eHealth.Model.Common;

namespace eHealth
{
    public partial class frmInsuranceMaster : Form
    {

        /* Variable Declaration */
        private FormAction action;
        public frmInsuranceMaster()
        {
            InitializeComponent();
        }

        private void frmInsuranceMaster_Load(object sender, EventArgs e)
        {
            action = FormAction.Add;

        }
    }
}
