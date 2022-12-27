namespace Developer_Allocation_Management
{
    partial class WindowHome
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
            this.mnuHome = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.developerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerProjectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.allocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerAllocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuHome
            // 
            this.mnuHome.BackColor = System.Drawing.Color.DimGray;
            this.mnuHome.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.developerToolStripMenuItem,
            this.projectToolStripMenuItem,
            this.allocationToolStripMenuItem,
            this.reportToolStripMenuItem1});
            this.mnuHome.Location = new System.Drawing.Point(0, 0);
            this.mnuHome.Name = "mnuHome";
            this.mnuHome.Size = new System.Drawing.Size(800, 26);
            this.mnuHome.TabIndex = 0;
            this.mnuHome.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(42, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // developerToolStripMenuItem
            // 
            this.developerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem});
            this.developerToolStripMenuItem.Name = "developerToolStripMenuItem";
            this.developerToolStripMenuItem.Size = new System.Drawing.Size(87, 22);
            this.developerToolStripMenuItem.Text = "Developer";
            this.developerToolStripMenuItem.Visible = false;
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.registerToolStripMenuItem.Text = "Register Developer";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerProjectToolStripMenuItem1});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(66, 22);
            this.projectToolStripMenuItem.Text = "Project";
            this.projectToolStripMenuItem.Visible = false;
            // 
            // registerProjectToolStripMenuItem1
            // 
            this.registerProjectToolStripMenuItem1.Name = "registerProjectToolStripMenuItem1";
            this.registerProjectToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.registerProjectToolStripMenuItem1.Text = "Register Project";
            this.registerProjectToolStripMenuItem1.Click += new System.EventHandler(this.registerProjectToolStripMenuItem1_Click);
            // 
            // allocationToolStripMenuItem
            // 
            this.allocationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerAllocationToolStripMenuItem});
            this.allocationToolStripMenuItem.Name = "allocationToolStripMenuItem";
            this.allocationToolStripMenuItem.Size = new System.Drawing.Size(83, 22);
            this.allocationToolStripMenuItem.Text = "Allocation";
            this.allocationToolStripMenuItem.Visible = false;
            // 
            // registerAllocationToolStripMenuItem
            // 
            this.registerAllocationToolStripMenuItem.Name = "registerAllocationToolStripMenuItem";
            this.registerAllocationToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.registerAllocationToolStripMenuItem.Text = "Register Allocation";
            this.registerAllocationToolStripMenuItem.Click += new System.EventHandler(this.registerAllocationToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem1
            // 
            this.reportToolStripMenuItem1.Name = "reportToolStripMenuItem1";
            this.reportToolStripMenuItem1.Size = new System.Drawing.Size(64, 22);
            this.reportToolStripMenuItem1.Text = "Report";
            this.reportToolStripMenuItem1.Click += new System.EventHandler(this.reportToolStripMenuItem1_Click);
            // 
            // WindowHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnuHome);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuHome;
            this.Name = "WindowHome";
            this.Text = "Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WindowHome_FormClosed);
            this.mnuHome.ResumeLayout(false);
            this.mnuHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuHome;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem developerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerProjectToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem allocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerAllocationToolStripMenuItem;
    }
}