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
    public partial class WindowHome : Form
    {
        private WindowHome(Developer developer)
        {
            InitializeComponent();

            if (developer.Credential.Administrator == true)
            {
                developerToolStripMenuItem.Visible = true;
                projectToolStripMenuItem.Visible = true;
                allocationToolStripMenuItem.Visible = true;
                reportToolStripMenuItem.Visible = true;
                registerTaskToolStripMenuItem.Visible = true;
            }
        }

        private static WindowHome _instance;
        public static WindowHome GetInstance(Developer developer)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new WindowHome(developer);
            }

            return _instance;
        }

        private void WindowHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            WindowLogin.GetInstance().Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

            WindowLogin.GetInstance().Show();
        }
        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowRegisterDev windowRegisterDev = WindowRegisterDev.GetInstance();
            windowRegisterDev.MdiParent = this;
            windowRegisterDev.WindowState = FormWindowState.Normal;
            windowRegisterDev.Show();
        }
        private void registerProjectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            WindowRegisterProject windowRegisterProject = WindowRegisterProject.GetInstance();
            windowRegisterProject.MdiParent = this;
            windowRegisterProject.WindowState = FormWindowState.Normal;
            windowRegisterProject.Show();
        }
        private void reportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            WindowReport windowReport = WindowReport.GetInstance();
            windowReport.MdiParent = this;
            windowReport.WindowState = FormWindowState.Normal;
            windowReport.Show();
        }

        private void registerAllocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowRegisterAlloc windowRegisterAlloc = WindowRegisterAlloc.GetInstance();
            windowRegisterAlloc.MdiParent = this;
            windowRegisterAlloc.WindowState = FormWindowState.Normal;
            windowRegisterAlloc.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowAbout windowAbout = WindowAbout.GetInstance();
            windowAbout.MdiParent = this;
            windowAbout.WindowState = FormWindowState.Normal;
            windowAbout.Show();
        }

        private void updateDeveloperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowUpdateDev windowUpdateDev = WindowUpdateDev.GetInstance();
            windowUpdateDev.MdiParent = this;
            windowUpdateDev.WindowState = FormWindowState.Normal;
            windowUpdateDev.Show();
        }

        private void updateProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowUpdateProj windowUpdateProj = WindowUpdateProj.GetInstance();
            windowUpdateProj.MdiParent = this;
            windowUpdateProj.WindowState = FormWindowState.Normal;
            windowUpdateProj.Show();
        }

        private void updateAllocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowUpdateAllocation windowUpdateAllocation = WindowUpdateAllocation.GetInstance();
            windowUpdateAllocation.MdiParent = this;
            windowUpdateAllocation.WindowState = FormWindowState.Normal;
            windowUpdateAllocation.Show();
        }

        private void registerTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowTasks windowTasks = WindowTasks.GetInstance();
            windowTasks.MdiParent = this;
            windowTasks.WindowState = FormWindowState.Normal;
            windowTasks.Show();
        }

        private void myTasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowMyTasks windowMyTasks = WindowMyTasks.GetInstance();
            windowMyTasks.MdiParent = this;
            windowMyTasks.WindowState = FormWindowState.Normal;
            windowMyTasks.Show();
        }
    }
}
