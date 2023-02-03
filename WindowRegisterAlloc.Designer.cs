﻿namespace Developer_Allocation_Management
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
            this.txtProject = new System.Windows.Forms.TextBox();
            this.txtDeveloper = new System.Windows.Forms.TextBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblStart = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpTermination = new System.Windows.Forms.DateTimePicker();
            this.nmrHours = new System.Windows.Forms.NumericUpDown();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblRs = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lstProject = new System.Windows.Forms.ListBox();
            this.lstDeveloper = new System.Windows.Forms.ListBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtRemuneration = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmrHours)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Font = new System.Drawing.Font("Montserrat", 9.749999F);
            this.lblDeveloper.Location = new System.Drawing.Point(27, 73);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(60, 18);
            this.lblDeveloper.TabIndex = 0;
            this.lblDeveloper.Text = "Project: ";
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Font = new System.Drawing.Font("Montserrat", 9.749999F);
            this.lblProject.Location = new System.Drawing.Point(291, 73);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(81, 18);
            this.lblProject.TabIndex = 1;
            this.lblProject.Text = "Developer: ";
            // 
            // txtProject
            // 
            this.txtProject.Location = new System.Drawing.Point(93, 73);
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(160, 20);
            this.txtProject.TabIndex = 2;
            this.txtProject.TextChanged += new System.EventHandler(this.txtProject_TextChanged);
            // 
            // txtDeveloper
            // 
            this.txtDeveloper.Location = new System.Drawing.Point(378, 73);
            this.txtDeveloper.Name = "txtDeveloper";
            this.txtDeveloper.Size = new System.Drawing.Size(160, 20);
            this.txtDeveloper.TabIndex = 3;
            this.txtDeveloper.TextChanged += new System.EventHandler(this.txtDeveloper_TextChanged);
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(185, 284);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(145, 20);
            this.dtpStart.TabIndex = 4;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Montserrat", 9.749999F);
            this.lblStart.Location = new System.Drawing.Point(134, 287);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(45, 18);
            this.lblStart.TabIndex = 5;
            this.lblStart.Text = "Start: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 9.749999F);
            this.label4.Location = new System.Drawing.Point(87, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Termination: ";
            // 
            // dtpTermination
            // 
            this.dtpTermination.Location = new System.Drawing.Point(185, 310);
            this.dtpTermination.Name = "dtpTermination";
            this.dtpTermination.Size = new System.Drawing.Size(145, 20);
            this.dtpTermination.TabIndex = 7;
            // 
            // nmrHours
            // 
            this.nmrHours.Location = new System.Drawing.Point(185, 336);
            this.nmrHours.Name = "nmrHours";
            this.nmrHours.Size = new System.Drawing.Size(145, 20);
            this.nmrHours.TabIndex = 8;
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Montserrat", 9.749999F);
            this.lblHours.Location = new System.Drawing.Point(126, 338);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(53, 18);
            this.lblHours.TabIndex = 9;
            this.lblHours.Text = "Hours: ";
            // 
            // lblRs
            // 
            this.lblRs.AutoSize = true;
            this.lblRs.Font = new System.Drawing.Font("Montserrat", 9.749999F);
            this.lblRs.Location = new System.Drawing.Point(154, 363);
            this.lblRs.Name = "lblRs";
            this.lblRs.Size = new System.Drawing.Size(25, 18);
            this.lblRs.TabIndex = 10;
            this.lblRs.Text = "R$";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(467, 357);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(71, 24);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lstProject
            // 
            this.lstProject.Font = new System.Drawing.Font("Montserrat", 9.749999F);
            this.lstProject.FormattingEnabled = true;
            this.lstProject.ItemHeight = 18;
            this.lstProject.Location = new System.Drawing.Point(93, 99);
            this.lstProject.Name = "lstProject";
            this.lstProject.Size = new System.Drawing.Size(160, 130);
            this.lstProject.TabIndex = 13;
            // 
            // lstDeveloper
            // 
            this.lstDeveloper.Font = new System.Drawing.Font("Montserrat", 9.749999F);
            this.lstDeveloper.FormattingEnabled = true;
            this.lstDeveloper.ItemHeight = 18;
            this.lstDeveloper.Location = new System.Drawing.Point(378, 99);
            this.lstDeveloper.Name = "lstDeveloper";
            this.lstDeveloper.Size = new System.Drawing.Size(160, 130);
            this.lstDeveloper.TabIndex = 14;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(171, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(201, 26);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Register Allocation";
            // 
            // txtRemuneration
            // 
            this.txtRemuneration.Location = new System.Drawing.Point(185, 361);
            this.txtRemuneration.Name = "txtRemuneration";
            this.txtRemuneration.Size = new System.Drawing.Size(145, 20);
            this.txtRemuneration.TabIndex = 16;
            this.txtRemuneration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRemuneration_KeyPress);
            // 
            // WindowRegisterAlloc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 409);
            this.Controls.Add(this.txtRemuneration);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lstDeveloper);
            this.Controls.Add(this.lstProject);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblRs);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.nmrHours);
            this.Controls.Add(this.dtpTermination);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.txtDeveloper);
            this.Controls.Add(this.txtProject);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.lblDeveloper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WindowRegisterAlloc";
            this.Text = "Register Allocation";
            ((System.ComponentModel.ISupportInitialize)(this.nmrHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeveloper;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.TextBox txtProject;
        private System.Windows.Forms.TextBox txtDeveloper;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpTermination;
        private System.Windows.Forms.NumericUpDown nmrHours;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblRs;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ListBox lstProject;
        private System.Windows.Forms.ListBox lstDeveloper;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtRemuneration;
    }
}