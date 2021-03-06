﻿namespace eHealth
{
    partial class frmCategoryMaster
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
            this.textboxCategoryDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxCategoryCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxIsActive = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.selectSiteName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectSiteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siteSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewSite = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewCategoryList = new System.Windows.Forms.DataGridView();
            this.gridColIsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridColCategoryCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridColCategoryDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.comboBoxOperator = new System.Windows.Forms.ComboBox();
            this.comboBoxSearchFields = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSite)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategoryList)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textboxCategoryDescription
            // 
            this.textboxCategoryDescription.Location = new System.Drawing.Point(92, 52);
            this.textboxCategoryDescription.Name = "textboxCategoryDescription";
            this.textboxCategoryDescription.Size = new System.Drawing.Size(467, 21);
            this.textboxCategoryDescription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // textboxCategoryCode
            // 
            this.textboxCategoryCode.Location = new System.Drawing.Point(92, 20);
            this.textboxCategoryCode.Name = "textboxCategoryCode";
            this.textboxCategoryCode.Size = new System.Drawing.Size(98, 21);
            this.textboxCategoryCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkBoxIsActive);
            this.groupBox1.Controls.Add(this.textboxCategoryDescription);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textboxCategoryCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 108);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            // 
            // checkBoxIsActive
            // 
            this.checkBoxIsActive.AutoSize = true;
            this.checkBoxIsActive.Location = new System.Drawing.Point(92, 83);
            this.checkBoxIsActive.Name = "checkBoxIsActive";
            this.checkBoxIsActive.Size = new System.Drawing.Size(61, 22);
            this.checkBoxIsActive.TabIndex = 4;
            this.checkBoxIsActive.Text = "Active";
            this.checkBoxIsActive.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(10, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(788, 6);
            this.label13.TabIndex = 40;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(189, 591);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 29);
            this.buttonFind.TabIndex = 44;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(97, 591);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 29);
            this.buttonClose.TabIndex = 43;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(783, 352);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Audit";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // selectSiteName
            // 
            this.selectSiteName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.selectSiteName.HeaderText = "Site";
            this.selectSiteName.Name = "selectSiteName";
            // 
            // SelectSiteId
            // 
            this.SelectSiteId.HeaderText = "Site Id";
            this.SelectSiteId.Name = "SelectSiteId";
            // 
            // siteSelect
            // 
            this.siteSelect.HeaderText = "Select";
            this.siteSelect.Name = "siteSelect";
            this.siteSelect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.siteSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.siteSelect.Width = 50;
            // 
            // dataGridViewSite
            // 
            this.dataGridViewSite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSite.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.siteSelect,
            this.SelectSiteId,
            this.selectSiteName});
            this.dataGridViewSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSite.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSite.Name = "dataGridViewSite";
            this.dataGridViewSite.RowTemplate.Height = 24;
            this.dataGridViewSite.Size = new System.Drawing.Size(783, 352);
            this.dataGridViewSite.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewSite);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 352);
            this.panel1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(783, 352);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Site";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(7, 202);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(791, 383);
            this.tabControl1.TabIndex = 41;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewCategoryList);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(783, 352);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Category List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCategoryList
            // 
            this.dataGridViewCategoryList.AllowUserToAddRows = false;
            this.dataGridViewCategoryList.AllowUserToDeleteRows = false;
            this.dataGridViewCategoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategoryList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridColIsActive,
            this.gridColCategoryCode,
            this.gridColCategoryDescription});
            this.dataGridViewCategoryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCategoryList.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCategoryList.MultiSelect = false;
            this.dataGridViewCategoryList.Name = "dataGridViewCategoryList";
            this.dataGridViewCategoryList.ReadOnly = true;
            this.dataGridViewCategoryList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCategoryList.Size = new System.Drawing.Size(783, 352);
            this.dataGridViewCategoryList.TabIndex = 0;
            // 
            // gridColIsActive
            // 
            this.gridColIsActive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.gridColIsActive.HeaderText = "Is Active";
            this.gridColIsActive.Name = "gridColIsActive";
            this.gridColIsActive.ReadOnly = true;
            this.gridColIsActive.Width = 72;
            // 
            // gridColCategoryCode
            // 
            this.gridColCategoryCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gridColCategoryCode.HeaderText = "Category Code";
            this.gridColCategoryCode.Name = "gridColCategoryCode";
            this.gridColCategoryCode.ReadOnly = true;
            this.gridColCategoryCode.Width = 105;
            // 
            // gridColCategoryDescription
            // 
            this.gridColCategoryDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gridColCategoryDescription.HeaderText = "Category Description";
            this.gridColCategoryDescription.Name = "gridColCategoryDescription";
            this.gridColCategoryDescription.ReadOnly = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 591);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 29);
            this.buttonSave.TabIndex = 42;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBoxSearch);
            this.panel2.Controls.Add(this.comboBoxOperator);
            this.panel2.Controls.Add(this.comboBoxSearchFields);
            this.panel2.Location = new System.Drawing.Point(7, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(788, 70);
            this.panel2.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(213, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Operator";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Search By";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(0, -2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Filter";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(290, 40);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(210, 21);
            this.textBoxSearch.TabIndex = 2;
            // 
            // comboBoxOperator
            // 
            this.comboBoxOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOperator.FormattingEnabled = true;
            this.comboBoxOperator.Items.AddRange(new object[] {
            "Like",
            "Equal to ",
            "Contain"});
            this.comboBoxOperator.Location = new System.Drawing.Point(211, 39);
            this.comboBoxOperator.Name = "comboBoxOperator";
            this.comboBoxOperator.Size = new System.Drawing.Size(75, 26);
            this.comboBoxOperator.TabIndex = 1;
            // 
            // comboBoxSearchFields
            // 
            this.comboBoxSearchFields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchFields.FormattingEnabled = true;
            this.comboBoxSearchFields.Items.AddRange(new object[] {
            "Code",
            "Description"});
            this.comboBoxSearchFields.Location = new System.Drawing.Point(7, 39);
            this.comboBoxSearchFields.Name = "comboBoxSearchFields";
            this.comboBoxSearchFields.Size = new System.Drawing.Size(198, 26);
            this.comboBoxSearchFields.TabIndex = 0;
            // 
            // frmCategoryMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(803, 621);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonSave);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCategoryMaster";
            this.Load += new System.EventHandler(this.frmCategoryMaster_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSite)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategoryList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.TextBox textboxCategoryDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxCategoryCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn selectSiteName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectSiteId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn siteSelect;
        private System.Windows.Forms.DataGridView dataGridViewSite;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.CheckBox checkBoxIsActive;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxOperator;
        private System.Windows.Forms.ComboBox comboBoxSearchFields;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView dataGridViewCategoryList;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColIsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColCategoryCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColCategoryDescription;
    }
}