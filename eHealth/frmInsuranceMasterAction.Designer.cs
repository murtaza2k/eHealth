namespace eHealth
{
    partial class frmInsuranceMasterAction
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
            this.paneFormAction = new System.Windows.Forms.Panel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.paneFormAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneFormAction
            // 
            this.paneFormAction.Controls.Add(this.buttonEdit);
            this.paneFormAction.Controls.Add(this.label1);
            this.paneFormAction.Controls.Add(this.textBoxSearch);
            this.paneFormAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneFormAction.Location = new System.Drawing.Point(0, 0);
            this.paneFormAction.Name = "paneFormAction";
            this.paneFormAction.Size = new System.Drawing.Size(509, 96);
            this.paneFormAction.TabIndex = 0;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxSearch.Location = new System.Drawing.Point(6, 38);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(493, 22);
            this.textBoxSearch.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type Insurance Name";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(424, 66);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Edit ";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // frmInsuranceMasterAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 96);
            this.Controls.Add(this.paneFormAction);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmInsuranceMasterAction";
            this.Text = "Insurance Search";
            this.Load += new System.EventHandler(this.frmInsuranceMasterAction_Load);
            this.paneFormAction.ResumeLayout(false);
            this.paneFormAction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneFormAction;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearch;
    }
}