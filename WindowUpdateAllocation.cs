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
    public partial class WindowUpdateAllocation : Form
    {
        private static WindowUpdateAllocation _instance;
        public static WindowUpdateAllocation GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new WindowUpdateAllocation();
            }
            return _instance;
        }
        private WindowUpdateAllocation()
        {
            InitializeComponent();
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

        private void txtAllocation_TextChanged(object sender, EventArgs e)
        {
            lstAllocation.DataSource = AllocationRepository.FindByDevProj(txtAllocation.Text);
        }

        private void lstAllocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            Allocation allocation = (Allocation)lstAllocation.SelectedItem;

            dtpStart.Value = allocation.Start;
            dtpTermination.Value = allocation.Termination;
            nmrHours.Value = allocation.HoursWeekly;
            txtRemuneration.Text = $"{allocation.Remuneration}";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstAllocation.SelectedIndex < 0)
            {
                if (nmrHours.Value > 0 && txtRemuneration.Text != string.Empty)
                {
                    Allocation allocation = (Allocation)lstAllocation.SelectedItem;

                    allocation.Start = dtpStart.Value;
                    allocation.Termination = dtpTermination.Value;
                    allocation.HoursWeekly = Convert.ToByte(nmrHours.Value);
                    allocation.Remuneration = Convert.ToDecimal(txtRemuneration.Text);

                    AllocationRepository.Save(allocation);
                }
                else
                {
                    MessageBox.Show("Fill in all fields.");
                }
            }
            else
            {
                MessageBox.Show("Select a allocation.");
            }
        }
    }
}
