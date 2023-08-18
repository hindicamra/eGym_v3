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
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateChildren(ValidationConstraints.Enabled))
                {
                    MessageBox.Show("Morate unijete opis obroka");
                    return;
                }

                if (cmbDay.SelectedIndex == -1)
                {
                    MessageBox.Show("Morate odabrati dan");
                    return;
                }

                if (cmbMeal.SelectedIndex == -1)
                {
                    MessageBox.Show("Morate odabrati obrok");
                    return;
                }

                var request = new CreateDietRequest()
                {
                    AccountId = selectedUser.AccountId,
                    Day = (DayOfWeek)cmbDay.SelectedIndex,
                    Meal = (BLL.Models.Enums.Meal)cmbMeal.SelectedIndex,
                    Description = rtxtDescription.Text
                };

                await _service.Post<DietDTO>(request);

                MessageBox.Show("Uspjesno kreiran");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Desila se greska");
            }
        }

        private void frmCreateNewDiet_Load(object sender, EventArgs e)
        {
            txtName.Text = txtName.Text = selectedUser.FirstName + " " + selectedUser.LastName;
        }

        private void textBoxDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtxtDescription.Text))
            {
                e.Cancel = true;
                rtxtDescription.Focus();
                errorProviderApp.SetError(rtxtDescription, "Morate unijeti opis");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(rtxtDescription, "");
            }
        }
    }
}
