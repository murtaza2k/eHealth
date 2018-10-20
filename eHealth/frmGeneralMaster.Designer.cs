namespace eHealth
{
    partial class frmGeneralMaster
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.comboBoxSearchFields = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxOperator = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.siteSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SelectSiteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectSiteName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.checkBoxIsActive = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxCategoryCode = new System.Windows.Forms.ComboBox();
            this.textboxDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxGeneralCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(426, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Operator";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(12, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Search By";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(0, -8);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Filter";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(586, 78);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(378, 35);
            this.textBoxSearch.TabIndex = 2;
            // 
            // comboBoxSearchFields
            // 
            this.comboBoxSearchFields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchFields.FormattingEnabled = true;
            this.comboBoxSearchFields.Items.AddRange(new object[] {
            "Code",
            "Description"});
            this.comboBoxSearchFields.Location = new System.Drawing.Point(14, 78);
            this.comboBoxSearchFields.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxSearchFields.Name = "comboBoxSearchFields";
            this.comboBoxSearchFields.Size = new System.Drawing.Size(392, 37);
            this.comboBoxSearchFields.TabIndex = 0;
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
            this.panel2.Location = new System.Drawing.Point(12, 308);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1576, 140);
            this.panel2.TabIndex = 53;
            // 
            // comboBoxOperator
            // 
            this.comboBoxOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOperator.FormattingEnabled = true;
            this.comboBoxOperator.Items.AddRange(new object[] {
            "Like",
            "Equal to ",
            "Contain"});
            this.comboBoxOperator.Location = new System.Drawing.Point(422, 78);
            this.comboBoxOperator.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxOperator.Name = "comboBoxOperator";
            this.comboBoxOperator.Size = new System.Drawing.Size(146, 37);
            this.comboBoxOperator.TabIndex = 1;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(26, 1358);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(150, 58);
            this.buttonSave.TabIndex = 50;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1560, 847);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(8, 43);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1560, 847);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "General Master List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 460);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1576, 898);
            this.tabControl1.TabIndex = 49;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Location = new System.Drawing.Point(8, 43);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1560, 847);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Site";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1560, 847);
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
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1560, 847);
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
            this.tabPage2.Location = new System.Drawing.Point(8, 43);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage2.Size = new System.Drawing.Size(1560, 847);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Audit";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(18, 288);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(1576, 12);
            this.label13.TabIndex = 48;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(380, 1358);
            this.buttonFind.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(150, 58);
            this.buttonFind.TabIndex = 52;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(196, 1358);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(150, 58);
            this.buttonClose.TabIndex = 51;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsActive
            // 
            this.checkBoxIsActive.AutoSize = true;
            this.checkBoxIsActive.Location = new System.Drawing.Point(718, 174);
            this.checkBoxIsActive.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxIsActive.Name = "checkBoxIsActive";
            this.checkBoxIsActive.Size = new System.Drawing.Size(113, 33);
            this.checkBoxIsActive.TabIndex = 4;
            this.checkBoxIsActive.Text = "Active";
            this.checkBoxIsActive.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxCategoryCode);
            this.groupBox1.Controls.Add(this.checkBoxIsActive);
            this.groupBox1.Controls.Add(this.textboxDescription);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textboxGeneralCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(1576, 268);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 174);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Category";
            // 
            // comboBoxCategoryCode
            // 
            this.comboBoxCategoryCode.FormattingEnabled = true;
            this.comboBoxCategoryCode.Location = new System.Drawing.Point(184, 166);
            this.comboBoxCategoryCode.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxCategoryCode.Name = "comboBoxCategoryCode";
            this.comboBoxCategoryCode.Size = new System.Drawing.Size(482, 37);
            this.comboBoxCategoryCode.TabIndex = 5;
            // 
            // textboxDescription
            // 
            this.textboxDescription.Location = new System.Drawing.Point(184, 104);
            this.textboxDescription.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textboxDescription.Name = "textboxDescription";
            this.textboxDescription.Size = new System.Drawing.Size(930, 35);
            this.textboxDescription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // textboxGeneralCode
            // 
            this.textboxGeneralCode.Location = new System.Drawing.Point(184, 40);
            this.textboxGeneralCode.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textboxGeneralCode.Name = "textboxGeneralCode";
            this.textboxGeneralCode.Size = new System.Drawing.Size(192, 35);
            this.textboxGeneralCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // frmGeneralMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1606, 1428);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "frmGeneralMaster";
            this.Text = "General Master";
            this.Load += new System.EventHandler(this.frmGeneralMaster_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxSearchFields;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxOperator;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn siteSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectSiteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn selectSiteName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.CheckBox checkBoxIsActive;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textboxDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxGeneralCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxCategoryCode;
    }
}