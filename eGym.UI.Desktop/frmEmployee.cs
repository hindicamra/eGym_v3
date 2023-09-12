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

        public frmEmployee()
        {
            InitializeComponent();
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            dgvEmployee.AutoGenerateColumns = false;
        }

        private async void frmEmployee_Load(object sender, EventArgs e)
        {
            try
            {
                dgvEmployee.DataSource = await _service.Get<List<EmployeeDTO>>(null, "/getAll");
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
                if (txtSearch.Text == "")
                {
                    dgvEmployee.DataSource = await _service.Get<List<EmployeeDTO>>(null, "/getAll");
                }
                else
                {
                    dgvEmployee.DataSource = await _service.Get<List<EmployeeDTO>>(new { text = txtSearch.Text }, "/search");
                }
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

                txtId.Text = string.Empty;
                txtName.Text = string.Empty;
                txtLastName.Text = string.Empty;
                txtUsername.Text = string.Empty;
                dateTimePicker1.Value = DateTime.Now;
                comboBox1.SelectedIndex = -1;

                selectedEmployee = null;

                labelError.Text = "Uspjesno obirsan uposlenik";
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
                        Role = role
                    };

                    await _service.Put<EmployeeDTO>(selectedEmployee.EmployeeId, request);

                    dgvEmployee.DataSource = await _service.Get<List<EmployeeDTO>>(null, "/getAll");

                    labelError.Text = "Uspjesno updatovan uposlenik";
                    btnDelete.Enabled = btnSave.Enabled = false;
                }
                catch (Exception ex)
                {
                    labelError.Text = "Desila se greska";
                }
            }
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            selectedEmployee = (EmployeeDTO)dgvEmployee.Rows[index].DataBoundItem;

            txtId.Text = selectedEmployee.EmployeeId.ToString();
            txtName.Text = selectedEmployee.FirstName;
            txtLastName.Text = selectedEmployee.LastName;
            txtUsername.Text = selectedEmployee.Username;
            dateTimePicker1.Value = selectedEmployee.BirthDate;
            comboBox1.SelectedIndex = (int)selectedEmployee.Role;

            if (selectedEmployee.Gender == BLL.Models.Enums.Gender.Female)
            {
                rbZensko.Checked = true;
            }
            else
            {
                rbMale.Checked = true;
            }
            if (selectedEmployee != null)
            {
                btnDelete.Enabled = btnSave.Enabled = true;
            }
        }

        private void textBoxName_Validating(object sender, CancelEventArgs e)
        {
            string name = txtName.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                e.Cancel = true;
                SetError(txtName, "Morate unijeti ime");
            }
            else if (name.Length <= 2)
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

        private void SetError(Control control, string message)
        {
            err.SetError(control, message);
            control.Focus();
        }

        private void textBoxLastName_Validating(object sender, CancelEventArgs e)
        {
            string lastName = txtLastName.Text.Trim();

            if (string.IsNullOrEmpty(lastName))
            {
                e.Cancel = true;
                SetError(txtLastName, "Morate unijeti prezime");
            }
            else if (lastName.Length <= 2)
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


        private void textBoxUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                e.Cancel = true;
                txtUsername.Focus();
                err.SetError(txtUsername, "Morate unijeti username");
            }
            else if (txtUsername.Text.Length <= 2)
            {
                e.Cancel = true;
                txtUsername.Focus();
                err.SetError(txtUsername, "Username ne smije biti kraće od 2 karaktera.");
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtUsername, "");
            }
        }
    }
}
