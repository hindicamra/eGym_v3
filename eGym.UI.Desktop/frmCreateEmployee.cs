using eGym.BLL.Models;
using eGym.BLL.Models.Requests;

namespace eGym.UI.Desktop
{
    public partial class frmCreateEmployee : Form
    {
        private readonly APIService _service = new APIService("Employee");
        bool ValidationInput1 = false, ValidationInput2 = false, ValidationInput3 = false, ValidationInput4 = false, ValidationInput5 = false, ValidationInput6 = false, ValidationInput7 = false;

        public frmCreateEmployee()
        {
            InitializeComponent();
            this.cbRole.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                try
                {
                    //OVO NE RADI
                    if (txtName.Text != "")
                    {
                        txtName.BackColor = SystemColors.Window;
                        txtName.ForeColor = SystemColors.WindowText;
                        txtName.BorderStyle = BorderStyle.FixedSingle;
                        ValidationInput1 = false;
                    }
                    else
                    {
                        txtName.BackColor = Color.LightPink;
                        txtName.ForeColor = Color.Red;
                        txtName.BorderStyle = BorderStyle.Fixed3D;
                        ValidationInput1 = true;
                    }
                    if (txtLastName.Text != "")
                    {
                        txtLastName.BackColor = SystemColors.Window;
                        txtLastName.ForeColor = SystemColors.WindowText;
                        txtLastName.BorderStyle = BorderStyle.FixedSingle;
                        ValidationInput2 = false;
                    }
                    else
                    {
                        txtLastName.BackColor = Color.LightPink;
                        txtLastName.ForeColor = Color.Red;
                        txtLastName.BorderStyle = BorderStyle.Fixed3D;
                        ValidationInput2 = true;
                    }
                    if ((rbFemale.Checked && !rbMale.Checked) || (!rbFemale.Checked && rbMale.Checked))
                    {
                        rbFemale.BackColor = SystemColors.Window;
                        rbFemale.ForeColor = SystemColors.WindowText;

                        rbMale.BackColor = SystemColors.Window;
                        rbMale.ForeColor = SystemColors.WindowText;
                        ValidationInput3 = false;
                    }
                    else
                    {
                        rbFemale.BackColor = Color.LightPink;
                        rbFemale.ForeColor = Color.Red;

                        rbMale.BackColor = SystemColors.Window;
                        rbMale.ForeColor = SystemColors.WindowText;
                        ValidationInput3 = true;
                    }
                    if (txtPassword.Text != "" || txtPassword.Text.Length >= 3)
                    {
                        txtPassword.BackColor = SystemColors.Window;
                        txtPassword.ForeColor = SystemColors.WindowText;
                        txtPassword.BorderStyle = BorderStyle.FixedSingle;
                        ValidationInput4 = false;
                    }
                    else
                    {
                        txtPassword.BackColor = Color.LightPink;
                        txtPassword.ForeColor = Color.Red;
                        txtPassword.BorderStyle = BorderStyle.Fixed3D;
                        ValidationInput4 = true;
                    }
                    if (txtEmail.Text != "" && txtEmail.Text.Contains("@") && txtEmail.Text.Contains("."))
                    {
                        txtEmail.BackColor = SystemColors.Window;
                        txtEmail.ForeColor = SystemColors.WindowText;
                        txtEmail.BorderStyle = BorderStyle.FixedSingle;
                        ValidationInput5 = false;
                    }
                    else
                    {
                        txtEmail.BackColor = Color.LightPink;
                        txtEmail.ForeColor = Color.Red;
                        txtEmail.BorderStyle = BorderStyle.Fixed3D;
                        ValidationInput5 = true;
                    }
                    if (txtUsername.Text != "")
                    {
                        txtUsername.BackColor = SystemColors.Window;
                        txtUsername.ForeColor = SystemColors.WindowText;
                        txtUsername.BorderStyle = BorderStyle.FixedSingle;
                        ValidationInput6 = false;
                    }
                    else
                    {
                        txtUsername.BackColor = Color.LightPink;
                        txtUsername.ForeColor = Color.Red;
                        txtUsername.BorderStyle = BorderStyle.Fixed3D;
                        ValidationInput6 = true;
                    }
                    if (cbRole.SelectedIndex != -1)
                    {
                        cbRole.BackColor = SystemColors.Window;
                        cbRole.ForeColor = SystemColors.WindowText;
                        ValidationInput7 = false;
                    }
                    else
                    {
                        cbRole.BackColor = Color.LightPink;
                        cbRole.ForeColor = Color.Red;
                        ValidationInput7 = true;
                    }


                    if (!ValidationInput1 && !ValidationInput2 && !ValidationInput3 && !ValidationInput4 && !ValidationInput5 && !ValidationInput6 && !ValidationInput7)
                    {
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
                            request.Gender = (BLL.Models.Enums.Gender)1;
                        }
                        else
                        {
                            request.Gender = (BLL.Models.Enums.Gender)0;
                        }

                        await _service.Post<EmployeeDTO>(request);
                        labelError.Text = "Uspjesno kreiran uposlenik";
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    labelError.Text = "Desila se greska";
                }
            }
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
            else if (txtUsername.Text.Length <2)
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
            else if (txtPassword.Text.Length < 2)
            {
                e.Cancel = true;
                SetError(txtPassword, "Šifra ne smije biti kraće od 2 karaktera.");
            }
            else
            {
                e.Cancel = false;
                SetError(txtPassword, "");
            }
        }

        private void cbRole_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cbRole.Text))
            {
                e.Cancel = true;
                SetError(cbRole, "Morate unijeti ulogu");
            }
            else
            {
                e.Cancel = false;
                SetError(cbRole, "");
            }
        }
    }
}