using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eHealth.Model;
using eHealth.BusinessLogic;
using eHealth.Model.Common;
namespace eHealth
{
    public partial class frmPatRegistration : Form
    {
        private FormAction action;
        private DataSet dsInsuranceType;
        private DataSet dsCountryMaster;

        public frmPatRegistration()
        {
            InitializeComponent();
        }

        private void frmPatRegistration_Load(object sender, EventArgs e)
        {
            fillInsuranceType();
            fillcountryMaster();
        }

        
        public void fillInsuranceType()
        {
            try
            {
                BLGeneralMaster obj = new BLGeneralMaster();
                dsInsuranceType = obj.getSponsorType();
                comboBoxInsuranceType.DataSource = dsInsuranceType.Tables[0];
                comboBoxInsuranceType.DisplayMember = "Description";
                comboBoxInsuranceType.ValueMember = "Code";

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
                comboBoxCountryOfResidence.DataSource = dsCountryMaster.Tables[0];
                comboBoxCountryOfResidence.DisplayMember = "CountryName";
                comboBoxCountryOfResidence.ValueMember = "CountryCode";

            }
            catch (Exception ex)
            {

            }

        }

      
    }
}
