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
                err.SetError(control, ""); // Clear error message
            }

            return isValid;
        }

        private bool ValidatePassword(TextBox textBox, string errorMessage)
        {
            bool isValid = !string.IsNullOrWhiteSpace(textBox.Text) && textBox.Text.Length > 2;

            if (!isValid)
            {
                err.SetError(textBox, errorMessage);
            }
            else
            {
                err.SetError(textBox, ""); // Clear error message
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
                err.SetError(textBox, ""); // Clear error message
            }

            return isValid;
        }
    }
}
