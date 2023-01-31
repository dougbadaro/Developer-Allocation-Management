using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Developer_Allocation_Management
{
    public partial class WindowRegisterAlloc : Form
    {
        private static WindowRegisterAlloc _instance;

        public static WindowRegisterAlloc GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new WindowRegisterAlloc();
            }

            return _instance;
        }
        public WindowRegisterAlloc()
        {
            InitializeComponent();
        }

        private void txtDeveloper_TextChanged(object sender, EventArgs e)
        {
            if (txtDeveloper.Text != "")
            {
                lstDevelopers.DataSource = DeveloperRepository.FindByPartialName(txtDeveloper.Text);
            }
        }

        private void txtProject_TextChanged(object sender, EventArgs e)
        {
            if (txtProject.Text != "")
            {
                lstProjects.DataSource = ProjectRepository.FindByPartialName(txtProject.Text);
            }
        }

        private void txtRemuneration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (lstDevelopers.SelectedIndex >= 0 && lstProjects.SelectedIndex >= 0)
            {
                if (nmrHours.Value > 0 && txtRemuneration.Text != "")
                {
                    Developer dev = (Developer)lstDevelopers.SelectedItem;
                    Project proj = (Project)lstProjects.SelectedItem;

                    Allocation allocation = new Allocation(dtpStart.Value.Date, dtpTermination.Value.Date, Convert.ToByte(nmrHours.Value), Convert.ToDecimal(txtRemuneration.Text), dev, proj);

                    AllocationRepository.Save(allocation);
                    Sucesseful_AddTask(sender, e, allocation);
                    Clear();
                }
                else
                {
                    MessageBox.Show("Fill in all fields.");
                }
            }
            else
            {
                MessageBox.Show("Select a developer and project.");
            }
        }
        private void Sucesseful_AddTask(object sender, EventArgs e, Allocation createdAllocation)
        {
            DialogResult result = MessageBox.Show("Allocation added, want to add Tasks?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                WindowTasks windowTasks = WindowTasks.GetInstance(createdAllocation);
                windowTasks.MdiParent = this.MdiParent;
                windowTasks.WindowState = FormWindowState.Normal;
                windowTasks.Show();
                this.Close();
            }
        }

        private void txtRemuneration_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void Clear()
        {
            txtDeveloper.Text = "";
            txtProject.Text = "";
            dtpStart.Value = DateTime.Now;
            dtpTermination.Value = DateTime.Now;
            nmrHours.Value = 1;
            txtRemuneration.Text = "";
            lstDevelopers.DataSource = null;
            lstProjects.DataSource = null;
        }
    }
}
