using eGym.BLL.Models;
using eGym.BLL.Models.Enums;
using eGym.BLL.Models.Requests;
using System.ComponentModel;

namespace eGym.UI.Desktop
{
    public partial class frmEmployee : Form
    {
        private readonly APIService _service = new APIService("Employee");
        private EmployeeDTO selectedEmployee = new EmployeeDTO();
        bool ValidationInput1 = false, ValidationInput2 = false, ValidationInput3 = false, ValidationInput4 = false, ValidationInput5 = false;

        public frmEmployee()
        {
            InitializeComponent();
        }

        private async void frmEmployee_Load(object sender, EventArgs e)
        {
            try
            {
                dgvEmployee.DataSource = await _service.Get<List<EmployeeDTO>>(null, "/getAll");
                dgvEmployee.Columns["EmployeeId"].Visible = false;
            }
            catch (Exception ex)
            {
                labelError.Text = "Desila se greska";
            }

            btnDelete.Enabled = btnSave.Enabled = false;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvEmployee.DataSource = await _service.Get<List<EmployeeDTO>>(new { text = txtSearch.Text }, "/search");
                dgvEmployee.Columns["EmployeeId"].Visible = false;
            }
            catch (Exception ex)
            {
                labelError.Text = "Desila se greska";
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedEmployee == null)
                {
                    labelError.Text = "Morate odabrati korisnika";
                    return;
                }
                await _service.Delete(new { id = selectedEmployee.EmployeeId });

                dgvEmployee.DataSource = await _service.Get<List<EmployeeDTO>>(null, "/getAll");
                dgvEmployee.Columns["EmployeeId"].Visible = false;

                txtId.Text = string.Empty;
                txtName.Text = string.Empty;
                txtLastName.Text = string.Empty;
                txtPassword.Text = string.Empty;
                txtUsername.Text = string.Empty;
                dateTimePicker1.Value = DateTime.Now;
                comboBox1.SelectedIndex = -1;

                selectedEmployee = null;

                labelError.Text = "Uspjesno obirsan uposlenik";
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

                if (!ValidationInput1 && !ValidationInput2 && !ValidationInput3 && !ValidationInput4 && !ValidationInput5 && selectedEmployee != null)
                {
                    Role role = Role.Employee;
                    if (comboBox1.SelectedIndex == -1)
                    {
                        labelError.Text = "Morate odabrati rolu";
                        return;
                    }
                    else
                    {
                        if (comboBox1.SelectedIndex == 0)
                            role = Role.Admin;
                        if (comboBox1.SelectedIndex == 1)
                            role = Role.Employee;
                    }

                    if (selectedEmployee == null)
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
                        Password = txtPassword.Text,
                        Role = role

                    };

                    await _service.Put<EmployeeDTO>(selectedEmployee.EmployeeId, request);

                    dgvEmployee.DataSource = await _service.Get<List<EmployeeDTO>>(null, "/getAll");
                    dgvEmployee.Columns["EmployeeId"].Visible = false;

                    labelError.Text = "Uspjesno updatovan uposlenik";
                    btnDelete.Enabled = btnSave.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                labelError.Text = "Desila se greska";
            }
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            selectedEmployee = dgvEmployee.Rows[index].DataBoundItem as EmployeeDTO;

            txtId.Text = selectedEmployee.EmployeeId.ToString();
            txtName.Text = selectedEmployee.FirstName;
            txtLastName.Text = selectedEmployee.LastName;
            txtPassword.Text = selectedEmployee.Password;
            txtUsername.Text = selectedEmployee.Username;
            dateTimePicker1.Value = selectedEmployee.BirthDate;
            comboBox1.SelectedIndex = (int)selectedEmployee.Role;

            if(selectedEmployee.Gender == BLL.Models.Enums.Gender.Female)
            {
                rbZensko.Checked = true;
            }
            else
            {
                rbMale.Checked = true;
            }
            if (selectedEmployee!=null)
            {
                btnDelete.Enabled = btnSave.Enabled = true;
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
