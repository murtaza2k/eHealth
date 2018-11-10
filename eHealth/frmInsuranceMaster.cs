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
        private BLInsuranceMaster fBLInsurance;
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
            fBLInsurance = new BLInsuranceMaster();
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

        private bool Validation()
        {
            bool IsValid = false;
            errorProviderInsurance.RightToLeft = true;
            TextBox[] newTextBox = { textboxAlias, textboxInsuranceName };
            for (int inti = 0; inti < newTextBox.Length; inti++)
            {
                if (string.IsNullOrEmpty(newTextBox[inti].Text))
                {
                    MessageBox.Show("Please fill the text box");
                    newTextBox[inti].Focus();
                    errorProviderInsurance.SetError(newTextBox[inti], "Please fill the text box");

                    IsValid=  false;
                }
            }
            if (checkBoxERx.Checked == true)
            {
                TextBox[] newTextBoxERX = { textboxReceiverId, textBoxHaadReceiverId};
                for (int inti = 0; inti < newTextBoxERX.Length; inti++)
                {
                        if (string.IsNullOrEmpty(newTextBox[inti].Text))
                        {
                            MessageBox.Show("Please fill the text box");
                            newTextBoxERX[inti].Focus();
                            errorProviderInsurance.SetError(newTextBoxERX[inti], "Please fill the text box");

                            IsValid=  false;
                        }
                }
        }

            return IsValid;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {

            Validation();
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
            clsIns.ModifiedBy = Environment.UserName.ToString();
            clsIns.ModifiedDateTime =  new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, DateTime.Today.Hour, DateTime.Today.Minute, DateTime.Today.Second);
            clsIns.Email = textBoxEmail.Text.ToString();
            clsIns.AccountCode = textBoxAccountCode.Text;
            


            if (action == FormAction.Add)
            {

                if (insMaster.insert(clsIns, out output) == true)
                {
                    MessageBox.Show("Record Save Sucessfully.! Insurance id : " + clsIns.InsuranceId.ToString());
                    textboxInsuranceCode.Text = clsIns.InsuranceId.ToString();
                    clearControl();
                }
            }
            else if (action == FormAction.Edit)
            {
                clsIns.InsuranceId = textboxInsuranceCode.Text.ToString();
                if (insMaster.update(clsIns, out output) == true)
                {
                    MessageBox.Show("Record Save Sucessfully.! Insurance id : " + clsIns.InsuranceId);
                    clearControl();
                     
                }
            }
            
        }

        private void buttonAddPlan_Click(object sender, EventArgs e)
        {
            frmPlanMaster plan = new frmPlanMaster();
            plan.InsuranceId = textboxInsuranceCode.Text;
            plan.InsuranceName = textboxInsuranceName.Text;
            
            plan.ShowDialog(this);

        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            frmInsuranceMasterAction frmEdit = new frmInsuranceMasterAction();
            frmEdit.ShowDialog();
            if (!string.IsNullOrEmpty(frmEdit.selectedInsuranceId))
            {
                EditInsurance(frmEdit.selectedInsuranceId);   
            }
        }
        private void EditInsurance(string sInsuranceId)
        {
            action = FormAction.Edit;
            try
            {

                clsInsurance clsIns = fBLInsurance.getInsuranceForEdit(sInsuranceId);

                textboxInsuranceCode.Text =  clsIns.InsuranceId;
                textboxInsuranceName.Text = clsIns.InsuranceName;
                textboxAlias.Text = clsIns.InsuranceAlias;
                textBoxIntegrationCode.Text=clsIns.IntegrationCode ;
                checkBoxAppForAddmission.Checked = clsIns.IsApprovalRequiredForAdmission;
                checkBoxEAuth.Checked= clsIns.IsEAuth;
                checkBoxERx.Checked= clsIns.IsERX;
                checkBoxRegFees.Checked = clsIns.IsRegFeeApplicable;
                checkBoxSelfPaying.Checked = clsIns.IsSelfPaying;
                textBoxPhone.Text = clsIns.Phone;
                textBoxPOBox.Text = clsIns.POBox;
                textBoxPreAppValidity.Text =clsIns.PreApprovalValidityDays.ToString();
                textboxReceiverId.Text = clsIns.ReceiverDHA;
                textBoxHaadReceiverId.Text= clsIns.ReceiverHAAD;
                textBoxCreditDays.Text= clsIns.CreditDays.ToString();
                
                textBoxEmail.Text = clsIns.Email.ToString();
                textBoxFax.Text = clsIns.Fax.ToString();
                textBoxAccountCode.Text = clsIns.AccountCode.ToString();
                //clsIns.CreatedBy = Environment.UserName.ToString();
                //clsIns.CreatedDateTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, DateTime.Today.Hour, DateTime.Today.Minute, DateTime.Today.Second);
                comboboxInsuranceType.SelectedValue= clsIns.InsuranceType;
                textBoxVATNo.Text = clsIns.VATTrn.ToString();
                textBoxEmail.Text = clsIns.Email.ToString();


            }
            catch (Exception ex)
            {

            }

        }

        private void clearControl()
        {
            foreach (Control cntrl in this.groupBoxHeader.Controls)
                {
                    if (cntrl is TextBox)
                    {
                        cntrl.Text = string.Empty;

                    }
                }
            foreach (Control cntrl in this.groupBoxMiddle.Controls)
            {
                if (cntrl is TextBox)
                {
                    cntrl.Text = string.Empty;

                }
            }
            foreach (Control cntrl in this.groupBoxConfiguration.Controls)
            {
                if (cntrl is TextBox)
                {
                    cntrl.Text = string.Empty;

                }
                if (cntrl is CheckBox)
                {
                    (cntrl as CheckBox).Checked = false;
                }
            }
   
        }
       
    }
}
