using eGym.BLL.Models;
using eGym.BLL.Models.Requests;
using System.ComponentModel;

namespace eGym.UI.Desktop
{
    public partial class frmCreateNewDiet : Form
    {
        private readonly APIService _service = new APIService("Diet");
        private readonly AccountDTO selectedUser;
        bool ValidationInput1 = false, ValidationInput2 = false, ValidationInput3 = false;

        public frmCreateNewDiet(AccountDTO user)
        {
            selectedUser = user;
            InitializeComponent();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
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
                if (cmbMeal.SelectedIndex != -1)
                {
                    cmbMeal.BackColor = SystemColors.Window;
                    cmbMeal.ForeColor = SystemColors.WindowText;
                    ValidationInput2 = false;
                }
                else
                {
                    cmbMeal.BackColor = Color.LightPink;
                    cmbMeal.ForeColor = Color.Red;
                    ValidationInput2 = true;
                }
                if (rtxtDescription.Text != "")
                {
                    rtxtDescription.BackColor = SystemColors.Window;
                    rtxtDescription.ForeColor = SystemColors.WindowText;
                    rtxtDescription.BorderStyle = BorderStyle.FixedSingle;
                    ValidationInput3 = false;
                }
                else
                {
                    rtxtDescription.BackColor = Color.LightPink;
                    rtxtDescription.ForeColor = Color.Red;
                    rtxtDescription.BorderStyle = BorderStyle.Fixed3D;
                    ValidationInput3 = true;
                }

                if (!ValidationInput1 && !ValidationInput2 && !ValidationInput3)
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
            catch(Exception ex)
            {
                labelError.Text = "Desila se greska";
            }
        }

        private void frmCreateNewDiet_Load(object sender, EventArgs e)
        {
            txtName.Text = txtName.Text = selectedUser.FirstName + " " + selectedUser.LastName;
        }
    }
}
