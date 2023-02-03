namespace Developer_Allocation_Management
{
    partial class WindowUpdateProj
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
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lstProjects = new System.Windows.Forms.ListBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dtpPlannedTerm = new System.Windows.Forms.DateTimePicker();
            this.lblPlannedTerm = new System.Windows.Forms.Label();
            this.dtpTermination = new System.Windows.Forms.DateTimePicker();
            this.lblTermination = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(472, 190);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(121, 20);
            this.dtpStart.TabIndex = 41;
            // 
            // lstProjects
            // 
            this.lstProjects.Font = new System.Drawing.Font("Montserrat", 9.749999F);
            this.lstProjects.FormattingEnabled = true;
            this.lstProjects.ItemHeight = 18;
            this.lstProjects.Location = new System.Drawing.Point(27, 122);
            this.lstProjects.Name = "lstProjects";
            this.lstProjects.Size = new System.Drawing.Size(240, 292);
            this.lstProjects.TabIndex = 40;
            this.lstProjects.SelectedIndexChanged += new System.EventHandler(this.lstProjects_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(527, 401);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(66, 24);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(472, 164);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 20);
            this.txtName.TabIndex = 33;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(421, 192);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(45, 18);
            this.lblStart.TabIndex = 27;
            this.lblStart.Text = "Start: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(411, 164);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 18);
            this.lblName.TabIndex = 26;
            this.lblName.Text = "Name: ";
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProject.Location = new System.Drawing.Point(24, 84);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(60, 18);
            this.lblProject.TabIndex = 25;
            this.lblProject.Text = "Project: ";
            // 
            // txtProject
            // 
            this.txtProject.Location = new System.Drawing.Point(111, 84);
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(156, 20);
            this.txtProject.TabIndex = 24;
            this.txtProject.TextChanged += new System.EventHandler(this.txtProject_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(254, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(161, 26);
            this.lblTitle.TabIndex = 23;
            this.lblTitle.Text = "Project Update";
            // 
            // dtpPlannedTerm
            // 
            this.dtpPlannedTerm.Location = new System.Drawing.Point(472, 216);
            this.dtpPlannedTerm.Name = "dtpPlannedTerm";
            this.dtpPlannedTerm.Size = new System.Drawing.Size(121, 20);
            this.dtpPlannedTerm.TabIndex = 43;
            // 
            // lblPlannedTerm
            // 
            this.lblPlannedTerm.AutoSize = true;
            this.lblPlannedTerm.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlannedTerm.Location = new System.Drawing.Point(317, 218);
            this.lblPlannedTerm.Name = "lblPlannedTerm";
            this.lblPlannedTerm.Size = new System.Drawing.Size(149, 18);
            this.lblPlannedTerm.TabIndex = 42;
            this.lblPlannedTerm.Text = "Planned termination: ";
            // 
            // dtpTermination
            // 
            this.dtpTermination.Location = new System.Drawing.Point(472, 242);
            this.dtpTermination.Name = "dtpTermination";
            this.dtpTermination.Size = new System.Drawing.Size(121, 20);
            this.dtpTermination.TabIndex = 45;
            // 
            // lblTermination
            // 
            this.lblTermination.AutoSize = true;
            this.lblTermination.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTermination.Location = new System.Drawing.Point(374, 244);
            this.lblTermination.Name = "lblTermination";
            this.lblTermination.Size = new System.Drawing.Size(92, 18);
            this.lblTermination.TabIndex = 44;
            this.lblTermination.Text = "Termination: ";
            // 
            // WindowUpdateProj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 450);
            this.Controls.Add(this.dtpTermination);
            this.Controls.Add(this.lblTermination);
            this.Controls.Add(this.dtpPlannedTerm);
            this.Controls.Add(this.lblPlannedTerm);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.lstProjects);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.txtProject);
            this.Controls.Add(this.lblTitle);
            this.Name = "WindowUpdateProj";
            this.Text = "Update Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.ListBox lstProjects;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.TextBox txtProject;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DateTimePicker dtpPlannedTerm;
        private System.Windows.Forms.Label lblPlannedTerm;
        private System.Windows.Forms.DateTimePicker dtpTermination;
        private System.Windows.Forms.Label lblTermination;
    }
}