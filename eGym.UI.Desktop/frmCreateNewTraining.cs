using eGym.BLL.Models;
using eGym.BLL.Models.Requests;

namespace eGym.UI.Desktop
{
    public partial class frmCreateNewTraining : Form
    {
        private readonly APIService _service = new APIService("Training");
        private AccountDTO selectedUser;
        bool ValidationInput1 = false, ValidationInput2 = false;

        public frmCreateNewTraining(AccountDTO user)
        {
            selectedUser = user;
            InitializeComponent();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbDay.SelectedIndex != -1)
            {
                cmbDay.BackColor = SystemColors.Window;
                cmbDay.ForeColor = SystemColors.WindowText;
                ValidationInput1 = false;
            }
            else
            {
                cmbDay.BackColor = Color.LightPink;
                cmbDay.ForeColor = Color.Red;
                ValidationInput1 = true;
            }

            if (rtxtDescription.Text != "")
            {
                rtxtDescription.BackColor = SystemColors.Window;
                rtxtDescription.ForeColor = SystemColors.WindowText;
                rtxtDescription.BorderStyle = BorderStyle.FixedSingle;
                ValidationInput2 = false;
            }
            else
            {
                rtxtDescription.BackColor = Color.LightPink;
                rtxtDescription.ForeColor = Color.Red;
                rtxtDescription.BorderStyle = BorderStyle.Fixed3D;
                ValidationInput2 = true;
            }

            try
            {
                if (!ValidationInput1 && !ValidationInput2)
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
