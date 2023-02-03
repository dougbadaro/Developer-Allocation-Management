﻿using System;
using System.Windows.Forms;

namespace Developer_Allocation_Management
{
    public partial class WindowLogin : Form
    {
        private static WindowLogin _instance;
        public static Developer developer;
        public static WindowLogin GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new WindowLogin();
            }

            return _instance;
        }
        private WindowLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            developer = CredentialRepository.Authenticate(txtEmail.Text, txtSenha.Text);

            if (developer == null)
            {
                MessageBox.Show("Incorrect email or password.");
            }
            else if (developer.Credential.Active == true)
            {
                this.Hide();

                WindowHome.GetInstance(developer).Show();

                txtEmail.Text = null;
                txtSenha.Text = null;
            }
            else
            {
                MessageBox.Show("Inactive user.");
            }
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
