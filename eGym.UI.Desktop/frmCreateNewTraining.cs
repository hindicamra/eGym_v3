using eGym.BLL.Models;
using eGym.BLL.Models.Requests;

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
                    labelError.Text = "Morate unijete opis treninga";
                    return;
                }

                if (cmbDay.SelectedIndex == -1)
                {
                    labelError.Text = "Morate odabrati dan";
                    return;
                }

                var request = new CreateTrainingRequest()
                {
                    AccountId = selectedUser.AccountId,
                    Day = (DayOfWeek)cmbDay.SelectedIndex,
                    Description = rtxtDescription.Text
                };

                await _service.Post<TrainingDTO>(request);

                labelError.Text = "Uspjesno kreiran";
                this.Close();
            }
            catch (Exception ex)
            {
                labelError.Text = "Desila se greska";
            }
        }

        private void frmCreateNewTraining_Load(object sender, EventArgs e)
        {
            txtName.Text = selectedUser.FirstName + " " + selectedUser.LastName;
        }
    }
}
