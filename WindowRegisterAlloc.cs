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
            else
            {
                lstDevelopers.Items.Clear();
            }
        }

        private void txtProject_TextChanged(object sender, EventArgs e)
        {
            if (txtProject.Text != "")
            {
                lstProjects.DataSource = ProjectRepository.FindByPartialName(txtProject.Text);
            }
            else
            {
                lstProjects.Items.Clear();
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
            Allocation allocation = new Allocation(dtpStart.Value.Date, dtpTermination.Value.Date, Convert.ToByte(nmrHours.Value), Convert.ToDecimal(txtRemuneration.Text), (Developer) lstDevelopers.SelectedItem, (Project) lstProjects.SelectedItem);
        }
    }
}
