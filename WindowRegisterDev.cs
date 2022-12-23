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
    public partial class WindowRegisterDev : Form
    {
        private static WindowRegisterDev _instance;
        public static WindowRegisterDev GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new WindowRegisterDev();
            }

            return _instance;
        }
        public WindowRegisterDev()
        {
            InitializeComponent();

            cbbLevel.Items.Add("Select a level");
            cbbLevel.Items.Add("Júnior");
            cbbLevel.Items.Add("Pleno");
            cbbLevel.Items.Add("Sênior");

            cbbLevel.SelectedIndex = 0;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (CredentialRepository.AuthenticateDataBase(txtEmail.Text) == null)
            {
                if (txtPassword.Text.Length >= 6 && txtPassword.Text.Length <= 12)
                {
                    Developer developer = new Developer();
                    developer.Name = txtName.Text;
                    developer.BirthDay = dtpBirthDay.Value;

                    SetLevel(developer);

                    Credential credential = new Credential();
                    credential.Email = txtEmail.Text;
                    credential.Password = txtPassword.Text;
                    credential.Active = rbtYesActive.Checked;
                    credential.Administrator = rbtYesAdmin.Checked;

                    credential.Developer = developer;
                    developer.Credential = credential;

                    DeveloperRepository.Save(developer);

                    MessageBox.Show("Developer successfully registered!");

                    CleanWindow();
                }
                else
                {
                    MessageBox.Show("The password must contain 6 to 12 characters.");
                }
            }
            else
            {
                MessageBox.Show("E-mail already registered.");
            }
        }

        private void EnableButton()
        {
            btnRegister.Enabled = true;
        }

        private void cbbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRegister.Enabled = false;
            if (cbbLevel.SelectedIndex != 0)
            {
                EnableButton();
            }
        }

        public void CleanWindow()
        {
            txtName.Text = null;
            txtEmail.Text = null;
            txtPassword.Text = null;
            dtpBirthDay.Value = DateTime.Now;
            cbbLevel.SelectedIndex = 0;
            rbtNoActive.Checked = false;
            rbtYesAdmin.Checked = false;
            rbtYesActive.Checked = false;
            rbtNoAdmin.Checked = false;
        }

        public void SetLevel(Developer developer)
        {
            if (cbbLevel.SelectedIndex == 1)
            {
                developer.LetterLevel = 'J';
                EnableButton();
            }
            if (cbbLevel.SelectedIndex == 2)
            {
                developer.LetterLevel = 'P';
                EnableButton();
            }
            if (cbbLevel.SelectedIndex == 3)
            {
                developer.LetterLevel = 'S';
                EnableButton();
            }
        }
    }
}
