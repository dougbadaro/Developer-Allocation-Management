namespace Developer_Allocation_Management
{
    partial class WindowUpdateAllocation
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtAllocation = new System.Windows.Forms.TextBox();
            this.lblAllocation = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lstAllocation = new System.Windows.Forms.ListBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblTermination = new System.Windows.Forms.Label();
            this.dtpTermination = new System.Windows.Forms.DateTimePicker();
            this.txtRemuneration = new System.Windows.Forms.TextBox();
            this.lblRs = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.nmrHours = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nmrHours)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(547, 399);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(66, 24);
            this.btnUpdate.TabIndex = 52;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(249, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(191, 26);
            this.lblTitle.TabIndex = 46;
            this.lblTitle.Text = "Allocation Update";
            // 
            // txtAllocation
            // 
            this.txtAllocation.Location = new System.Drawing.Point(131, 82);
            this.txtAllocation.Name = "txtAllocation";
            this.txtAllocation.Size = new System.Drawing.Size(156, 20);
            this.txtAllocation.TabIndex = 47;
            this.txtAllocation.TextChanged += new System.EventHandler(this.txtAllocation_TextChanged);
            // 
            // lblAllocation
            // 
            this.lblAllocation.AutoSize = true;
            this.lblAllocation.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllocation.Location = new System.Drawing.Point(48, 82);
            this.lblAllocation.Name = "lblAllocation";
            this.lblAllocation.Size = new System.Drawing.Size(77, 18);
            this.lblAllocation.TabIndex = 48;
            this.lblAllocation.Text = "Allocation: ";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(441, 190);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(45, 18);
            this.lblStart.TabIndex = 50;
            this.lblStart.Text = "Start: ";
            // 
            // lstAllocation
            // 
            this.lstAllocation.Font = new System.Drawing.Font("Montserrat", 9.749999F);
            this.lstAllocation.FormattingEnabled = true;
            this.lstAllocation.ItemHeight = 18;
            this.lstAllocation.Location = new System.Drawing.Point(47, 120);
            this.lstAllocation.Name = "lstAllocation";
            this.lstAllocation.Size = new System.Drawing.Size(240, 292);
            this.lstAllocation.TabIndex = 53;
            this.lstAllocation.SelectedIndexChanged += new System.EventHandler(this.lstAllocation_SelectedIndexChanged);
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(492, 188);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(121, 20);
            this.dtpStart.TabIndex = 54;
            // 
            // lblTermination
            // 
            this.lblTermination.AutoSize = true;
            this.lblTermination.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTermination.Location = new System.Drawing.Point(394, 217);
            this.lblTermination.Name = "lblTermination";
            this.lblTermination.Size = new System.Drawing.Size(92, 18);
            this.lblTermination.TabIndex = 57;
            this.lblTermination.Text = "Termination: ";
            // 
            // dtpTermination
            // 
            this.dtpTermination.Location = new System.Drawing.Point(492, 214);
            this.dtpTermination.Name = "dtpTermination";
            this.dtpTermination.Size = new System.Drawing.Size(121, 20);
            this.dtpTermination.TabIndex = 58;
            // 
            // txtRemuneration
            // 
            this.txtRemuneration.Location = new System.Drawing.Point(492, 266);
            this.txtRemuneration.Name = "txtRemuneration";
            this.txtRemuneration.Size = new System.Drawing.Size(121, 20);
            this.txtRemuneration.TabIndex = 66;
            this.txtRemuneration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRemuneration_KeyPress);
            // 
            // lblRs
            // 
            this.lblRs.AutoSize = true;
            this.lblRs.Font = new System.Drawing.Font("Montserrat", 9.749999F);
            this.lblRs.Location = new System.Drawing.Point(461, 268);
            this.lblRs.Name = "lblRs";
            this.lblRs.Size = new System.Drawing.Size(25, 18);
            this.lblRs.TabIndex = 65;
            this.lblRs.Text = "R$";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Montserrat", 9.749999F);
            this.lblHours.Location = new System.Drawing.Point(433, 242);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(53, 18);
            this.lblHours.TabIndex = 64;
            this.lblHours.Text = "Hours: ";
            // 
            // nmrHours
            // 
            this.nmrHours.Location = new System.Drawing.Point(492, 240);
            this.nmrHours.Name = "nmrHours";
            this.nmrHours.Size = new System.Drawing.Size(121, 20);
            this.nmrHours.TabIndex = 63;
            // 
            // WindowUpdateAllocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 450);
            this.Controls.Add(this.txtRemuneration);
            this.Controls.Add(this.lblRs);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.nmrHours);
            this.Controls.Add(this.dtpTermination);
            this.Controls.Add(this.lblTermination);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.lstAllocation);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblAllocation);
            this.Controls.Add(this.txtAllocation);
            this.Controls.Add(this.lblTitle);
            this.Name = "WindowUpdateAllocation";
            this.Text = "Allocation Update";
            ((System.ComponentModel.ISupportInitialize)(this.nmrHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtAllocation;
        private System.Windows.Forms.Label lblAllocation;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.ListBox lstAllocation;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblTermination;
        private System.Windows.Forms.DateTimePicker dtpTermination;
        private System.Windows.Forms.TextBox txtRemuneration;
        private System.Windows.Forms.Label lblRs;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.NumericUpDown nmrHours;
    }
}