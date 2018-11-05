﻿using System;
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
    public partial class frmMasterSubMenu : Form
    {
        public frmMasterSubMenu()
        {
            InitializeComponent();
        }

           const int AW_SLIDE = 0X40000;

        const int AW_HOR_POSITIVE = 0X1;

        const int AW_HOR_NEGATIVE = 0X2;

        const int AW_BLEND = 0X80000;




        [DllImport("user32")]

        static extern bool AnimateWindow(IntPtr hwnd, int time, int flags);

       

         protected override void OnLoad(EventArgs e)
        {
         //   base.OnLoad(e);
            string formName = "frmMainMenuInsurance";

            int WidthOfMain = Application.OpenForms[formName].Width;

            int HeightofMain = Application.OpenForms[formName].Height;

            int LocationMainX = Application.OpenForms[formName].Location.X;

            int locationMainy = Application.OpenForms[formName].Location.Y;



            //Set the Location

            this.Location = new Point(LocationMainX + WidthOfMain, locationMainy);

         //   frmHeight = this.Height;

            //Animate form

            AnimateWindow(this.Handle, 500, AW_SLIDE | AW_HOR_POSITIVE);

        }

         private void frmMasterSubMenu_Load(object sender, EventArgs e)
         {
             //tableLayoutPanelMaster.VerticalScroll.Visible = false;
             //pnl_Menu.VerticalScroll.Visible = false;
             //this.VerticalScroll.Visible = false;

             //tableLayoutPanelMaster.HorizontalScroll.Visible = false;
             //pnl_Menu.HorizontalScroll.Visible = false;
             //this.HorizontalScroll.Visible = false;
         }

    }
}
