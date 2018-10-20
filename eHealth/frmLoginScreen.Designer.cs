namespace PrjInsuranceModule
{
    partial class frmLoginScreen
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
            this.grpDepartment = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cboRequestedService = new System.Windows.Forms.ComboBox();
            this.grpDepartment.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDepartment
            // 
            this.grpDepartment.Controls.Add(this.btnLogin);
            this.grpDepartment.Controls.Add(this.label9);
            this.grpDepartment.Controls.Add(this.cboRequestedService);
            this.grpDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDepartment.Location = new System.Drawing.Point(0, 0);
            this.grpDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.grpDepartment.Name = "grpDepartment";
            this.grpDepartment.Padding = new System.Windows.Forms.Padding(4);
            this.grpDepartment.Size = new System.Drawing.Size(505, 63);
            this.grpDepartment.TabIndex = 0;
            this.grpDepartment.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(425, 13);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(73, 38);
            this.btnLogin.TabIndex = 55;
            this.btnLogin.UseVisualStyleBackColor = true;
           // this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(8, 24);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 16);
            this.label9.TabIndex = 54;
            this.label9.Text = "Location";
            // 
            // cboRequestedService
            // 
            this.cboRequestedService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRequestedService.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRequestedService.FormattingEnabled = true;
            this.cboRequestedService.Location = new System.Drawing.Point(83, 19);
            this.cboRequestedService.Margin = new System.Windows.Forms.Padding(4);
            this.cboRequestedService.Name = "cboRequestedService";
            this.cboRequestedService.Size = new System.Drawing.Size(319, 24);
            this.cboRequestedService.TabIndex = 53;
            this.cboRequestedService.SelectedIndexChanged += new System.EventHandler(this.cboRequestedService_SelectedIndexChanged);
            this.cboRequestedService.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboRequestedService_KeyDown);
            // 
            // frmLoginScreen
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 63);
            this.Controls.Add(this.grpDepartment);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginScreen";
            this.Load += new System.EventHandler(this.frmLoginScreen_Load);
            this.grpDepartment.ResumeLayout(false);
            this.grpDepartment.PerformLayout();
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.GroupBox grpDepartment;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboRequestedService;
    }
}