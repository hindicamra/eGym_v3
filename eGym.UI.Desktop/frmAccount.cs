using eGym.BLL.Models;
using eGym.BLL.Models.Requests;
using System.ComponentModel;

namespace eGym.UI.Desktop
{
    public partial class frmAccount : Form
    {
        private readonly APIService _service = new APIService("Account");
        private AccountDTO selectedUser;

        public frmAccount()
        {
            InitializeComponent();
        }

        private async void frmAccount_Load(object sender, EventArgs e)
        {
            try
            {
                dgvAccount.DataSource = await _service.Get<List<AccountDTO>>(null, "/getAll");
                dgvAccount.Columns["AccountId"].Visible = false;
            }
            catch(Exception ex) 
            {
                labelError.Text = "Desila se greska";
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvAccount.DataSource = await _service.Get<List<AccountDTO>>(new { text = txtSearch.Text }, "/search");
            }
            catch(Exception ex) 
            {
                labelError.Text = "Desila se greska";
            }

        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            selectedUser = dgvAccount.Rows[index].DataBoundItem as AccountDTO;

            txtId.Text = selectedUser.AccountId.ToString();
            txtName.Text = selectedUser.FirstName;
            txtLastName.Text = selectedUser.LastName;
            txtPassword.Text = selectedUser.Password;
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
                txtPassword.Text = string.Empty;
                txtUsername.Text = string.Empty;
                dateTimePicker1.Value = DateTime.Now;

                selectedUser = null;

                labelError.Text = "Uspjesno obrisan korisnik";
            }
            catch(Exception ex)
            {
                labelError.Text = "Desila se greska";
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateChildren(ValidationConstraints.Enabled))
                {
                    labelError.Text = "Morate unijete sva obavezna polja";
                    return;
                }

                if (!rbZensko.Checked && !rbMale.Checked)
                {
                    labelError.Text = "Morate odabrati pol";
                    return;
                }

                if (selectedUser == null)
                {
                    labelError.Text = "Morate odabrati korisnika";
                    return;
                }

                var request = new UpdateAccountRequest()
                {
                    FirstName = txtName.Text,
                    LastName = txtLastName.Text,
                    BirthDate = dateTimePicker1.Value,
                    Username = txtUsername.Text,
                    Password = txtPassword.Text
                };

                await _service.Put<AccountDTO>(selectedUser.AccountId, request);

                dgvAccount.DataSource = await _service.Get<List<AccountDTO>>(null, "/getAll");

                labelError.Text = "Uspjesno updatovan korisnik";
            }
            catch(Exception ex)
            {
                labelError.Text = "Desila se greska";
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
    }
}
