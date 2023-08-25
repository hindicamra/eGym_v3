using eGym.BLL.Models;
using eGym.BLL.Models.Requests;
using System.ComponentModel;

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

            btnSave.Enabled = btnDelete.Enabled = false;
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

            if (selectedUser!=null)
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

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text!="")
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
                if (txtPassword.Text != "")
                {
                    txtPassword.BackColor = SystemColors.Window;
                    txtPassword.ForeColor = SystemColors.WindowText;
                    txtPassword.BorderStyle = BorderStyle.FixedSingle;
                    ValidationInput5 = false;
                }
                else
                {
                    txtPassword.BackColor = Color.LightPink;
                    txtPassword.ForeColor = Color.Red;
                    txtPassword.BorderStyle = BorderStyle.Fixed3D;
                    ValidationInput5 = true;
                }



                //if (!ValidateChildren(ValidationConstraints.Enabled))
                //{
                //    labelError.Text = "Morate unijete sva obavezna polja";
                //    return;
                //}

                //if (!rbZensko.Checked && !rbMale.Checked)
                //{
                //    labelError.Text = "Morate odabrati pol";
                //    return;
                //}

                //if (selectedUser == null)
                //{
                //    labelError.Text = "Morate odabrati korisnika";
                //    return;
                //}

                if (!ValidationInput1 && !ValidationInput2 && !ValidationInput3 && !ValidationInput4 && !ValidationInput5 && selectedUser!=null)
                {
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

                    btnSave.Enabled = btnDelete.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                labelError.Text = "Desila se greska";
            }
        }
    }
}
