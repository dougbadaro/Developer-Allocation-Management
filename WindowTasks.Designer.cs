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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.lstAllocation = new System.Windows.Forms.ListBox();
            this.lblTask = new System.Windows.Forms.Label();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.lstTask = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAllocation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(154, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(64, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Tasks";
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.lblDeveloper.Location = new System.Drawing.Point(11, 85);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(123, 16);
            this.lblDeveloper.TabIndex = 1;
            this.lblDeveloper.Text = "Developer/Project: ";
            // 
            // lstAllocation
            // 
            this.lstAllocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAllocation.FormattingEnabled = true;
            this.lstAllocation.Location = new System.Drawing.Point(140, 120);
            this.lstAllocation.Name = "lstAllocation";
            this.lstAllocation.Size = new System.Drawing.Size(120, 82);
            this.lstAllocation.TabIndex = 3;
            this.lstAllocation.SelectedIndexChanged += new System.EventHandler(this.lstAllocation_SelectedIndexChanged);
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.lblTask.Location = new System.Drawing.Point(90, 260);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(44, 16);
            this.lblTask.TabIndex = 4;
            this.lblTask.Text = "Task: ";
            // 
            // txtTask
            // 
            this.txtTask.Location = new System.Drawing.Point(140, 259);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(120, 20);
            this.txtTask.TabIndex = 5;
            // 
            // lstTask
            // 
            this.lstTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTask.FormattingEnabled = true;
            this.lstTask.Location = new System.Drawing.Point(140, 296);
            this.lstTask.Name = "lstTask";
            this.lstTask.Size = new System.Drawing.Size(120, 82);
            this.lstTask.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(269, 259);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(39, 20);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAllocation
            // 
            this.txtAllocation.Location = new System.Drawing.Point(140, 84);
            this.txtAllocation.Name = "txtAllocation";
            this.txtAllocation.Size = new System.Drawing.Size(120, 20);
            this.txtAllocation.TabIndex = 8;
            this.txtAllocation.TextChanged += new System.EventHandler(this.txtAllocation_TextChanged);
            // 
            // WindowTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 407);
            this.Controls.Add(this.txtAllocation);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstTask);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.lblTask);
            this.Controls.Add(this.lstAllocation);
            this.Controls.Add(this.lblDeveloper);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WindowTasks";
            this.Text = "WindowTasks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDeveloper;
        private System.Windows.Forms.ListBox lstAllocation;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.ListBox lstTask;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAllocation;
    }
}