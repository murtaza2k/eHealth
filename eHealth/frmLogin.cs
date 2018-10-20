using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using eHealth.Connection;
using eHealth.BusinessLogic;
using eHealth.Model;


namespace eHealth
{
    public partial class frmLogin : Form
    {
        
        
       private Font _Empty_Font = new Font("Verdana", 9,FontStyle.Italic);  //new Font("Verdana", 9D, FontStyle.Italic);
       private Font  _Fill_Font_User_ID = new Font("Consolas", 9, FontStyle.Regular);
       private Font _Fill_Font_Password = new Font("Wingdings 2", 10, FontStyle.Bold);

       

        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            BLLocation work = new BLLocation();
            List<clsLocationMaster> list = work.getProviderDetails();

            
            cboCentre.DataSource = list;
            cboCentre.ValueMember = "SourceLocation";
            cboCentre.DisplayMember = "SourceLocation";

            SetEmptyTextValues_ToUserID();
            TextBoxUserName.Text = "[Set User Name]";
            SetEmptyTextValues_Password();
            TextBoxPassword.Text = "[Set Password]";
            this.PictureBoxLogin.Image = null;
            this.TextBoxUserName.Leave += TextBoxUserName_Leave;
            this.TextBoxUserName.TextChanged += TextBoxUserName_TextChanged;
            this.TextBoxPassword.Leave += TextBoxPassword_Leave;
            this.TextBoxPassword.TextChanged += TextBoxPassword_TextChanged;
          ///  this.PictureBoxLogin.BackgroundImage  = Image.FromFile(Application.StartupPath.ToString() + "\\Icons\\secrecy-icon.png");
     
        }

        void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxPassword.Text.ToString().Trim() == "[Set Password]".ToString().Trim() || TextBoxPassword.Text.ToString().Trim().Length == 0)
                SetEmptyTextValues_Password();
            else
                SetFillTextValues_Password();  
        }

        void TextBoxPassword_Leave(object sender, EventArgs e)
        {
            if (TextBoxUserName.Text.ToString().Trim() == "[Set User Name]".ToString().Trim() || TextBoxUserName.Text.ToString().Trim().Length == 0)
                SetEmptyTextValues_ToUserID();
            else
                SetFillTextValues_ToUserID();        
        }

        void TextBoxUserName_TextChanged(object sender, EventArgs e)
        {
             if (TextBoxUserName.Text.ToString().Trim() == "[Set User Name]".ToString().Trim() || TextBoxUserName.Text.ToString().Trim().Length == 0)
                SetEmptyTextValues_ToUserID();
            else
                SetFillTextValues_ToUserID(); 
        }

        void TextBoxUserName_Leave(object sender, EventArgs e)
        {
            if (TextBoxUserName.Text.ToString().Trim().Length == 0 || TextBoxUserName.Text.ToString().Trim() == "[Set User Name]".ToString().Trim())
            {
                SetEmptyTextValues_ToUserID();
                TextBoxUserName.Text = "[Set User Name]";
            }
            else
                SetFillTextValues_ToUserID();
        }

        //void TextBoxUserName_Leave(object sender, System.EventArgs e)
        //{
        //    if (TextBoxUserName.Text.ToString().Trim().Length == 0 || TextBoxUserName.Text.ToString().Trim() == "[Set User Name]".ToString().Trim())
        //    {
        //        SetEmptyTextValues_ToUserID();
        //        TextBoxUserName.Text = "[Set User Name]";
        //    }
        //    else
        //        SetFillTextValues_ToUserID();
        
        //}
        //void TextBoxUserName_TextChanged(object sender, System.EventArgs e)
        //{
        //    if (TextBoxUserName.Text.ToString().Trim() == "[Set User Name]".ToString().Trim() || TextBoxUserName.Text.ToString().Trim().Length == 0)
        //        SetEmptyTextValues_ToUserID();
        //    else
        //        SetFillTextValues_ToUserID();        
        //}

        //void TextBoxPassword_TextChanged(object sender, System.EventArgs e)
        //{

        //    if (TextBoxPassword.Text.ToString().Trim() == "[Set Password]".ToString().Trim() || TextBoxPassword.Text.ToString().Trim().Length == 0)
        //        SetEmptyTextValues_Password();
        //    else
        //        SetFillTextValues_Password();  
        //}

        //void TextBoxPassword_Leave(object sender, System.EventArgs e)
        //{

        //    if (TextBoxPassword.Text.ToString().Trim().Length == 0 || TextBoxPassword.Text.ToString().Trim() == "[Set Password]".ToString().Trim())
        //    {
        //        SetEmptyTextValues_Password();
        //        TextBoxPassword.Text = "[Set Password]";
        //    }
        //    else
        //        SetFillTextValues_Password();

        //}

        void SetEmptyTextValues_ToUserID()
        {
                TextBoxUserName.BackColor = Color.White;
                TextBoxUserName.ForeColor = Color.Red ;
                TextBoxUserName.Font = _Empty_Font;
        }
        void SetFillTextValues_ToUserID()
        {
                TextBoxUserName.BackColor = Color.White;
                TextBoxUserName.ForeColor = Color.Black;
                TextBoxUserName.Font = _Fill_Font_User_ID;
        }
        
        void SetEmptyTextValues_Password()
        {
            string replaceStringChar="t";

            TextBoxPassword.BackColor = Color.White;
            TextBoxPassword.ForeColor = Color.Red ;
            TextBoxPassword.Font = _Empty_Font;
            TextBoxPassword.PasswordChar = '\0'; //replaceStringChar.Replace("t","");
        }
        void SetFillTextValues_Password()
        {
            TextBoxPassword.BackColor = Color.White;
            TextBoxPassword.ForeColor = Color.Red;
            TextBoxPassword.Font = _Fill_Font_Password;
            TextBoxPassword.PasswordChar = Convert.ToChar("®");
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            string passwordEncrypted = eHealth.Utility.CryptDecrypt.Encrypt(TextBoxPassword.Text.ToString(), true);
            string passwordDecrypted = eHealth.Utility.CryptDecrypt.Decrypt(passwordEncrypted, true);
            frmMain frmMain = new frmMain();
            frmMain.Show();
        }


    }
}
