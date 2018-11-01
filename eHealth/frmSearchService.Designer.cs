namespace eHealth
{
    partial class frmSearchService
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
            this.panelManualOrder = new System.Windows.Forms.Panel();
            this.label40 = new System.Windows.Forms.Label();
            this.chkCoveredStatus = new System.Windows.Forms.CheckBox();
            this.cboActivityType = new System.Windows.Forms.ComboBox();
            this.cboPhysioSessions = new System.Windows.Forms.ComboBox();
            this.label61 = new System.Windows.Forms.Label();
            this.txtExternalDoctor = new System.Windows.Forms.TextBox();
            this.dtpActivityStartDate = new System.Windows.Forms.DateTimePicker();
            this.label58 = new System.Windows.Forms.Label();
            this.nmUPDown = new System.Windows.Forms.NumericUpDown();
            this.label39 = new System.Windows.Forms.Label();
            this.cboLicenseDoctor = new System.Windows.Forms.ComboBox();
            this.label34 = new System.Windows.Forms.Label();
            this.txtHISDescription = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.txtHISCode = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.btnClosePanel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddManualCPT = new System.Windows.Forms.Button();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.txtCPTDescription = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.txtCPTCode = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.pnlList = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grdItemMaster = new System.Windows.Forms.DataGridView();
            this.colMSelectServices = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colMServiceCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMServiceDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMTariff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMHISCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMHISName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMActivityType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMLicenseCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelManualOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmUPDown)).BeginInit();
            this.pnlList.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdItemMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // panelManualOrder
            // 
            this.panelManualOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelManualOrder.Controls.Add(this.label40);
            this.panelManualOrder.Controls.Add(this.chkCoveredStatus);
            this.panelManualOrder.Controls.Add(this.cboActivityType);
            this.panelManualOrder.Controls.Add(this.cboPhysioSessions);
            this.panelManualOrder.Controls.Add(this.label61);
            this.panelManualOrder.Controls.Add(this.txtExternalDoctor);
            this.panelManualOrder.Controls.Add(this.dtpActivityStartDate);
            this.panelManualOrder.Controls.Add(this.label58);
            this.panelManualOrder.Controls.Add(this.nmUPDown);
            this.panelManualOrder.Controls.Add(this.label39);
            this.panelManualOrder.Controls.Add(this.cboLicenseDoctor);
            this.panelManualOrder.Controls.Add(this.label34);
            this.panelManualOrder.Controls.Add(this.txtHISDescription);
            this.panelManualOrder.Controls.Add(this.label32);
            this.panelManualOrder.Controls.Add(this.txtHISCode);
            this.panelManualOrder.Controls.Add(this.label33);
            this.panelManualOrder.Controls.Add(this.btnClosePanel);
            this.panelManualOrder.Controls.Add(this.btnSearch);
            this.panelManualOrder.Controls.Add(this.btnAddManualCPT);
            this.panelManualOrder.Controls.Add(this.txtRate);
            this.panelManualOrder.Controls.Add(this.label35);
            this.panelManualOrder.Controls.Add(this.txtQty);
            this.panelManualOrder.Controls.Add(this.label36);
            this.panelManualOrder.Controls.Add(this.txtCPTDescription);
            this.panelManualOrder.Controls.Add(this.label37);
            this.panelManualOrder.Controls.Add(this.txtCPTCode);
            this.panelManualOrder.Controls.Add(this.label38);
            this.panelManualOrder.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelManualOrder.Location = new System.Drawing.Point(4, 1);
            this.panelManualOrder.Name = "panelManualOrder";
            this.panelManualOrder.Size = new System.Drawing.Size(645, 234);
            this.panelManualOrder.TabIndex = 104;
            // 
            // label40
            // 
            this.label40.Location = new System.Drawing.Point(15, 31);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(80, 19);
            this.label40.TabIndex = 1;
            this.label40.Text = "Activity Type";
            // 
            // chkCoveredStatus
            // 
            this.chkCoveredStatus.AutoSize = true;
            this.chkCoveredStatus.Checked = true;
            this.chkCoveredStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCoveredStatus.Location = new System.Drawing.Point(680, 121);
            this.chkCoveredStatus.Name = "chkCoveredStatus";
            this.chkCoveredStatus.Size = new System.Drawing.Size(147, 18);
            this.chkCoveredStatus.TabIndex = 26;
            this.chkCoveredStatus.Tag = "0";
            this.chkCoveredStatus.Text = "Check Covered Status";
            this.chkCoveredStatus.UseVisualStyleBackColor = true;
            // 
            // cboActivityType
            // 
            this.cboActivityType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActivityType.FormattingEnabled = true;
            this.cboActivityType.Location = new System.Drawing.Point(113, 28);
            this.cboActivityType.Name = "cboActivityType";
            this.cboActivityType.Size = new System.Drawing.Size(163, 22);
            this.cboActivityType.TabIndex = 0;
            // 
            // cboPhysioSessions
            // 
            this.cboPhysioSessions.FormattingEnabled = true;
            this.cboPhysioSessions.Items.AddRange(new object[] {
            "MUSCULOSKELETAL(MSK)",
            "SHOCKWAVE THERAPY",
            "OB GYN UROLOGY",
            "ONCO VASCULAR",
            "ORTHO POST OP UPPER LIMB",
            "ORTHO POST OP LOWER LIMB",
            "ENT NEURO",
            "NEURO\t",
            "PEDIATRIC",
            "CHEST",
            "HAND THERAPY",
            "OCCUPATIONAL THERAPY - ADULTS",
            "PAEDIATRIC OCCUPATIONAL THERAPY  (General)",
            "PAEDIATRIC OCCUPATIONAL THERAPY (Feeding Support)",
            "PAEDIATRIC OCCUPATIONAL THERAPY (Behaviour)",
            "SPEECH THERAPY (Feeding Support)",
            "SPEECH & LANGUAGE THERAPY"});
            this.cboPhysioSessions.Location = new System.Drawing.Point(745, 195);
            this.cboPhysioSessions.Name = "cboPhysioSessions";
            this.cboPhysioSessions.Size = new System.Drawing.Size(277, 22);
            this.cboPhysioSessions.TabIndex = 25;
            this.cboPhysioSessions.Visible = false;
            this.cboPhysioSessions.SelectedIndexChanged += new System.EventHandler(this.cboPhysioSessions_SelectedIndexChanged);
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(748, 174);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(127, 14);
            this.label61.TabIndex = 24;
            this.label61.Text = "Physiotherapy Session";
            this.label61.Visible = false;
            this.label61.Click += new System.EventHandler(this.label61_Click);
            // 
            // txtExternalDoctor
            // 
            this.txtExternalDoctor.Location = new System.Drawing.Point(696, 149);
            this.txtExternalDoctor.Name = "txtExternalDoctor";
            this.txtExternalDoctor.Size = new System.Drawing.Size(220, 22);
            this.txtExternalDoctor.TabIndex = 23;
            this.txtExternalDoctor.Visible = false;
            this.txtExternalDoctor.WordWrap = false;
            // 
            // dtpActivityStartDate
            // 
            this.dtpActivityStartDate.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dtpActivityStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpActivityStartDate.Location = new System.Drawing.Point(113, 197);
            this.dtpActivityStartDate.Name = "dtpActivityStartDate";
            this.dtpActivityStartDate.Size = new System.Drawing.Size(132, 22);
            this.dtpActivityStartDate.TabIndex = 22;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(38, 203);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(64, 14);
            this.label58.TabIndex = 21;
            this.label58.Text = "Start Date";
            // 
            // nmUPDown
            // 
            this.nmUPDown.BackColor = System.Drawing.Color.Yellow;
            this.nmUPDown.Location = new System.Drawing.Point(645, 140);
            this.nmUPDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmUPDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmUPDown.Name = "nmUPDown";
            this.nmUPDown.Size = new System.Drawing.Size(38, 22);
            this.nmUPDown.TabIndex = 20;
            this.nmUPDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(251, 205);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(79, 14);
            this.label39.TabIndex = 16;
            this.label39.Text = "Doctor Name";
            // 
            // cboLicenseDoctor
            // 
            this.cboLicenseDoctor.FormattingEnabled = true;
            this.cboLicenseDoctor.Location = new System.Drawing.Point(336, 197);
            this.cboLicenseDoctor.Name = "cboLicenseDoctor";
            this.cboLicenseDoctor.Size = new System.Drawing.Size(220, 22);
            this.cboLicenseDoctor.TabIndex = 15;
            // 
            // label34
            // 
            this.label34.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label34.Dock = System.Windows.Forms.DockStyle.Top;
            this.label34.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label34.Location = new System.Drawing.Point(0, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(641, 22);
            this.label34.TabIndex = 11;
            this.label34.Text = "Search Service";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHISDescription
            // 
            this.txtHISDescription.Location = new System.Drawing.Point(114, 140);
            this.txtHISDescription.Name = "txtHISDescription";
            this.txtHISDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHISDescription.Size = new System.Drawing.Size(378, 22);
            this.txtHISDescription.TabIndex = 11;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(12, 154);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(90, 14);
            this.label32.TabIndex = 14;
            this.label32.Text = "HIS Description";
            // 
            // txtHISCode
            // 
            this.txtHISCode.Location = new System.Drawing.Point(114, 112);
            this.txtHISCode.Name = "txtHISCode";
            this.txtHISCode.Size = new System.Drawing.Size(127, 22);
            this.txtHISCode.TabIndex = 9;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(44, 125);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(58, 14);
            this.label33.TabIndex = 12;
            this.label33.Text = "HIS Code";
            // 
            // btnClosePanel
            // 
            this.btnClosePanel.Location = new System.Drawing.Point(564, 196);
            this.btnClosePanel.Name = "btnClosePanel";
            this.btnClosePanel.Size = new System.Drawing.Size(75, 23);
            this.btnClosePanel.TabIndex = 12;
            this.btnClosePanel.Text = "Close";
            this.btnClosePanel.UseVisualStyleBackColor = true;
            this.btnClosePanel.Click += new System.EventHandler(this.btnClosePanel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(564, 140);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddManualCPT
            // 
            this.btnAddManualCPT.Location = new System.Drawing.Point(564, 168);
            this.btnAddManualCPT.Name = "btnAddManualCPT";
            this.btnAddManualCPT.Size = new System.Drawing.Size(75, 23);
            this.btnAddManualCPT.TabIndex = 13;
            this.btnAddManualCPT.Text = "Add";
            this.btnAddManualCPT.UseVisualStyleBackColor = true;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(285, 168);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(93, 22);
            this.txtRate.TabIndex = 7;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(247, 176);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(32, 14);
            this.label35.TabIndex = 6;
            this.label35.Text = "Rate";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(114, 168);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(127, 22);
            this.txtQty.TabIndex = 5;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(53, 177);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(49, 14);
            this.label36.TabIndex = 4;
            this.label36.Text = "Quanity";
            // 
            // txtCPTDescription
            // 
            this.txtCPTDescription.Location = new System.Drawing.Point(113, 84);
            this.txtCPTDescription.Name = "txtCPTDescription";
            this.txtCPTDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCPTDescription.Size = new System.Drawing.Size(378, 22);
            this.txtCPTDescription.TabIndex = 3;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(9, 93);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(93, 14);
            this.label37.TabIndex = 2;
            this.label37.Text = "CPT Description";
            // 
            // txtCPTCode
            // 
            this.txtCPTCode.Location = new System.Drawing.Point(113, 56);
            this.txtCPTCode.Name = "txtCPTCode";
            this.txtCPTCode.Size = new System.Drawing.Size(128, 22);
            this.txtCPTCode.TabIndex = 1;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(41, 60);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(61, 14);
            this.label38.TabIndex = 0;
            this.label38.Text = "CPT Code";
            // 
            // label41
            // 
            this.label41.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label41.BackColor = System.Drawing.Color.Red;
            this.label41.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label41.Location = new System.Drawing.Point(7, 244);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(635, 3);
            this.label41.TabIndex = 18;
            // 
            // pnlList
            // 
            this.pnlList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlList.Controls.Add(this.tabControl1);
            this.pnlList.Location = new System.Drawing.Point(4, 251);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(645, 0);
            this.pnlList.TabIndex = 105;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(645, 0);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grdItemMaster);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(637, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Selected CPT";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grdItemMaster
            // 
            this.grdItemMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdItemMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMSelectServices,
            this.colMServiceCode,
            this.colMServiceDescription,
            this.colMQty,
            this.colMTariff,
            this.colMHISCode,
            this.colMHISName,
            this.colMActivityType,
            this.colMLicenseCode});
            this.grdItemMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdItemMaster.Location = new System.Drawing.Point(3, 3);
            this.grdItemMaster.Name = "grdItemMaster";
            this.grdItemMaster.Size = new System.Drawing.Size(631, 0);
            this.grdItemMaster.TabIndex = 20;
            // 
            // colMSelectServices
            // 
            this.colMSelectServices.HeaderText = "Select Service";
            this.colMSelectServices.Name = "colMSelectServices";
            this.colMSelectServices.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMSelectServices.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colMServiceCode
            // 
            this.colMServiceCode.HeaderText = "ServiceCode";
            this.colMServiceCode.Name = "colMServiceCode";
            // 
            // colMServiceDescription
            // 
            this.colMServiceDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMServiceDescription.HeaderText = "ServiceDescription";
            this.colMServiceDescription.Name = "colMServiceDescription";
            // 
            // colMQty
            // 
            this.colMQty.HeaderText = "Qty";
            this.colMQty.Name = "colMQty";
            this.colMQty.Width = 50;
            // 
            // colMTariff
            // 
            this.colMTariff.HeaderText = "Tariff";
            this.colMTariff.Name = "colMTariff";
            this.colMTariff.Width = 50;
            // 
            // colMHISCode
            // 
            this.colMHISCode.HeaderText = "HISCode ";
            this.colMHISCode.Name = "colMHISCode";
            this.colMHISCode.Width = 50;
            // 
            // colMHISName
            // 
            this.colMHISName.HeaderText = "HISName";
            this.colMHISName.Name = "colMHISName";
            this.colMHISName.Width = 104;
            // 
            // colMActivityType
            // 
            this.colMActivityType.HeaderText = "Activity Type";
            this.colMActivityType.Name = "colMActivityType";
            this.colMActivityType.Width = 40;
            // 
            // colMLicenseCode
            // 
            this.colMLicenseCode.HeaderText = "LicenseCode";
            this.colMLicenseCode.Name = "colMLicenseCode";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(637, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Most Common CPTs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmSearchService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 250);
            this.ControlBox = false;
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.panelManualOrder);
            this.Controls.Add(this.label41);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSearchService";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.panelManualOrder.ResumeLayout(false);
            this.panelManualOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmUPDown)).EndInit();
            this.pnlList.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdItemMaster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelManualOrder;
        private System.Windows.Forms.CheckBox chkCoveredStatus;
        private System.Windows.Forms.ComboBox cboPhysioSessions;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.TextBox txtExternalDoctor;
        private System.Windows.Forms.DateTimePicker dtpActivityStartDate;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.NumericUpDown nmUPDown;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.ComboBox cboActivityType;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.ComboBox cboLicenseDoctor;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox txtHISDescription;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtHISCode;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Button btnClosePanel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddManualCPT;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox txtCPTDescription;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox txtCPTCode;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView grdItemMaster;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colMSelectServices;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMServiceCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMServiceDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMTariff;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMHISCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMHISName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMActivityType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMLicenseCode;

    }
}