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
        private DataSet dsNationalities;

        public frmPatRegistration()
        {
            InitializeComponent();
            comboBoxCountryOfResidence.SelectionChangeCommitted += comboBoxCountryOfResidence_SelectionChangeCommitted;
        }

        void comboBoxCountryOfResidence_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            DataRowView row =(DataRowView) comboBoxCountryOfResidence.SelectedItem;
            if (row != null)
            {
                if (row[2] != null)
                {
                    maskedTextBoxMobileNo.Text = row[2].ToString();
                }
            }
        }

        private void frmPatRegistration_Load(object sender, EventArgs e)
        {
            fillInsuranceType();
            fillcountryMaster();
            fillNationalitiesMaster();
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
        public void fillNationalitiesMaster()
        {
            try
            {
                BLGeneralMaster obj = new BLGeneralMaster();
                dsNationalities = obj.getNationalities();
                comboBoxNationality.DataSource = dsNationalities.Tables[0];
                comboBoxNationality.DisplayMember = "Description";
                comboBoxNationality.ValueMember = "Code";

            }
            catch (Exception ex)
            {

            }

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            errorProviderReg.Clear();
            //Validate the patient details
           bool IsValid =  validatePatientDemographic();


        }

        private Boolean validatePatientDemographic()
        {
            bool IsValid = true;
            //var controls = new[] { textBoxFirstName.Text, textBoxLastName.Text,maskedTextBoxMobileNo.Text,textBoxEmergencyContact.Text,maskedTextBoxEmergencyMobileNo.Text};
            //if (controls.All(x => string.IsNullOrEmpty(x)))
            //    IsValid = true;

            
         //   IsValid = !(string.IsNullOrEmpty(textBoxFirstName.Text) && string.IsNullOrEmpty(textBoxLastName.Text));
         //   IsValid = !(string.IsNullOrEmpty(comboBoxGender.Text) && string.IsNullOrEmpty(comboBoxMaritalStatus.Text));
            errorProviderReg.RightToLeft = true;
            TextBox[] newTextBox = { textBoxFirstName, textBoxLastName,  textBoxEmergencyContact };
            MaskedTextBox[] maskTextBox = { maskedTextBoxMobileNo, maskedTextBoxEmergencyMobileNo };
            for (int inti = 0; inti < newTextBox.Length; inti++)
            {
                if  (string.IsNullOrEmpty(newTextBox[inti].Text))             
                {
                     MessageBox.Show("Please fill the text box");
                     newTextBox[inti].Focus();
                     errorProviderReg.SetError(newTextBox[inti], "Please fill the text box");
                  
                    return false;
                }
            }
            for (int inti = 0; inti < maskTextBox.Length; inti++)
            {
                if (string.IsNullOrEmpty(maskTextBox[inti].Text))
                {
                    MessageBox.Show("Please fill the text box");
                    maskTextBox[inti].Focus();
                    errorProviderReg.SetError(maskTextBox[inti], "Please fill the text box");

                    return false;
                }
            }

            return IsValid;
        }

        private void buttonAddPlan_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
      
    }
}
