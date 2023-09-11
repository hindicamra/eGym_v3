using eGym.BLL.Models;
using eGym.BLL.Models.Requests;

namespace eGym.UI.Desktop
{
    public partial class frmAccount : Form
    {
        private readonly APIService _service = new APIService("Account");
        private AccountDTO selectedUser;

        bool ValidationInput1 = false, ValidationInput2 = false, ValidationInput3 = false, ValidationInput4 = false,
             ValidationInput5 = false;


        public frmAccount()
        {
            InitializeComponent();
            dgvAccount.AutoGenerateColumns = false;
        }

        private async void frmAccount_Load(object sender, EventArgs e)
        {
            try
            {
                dgvAccount.DataSource = await _service.Get<List<AccountDTO>>(null, "/getAll");
            }
            catch (Exception ex)
            {
                labelError.Text = "Desila se greska";
            }

            btnSave.Enabled = btnDelete.Enabled = false;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text == "")
                {
                    dgvAccount.DataSource = await _service.Get<List<AccountDTO>>(null, "/getAll");
                }
                else
                {
                    dgvAccount.DataSource = await _service.Get<List<AccountDTO>>(new { text = txtSearch.Text }, "/search");
                }
            }
            catch (Exception ex)
            {
                labelError.Text = "Desila se greska";
            }

        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            selectedUser = (AccountDTO)dgvAccount.Rows[index].DataBoundItem;

            txtId.Text = selectedUser.AccountId.ToString();
            txtName.Text = selectedUser.FirstName;
            txtLastName.Text = selectedUser.LastName;
            txtUsername.Text = selectedUser.Username;
            dateTimePicker1.Value = selectedUser.BirthDate;

            if (selectedUser.Gender == BLL.Models.Enums.Gender.Female)
            {
                rbZensko.Checked = true;
            }
            else
            {
                rbMale.Checked = true;
            }

            if (selectedUser != null)
            {
                btnSave.Enabled = btnDelete.Enabled = true;
            }
            else
            {
                btnSave.Enabled = btnDelete.Enabled = false;
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedUser == null)
                {
                    labelError.Text = "Desila se greska";
                    MessageBox.Show("Morate odabrati korisnika");
                    return;
                }
                await _service.Delete(new { id = selectedUser.AccountId });

                dgvAccount.DataSource = await _service.Get<List<AccountDTO>>(null, "/getAll");

                txtId.Text = string.Empty;
                txtName.Text = string.Empty;
                txtLastName.Text = string.Empty;
                txtUsername.Text = string.Empty;
                dateTimePicker1.Value = DateTime.Now;

                selectedUser = null;

                labelError.Text = "Uspjesno obrisan korisnik";
                btnSave.Enabled = btnDelete.Enabled = false;
            }
            catch (Exception ex)
            {
                labelError.Text = "Desila se greska";
            }
        }


        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                try
                {
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
                    if ((rbZensko.Checked && !rbMale.Checked) || (!rbZensko.Checked && rbMale.Checked))
                    {
                        rbZensko.BackColor = SystemColors.Window;
                        rbZensko.ForeColor = SystemColors.WindowText;

                        rbMale.BackColor = SystemColors.Window;
                        rbMale.ForeColor = SystemColors.WindowText;
                        ValidationInput3 = false;
                    }
                    else
                    {
                        rbZensko.BackColor = Color.LightPink;
                        rbZensko.ForeColor = Color.Red;

                        rbMale.BackColor = SystemColors.Window;
                        rbMale.ForeColor = SystemColors.WindowText;
                        ValidationInput3 = true;
                    }
                    if (txtName.Text != "")
                    {
                        txtUsername.BackColor = SystemColors.Window;
                        txtUsername.ForeColor = SystemColors.WindowText;
                        txtUsername.BorderStyle = BorderStyle.FixedSingle;
                        ValidationInput4 = false;
                    }
                    else
                    {
                        txtUsername.BackColor = Color.LightPink;
                        txtUsername.ForeColor = Color.Red;
                        txtUsername.BorderStyle = BorderStyle.Fixed3D;
                        ValidationInput4 = true;
                    }
                    if (!ValidationInput1 && !ValidationInput2 && !ValidationInput3 && !ValidationInput4 && !ValidationInput5 && selectedUser != null)
                    {
                        var request = new UpdateAccountRequest()
                        {
                            FirstName = txtName.Text,
                            LastName = txtLastName.Text,
                            BirthDate = dateTimePicker1.Value,
                            Username = txtUsername.Text,
                        };

                        await _service.Put<AccountDTO>(selectedUser.AccountId, request);

                        dgvAccount.DataSource = await _service.Get<List<AccountDTO>>(null, "/getAll");

                        labelError.Text = "Uspjesno updatovan korisnik";

                        btnSave.Enabled = btnDelete.Enabled = false;
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

        private void txtUsername_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string lastName = txtUsername.Text.Trim();

            if (string.IsNullOrEmpty(lastName))
            {
                e.Cancel = true;
                SetError(txtUsername, "Morate unijeti korisnicko ime");
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

        private void txtLastName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string lastName = txtLastName.Text.Trim();

            if (string.IsNullOrEmpty(lastName))
            {
                e.Cancel = true;
                SetError(txtLastName, "Morate unijeti prezime");
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
    }
}
