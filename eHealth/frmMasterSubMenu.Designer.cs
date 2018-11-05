namespace eHealth
{
    partial class frmMasterSubMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMasterSubMenu));
            this.imageListMainMenu = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanelMaster = new System.Windows.Forms.TableLayoutPanel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanelMaster.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageListMainMenu
            // 
            this.imageListMainMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMainMenu.ImageStream")));
            this.imageListMainMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMainMenu.Images.SetKeyName(0, "icons8-user-64.png");
            this.imageListMainMenu.Images.SetKeyName(1, "icons8-user-128.png");
            this.imageListMainMenu.Images.SetKeyName(2, "icons8-organization-64.png");
            this.imageListMainMenu.Images.SetKeyName(3, "icons8-organization-128.png");
            this.imageListMainMenu.Images.SetKeyName(4, "icons8-medical-doctor-64.png");
            this.imageListMainMenu.Images.SetKeyName(5, "icons8-go-back-64.png");
            this.imageListMainMenu.Images.SetKeyName(6, "icons8-services-64.png");
            // 
            // tableLayoutPanelMaster
            // 
            this.tableLayoutPanelMaster.AutoScrollMargin = new System.Drawing.Size(0, 1);
            this.tableLayoutPanelMaster.AutoScrollMinSize = new System.Drawing.Size(2, 2);
            this.tableLayoutPanelMaster.AutoSize = true;
            this.tableLayoutPanelMaster.ColumnCount = 1;
            this.tableLayoutPanelMaster.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMaster.Controls.Add(this.button5, 0, 4);
            this.tableLayoutPanelMaster.Controls.Add(this.button4, 0, 3);
            this.tableLayoutPanelMaster.Controls.Add(this.button3, 0, 2);
            this.tableLayoutPanelMaster.Controls.Add(this.button2, 0, 1);
            this.tableLayoutPanelMaster.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanelMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMaster.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMaster.Name = "tableLayoutPanelMaster";
            this.tableLayoutPanelMaster.RowCount = 5;
            this.tableLayoutPanelMaster.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMaster.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMaster.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMaster.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMaster.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMaster.Size = new System.Drawing.Size(247, 465);
            this.tableLayoutPanelMaster.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.ImageKey = "icons8-go-back-64.png";
            this.button5.ImageList = this.imageListMainMenu;
            this.button5.Location = new System.Drawing.Point(3, 367);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(241, 95);
            this.button5.TabIndex = 4;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.ImageKey = "icons8-services-64.png";
            this.button4.ImageList = this.imageListMainMenu;
            this.button4.Location = new System.Drawing.Point(3, 276);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(241, 85);
            this.button4.TabIndex = 3;
            this.button4.Text = "General Master";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageIndex = 4;
            this.button3.ImageList = this.imageListMainMenu;
            this.button3.Location = new System.Drawing.Point(3, 185);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(241, 85);
            this.button3.TabIndex = 2;
            this.button3.Text = "Doctor";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 2;
            this.button2.ImageList = this.imageListMainMenu;
            this.button2.Location = new System.Drawing.Point(3, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(241, 85);
            this.button2.TabIndex = 1;
            this.button2.Text = "Insurance";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 1;
            this.button1.ImageList = this.imageListMainMenu;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 85);
            this.button1.TabIndex = 0;
            this.button1.Text = "     User";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmMasterSubMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(247, 465);
            this.Controls.Add(this.tableLayoutPanelMaster);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMasterSubMenu";
            this.ShowInTaskbar = false;
            this.Text = "Master Sub Menu";
            this.Load += new System.EventHandler(this.frmMasterSubMenu_Load);
            this.tableLayoutPanelMaster.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageListMainMenu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMaster;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}