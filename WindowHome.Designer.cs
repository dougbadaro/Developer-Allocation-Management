﻿namespace Developer_Allocation_Management
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
            this.updateDeveloperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerProjectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerAllocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAllocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuHome
            // 
            this.mnuHome.BackColor = System.Drawing.Color.DimGray;
            this.mnuHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.developerToolStripMenuItem,
            this.projectToolStripMenuItem,
            this.allocationToolStripMenuItem,
            this.tasksToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.mnuHome.Location = new System.Drawing.Point(0, 0);
            this.mnuHome.Name = "mnuHome";
            this.mnuHome.Size = new System.Drawing.Size(800, 24);
            this.mnuHome.TabIndex = 0;
            this.mnuHome.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // developerToolStripMenuItem
            // 
            this.developerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem,
            this.updateDeveloperToolStripMenuItem});
            this.developerToolStripMenuItem.Name = "developerToolStripMenuItem";
            this.developerToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.developerToolStripMenuItem.Text = "Developer";
            this.developerToolStripMenuItem.Visible = false;
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.registerToolStripMenuItem.Text = "Register Developer";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // updateDeveloperToolStripMenuItem
            // 
            this.updateDeveloperToolStripMenuItem.Name = "updateDeveloperToolStripMenuItem";
            this.updateDeveloperToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.updateDeveloperToolStripMenuItem.Text = "Update Developer";
            this.updateDeveloperToolStripMenuItem.Click += new System.EventHandler(this.updateDeveloperToolStripMenuItem_Click);
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerProjectToolStripMenuItem1,
            this.updateProjectToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.projectToolStripMenuItem.Text = "Project";
            this.projectToolStripMenuItem.Visible = false;
            // 
            // registerProjectToolStripMenuItem1
            // 
            this.registerProjectToolStripMenuItem1.Name = "registerProjectToolStripMenuItem1";
            this.registerProjectToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.registerProjectToolStripMenuItem1.Text = "Register Project";
            this.registerProjectToolStripMenuItem1.Click += new System.EventHandler(this.registerProjectToolStripMenuItem1_Click);
            // 
            // updateProjectToolStripMenuItem
            // 
            this.updateProjectToolStripMenuItem.Name = "updateProjectToolStripMenuItem";
            this.updateProjectToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.updateProjectToolStripMenuItem.Text = "Update Project";
            this.updateProjectToolStripMenuItem.Click += new System.EventHandler(this.updateProjectToolStripMenuItem_Click);
            // 
            // allocationToolStripMenuItem
            // 
            this.allocationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerAllocationToolStripMenuItem,
            this.updateAllocationToolStripMenuItem});
            this.allocationToolStripMenuItem.Name = "allocationToolStripMenuItem";
            this.allocationToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.allocationToolStripMenuItem.Text = "Allocation";
            this.allocationToolStripMenuItem.Visible = false;
            // 
            // registerAllocationToolStripMenuItem
            // 
            this.registerAllocationToolStripMenuItem.Name = "registerAllocationToolStripMenuItem";
            this.registerAllocationToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.registerAllocationToolStripMenuItem.Text = "Register Allocation";
            this.registerAllocationToolStripMenuItem.Click += new System.EventHandler(this.registerAllocationToolStripMenuItem_Click);
            // 
            // updateAllocationToolStripMenuItem
            // 
            this.updateAllocationToolStripMenuItem.Name = "updateAllocationToolStripMenuItem";
            this.updateAllocationToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.updateAllocationToolStripMenuItem.Text = "Update Allocation";
            this.updateAllocationToolStripMenuItem.Click += new System.EventHandler(this.updateAllocationToolStripMenuItem_Click);
            // 
            // tasksToolStripMenuItem
            // 
            this.tasksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerTaskToolStripMenuItem,
            this.myTasksToolStripMenuItem});
            this.tasksToolStripMenuItem.Name = "tasksToolStripMenuItem";
            this.tasksToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.tasksToolStripMenuItem.Text = "Tasks";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Visible = false;
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem1_Click);
            // 
            // registerTaskToolStripMenuItem
            // 
            this.registerTaskToolStripMenuItem.Name = "registerTaskToolStripMenuItem";
            this.registerTaskToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registerTaskToolStripMenuItem.Text = "Register Task";
            this.registerTaskToolStripMenuItem.Visible = false;
            this.registerTaskToolStripMenuItem.Click += new System.EventHandler(this.registerTaskToolStripMenuItem_Click);
            // 
            // myTasksToolStripMenuItem
            // 
            this.myTasksToolStripMenuItem.Name = "myTasksToolStripMenuItem";
            this.myTasksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.myTasksToolStripMenuItem.Text = "My Tasks";
            this.myTasksToolStripMenuItem.Click += new System.EventHandler(this.myTasksToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerAllocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDeveloperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateAllocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myTasksToolStripMenuItem;
    }
}