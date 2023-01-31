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
    public partial class WindowTasks : Form
    {
        private static WindowTasks _instance;
        private Boolean _preAllocation = false;
        private WindowTasks()
        {
            InitializeComponent();
        }
        private WindowTasks(Allocation createdAllocation) : this()
        {
            _preAllocation = true;
            txtAllocation.Text = $"{createdAllocation.Id}";

            List<Allocation> list = new List<Allocation>
                {
                    AllocationRepository.FindById(createdAllocation.Id)
                };
            lstAllocation.DataSource = list;
        }
        public static WindowTasks GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new WindowTasks();
            }

            return _instance;
        }
        public static WindowTasks GetInstance(Allocation createdAllocation)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new WindowTasks(createdAllocation);
            }

            return _instance;
        }

        private void txtAllocation_TextChanged(object sender, EventArgs e)
        {
            if (!_preAllocation)
            {
                lstAllocation.DataSource = AllocationRepository.FindByDevProj(txtAllocation.Text);
            }
            else
            {
                _preAllocation = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAllocation.Text))
            {
                Allocation allocation = (Allocation)lstAllocation.SelectedItem;
                Task task = new Task(txtTask.Text);
                AllocationRepository.AddTask(allocation, task);

                lstTask.DataSource = AllocationRepository.GetTasks(allocation.Id);
                txtTask.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Enter a description for your task.");
            }
        }

        private void lstAllocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            Allocation allocation = (Allocation)lstAllocation.SelectedItem;
            lstTask.DataSource = AllocationRepository.GetTasks(allocation.Id);
        }
    }
}
