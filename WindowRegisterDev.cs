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
            if ( _instance == null || _instance.IsDisposed )
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
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Developer developer = new Developer();
            developer.Name = txtName.Text;
            developer.BirthDay = dtpBirthDay.Value;

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

            Credential credential = new Credential();
            credential.Email= txtEmail.Text;
            credential.Password= txtPassword.Text;
            
            if (rbtYesActive.Checked == true) credential.Active = true;
            if (rbtNoActive.Checked == false) credential.Active = false;

            if (rbtYesAdmin.Checked == true) credential.Administrator = true;
            if (rbtNoAdmin.Checked == false) credential.Active = false;

            credential.Developer = developer;
            developer.Credencial = credential;

            txtName.Text = null;
            txtEmail.Text = null;
            txtPassword.Text = null;
            dtpBirthDay.Value = DateTime.Now;
            cbbLevel.SelectedIndex = 0;
            rbtNoActive.Checked = false;
            rbtYesAdmin.Checked = false;
            rbtYesActive.Checked = false;
            rbtNoAdmin.Checked = false;

            DeveloperRepository.Save(developer);
        }

        private void EnableButton()
        {
            btnRegister.Enabled = true;
        }

        private void cbbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRegister.Enabled = false;
            if (cbbLevel.SelectedIndex == 1)
            {
                EnableButton();
            }
            if (cbbLevel.SelectedIndex == 2)
            {
                EnableButton();
            }
            if (cbbLevel.SelectedIndex == 3)
            {
                EnableButton();
            }
        }
    }
}
