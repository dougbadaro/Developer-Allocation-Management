namespace Developer_Allocation_Management
{
    partial class Report
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
            this.dgvRegister = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRegister
            // 
            this.dgvRegister.AllowUserToAddRows = false;
            this.dgvRegister.AllowUserToDeleteRows = false;
            this.dgvRegister.BackgroundColor = System.Drawing.Color.White;
            this.dgvRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRegister.GridColor = System.Drawing.Color.DimGray;
            this.dgvRegister.Location = new System.Drawing.Point(0, 0);
            this.dgvRegister.Name = "dgvRegister";
            this.dgvRegister.ReadOnly = true;
            this.dgvRegister.Size = new System.Drawing.Size(800, 450);
            this.dgvRegister.TabIndex = 0;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvRegister);
            this.Name = "Report";
            this.Text = "WindowReport";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegister)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRegister;
    }
}