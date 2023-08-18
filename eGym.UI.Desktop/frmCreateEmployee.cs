using eGym.BLL.Models;
using eGym.BLL.Models.Requests;
using System.ComponentModel;

namespace eGym.UI.Desktop
{
    public partial class frmCreateEmployee : Form
    {
        private readonly APIService _service = new APIService("Employee");

        public frmCreateEmployee()
        {
            InitializeComponent();
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateChildren(ValidationConstraints.Enabled))
                {
                    MessageBox.Show("Morate unijete sva obavezna polja");
                    return;
                }

                if (!rbFemale.Checked && !rbMale.Checked)
                {
                    MessageBox.Show("Morate odabrati pol");
                    return;
                }

                if (cbRole.SelectedIndex == -1)
                {
                    MessageBox.Show("Morate odabrati rolu");
                    return;
                }

                var request = new CreateEmployeeRequest
                {
                    FirstName = txtName.Text,
                    LastName = txtLastName.Text,
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    BirthDate = dateTimePicker1.Value.Date,
                    Role = (BLL.Models.Enums.Role)cbRole.SelectedIndex,
                    Email = txtEmail.Text
                };

                if (rbFemale.Checked)
                {
                    request.Gender = BLL.Models.Enums.Gender.Female;
                }
                else
                {
                    request.Gender = BLL.Models.Enums.Gender.Male;
                }

                await _service.Post<EmployeeDTO>(request);
                MessageBox.Show("Uspjesno kreiran uposlenik");
                this.Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Desila se greska");
            }
        }

        private void textBoxName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                e.Cancel = true;
                txtName.Focus();
                errorProviderApp.SetError(txtName, "Morate unijeti ime");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtName, "");
            }
        }

        private void textBoxLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                e.Cancel = true;
                txtLastName.Focus();
                errorProviderApp.SetError(txtLastName, "Morate unijeti prezime");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtLastName, "");
            }
        }

        private void textBoxUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                e.Cancel = true;
                txtUsername.Focus();
                errorProviderApp.SetError(txtUsername, "Morate unijeti username");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtUsername, "");
            }
        }

        private void textBoxPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                e.Cancel = true;
                txtUsername.Focus();
                errorProviderApp.SetError(txtPassword, "Morate unijeti password");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtUsername, "");
            }
        }

        private void textBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !txtEmail.Text.Contains("@"))
            {
                e.Cancel = true;
                txtUsername.Focus();
                errorProviderApp.SetError(txtPassword, "Morate unijeti ispravan email");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtUsername, "");
            }
        }
    }
}
