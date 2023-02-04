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
        private WindowRegisterAlloc()
        {
            InitializeComponent();
        }

        private void txtProject_TextChanged(object sender, EventArgs e)
        {
            lstProject.DataSource = ProjectRepository.FindByPartialName(txtProject.Text);
        }

        private void txtDeveloper_TextChanged(object sender, EventArgs e)
        {
            lstDeveloper.DataSource = DeveloperRepository.FindByPartialName(txtDeveloper.Text);
        }

        private void txtRemuneration_KeyPress(object sender, KeyPressEventArgs e)
        {
            string currentText = txtRemuneration.Text;
            int cursorPosition = txtRemuneration.SelectionStart;
            int decimalPointIndex = currentText.IndexOf('.');
            int commaIndex = currentText.IndexOf(',');
            int lastDigitIndex = -1;

            for (int i = cursorPosition - 1; i >= 0; i--)
            {
                if (Char.IsDigit(currentText[i]))
                {
                    lastDigitIndex = i;
                    break;
                }
            }

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            else if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (lastDigitIndex == -1 && cursorPosition == 0)
                {
                    e.Handled = true;
                }
                else if (decimalPointIndex != -1 || commaIndex != -1)
                {
                    e.Handled = true;
                }
                else
                {
                    e.KeyChar = '.';
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (lstProject.SelectedIndex >= 0 && lstDeveloper.SelectedIndex >= 0)
            {
                if (nmrHours.Value > 0 && txtRemuneration.Text != string.Empty)
                {
                    Developer dev = (Developer)lstDeveloper.SelectedItem;
                    Project proj = (Project)lstProject.SelectedItem;

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

        private void Clear()
        {
            txtProject.Text = string.Empty;
            txtDeveloper.Text = string.Empty;
            dtpStart.Value = DateTime.Now;
            dtpTermination.Value = DateTime.Now;
            nmrHours.Value = 1;
            txtRemuneration.Text = string.Empty;
            lstProject.DataSource = null;
            lstDeveloper.DataSource = null;
        }
    }
}
