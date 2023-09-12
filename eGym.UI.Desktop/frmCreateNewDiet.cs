using eGym.BLL.Models;
using eGym.BLL.Models.Requests;
using System.ComponentModel;

namespace eGym.UI.Desktop
{
    public partial class frmCreateNewDiet : Form
    {
        private readonly APIService _service = new APIService("Diet");
        private readonly AccountDTO selectedUser;

        public frmCreateNewDiet(AccountDTO user)
        {
            selectedUser = user;
            InitializeComponent();
            this.cmbDay.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbMeal.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren())
                {
                    var request = new CreateDietRequest()
                    {
                        AccountId = selectedUser.AccountId,
                        Day = (DayOfWeek)cmbDay.SelectedIndex,
                        Meal = (BLL.Models.Enums.Meal)cmbMeal.SelectedIndex,
                        Description = rtxtDescription.Text
                    };
                    await _service.Post<DietDTO>(request);
                    labelError.Text = "Uspjesno kreiran";
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                labelError.Text = "Desila se greska";
            }
        }

        private void frmCreateNewDiet_Load(object sender, EventArgs e)
        {
            txtName.Text = txtName.Text = selectedUser.FirstName + " " + selectedUser.LastName;
        }

        private void cmbDay_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(cmbDay.Text))
            {
                e.Cancel = true;
                SetError(cmbDay, "Morate unijeti dan");
            }
            else
            {
                e.Cancel = false;
                SetError(cmbDay, "");
            }
        }

        private void cmbMeal_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbMeal.Text))
            {
                e.Cancel = true;
                SetError(cmbMeal, "Morate unijeti obrok");
            }
            else
            {
                e.Cancel = false;
                SetError(cmbMeal, "");
            }
        }

        private void rtxtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(rtxtDescription.Text))
            {
                e.Cancel = true;
                SetError(rtxtDescription, "Morate unijeti obrok");
            }
            else
            {
                e.Cancel = false;
                SetError(rtxtDescription, "");
            }
        }
        private void SetError(Control control, string message)
        {
            err.SetError(control, message);
            control.Focus();
        }
    }
}
