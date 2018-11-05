namespace eHealth
{
    partial class frmObservation
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
            this.pnlObservation = new System.Windows.Forms.Panel();
            this.label57 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.txtObservationActivity = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.btnCancelObs = new System.Windows.Forms.Button();
            this.btnActionObservation = new System.Windows.Forms.Button();
            this.txtObservationValueType = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.txtObservationValue = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.txtObservationCode = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.cboObservationType = new System.Windows.Forms.ComboBox();
            this.pnlObservation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlObservation
            // 
            this.pnlObservation.BackColor = System.Drawing.SystemColors.Control;
            this.pnlObservation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlObservation.Controls.Add(this.label57);
            this.pnlObservation.Controls.Add(this.label42);
            this.pnlObservation.Controls.Add(this.txtObservationActivity);
            this.pnlObservation.Controls.Add(this.label46);
            this.pnlObservation.Controls.Add(this.btnCancelObs);
            this.pnlObservation.Controls.Add(this.btnActionObservation);
            this.pnlObservation.Controls.Add(this.txtObservationValueType);
            this.pnlObservation.Controls.Add(this.label45);
            this.pnlObservation.Controls.Add(this.txtObservationValue);
            this.pnlObservation.Controls.Add(this.label44);
            this.pnlObservation.Controls.Add(this.txtObservationCode);
            this.pnlObservation.Controls.Add(this.label43);
            this.pnlObservation.Controls.Add(this.cboObservationType);
            this.pnlObservation.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlObservation.Location = new System.Drawing.Point(1, 3);
            this.pnlObservation.Name = "pnlObservation";
            this.pnlObservation.Size = new System.Drawing.Size(624, 162);
            this.pnlObservation.TabIndex = 108;
            // 
            // label57
            // 
            this.label57.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label57.Dock = System.Windows.Forms.DockStyle.Top;
            this.label57.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label57.Location = new System.Drawing.Point(0, 0);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(620, 23);
            this.label57.TabIndex = 12;
            this.label57.Text = "Add Observations";
            this.label57.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(0, 35);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(104, 14);
            this.label42.TabIndex = 1;
            this.label42.Text = "Observation Type";
            // 
            // txtObservationActivity
            // 
            this.txtObservationActivity.BackColor = System.Drawing.SystemColors.Control;
            this.txtObservationActivity.Location = new System.Drawing.Point(309, 56);
            this.txtObservationActivity.Multiline = true;
            this.txtObservationActivity.Name = "txtObservationActivity";
            this.txtObservationActivity.Size = new System.Drawing.Size(290, 20);
            this.txtObservationActivity.TabIndex = 11;
            // 
            // label46
            // 
            this.label46.Location = new System.Drawing.Point(336, 30);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(172, 23);
            this.label46.TabIndex = 10;
            this.label46.Text = "Observation For Activity ";
            // 
            // btnCancelObs
            // 
            this.btnCancelObs.Location = new System.Drawing.Point(521, 123);
            this.btnCancelObs.Name = "btnCancelObs";
            this.btnCancelObs.Size = new System.Drawing.Size(78, 23);
            this.btnCancelObs.TabIndex = 9;
            this.btnCancelObs.Text = "Cancel Obs";
            this.btnCancelObs.UseVisualStyleBackColor = true;
            this.btnCancelObs.Click += new System.EventHandler(this.btnCancelObs_Click);
            // 
            // btnActionObservation
            // 
            this.btnActionObservation.Location = new System.Drawing.Point(400, 122);
            this.btnActionObservation.Name = "btnActionObservation";
            this.btnActionObservation.Size = new System.Drawing.Size(108, 23);
            this.btnActionObservation.TabIndex = 8;
            this.btnActionObservation.Text = "Save Obs";
            this.btnActionObservation.UseVisualStyleBackColor = true;
            // 
            // txtObservationValueType
            // 
            this.txtObservationValueType.Location = new System.Drawing.Point(136, 123);
            this.txtObservationValueType.Name = "txtObservationValueType";
            this.txtObservationValueType.Size = new System.Drawing.Size(170, 22);
            this.txtObservationValueType.TabIndex = 7;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(0, 131);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(138, 14);
            this.label45.TabIndex = 6;
            this.label45.Text = "Observation Value Type";
            // 
            // txtObservationValue
            // 
            this.txtObservationValue.Location = new System.Drawing.Point(135, 82);
            this.txtObservationValue.Multiline = true;
            this.txtObservationValue.Name = "txtObservationValue";
            this.txtObservationValue.Size = new System.Drawing.Size(464, 35);
            this.txtObservationValue.TabIndex = 5;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(0, 90);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(106, 14);
            this.label44.TabIndex = 4;
            this.label44.Text = "Observation Value";
            // 
            // txtObservationCode
            // 
            this.txtObservationCode.Location = new System.Drawing.Point(135, 55);
            this.txtObservationCode.Name = "txtObservationCode";
            this.txtObservationCode.Size = new System.Drawing.Size(170, 22);
            this.txtObservationCode.TabIndex = 3;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(0, 63);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(104, 14);
            this.label43.TabIndex = 2;
            this.label43.Text = "Observation Code";
            // 
            // cboObservationType
            // 
            this.cboObservationType.FormattingEnabled = true;
            this.cboObservationType.Items.AddRange(new object[] {
            "LOINC",
            "Text",
            "File",
            "UniversalDental",
            "Financial ",
            "Grouping",
            "ERX",
            "Result"});
            this.cboObservationType.Location = new System.Drawing.Point(135, 27);
            this.cboObservationType.Name = "cboObservationType";
            this.cboObservationType.Size = new System.Drawing.Size(173, 22);
            this.cboObservationType.TabIndex = 0;
            // 
            // frmObservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 166);
            this.ControlBox = false;
            this.Controls.Add(this.pnlObservation);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmObservation";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.pnlObservation.ResumeLayout(false);
            this.pnlObservation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlObservation;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox txtObservationActivity;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Button btnCancelObs;
        private System.Windows.Forms.Button btnActionObservation;
        private System.Windows.Forms.TextBox txtObservationValueType;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox txtObservationValue;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox txtObservationCode;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.ComboBox cboObservationType;
    }
}