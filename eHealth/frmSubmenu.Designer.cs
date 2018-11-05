namespace eHealth
{
    partial class frmSubmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubmenu));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.imageListMainMenu = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(241, 410);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.ImageKey = "icons8-go-back-64.png";
            this.button4.ImageList = this.imageListMainMenu;
            this.button4.Location = new System.Drawing.Point(3, 309);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(235, 98);
            this.button4.TabIndex = 3;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageIndex = 4;
            this.button3.ImageList = this.imageListMainMenu;
            this.button3.Location = new System.Drawing.Point(3, 207);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(235, 96);
            this.button3.TabIndex = 2;
            this.button3.Text = "Search Request";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageKey = "icons8-edit-property-64.png";
            this.button2.ImageList = this.imageListMainMenu;
            this.button2.Location = new System.Drawing.Point(3, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(235, 96);
            this.button2.TabIndex = 1;
            this.button2.Text = "Modify Request";
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
            this.button1.Size = new System.Drawing.Size(235, 96);
            this.button1.TabIndex = 0;
            this.button1.Text = "New Request";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // imageListMainMenu
            // 
            this.imageListMainMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMainMenu.ImageStream")));
            this.imageListMainMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMainMenu.Images.SetKeyName(0, "icons8-add-64.png");
            this.imageListMainMenu.Images.SetKeyName(1, "icons8-add-128.png");
            this.imageListMainMenu.Images.SetKeyName(2, "icons8-edit-property-64.png");
            this.imageListMainMenu.Images.SetKeyName(3, "icons8-edit-property-128.png");
            this.imageListMainMenu.Images.SetKeyName(4, "icons8-search-64.png");
            this.imageListMainMenu.Images.SetKeyName(5, "icons8-search-128.png");
            this.imageListMainMenu.Images.SetKeyName(6, "icons8-go-back-64.png");
            this.imageListMainMenu.Images.SetKeyName(7, "icons8-go-back-128.png");
            // 
            // frmSubmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 410);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSubmenu";
            this.Text = "Submenu";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageListMainMenu;
    }
}