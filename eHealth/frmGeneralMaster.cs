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
    public partial class frmGeneralMaster : Form
    {
        FormAction action = FormAction.Add;
        BLGeneralMaster general;
     
        public frmGeneralMaster()
        {
            InitializeComponent();
        }

        private void frmGeneralMaster_Load(object sender, EventArgs e)
        {
            fillCategoryList();
            fillGeneralList();
            general = new BLGeneralMaster();
        }
        private void fillCategoryList()
        {
            this.Location = new Point(10, 10);
            BLCategoryMaster fillAction = new BLCategoryMaster();
            DataSet dt = fillAction.getAllCategoryMaster();
            comboBoxCategoryCode.DataSource = dt.Tables[0];
            comboBoxCategoryCode.ValueMember = "Code";
            comboBoxCategoryCode.DisplayMember = "Description";
        }

      

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DataRowView clsCat =(DataRowView) comboBoxCategoryCode.SelectedItem;
             DataRowView dr;
            // action = FormAction.Edit;
             string output;
             if (clsCat == null)
             {
                 MessageBox.Show("Select Category..", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Stop);
             }
            if (action == FormAction.Add)

                if (general.insert(textboxGeneralCode.Text.ToString(), textboxDescription.Text, clsCat[0].ToString(), checkBoxIsActive.Checked, "murtaza.ali", out output) == true)
                {
                    MessageBox.Show("Record Sucessfully Saved");
                    clearControl();
                }
                else
                {
                    MessageBox.Show("Error While Saving..!!!" + Environment.NewLine + output.ToString() , "Error..!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            else if (action == FormAction.Edit)
            {
                if (general.update(textboxGeneralCode.Text.ToString(), textboxDescription.Text, clsCat[0].ToString(), checkBoxIsActive.Checked, "murtaza.ali",out output) == true)
                {
                    MessageBox.Show("Record Sucessfully Saved");
                    clearControl();
                }
                else
                {
                    MessageBox.Show("Error While Saving..!!!" + Environment.NewLine + output.ToString() , "Error..!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void fillGeneralList()
        {

            if (general == null)
                general = new BLGeneralMaster();
            DataSet dt = general.getAllGeneralMaster();
            dataGridViewCategoryList.Rows.Clear();
            foreach (DataRow dRow in dt.Tables[0].Rows)
            {
                Int32 iRow = dataGridViewCategoryList.Rows.Add();

                dataGridViewCategoryList.Rows[iRow].Cells["gridColGeneralCode"].Value = dRow[0];
                dataGridViewCategoryList.Rows[iRow].Cells["gridColGeneralDescription"].Value = dRow[1];
                dataGridViewCategoryList.Rows[iRow].Cells["gridColIsActive"].Value = dRow[4];
                dataGridViewCategoryList.Rows[iRow].Cells["gridColCategoryCode"].Value = dRow[2];
                dataGridViewCategoryList.Rows[iRow].Cells["gridColCategoryDescription"].Value = dRow[3];
            //    dataGridViewCategoryList.Rows[iRow].Cells["gridColIsActive"].Value = dRow[5];


            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewCategoryList.Rows.Count > 0)
            {
                textboxGeneralCode.Text= dataGridViewCategoryList.CurrentRow.Cells["gridColGeneralCode"].Value.ToString() ;
                textboxDescription.Text = dataGridViewCategoryList.CurrentRow.Cells["gridColGeneralDescription"].Value.ToString(); 

                if (dataGridViewCategoryList.CurrentRow.Cells["gridColIsActive"].Value.ToString() == "Y")
                    checkBoxIsActive.Checked = true;
                else
                    checkBoxIsActive.Checked = false;
                setCategoryCode(dataGridViewCategoryList.CurrentRow.Cells["gridColCategoryCode"].Value.ToString());
             //   dataGridViewCategoryList.CurrentRow.Cells["gridColCategoryCode"].Value;
             //  dataGridViewCategoryList.CurrentRow.Cells["gridColCategoryDescription"].Value;
                action = FormAction.Edit;
            }
        }

        void setCategoryCode(string strCategoryCode)
        {
            for(Int32 irow=0;irow<comboBoxCategoryCode.Items.Count -1;irow++)
            {
                 DataRowView clsCat =(DataRowView) comboBoxCategoryCode.Items[irow];
                 if (strCategoryCode == clsCat[0].ToString())
                     comboBoxCategoryCode.SelectedIndex = irow;

            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void clearControl()
        {
            textboxGeneralCode.Text = string.Empty;
            textboxDescription.Text = string.Empty;
            textBoxSearch.Text = string.Empty;
            action = FormAction.Add;
            fillGeneralList();
        }
    }
}
