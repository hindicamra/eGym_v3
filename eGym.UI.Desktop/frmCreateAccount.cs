using eGym.BLL.Models;
using eGym.BLL.Models.Requests;

namespace eGym.UI.Desktop
{
    public partial class frmCreateAccount : Form
    {
        private readonly APIService _service = new APIService("Account");

        public frmCreateAccount()
        {
            InitializeComponent();
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                bool isValidInput1 = ValidateControl(txtName, "Morate unijeti ime");
                bool isValidInput2 = ValidateControl(txtLastName, "Morate unijeti prezime");
                bool isValidInput3 = (rbFemale.Checked && !rbMale.Checked) || (!rbFemale.Checked && rbMale.Checked);
                bool isValidInput4 = ValidatePassword(txtPassword, "Morate unijeti šifru");
                bool isValidInput5 = ValidateEmail(txtEmail, "Neispravna email adresa");
                bool isValidInput6 = ValidateControl(txtUsername, "Morate unijeti username");

                if (isValidInput1 && isValidInput2 && isValidInput3 && isValidInput4 && isValidInput5 && isValidInput6)
                {
                    var request = new CreateAccountRequest
                    {
                        FirstName = txtName.Text,
                        LastName = txtLastName.Text,
                        Username = txtUsername.Text,
                        Password = txtPassword.Text,
                        BirthDate = dateTimePicker1.Value.Date,
                        Email = txtEmail.Text,
                        Gender = rbFemale.Checked ? BLL.Models.Enums.Gender.Female : BLL.Models.Enums.Gender.Male
                    };

                    await _service.Post<AccountDTO>(request);
                    labelError.Text = "Uspješno kreiran korisnik";
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                labelError.Text = "Desila se greška";
            }
        }

        private bool ValidateControl(Control control, string errorMessage)
        {
            bool isValid = !string.IsNullOrWhiteSpace(control.Text);

            if (!isValid)
            {
                err.SetError(control, errorMessage);
            }
            else
            {
                err.SetError(control, "");
            }

            return isValid;
        }

        private bool ValidatePassword(TextBox textBox, string errorMessage)
        {
            bool isValid = !string.IsNullOrWhiteSpace(textBox.Text) && textBox.Text.Length > 2 && textBox.Text.Length < 21;

            if (!isValid)
            {
                err.SetError(textBox, errorMessage);
            }
            else
            {
                err.SetError(textBox, "");
            }

            return isValid;
        }

        private bool ValidateEmail(TextBox textBox, string errorMessage)
        {
            bool isValid = !string.IsNullOrWhiteSpace(textBox.Text) && textBox.Text.Contains("@") && textBox.Text.Contains(".");

            if (!isValid)
            {
                err.SetError(textBox, errorMessage);
            }
            else
            {
                err.SetError(textBox, "");
            }

            return isValid;
        }
        private void SetError(Control control, string message)
        {
            err.SetError(control, message);
            control.Focus();
        }

        private void txtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string lastName = txtName.Text.Trim();

            if (string.IsNullOrEmpty(lastName))
            {
                e.Cancel = true;
                SetError(txtName, "Morate unijeti ime");
            }
            else if (txtName.Text.Length < 2)
            {
                e.Cancel = true;
                SetError(txtName, "Ime ne smije biti kraće od 2 karaktera.");
            }
            else
            {
                e.Cancel = false;
                SetError(txtName, "");
            }
        }

        private void txtLastName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string lastName = txtLastName.Text.Trim();

            if (string.IsNullOrEmpty(lastName))
            {
                e.Cancel = true;
                SetError(txtLastName, "Morate unijeti ime");
            }
            else if (txtLastName.Text.Length < 2)
            {
                e.Cancel = true;
                SetError(txtLastName, "Prezime ne smije biti kraće od 2 karaktera.");
            }
            else
            {
                e.Cancel = false;
                SetError(txtLastName, "");
            }
        }

        private void txtEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string lastName = txtEmail.Text.Trim();
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (string.IsNullOrEmpty(lastName))
            {
                e.Cancel = true;
                SetError(txtEmail, "Morate unijeti email");
            }

            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text, emailPattern))
            {
                e.Cancel = true;
                SetError(txtEmail, "Email nije u ispravnom formatu.");
            }
            else
            {
                e.Cancel = false;
                SetError(txtEmail, "");
            }
        }

        private void txtUsername_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string username = txtUsername.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                e.Cancel = true;
                SetError(txtUsername, "Morate unijeti korisnicko ime!");
            }
            else if (txtUsername.Text.Length < 2)
            {
                e.Cancel = true;
                SetError(txtUsername, "Korisnicko ime ne smije biti kraće od 2 karaktera.");
            }
            else
            {
                e.Cancel = false;
                SetError(txtUsername, "");
            }
        }

        private void txtPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(password))
            {
                e.Cancel = true;
                SetError(txtPassword, "Morate unijeti šifru.");
            }
            else if (txtPassword.Text.Length < 3)
            {
                e.Cancel = true;
                SetError(txtPassword, "Šifra ne smije biti kraća od 3 karaktera.");
            }
            else if (txtPassword.Text.Length > 20)
            {
                e.Cancel = true;
                SetError(txtPassword, "Šifra ne smije biti duza od 20 karaktera.");
            }
            else
            {
                e.Cancel = false;
                SetError(txtPassword, "");
            }
        }
    }
}
