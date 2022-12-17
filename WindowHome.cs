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
                registerToolStripMenuItem.Visible = true;
                registerProjectToolStripMenuItem.Visible = true;
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

        private void registerProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowRegisterProject windowRegisterProject = WindowRegisterProject.GetInstance();
            windowRegisterProject.MdiParent = this;
            windowRegisterProject.WindowState = FormWindowState.Normal;
            windowRegisterProject.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowReport windowReport = WindowReport.GetInstance();
            windowReport.MdiParent = this;
            windowReport.WindowState = FormWindowState.Normal;
            windowReport.Show();
        }
    }
}
