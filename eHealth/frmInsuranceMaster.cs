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
using eHealth.Model;

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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            action = FormAction.Edit;
            BLInsuranceMaster insMaster = new BLInsuranceMaster();
            string output = string.Empty;

            clsInsurance clsIns = new clsInsurance();
            clsIns.InsuranceId = string.Empty;
            clsIns.InsuranceName = textboxInsuranceName.Text.Trim().ToUpper();
            clsIns.InsuranceAlias = textboxAlias.Text.Trim().ToUpper();
            clsIns.IntegrationCode = textBoxIntegrationCode.Text.Trim().ToUpper();
            clsIns.IsActive = true;
            clsIns.IsApprovalRequiredForAdmission = checkBoxAppForAddmission.Checked;
            clsIns.IsEAuth = checkBoxEAuth.Checked;
            clsIns.IsERX = checkBoxERx.Checked;
            clsIns.IsRegFeeApplicable = checkBoxRegFees.Checked;
            clsIns.IsSelfPaying = checkBoxSelfPaying.Checked;
            clsIns.Phone = textBoxPhone.Text;
            clsIns.POBox = textBoxPOBox.Text;
            clsIns.PreApprovalValidityDays = Convert.ToInt32(textBoxPreAppValidity.Text);
            clsIns.ReceiverDHA = textboxReceiverId.Text.Trim();
            clsIns.ReceiverHAAD = textBoxHaadReceiverId.Text.Trim();
            clsIns.CreditDays = Convert.ToInt32(textBoxCreditDays.Text);
            clsIns.VATTrn = textBoxVATNo.Text.ToString();
            clsIns.CreatedBy = Environment.UserName.ToString();
            clsIns.CreatedDateTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, DateTime.Today.Hour, DateTime.Today.Minute, DateTime.Today.Second);
            clsIns.InsuranceType = (string) comboboxInsuranceType.SelectedValue;


            if (action == FormAction.Add)
            {

                if (insMaster.insert(clsIns, out output) == true)
                {
                    MessageBox.Show("Record Save Sucessfully.! Insurance id : " + clsIns.InsuranceId.ToString());
                    textboxInsuranceCode.Text = clsIns.InsuranceId.ToString();
                    action = FormAction.Edit;
                }
            }
            else if (action == FormAction.Edit)
            {
                clsIns.InsuranceId = textboxInsuranceCode.Text.ToString();
                insMaster.update(clsIns,out output);
            }
            
        }
    }
}
