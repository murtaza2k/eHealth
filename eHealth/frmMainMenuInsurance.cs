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
    public partial class frmMainMenuInsurance : Form
    {
        public frmMainMenuInsurance()
        {
            InitializeComponent();
        }
        Form currentForm;
        private void button1_Click(object sender, EventArgs e)
        {
            currentForm = new frmSubmenu();
            currentForm.ShowDialog();
           
        }

        private void frmMainMenuInsurance_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentForm = new frmMasterSubMenu();
            currentForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
