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
    public partial class WindowLogin : Form
    {
        public WindowLogin()
        {
            InitializeComponent();
        }

        private void WindowLogin_Load(object sender, EventArgs e)
        {
            Repository repository = new Repository();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (Credencial.Authenticate(txtEmail.Text, txtSenha.Text))
            {
                WindowHome.GetInstance().Show();
            }
        }

    }
}
