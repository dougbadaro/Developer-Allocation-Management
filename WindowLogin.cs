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
        private static WindowLogin _instance;
        public static WindowLogin GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new WindowLogin();
            }

            return _instance;
        }
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
            if (Credential.Authenticate(txtEmail.Text, txtSenha.Text))
            {
                this.Hide();

                WindowHome.GetInstance().Show();
            }

            txtEmail.Text = null;
            txtSenha.Text = null;
        }

        private void txtEmail_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar.PerformClick();
            }
        }

    }
}
