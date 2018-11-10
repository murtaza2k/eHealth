using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eHealth
{
    public partial class frmPlanMaster : Form
    {

        public string InsuranceId { get; set; }
        public string InsuranceName { get; set; }
        public string DHAReceiverId { get; set; }
        public string HaadReceiverId { get; set; }

        public bool IsEAuth { get; set; }
        public bool IsERX { get; set; }


        public frmPlanMaster()
        {
            InitializeComponent();
         
        }

        private void frmPlanMaster_Load(object sender, EventArgs e)
        {
            lblPlanName.Text = InsuranceName;
            lblPlanName.Tag = InsuranceId;
            textBoxHaadReceiverId.Text = HaadReceiverId;
            textboxReceiverId.Text = DHAReceiverId;
            checkBoxEAuth.Checked = IsEAuth;
            checkBoxERx.Checked = IsERX;

        }
    }
}
