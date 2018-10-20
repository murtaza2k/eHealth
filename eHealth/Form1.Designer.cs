namespace eHealth
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.cboCentre = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.TextBoxUserName = new System.Windows.Forms.TextBox();
            this.LabelUserName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCentre
            // 
            this.cboCentre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCentre.FormattingEnabled = true;
            this.cboCentre.Location = new System.Drawing.Point(545, 133);
            this.cboCentre.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboCentre.Name = "cboCentre";
            this.cboCentre.Size = new System.Drawing.Size(376, 35);
            this.cboCentre.TabIndex = 16;
            this.cboCentre.Visible = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(427, 146);
            this.Label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(84, 27);
            this.Label1.TabIndex = 15;
            this.Label1.Text = "Centre";
            this.Label1.Visible = false;
            // 
            // ButtonClose
            // 
            this.ButtonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ButtonClose.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ButtonClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ButtonClose.Location = new System.Drawing.Point(759, 197);
            this.ButtonClose.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(168, 76);
            this.ButtonClose.TabIndex = 14;
            this.ButtonClose.Text = "&Cancel";
            this.ButtonClose.UseVisualStyleBackColor = true;
            // 
            // ButtonOk
            // 
            this.ButtonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ButtonOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonOk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ButtonOk.Location = new System.Drawing.Point(579, 197);
            this.ButtonOk.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(168, 76);
            this.ButtonOk.TabIndex = 13;
            this.ButtonOk.Text = "&Ok";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.TextBoxPassword.ForeColor = System.Drawing.Color.Red;
            this.TextBoxPassword.Location = new System.Drawing.Point(545, 71);
            this.TextBoxPassword.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TextBoxPassword.MaxLength = 30;
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '®';
            this.TextBoxPassword.Size = new System.Drawing.Size(376, 37);
            this.TextBoxPassword.TabIndex = 12;
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelPassword.Location = new System.Drawing.Point(408, 82);
            this.LabelPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(117, 27);
            this.LabelPassword.TabIndex = 11;
            this.LabelPassword.Text = "Password";
            // 
            // TextBoxUserName
            // 
            this.TextBoxUserName.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBoxUserName.Location = new System.Drawing.Point(545, 9);
            this.TextBoxUserName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TextBoxUserName.MaxLength = 30;
            this.TextBoxUserName.Name = "TextBoxUserName";
            this.TextBoxUserName.Size = new System.Drawing.Size(376, 38);
            this.TextBoxUserName.TabIndex = 10;
            // 
            // LabelUserName
            // 
            this.LabelUserName.AutoSize = true;
            this.LabelUserName.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelUserName.Location = new System.Drawing.Point(426, 14);
            this.LabelUserName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelUserName.Name = "LabelUserName";
            this.LabelUserName.Size = new System.Drawing.Size(96, 33);
            this.LabelUserName.TabIndex = 8;
            this.LabelUserName.Text = "User Id";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PictureBoxLogin);
            this.panel1.Location = new System.Drawing.Point(12, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 276);
            this.panel1.TabIndex = 17;
            // 
            // PictureBoxLogin
            // 
            this.PictureBoxLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBoxLogin.BackgroundImage")));
            this.PictureBoxLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PictureBoxLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PictureBoxLogin.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxLogin.Margin = new System.Windows.Forms.Padding(6);
            this.PictureBoxLogin.Name = "PictureBoxLogin";
            this.PictureBoxLogin.Size = new System.Drawing.Size(377, 276);
            this.PictureBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBoxLogin.TabIndex = 10;
            this.PictureBoxLogin.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(936, 283);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cboCentre);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonOk);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.TextBoxUserName);
            this.Controls.Add(this.LabelUserName);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.PictureBox PictureBoxLogin;
    }
}

