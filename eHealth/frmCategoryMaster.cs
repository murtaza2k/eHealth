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
using eHealth.Model;

namespace eHealth
{
    public partial class frmCategoryMaster : Form
    {

        public frmCategoryMaster()
        {
            InitializeComponent();
        }

        private void frmCategoryMaster_Load(object sender, EventArgs e)
        {
          clearAll();
          fillSearchFields();
          fillCategoryList();
           textBoxSearch.KeyUp+=textBoxSearch_KeyUp;
        }

        void textBoxSearch_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fillCategorySearch();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            BLCategoryMaster insertAction = new BLCategoryMaster();
            if (insertAction.insert(textboxCategoryCode.Text.ToString(), textboxCategoryDescription.Text, "Y", "murtaza.ali") == true)
            {
                MessageBox.Show("Record Sucessfully Saved");
                fillCategoryList();
            }
            

        }

        private Boolean checkCodeExists(string stringCategoryCode)
        {

            return false;
        }
        private void fillCategoryList()
        {
            BLCategoryMaster fillAction = new BLCategoryMaster();
            DataSet dt=   fillAction.getAllCategoryMaster();
            dataGridViewCategoryList.Rows.Clear();
            foreach (DataRow dRow in dt.Tables[0].Rows)
            {
               Int32 iRow= dataGridViewCategoryList.Rows.Add();

               dataGridViewCategoryList.Rows[iRow].Cells["gridColCategoryCode"].Value = dRow[0];
               dataGridViewCategoryList.Rows[iRow].Cells["gridColCategoryDescription"].Value = dRow[1];
               dataGridViewCategoryList.Rows[iRow].Cells["gridColIsActive"].Value = dRow[2];

            }
        }
        private void fillCategorySearch()
        {

             

            BLCategoryMaster fillAction = new BLCategoryMaster();
            DataSet dt = fillAction.getAllCategoryMaster(buildSearchString());
            dataGridViewCategoryList.Rows.Clear();
            foreach (DataRow dRow in dt.Tables[0].Rows)
            {
                Int32 iRow = dataGridViewCategoryList.Rows.Add();

                dataGridViewCategoryList.Rows[iRow].Cells["gridColCategoryCode"].Value = dRow[0];
                dataGridViewCategoryList.Rows[iRow].Cells["gridColCategoryDescription"].Value = dRow[1];
                dataGridViewCategoryList.Rows[iRow].Cells["gridColIsActive"].Value = dRow[2];

            }
        }

        private void clearAll()
        {
            textboxCategoryCode.Text = string.Empty;
            textboxCategoryDescription.Text = string.Empty;
            comboBoxOperator.SelectedIndex = 0;
            comboBoxSearchFields.SelectedIndex = 1;
        }

        void fillSearchFields()
        {

            List<clsSearch> listStatus;
            listStatus = new BLCategoryMaster().getCategorySearchFields(Application.StartupPath.ToString());
            comboBoxSearchFields.DataSource = listStatus;
            comboBoxSearchFields.ValueMember = "tblFieldId";
            comboBoxSearchFields.DisplayMember = "TextDescription";
        }
        private string  buildSearchString()
        {
            string sSearchString = "  ";


            try
            {
               
                clsSearch selectedField = (clsSearch)comboBoxSearchFields.SelectedItem;
                if (selectedField != null)
                {
                    sSearchString = sSearchString + selectedField.tblFieldId;


                }
                if (selectedField.TextDescription.Contains("Date") == true)
                {
                   // dDateValue = dtpSearchDate.Value.ToString("yyyy-MM-dd");
                   // sSearchString = "Convert(varchar(10)," + sSearchString + ",126)" + ' ' + cboOperator.Text.ToString() + " ''" + dDateValue + "''";
                }

                else if (comboBoxOperator.Text == "Like")
                    sSearchString = sSearchString + ' ' + comboBoxOperator.Text.ToString() + " '" + textBoxSearch.Text.ToString() + "%'";
                else
                    sSearchString = sSearchString + ' ' + comboBoxOperator.Text.ToString() + " '" + textBoxSearch.Text.ToString() + "'";
              
            }

            catch (Exception ex)
            {

            }
            return sSearchString;

        }
    
    
    }

}
