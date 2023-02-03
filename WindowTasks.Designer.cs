namespace Developer_Allocation_Management
{
    partial class WindowTasks
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lstDevelopers = new System.Windows.Forms.ListBox();
            this.lstProjects = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDeveloper = new System.Windows.Forms.TextBox();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.lstTasks = new System.Windows.Forms.ListBox();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.lblTask = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 9.749999F);
            this.label1.Location = new System.Drawing.Point(100, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "List of project developers";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(233, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(146, 26);
            this.lblTitle.TabIndex = 32;
            this.lblTitle.Text = "Register Task";
            // 
            // lstDevelopers
            // 
            this.lstDevelopers.Font = new System.Drawing.Font("Montserrat", 9.749999F);
            this.lstDevelopers.FormattingEnabled = true;
            this.lstDevelopers.ItemHeight = 18;
            this.lstDevelopers.Location = new System.Drawing.Point(105, 291);
            this.lstDevelopers.Name = "lstDevelopers";
            this.lstDevelopers.Size = new System.Drawing.Size(238, 130);
            this.lstDevelopers.TabIndex = 31;
            this.lstDevelopers.SelectedIndexChanged += new System.EventHandler(this.lstDevelopers_SelectedIndexChanged);
            // 
            // lstProjects
            // 
            this.lstProjects.Font = new System.Drawing.Font("Montserrat", 9.749999F);
            this.lstProjects.FormattingEnabled = true;
            this.lstProjects.ItemHeight = 18;
            this.lstProjects.Location = new System.Drawing.Point(105, 103);
            this.lstProjects.Name = "lstProjects";
            this.lstProjects.Size = new System.Drawing.Size(238, 130);
            this.lstProjects.TabIndex = 30;
            this.lstProjects.SelectedIndexChanged += new System.EventHandler(this.lstProjects_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Montserrat", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(567, 71);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(44, 20);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDeveloper
            // 
            this.txtDeveloper.Font = new System.Drawing.Font("Montserrat", 9.749999F);
            this.txtDeveloper.Location = new System.Drawing.Point(105, 265);
            this.txtDeveloper.Name = "txtDeveloper";
            this.txtDeveloper.Size = new System.Drawing.Size(238, 23);
            this.txtDeveloper.TabIndex = 21;
            this.txtDeveloper.TextChanged += new System.EventHandler(this.txtDeveloper_TextChanged);
            // 
            // txtProject
            // 
            this.txtProject.Font = new System.Drawing.Font("Montserrat", 9.749999F);
            this.txtProject.Location = new System.Drawing.Point(105, 77);
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(238, 23);
            this.txtProject.TabIndex = 20;
            this.txtProject.TextChanged += new System.EventHandler(this.txtProject_TextChanged);
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Font = new System.Drawing.Font("Montserrat", 9.749999F);
            this.lblDeveloper.Location = new System.Drawing.Point(18, 268);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(81, 18);
            this.lblDeveloper.TabIndex = 19;
            this.lblDeveloper.Text = "Developer: ";
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Font = new System.Drawing.Font("Montserrat", 9.749999F);
            this.lblProject.Location = new System.Drawing.Point(39, 80);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(60, 18);
            this.lblProject.TabIndex = 18;
            this.lblProject.Text = "Project: ";
            // 
            // lstTasks
            // 
            this.lstTasks.ContextMenuStrip = this.contextMenuStrip1;
            this.lstTasks.Font = new System.Drawing.Font("Montserrat", 9.749999F);
            this.lstTasks.FormattingEnabled = true;
            this.lstTasks.ItemHeight = 18;
            this.lstTasks.Location = new System.Drawing.Point(413, 111);
            this.lstTasks.Name = "lstTasks";
            this.lstTasks.Size = new System.Drawing.Size(198, 310);
            this.lstTasks.TabIndex = 35;
            this.lstTasks.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lstTasks_MouseUp);
            // 
            // txtTask
            // 
            this.txtTask.Font = new System.Drawing.Font("Montserrat", 9.749999F);
            this.txtTask.Location = new System.Drawing.Point(453, 71);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(96, 23);
            this.txtTask.TabIndex = 36;
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Font = new System.Drawing.Font("Montserrat", 9.749999F);
            this.lblTask.Location = new System.Drawing.Point(410, 74);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(43, 18);
            this.lblTask.TabIndex = 37;
            this.lblTask.Text = "Task: ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excluirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(110, 26);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // WindowTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 443);
            this.Controls.Add(this.lblTask);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.lstTasks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lstDevelopers);
            this.Controls.Add(this.lstProjects);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDeveloper);
            this.Controls.Add(this.txtProject);
            this.Controls.Add(this.lblDeveloper);
            this.Controls.Add(this.lblProject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WindowTasks";
            this.Text = "Register Tasks";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lstDevelopers;
        private System.Windows.Forms.ListBox lstProjects;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDeveloper;
        private System.Windows.Forms.TextBox txtProject;
        private System.Windows.Forms.Label lblDeveloper;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.ListBox lstTasks;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
    }
}