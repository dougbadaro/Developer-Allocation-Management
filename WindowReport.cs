using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Developer_Allocation_Management
{
    public partial class WindowReport : Form
    {
        private static WindowReport _instance;
        public static WindowReport GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new WindowReport();
            }

            return _instance;
        }
        private WindowReport()
        {
            InitializeComponent();
        }

        private void rbtnDeveloper_CheckedChanged(object sender, EventArgs e)
        {
            dgvSearch.DataSource = DeveloperRepository.FindAll();
            try
            {
                dgvSearch.AutoGenerateColumns = false;
                dgvSearch.Columns.Remove("LetterLevel");
            }
            catch
            {
                dgvSearch.AutoGenerateColumns = true;
            }
        }

        private void rbtnProject_CheckedChanged(object sender, EventArgs e)
        {
            dgvSearch.DataSource = ProjectRepository.FindAll();
        }

        private void rdbAllocation_CheckedChanged(object sender, EventArgs e)
        {
            dgvSearch.DataSource = AllocationRepository.FindAll();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (rdbDeveloper.Checked)
                dgvSearch.DataSource = DeveloperRepository.FindByPartialName(txtSearch.Text);
            if (rdbProject.Checked)
                dgvSearch.DataSource = ProjectRepository.FindByPartialName(txtSearch.Text);
            if(rdbAllocation.Checked)
                dgvSearch.DataSource = AllocationRepository.FindByDevProj(txtSearch.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (rdbDeveloper.Checked)
                dgvSearch.DataSource = DeveloperRepository.FindByPartialName(txtSearch.Text);
            if (rdbProject.Checked)
                dgvSearch.DataSource = ProjectRepository.FindByPartialName(txtSearch.Text);
            if (rdbAllocation.Checked)
                dgvSearch.DataSource = AllocationRepository.FindByDevProj(txtSearch.Text);
        }
    }
}
