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
    public partial class WindowUpdateDev : Form
    {
        private static WindowUpdateDev _instance;
        public static WindowUpdateDev GetInstance()
        {
            if(_instance == null || _instance.IsDisposed)
            {
                _instance = new WindowUpdateDev();
            }

            return _instance;
        }
        private WindowUpdateDev()
        {
            InitializeComponent();

            cbxLevel.Items.Add("Select a level");
            cbxLevel.Items.Add("Júnior");
            cbxLevel.Items.Add("Pleno");
            cbxLevel.Items.Add("Sênior");

            cbxLevel.SelectedIndex = 0;
        }

        private void txtDeveloper_TextChanged(object sender, EventArgs e)
        {
            lstDevelopers.DataSource = DeveloperRepository.FindByPartialName(txtDeveloper.Text);
        }

        private void lstDevelopers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Developer developer = (Developer)lstDevelopers.SelectedItem;

            txtName.Text = developer.Name;
            dtpBirthDay.Value = developer.BirthDay;

            if (developer.Level == Convert.ToString('J'))
                cbxLevel.SelectedIndex = 1;
            if (developer.Level == Convert.ToString('P'))
                cbxLevel.SelectedIndex = 2;
            if (developer.Level == Convert.ToString('S'))
                cbxLevel.SelectedIndex = 3;

            txtEmail.Text = developer.Credential.Email;
            chbActive.Checked = developer.Credential.Active;
            chbAdminstrator.Checked = developer.Credential.Administrator;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstDevelopers.SelectedIndex > -1)
            {   
                if(txtName.Text != string.Empty && cbxLevel.SelectedIndex > 0 && txtEmail.Text != string.Empty)
                {
                    Developer developer = (Developer)lstDevelopers.SelectedItem;
                    Console.WriteLine(developer);
                    developer.Name = txtName.Text;
                    developer.BirthDay = dtpBirthDay.Value;
                    SetLevel(developer);

                    developer.Credential.Email = txtEmail.Text;

                    if (txtPassword.Text != string.Empty)
                    {
                        developer.Credential.Password = txtPassword.Text;
                    }

                    developer.Credential.Active = chbActive.Checked;
                    developer.Credential.Administrator = chbAdminstrator.Checked;

                    DeveloperRepository.Save(developer);
                }
                else
                {
                    MessageBox.Show("Fill in all fields.");
                }
            }
            else
            {
                MessageBox.Show("Select a developer.");
            }
        }

        private void SetLevel(Developer developer)
        {
            if (cbxLevel.SelectedIndex == 1)
            {
                developer.LetterLevel = 'J';
            }
            if (cbxLevel.SelectedIndex == 2)
            {
                developer.LetterLevel = 'P';
            }
            if (cbxLevel.SelectedIndex == 3)
            {
                developer.LetterLevel = 'S';
            }
        }
    }
}
