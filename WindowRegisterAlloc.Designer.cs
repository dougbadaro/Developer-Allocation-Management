namespace Developer_Allocation_Management
{
    partial class WindowRegisterAlloc
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
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.txtDeveloper = new System.Windows.Forms.TextBox();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblStart = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpTermination = new System.Windows.Forms.DateTimePicker();
            this.nmrHours = new System.Windows.Forms.NumericUpDown();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblRs = new System.Windows.Forms.Label();
            this.txtRemuneration = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lstDevelopers = new System.Windows.Forms.ListBox();
            this.lstProjects = new System.Windows.Forms.ListBox();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrHours)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeveloper.Location = new System.Drawing.Point(28, 64);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(66, 15);
            this.lblDeveloper.TabIndex = 0;
            this.lblDeveloper.Text = "Developer:";
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProject.Location = new System.Drawing.Point(273, 64);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(51, 15);
            this.lblProject.TabIndex = 1;
            this.lblProject.Text = "Project: ";
            // 
            // txtDeveloper
            // 
            this.txtDeveloper.Location = new System.Drawing.Point(100, 62);
            this.txtDeveloper.Name = "txtDeveloper";
            this.txtDeveloper.Size = new System.Drawing.Size(100, 20);
            this.txtDeveloper.TabIndex = 2;
            // 
            // txtProject
            // 
            this.txtProject.Location = new System.Drawing.Point(330, 62);
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(100, 20);
            this.txtProject.TabIndex = 3;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(178, 212);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(145, 20);
            this.dtpStart.TabIndex = 4;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(135, 217);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(37, 15);
            this.lblStart.TabIndex = 5;
            this.lblStart.Text = "Start: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Termination: ";
            // 
            // dtpTermination
            // 
            this.dtpTermination.Location = new System.Drawing.Point(178, 238);
            this.dtpTermination.Name = "dtpTermination";
            this.dtpTermination.Size = new System.Drawing.Size(145, 20);
            this.dtpTermination.TabIndex = 7;
            // 
            // nmrHours
            // 
            this.nmrHours.Location = new System.Drawing.Point(178, 264);
            this.nmrHours.Name = "nmrHours";
            this.nmrHours.Size = new System.Drawing.Size(145, 20);
            this.nmrHours.TabIndex = 8;
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.Location = new System.Drawing.Point(128, 269);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(44, 15);
            this.lblHours.TabIndex = 9;
            this.lblHours.Text = "Hours: ";
            // 
            // lblRs
            // 
            this.lblRs.AutoSize = true;
            this.lblRs.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRs.Location = new System.Drawing.Point(150, 292);
            this.lblRs.Name = "lblRs";
            this.lblRs.Size = new System.Drawing.Size(22, 15);
            this.lblRs.TabIndex = 10;
            this.lblRs.Text = "R$";
            // 
            // txtRemuneration
            // 
            this.txtRemuneration.Location = new System.Drawing.Point(178, 290);
            this.txtRemuneration.Name = "txtRemuneration";
            this.txtRemuneration.Size = new System.Drawing.Size(145, 20);
            this.txtRemuneration.TabIndex = 11;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(359, 329);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(71, 24);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // lstDevelopers
            // 
            this.lstDevelopers.FormattingEnabled = true;
            this.lstDevelopers.Location = new System.Drawing.Point(100, 88);
            this.lstDevelopers.Name = "lstDevelopers";
            this.lstDevelopers.Size = new System.Drawing.Size(100, 95);
            this.lstDevelopers.TabIndex = 13;
            // 
            // lstProjects
            // 
            this.lstProjects.FormattingEnabled = true;
            this.lstProjects.Location = new System.Drawing.Point(330, 88);
            this.lstProjects.Name = "lstProjects";
            this.lstProjects.Size = new System.Drawing.Size(100, 95);
            this.lstProjects.TabIndex = 14;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Montserrat Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(138, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(210, 26);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Register Allocation";
            // 
            // WindowRegisterAlloc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 365);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lstProjects);
            this.Controls.Add(this.lstDevelopers);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtRemuneration);
            this.Controls.Add(this.lblRs);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.nmrHours);
            this.Controls.Add(this.dtpTermination);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.txtProject);
            this.Controls.Add(this.txtDeveloper);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.lblDeveloper);
            this.Name = "WindowRegisterAlloc";
            this.Text = "WindowRegisterAlloc";
            ((System.ComponentModel.ISupportInitialize)(this.nmrHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeveloper;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.TextBox txtDeveloper;
        private System.Windows.Forms.TextBox txtProject;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpTermination;
        private System.Windows.Forms.NumericUpDown nmrHours;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblRs;
        private System.Windows.Forms.TextBox txtRemuneration;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ListBox lstDevelopers;
        private System.Windows.Forms.ListBox lstProjects;
        private System.Windows.Forms.Label lblTitle;
    }
}