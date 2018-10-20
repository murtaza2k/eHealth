namespace eHealth
{
    partial class frmPlanMaster
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
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.siteSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SelectSiteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectSiteName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonAddPlan = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textboxReceiverId = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboboxInsuranceType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textboxAlias = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxInsuranceName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxInsuranceCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxIntegrationCode = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(66, 56);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(108, 22);
            this.checkBox2.TabIndex = 27;
            this.checkBox2.Text = "eAuthorization";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 341);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(630, 202);
            this.tabControl1.TabIndex = 33;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(622, 171);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Site";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 171);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.siteSelect,
            this.SelectSiteId,
            this.selectSiteName});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(622, 171);
            this.dataGridView2.TabIndex = 0;
            // 
            // siteSelect
            // 
            this.siteSelect.HeaderText = "Select";
            this.siteSelect.Name = "siteSelect";
            this.siteSelect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.siteSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.siteSelect.Width = 50;
            // 
            // SelectSiteId
            // 
            this.SelectSiteId.HeaderText = "Site Id";
            this.SelectSiteId.Name = "SelectSiteId";
            // 
            // selectSiteName
            // 
            this.selectSiteName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.selectSiteName.HeaderText = "Site";
            this.selectSiteName.Name = "selectSiteName";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(622, 171);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Audit";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(6, 139);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(630, 5);
            this.label13.TabIndex = 32;
            // 
            // buttonAddPlan
            // 
            this.buttonAddPlan.Location = new System.Drawing.Point(222, 543);
            this.buttonAddPlan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddPlan.Name = "buttonAddPlan";
            this.buttonAddPlan.Size = new System.Drawing.Size(90, 23);
            this.buttonAddPlan.TabIndex = 37;
            this.buttonAddPlan.Text = "Add New Plan";
            this.buttonAddPlan.UseVisualStyleBackColor = true;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(153, 543);
            this.buttonFind.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(60, 23);
            this.buttonFind.TabIndex = 36;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(79, 543);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(60, 23);
            this.buttonClose.TabIndex = 35;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(11, 543);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(60, 23);
            this.buttonSave.TabIndex = 34;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 56);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 22);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "eRX";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textboxReceiverId
            // 
            this.textboxReceiverId.Location = new System.Drawing.Point(74, 81);
            this.textboxReceiverId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textboxReceiverId.Name = "textboxReceiverId";
            this.textboxReceiverId.Size = new System.Drawing.Size(151, 21);
            this.textboxReceiverId.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.comboboxInsuranceType);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textboxReceiverId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textboxAlias);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textboxInsuranceName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textboxInsuranceCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(630, 132);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // comboboxInsuranceType
            // 
            this.comboboxInsuranceType.FormattingEnabled = true;
            this.comboboxInsuranceType.Location = new System.Drawing.Point(74, 103);
            this.comboboxInsuranceType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboboxInsuranceType.Name = "comboboxInsuranceType";
            this.comboboxInsuranceType.Size = new System.Drawing.Size(151, 26);
            this.comboboxInsuranceType.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 107);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Receiver Id";
            // 
            // textboxAlias
            // 
            this.textboxAlias.Location = new System.Drawing.Point(74, 59);
            this.textboxAlias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textboxAlias.Name = "textboxAlias";
            this.textboxAlias.Size = new System.Drawing.Size(151, 21);
            this.textboxAlias.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Alias";
            // 
            // textboxInsuranceName
            // 
            this.textboxInsuranceName.Location = new System.Drawing.Point(74, 38);
            this.textboxInsuranceName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textboxInsuranceName.Name = "textboxInsuranceName";
            this.textboxInsuranceName.Size = new System.Drawing.Size(374, 21);
            this.textboxInsuranceName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Insurance ";
            // 
            // textboxInsuranceCode
            // 
            this.textboxInsuranceCode.Location = new System.Drawing.Point(74, 16);
            this.textboxInsuranceCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textboxInsuranceCode.Name = "textboxInsuranceCode";
            this.textboxInsuranceCode.Size = new System.Drawing.Size(79, 21);
            this.textboxInsuranceCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.textBoxIntegrationCode);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(618, 80);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            // 
            // textBoxIntegrationCode
            // 
            this.textBoxIntegrationCode.Location = new System.Drawing.Point(5, 34);
            this.textBoxIntegrationCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxIntegrationCode.Name = "textBoxIntegrationCode";
            this.textBoxIntegrationCode.Size = new System.Drawing.Size(151, 21);
            this.textBoxIntegrationCode.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 13);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 18);
            this.label14.TabIndex = 24;
            this.label14.Text = "Integration Code";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(6, 142);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(629, 194);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            // 
            // frmPlanMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 571);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.buttonAddPlan);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmPlanMaster";
            this.Text = "PlanMaster";
            this.Load += new System.EventHandler(this.frmPlanMaster_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn siteSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectSiteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn selectSiteName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonAddPlan;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textboxReceiverId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboboxInsuranceType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textboxAlias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textboxInsuranceName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxInsuranceCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxIntegrationCode;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;

    }
}