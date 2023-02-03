namespace Developer_Allocation_Management
{
    partial class WindowReport
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
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlSelect = new System.Windows.Forms.Panel();
            this.rdbAllocation = new System.Windows.Forms.RadioButton();
            this.rdbProject = new System.Windows.Forms.RadioButton();
            this.rdbDeveloper = new System.Windows.Forms.RadioButton();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.pnlSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSearch
            // 
            this.dgvSearch.AllowUserToAddRows = false;
            this.dgvSearch.AllowUserToDeleteRows = false;
            this.dgvSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgvSearch.Location = new System.Drawing.Point(12, 154);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.ReadOnly = true;
            this.dgvSearch.Size = new System.Drawing.Size(776, 284);
            this.dgvSearch.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(352, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(79, 26);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Report";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(104, 98);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(139, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Montserrat", 9.749999F);
            this.lblName.Location = new System.Drawing.Point(43, 98);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 18);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name: ";
            // 
            // pnlSelect
            // 
            this.pnlSelect.Controls.Add(this.btnRefresh);
            this.pnlSelect.Controls.Add(this.rdbAllocation);
            this.pnlSelect.Controls.Add(this.rdbProject);
            this.pnlSelect.Controls.Add(this.rdbDeveloper);
            this.pnlSelect.Font = new System.Drawing.Font("Montserrat", 9.749999F);
            this.pnlSelect.Location = new System.Drawing.Point(584, 76);
            this.pnlSelect.Name = "pnlSelect";
            this.pnlSelect.Size = new System.Drawing.Size(204, 72);
            this.pnlSelect.TabIndex = 4;
            // 
            // rdbAllocation
            // 
            this.rdbAllocation.AutoSize = true;
            this.rdbAllocation.Font = new System.Drawing.Font("Montserrat", 9.749999F);
            this.rdbAllocation.Location = new System.Drawing.Point(3, 49);
            this.rdbAllocation.Name = "rdbAllocation";
            this.rdbAllocation.Size = new System.Drawing.Size(89, 22);
            this.rdbAllocation.TabIndex = 2;
            this.rdbAllocation.TabStop = true;
            this.rdbAllocation.Text = "Allocation";
            this.rdbAllocation.UseVisualStyleBackColor = true;
            this.rdbAllocation.CheckedChanged += new System.EventHandler(this.rdbAllocation_CheckedChanged);
            // 
            // rdbProject
            // 
            this.rdbProject.AutoSize = true;
            this.rdbProject.Font = new System.Drawing.Font("Montserrat", 9.749999F);
            this.rdbProject.Location = new System.Drawing.Point(3, 26);
            this.rdbProject.Name = "rdbProject";
            this.rdbProject.Size = new System.Drawing.Size(78, 22);
            this.rdbProject.TabIndex = 1;
            this.rdbProject.TabStop = true;
            this.rdbProject.Text = "Projects";
            this.rdbProject.UseVisualStyleBackColor = true;
            this.rdbProject.CheckedChanged += new System.EventHandler(this.rbtnProject_CheckedChanged);
            // 
            // rdbDeveloper
            // 
            this.rdbDeveloper.AutoSize = true;
            this.rdbDeveloper.Font = new System.Drawing.Font("Montserrat", 9.749999F);
            this.rdbDeveloper.Location = new System.Drawing.Point(3, 3);
            this.rdbDeveloper.Name = "rdbDeveloper";
            this.rdbDeveloper.Size = new System.Drawing.Size(99, 22);
            this.rdbDeveloper.TabIndex = 0;
            this.rdbDeveloper.TabStop = true;
            this.rdbDeveloper.Text = "Developers";
            this.rdbDeveloper.UseVisualStyleBackColor = true;
            this.rdbDeveloper.CheckedChanged += new System.EventHandler(this.rbtnDeveloper_CheckedChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Location = new System.Drawing.Point(126, 22);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(78, 30);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // WindowReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlSelect);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WindowReport";
            this.Text = "Report";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.pnlSelect.ResumeLayout(false);
            this.pnlSelect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlSelect;
        private System.Windows.Forms.RadioButton rdbProject;
        private System.Windows.Forms.RadioButton rdbDeveloper;
        private System.Windows.Forms.RadioButton rdbAllocation;
        private System.Windows.Forms.Button btnRefresh;
    }
}