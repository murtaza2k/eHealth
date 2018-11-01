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
using eHealth.BusinessLogic;
namespace eHealth
{
    public partial class frmInsuranceMaster : Form
    {

        /* Variable Declaration */
        private FormAction action;
        private DataSet dsInsuranceType;
        private DataSet dsCountryMaster;

        public frmInsuranceMaster()
        {
            InitializeComponent();
        }
        void setControlAndObjects()
        {
            action = FormAction.Add;
        }

        private void frmInsuranceMaster_Load(object sender, EventArgs e)
        {
            action = FormAction.Add;
            fillInsuranceType();
            fillcountryMaster();
        }

        public  void fillInsuranceType()
        {
            try
            {
               BLGeneralMaster obj = new BLGeneralMaster();
               dsInsuranceType= obj.getSponsorType();
               comboboxInsuranceType.DataSource = dsInsuranceType.Tables[0];
               comboboxInsuranceType.DisplayMember = "Description";
               comboboxInsuranceType.ValueMember = "Code";

            }
            catch (Exception ex)
            {

            }


        }
        public void fillcountryMaster()
        {
            try
            {
                BLCountry obj = new BLCountry();
                dsCountryMaster = obj.getAllCountry();
                comboBoxCountry.DataSource = dsCountryMaster.Tables[0];
                comboBoxCountry.DisplayMember = "CountryName";
                comboBoxCountry.ValueMember = "CountryCode";

            }
            catch (Exception ex)
            {

            }


        }
    }
}
