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
    public partial class WindowMyTasks : Form
    {
        private static WindowMyTasks _instance;
        public static WindowMyTasks GetInstance()
        {
            if(_instance == null || _instance.IsDisposed)
            {
                _instance = new WindowMyTasks();
            }

            return _instance;
        }
        private WindowMyTasks()
        {
            InitializeComponent();
        }

        private void WindowMyTasks_Load(object sender, EventArgs e)
        {
            lstTasks.DataSource = AllocationRepository.GetTaskByIdDeveloper(WindowLogin.developer.Id);
        }
    }
}
