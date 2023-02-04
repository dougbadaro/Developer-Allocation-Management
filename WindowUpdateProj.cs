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
    public partial class WindowUpdateProj : Form
    {
        private static WindowUpdateProj _instance;
        public static WindowUpdateProj GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new WindowUpdateProj();
            }

            return _instance;
        }
        private WindowUpdateProj()
        {
            InitializeComponent();
        }

        private void txtProject_TextChanged(object sender, EventArgs e)
        {
            lstProjects.DataSource = ProjectRepository.FindByPartialName(txtProject.Text);
        }

        private void lstProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            Project project = (Project)lstProjects.SelectedItem;

            txtName.Text = project.Name;
            dtpStart.Value = project.Start;
            dtpPlannedTerm.Value = project.PlannedTerm;
            dtpTermination.Value = project.Termination;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstProjects.SelectedIndex < -1)
            {
                if (txtName.Text != string.Empty)
                {
                    Project project = (Project)lstProjects.SelectedItem;

                    project.Name = txtName.Text;
                    project.Start = dtpStart.Value;
                    project.PlannedTerm = dtpPlannedTerm.Value;
                    project.Termination = dtpTermination.Value;

                    ProjectRepository.Save(project);

                    lstProjects.DataSource = ProjectRepository.FindByPartialName(txtProject.Text);
                }
                else
                {
                    MessageBox.Show("Fill in all fields.");
                }
            }
            else
            {
                MessageBox.Show("Select a project.");
            }
        }
    }
}
