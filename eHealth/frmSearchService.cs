using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace eHealth
{
    public partial class frmSearchService : Form
    {
        public string ServiceDateTime { get; set; }

        const int AW_SLIDE = 0X40000;

        const int AW_HOR_POSITIVE = 0X1;

        const int AW_HOR_NEGATIVE = 0X2;

        const int AW_BLEND = 0X80000;




        [DllImport("user32")]

        static extern bool AnimateWindow(IntPtr hwnd, int time, int flags);

        public frmSearchService()
        {
            InitializeComponent();
            
        }
        protected override void OnLoad(EventArgs e)
        {
        //    base.OnLoad(e);
            string formName = "frmInsuranceRequest";

            int WidthOfMain = Application.OpenForms[formName].Width / 4;

            int HeightofMain = Application.OpenForms[formName].Height;

            int LocationMainX = Application.OpenForms[formName].Location.X;

            int locationMainy = Application.OpenForms[formName].Location.Y;



            //Set the Location

            this.Location = new Point(LocationMainX + WidthOfMain, locationMainy );

            frmHeight = this.Height;

            //Animate form

            AnimateWindow(this.Handle, 500, AW_BLEND | AW_HOR_POSITIVE);

        }
        Boolean searchGridVisible = false;
        int frmHeight;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (searchGridVisible == false)
            {
                this.Height = this.Height + 200;
                searchGridVisible = true;
            }
            else
            {
                this.Height = frmHeight;
                searchGridVisible = false;
            }
        }

        private void label61_Click(object sender, EventArgs e)
        {

        }

        private void cboPhysioSessions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClosePanel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
