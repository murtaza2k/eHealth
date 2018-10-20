namespace eHealth
{
    partial class frmUserLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboCentre = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.TextBoxUserName = new System.Windows.Forms.TextBox();
            this.LabelUserName = new System.Windows.Forms.Label();
            this.PictureBoxLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCentre
            // 
            this.cboCentre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCentre.FormattingEnabled = true;
            this.cboCentre.Location = new System.Drawing.Point(155, 189);
            this.cboCentre.Name = "cboCentre";
            this.cboCentre.Size = new System.Drawing.Size(266, 37);
            this.cboCentre.TabIndex = 25;
            this.cboCentre.Visible = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(28, 197);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(85, 29);
            this.Label1.TabIndex = 24;
            this.Label1.Text = "Centre";
            this.Label1.Visible = false;
            // 
            // ButtonClose
            // 
            this.ButtonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ButtonClose.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ButtonClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ButtonClose.Location = new System.Drawing.Point(305, 232);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(116, 38);
            this.ButtonClose.TabIndex = 23;
            this.ButtonClose.Text = "&Cancel";
            this.ButtonClose.UseVisualStyleBackColor = true;
            // 
            // ButtonOk
            // 
            this.ButtonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ButtonOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonOk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ButtonOk.Location = new System.Drawing.Point(205, 232);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(84, 38);
            this.ButtonOk.TabIndex = 22;
            this.ButtonOk.Text = "&Ok";
            this.ButtonOk.UseVisualStyleBackColor = true;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.TextBoxPassword.ForeColor = System.Drawing.Color.Red;
            this.TextBoxPassword.Location = new System.Drawing.Point(155, 147);
            this.TextBoxPassword.MaxLength = 30;
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '®';
            this.TextBoxPassword.Size = new System.Drawing.Size(266, 37);
            this.TextBoxPassword.TabIndex = 21;
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelPassword.Location = new System.Drawing.Point(2, 150);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(111, 29);
            this.LabelPassword.TabIndex = 20;
            this.LabelPassword.Text = "Password";
            // 
            // TextBoxUserName
            // 
            this.TextBoxUserName.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBoxUserName.Location = new System.Drawing.Point(155, 106);
            this.TextBoxUserName.MaxLength = 30;
            this.TextBoxUserName.Name = "TextBoxUserName";
            this.TextBoxUserName.Size = new System.Drawing.Size(266, 38);
            this.TextBoxUserName.TabIndex = 19;
            // 
            // LabelUserName
            // 
            this.LabelUserName.AutoSize = true;
            this.LabelUserName.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelUserName.Location = new System.Drawing.Point(17, 106);
            this.LabelUserName.Name = "LabelUserName";
            this.LabelUserName.Size = new System.Drawing.Size(96, 33);
            this.LabelUserName.TabIndex = 17;
            this.LabelUserName.Text = "User Id";
            // 
            // PictureBoxLogin
            // 
            this.PictureBoxLogin.BackgroundImage = global::eHealth.Properties.Resources.PictureBoxLogin_BackgroundImage;
            this.PictureBoxLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PictureBoxLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PictureBoxLogin.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxLogin.Name = "PictureBoxLogin";
            this.PictureBoxLogin.Size = new System.Drawing.Size(429, 91);
            this.PictureBoxLogin.TabIndex = 18;
            this.PictureBoxLogin.TabStop = false;
            // 
            // frmUserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(433, 275);
            this.Controls.Add(this.cboCentre);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonOk);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.TextBoxUserName);
            this.Controls.Add(this.LabelUserName);
            this.Controls.Add(this.PictureBoxLogin);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmUserLogin";
            this.Text = "frmUserLogin";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox cboCentre;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button ButtonClose;
        internal System.Windows.Forms.Button ButtonOk;
        internal System.Windows.Forms.TextBox TextBoxPassword;
        internal System.Windows.Forms.Label LabelPassword;
        internal System.Windows.Forms.TextBox TextBoxUserName;
        internal System.Windows.Forms.Label LabelUserName;
        internal System.Windows.Forms.PictureBox PictureBoxLogin;
    }
}