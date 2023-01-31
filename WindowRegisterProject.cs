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
    public partial class WindowRegisterProject : Form
    {
        private static WindowRegisterProject _instance;
        public static WindowRegisterProject GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new WindowRegisterProject();
            }

            return _instance;
        }
        private WindowRegisterProject()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                Project project = new Project(txtName.Text, dtpStart.Value.Date, dtpPlannedTerm.Value.Date, dtpTermination.Value.Date);
                
                ProjectRepository.Save(project);
                ClearFields();
                MessageBox.Show("Project registered successfully.");
            }
            else
            {
                MessageBox.Show("Fill in the fields.");
            }
        }

        private void ClearFields()
        {
            txtName.Text = "";
            dtpStart.Value = DateTime.Now;
            dtpPlannedTerm.Value = DateTime.Now;
            dtpTermination.Value = DateTime.Now;
        }
    }
}
