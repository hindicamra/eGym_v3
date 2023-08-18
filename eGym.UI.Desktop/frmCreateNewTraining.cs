using eGym.BLL.Models;
using eGym.BLL.Models.Requests;
using System.ComponentModel;

namespace eGym.UI.Desktop
{
    public partial class frmCreateNewTraining : Form
    {
        private readonly APIService _service = new APIService("Training");
        private AccountDTO selectedUser;

        public frmCreateNewTraining(AccountDTO user)
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
                    MessageBox.Show("Morate unijete opis treninga");
                    return;
                }

                if (cmbDay.SelectedIndex == -1)
                {
                    MessageBox.Show("Morate odabrati dan");
                    return;
                }

                var request = new CreateTrainingRequest()
                {
                    AccountId = selectedUser.AccountId,
                    Day = (DayOfWeek)cmbDay.SelectedIndex,
                    Description = rtxtDescription.Text
                };

                await _service.Post<TrainingDTO>(request);

                MessageBox.Show("Uspjesno kreiran");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Desila se greska");
            }
        }

        private void frmCreateNewTraining_Load(object sender, EventArgs e)
        {
            txtName.Text = selectedUser.FirstName + " " + selectedUser.LastName;
        }

        private void textBoxDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtxtDescription.Text))
            {
                e.Cancel = true;
                rtxtDescription.Focus();
                errorProviderApp.SetError(rtxtDescription, "Morate unijeti username");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(rtxtDescription, "");
            }
        }
    }
}
