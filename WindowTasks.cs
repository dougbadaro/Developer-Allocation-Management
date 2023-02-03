using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

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
            txtProject.Text = $"{createdAllocation.Project.Name}";
            txtDeveloper.Text = $"{createdAllocation.Developer.Id}";
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

        private void txtProject_TextChanged(object sender, EventArgs e)
        {
            lstProjects.DataSource = ProjectRepository.FindByPartialName(txtDeveloper.Text);
        }

        private void lstProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstDevelopers.DataSource = AllocationRepository.FindByProject((Project)lstProjects.SelectedItem);

            Allocation allocation = (Allocation)lstDevelopers.SelectedItem;
            lstTasks.DataSource = AllocationRepository.GetTasks(allocation.Id);
        }

        private void txtDeveloper_TextChanged(object sender, EventArgs e)
        {
            if (!_preAllocation)
            {
                lstDevelopers.DataSource = AllocationRepository.FindByProject((Project)lstProjects.SelectedItem);
            }
            else
            {
                List<Developer> list = new List<Developer>();
                list.Add(DeveloperRepository.FindByIdEProject(Convert.ToInt64(txtDeveloper.Text), (Project)lstProjects.SelectedItem));
                lstDevelopers.DataSource = list;
                _preAllocation = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProject.Text))
            {
                Allocation allocation = (Allocation)lstDevelopers.SelectedItem;
                Task task = new Task(txtTask.Text);

                AllocationRepository.AddTask(allocation, task);
                lstTasks.DataSource = AllocationRepository.GetTasks(allocation.Id);
                txtTask.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Enter a description for your task.");
            }
        }

        private void lstDevelopers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Allocation allocation = (Allocation)lstDevelopers.SelectedItem;
            lstTasks.DataSource = AllocationRepository.GetTasks(allocation.Id);
        }

        private void lstTasks_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int index = lstTasks.IndexFromPoint(e.Location);
                if (index != -1)
                {
                    lstTasks.SelectedIndex = index;

                    Point locationOnForm = lstTasks.PointToScreen(e.Location);
                    contextMenuStrip1.Show(locationOnForm);
                }
            }
        }
        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllocationRepository.RemoveTask((Task)lstTasks.SelectedItem);

            Allocation allocation = (Allocation)lstDevelopers.SelectedItem;
            lstTasks.DataSource = AllocationRepository.GetTasks(allocation.Id);
        }

    }
}
