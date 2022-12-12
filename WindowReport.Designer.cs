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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlSelect = new System.Windows.Forms.Panel();
            this.rbtnDeveloper = new System.Windows.Forms.RadioButton();
            this.rbtnProject = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.pnlSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSearch
            // 
            this.dgvSearch.AllowUserToAddRows = false;
            this.dgvSearch.AllowUserToDeleteRows = false;
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Location = new System.Drawing.Point(12, 154);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.ReadOnly = true;
            this.dgvSearch.Size = new System.Drawing.Size(776, 284);
            this.dgvSearch.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Montserrat Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(352, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(82, 26);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Report";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(43, 98);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 18);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name: ";
            // 
            // pnlSelect
            // 
            this.pnlSelect.Controls.Add(this.rbtnProject);
            this.pnlSelect.Controls.Add(this.rbtnDeveloper);
            this.pnlSelect.Location = new System.Drawing.Point(652, 76);
            this.pnlSelect.Name = "pnlSelect";
            this.pnlSelect.Size = new System.Drawing.Size(136, 53);
            this.pnlSelect.TabIndex = 4;
            // 
            // rbtnDeveloper
            // 
            this.rbtnDeveloper.AutoSize = true;
            this.rbtnDeveloper.Location = new System.Drawing.Point(3, 3);
            this.rbtnDeveloper.Name = "rbtnDeveloper";
            this.rbtnDeveloper.Size = new System.Drawing.Size(79, 17);
            this.rbtnDeveloper.TabIndex = 0;
            this.rbtnDeveloper.TabStop = true;
            this.rbtnDeveloper.Text = "Developers";
            this.rbtnDeveloper.UseVisualStyleBackColor = true;
            // 
            // rbtnProject
            // 
            this.rbtnProject.AutoSize = true;
            this.rbtnProject.Location = new System.Drawing.Point(3, 26);
            this.rbtnProject.Name = "rbtnProject";
            this.rbtnProject.Size = new System.Drawing.Size(63, 17);
            this.rbtnProject.TabIndex = 1;
            this.rbtnProject.TabStop = true;
            this.rbtnProject.Text = "Projects";
            this.rbtnProject.UseVisualStyleBackColor = true;
            // 
            // WindowReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlSelect);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvSearch);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlSelect;
        private System.Windows.Forms.RadioButton rbtnProject;
        private System.Windows.Forms.RadioButton rbtnDeveloper;
    }
}