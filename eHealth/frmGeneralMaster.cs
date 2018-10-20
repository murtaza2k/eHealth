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

namespace eHealth
{
    public partial class frmGeneralMaster : Form
    {
        public frmGeneralMaster()
        {
            InitializeComponent();
        }

        private void frmGeneralMaster_Load(object sender, EventArgs e)
        {
            fillCategoryList();
        }
        private void fillCategoryList()
        {
            BLCategoryMaster fillAction = new BLCategoryMaster();
            DataSet dt = fillAction.getAllCategoryMaster();
           // comboBoxCategoryCode.Items.Clear();
            comboBoxCategoryCode.DataSource = dt.Tables[0];
            comboBoxCategoryCode.ValueMember = "Code";
            comboBoxCategoryCode.DisplayMember = "Description";
            


        }
    }
}
