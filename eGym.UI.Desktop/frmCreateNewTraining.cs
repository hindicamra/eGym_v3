using eGym.BLL.Models;
using eGym.BLL.Models.Requests;
using System.ComponentModel;

namespace eGym.UI.Desktop
{
    public partial class frmCreateNewTraining : Form
    {
        private readonly APIService _service = new APIService("Training");
        private AccountDTO selectedUser;
        bool ValidationInput1 = false, ValidationInput2 = false;

        public frmCreateNewTraining(AccountDTO user)
        {
            InitializeComponent();
            selectedUser = user;
            this.cmbDay.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDay.SelectedIndex = 0;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {

            if (ValidateChildren())
            {
                try
                {
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
        }

        private void frmCreateNewTraining_Load(object sender, EventArgs e)
        {
            txtName.Text = selectedUser.FirstName + " " + selectedUser.LastName;
        }

        private void SetError(Control control, string message)
        {
            err.SetError(control, message);
            control.Focus();
        }

        private void rtxtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(rtxtDescription.Text))
            {
                e.Cancel = true;
                SetError(rtxtDescription, "Morate unijeti trening");
            }
            else
            {
                e.Cancel = false;
                SetError(rtxtDescription, "");
            }
        }
    }
}
