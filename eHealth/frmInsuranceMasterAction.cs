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
    public partial class frmInsuranceMasterAction : Form
    {

        BLInsuranceMaster BLIns;
        System.Windows.Forms.AutoCompleteStringCollection insuranceList;
        public string selectedInsuranceId { get; set; }
        public string selectedInsuranceName { get; set; }

        public frmInsuranceMasterAction()
        {
            InitializeComponent();
        }
        public frmInsuranceMasterAction(string formName)
        {
            InitializeComponent();
            
        }        
        private void frmInsuranceMasterAction_Load(object sender, EventArgs e)
        {
            //// this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //txtDiagnosisName.AutoCompleteCustomSource = clsMisc.diagnosisCollection;
            //txtDiagnosisName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //txtDiagnosisName.AutoCompleteMode = AutoCompleteMode.Suggest;
            BLIns = new BLInsuranceMaster();
            insuranceList = BLIns.getInsuranceList();
            textBoxSearch.AutoCompleteCustomSource = insuranceList;
            textBoxSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }
   

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string[] selectedString = textBoxSearch.Text.Split('#');
            if (selectedString.Length > 1)
            {
                this.selectedInsuranceId = selectedString[1];
                this.selectedInsuranceName = selectedString[0];

            }
            this.Hide();
        }
    }
}
