using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using eHealth.Connection;
using eHealth.BusinessLogic;
using eHealth.Model;
using eHealth;


namespace PrjInsuranceModule
{
    public partial class frmLoginScreen : Form
    {
        public frmLoginScreen()
        {
            InitializeComponent();
        }
        private ClsUserLoging obj;
        private ClsUserLoging objResult;
        

        private void frmLoginScreen_Load(object sender, EventArgs e)
        {
        //    String settings = Properties.Settings.Default.DefaultLogin.ToString();
            //MessageBox.Show(settings);
            //clsHISDataAccessLayer cls = new clsHISDataAccessLayer();
            //Boolean pb = cls.getDBConnection();
            //if (pb == true)
            //{
            ////    MessageBox.Show("Connected");
            //}
            this.btnLogin.Image = Image.FromFile(Application.StartupPath.ToString() + "\\Icons\\secrecy-icon.png");
            fillServiceMasters();
        }
        private void fillServiceMasters()
        {
            eHealthGlobal.ConnectionString = "SERVER=172.20.32.40\\SQLExpress;uid=sa;pwd=mchins@123;Database=Insurance_MCH";
        

            BLService cls = new BLService();            
            try
            {              
                cboRequestedService.DataSource = null;
                cboRequestedService.DataSource = cls.getServiceMaster();
                cboRequestedService.ValueMember = "ServiceID";
                cboRequestedService.DisplayMember = "ServiceName";

            }
            catch (Exception ex)
            {
            }

        }

        //private void btnLogin_Click(object sender, EventArgs e)
        //{
        //    string useDashBoard = "NO";
        //    Cursor cr = this.Cursor;
        //    try
        //    {
        //        //MessageBox.Show(DateTime.Now.ToString("yyyy-MM-dd hh"));
        //        this.Cursor = Cursors.WaitCursor;

        //        obj = new ClsUserLoging();

        //        clsServiceMaster cls = (clsServiceMaster)cboRequestedService.SelectedItem;
                
        //       eHealthGlobal.globalLoginLocation = System.Configuration.ConfigurationManager.AppSettings["LoginLocation"].ToString();

        //        try
        //        {
        //            clsMisc.setFacilityDetails(clsMisc.globalLoginLocation);
        //            clsMisc.globalEAuth = System.Configuration.ConfigurationManager.AppSettings["EAuth"].ToString();
        //            useDashBoard = System.Configuration.ConfigurationManager.AppSettings["UsedDashBoard"].ToString();
        //            //clsMisc.globalDiagnosisMaster = new clsDiagnosisMaster().getAllDiagnosis();
        //            clsMisc.diagnosisCollection = new clsDiagnosisMaster().getAllDiagnosisName();
        //            clsMisc.createExportDirectory("C:\\Temp");
        //            clsMisc.enableDRG = System.Configuration.ConfigurationManager.AppSettings["EnableDRG"].ToString();

        //            this.Cursor = cr;
        //        }

        //        catch (Exception ex)
        //        {
        //            this.Cursor = cr;
        //        }
        //        if (cls != null)
        //        {
        //            objResult = obj.IsValidLog(Environment.UserName.ToString(), Environment.UserName.ToString());
        //            if (objResult == null)
        //            {
        //                MessageBox.Show("Sorry You Don't Have Access To This Module");
        //                return;
        //            }
        //            else
        //            {
        //                clsMisc.globalUser = objResult;
        //                clsMisc.globalUserRole = obj.GetUserAccess(objResult.UserRole.ToString(), cls.ServiceName.ToString());
        //                clsMisc.WriteLogs("Login", "INFO", DateTime.Now, objResult.UserRole.ToString() + "-" + cls.ServiceName.ToString());
        //            }

        //            if (cls.ServiceName.Contains("XYZ"))
        //            {
        //                frmEntry frm = new frmEntry();
        //                frm.Show();
        //                this.Hide();
        //            }
        //            else
        //            {
        //                clsMisc.WriteLogs("Login", "Login", DateTime.Now, "Login By " + Environment.UserName.ToString());

        //                clsMisc.WriteLogs("Login", "INFO", DateTime.Now, "BEFORE Checking Properties");
        //                Properties.Settings.Default.DefaultLogin = "Insurance";

        //                Properties.Settings.Default.Save();
        //                clsMisc.WriteLogs("Login", "INFO", DateTime.Now, "AFTER Checking Properties");
        //                //frmIPAddmision frm = new frmIPAddmision();
        //                // frmInsurance frm = new frmInsurance();
        //                if (clsMisc.globalUserRole == null)
        //                {
        //                    MessageBox.Show("Sorry You Don't Have Access To This Module");
        //                    return;
        //                }
        //                if (clsMisc.globalUserRole.RoleId.Contains("IP Admission") == true)
        //                {
        //                    Form1 frm = new Form1();
        //                    frm.Show();
        //                    this.Hide();
        //                }
        //                else if (clsMisc.globalUserRole.RoleId.Contains("Insurance Admin") == true && clsMisc.globalUserRole.Right.Contains("Physiotherapy") == true)
        //                {
        //                    frmEntry frm = new frmEntry();
        //                    frm.Show();
        //                    this.Hide();

        //                }

        //                else if ((clsMisc.globalUserRole.RoleId.Contains("Insurance") == true || clsMisc.globalUserRole.RoleId.Contains("Patient Admin") == true) && useDashBoard == "NO")
        //                {
        //                    this.Hide();
        //                    frmInsurance frm = new frmInsurance();
        //                    frm.Show();


        //                }
        //                else if ((clsMisc.globalUserRole.RoleId.Contains("Insurance") == true || clsMisc.globalUserRole.RoleId.Contains("Patient Admin") == true) && useDashBoard == "YES")
        //                {
        //                    this.Hide();
        //                    frmDashBoard frm = new frmDashBoard();
        //                    frm.Show();


        //                }
        //                else if (clsMisc.globalUserRole.RoleId.Contains("Physiotherapy") == true)
        //                {
        //                    frmEntry frm = new frmEntry();
        //                    frm.Show();
        //                    this.Hide();

        //                }






        //            }
        //        }
        //        this.Cursor = cr;
        //    }
        //    catch (Exception ex)
        //    {
        //        this.Cursor = cr;
        //        clsMisc.WriteLogs("LoginClick", "ERROR", DateTime.Now, ex.ToString());
        //        MessageBox.Show(ex.ToString());
        //    }
        //}

        void cboRequestedService_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.Control ==true && e.KeyCode == Keys.U )
            {
                //this.Hide();
                //frmUsersCreation frm = new frmUsersCreation();
                //frm.Show();
            
            }

            //throw new System.NotImplementedException();
        }

        private void cboRequestedService_SelectedIndexChanged(object sender, EventArgs e)
        {
             

        }
    }
}
