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
    public partial class frmInsuranceRequest : Form
    {
        public frmInsuranceRequest()
        {
            InitializeComponent();
        }

        private void buttonAddCPT_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            FormCollection fc = Application.OpenForms;

            foreach (Form f in fc)
            {

                if (f.Name == "frmSearchService")
                {

                    IsOpen = true;

                    f.Focus();

                    break;

                }

            }



            if (IsOpen == false)
            {

                frmSearchService form = new frmSearchService();

                form.Show();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            FormCollection fc = Application.OpenForms;

            foreach (Form f in fc)
            {

                if (f.Name == "frmObservation")
                {

                    IsOpen = true;

                    f.Focus();
                    f.BringToFront();
                    break;

                }

            }



            if (IsOpen == false)
            {

                frmObservation form = new frmObservation();

                form.Show();

            }


        }

        private void frmInsuranceRequest_Load(object sender, EventArgs e)
        {

        }
    }
}
