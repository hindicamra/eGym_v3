using eGym.BLL.Models;
using eGym.BLL.Models.Requests;

namespace eGym.UI.Desktop
{
    public partial class frmTraining : Form
    {
        private readonly APIService _userService = new APIService("Account");
        private readonly APIService _service = new APIService("Training");
        private AccountDTO selectedUser;
        private TrainingDTO selectedTraining;

        public frmTraining()
        {
            InitializeComponent();
            dgvTraining.AutoGenerateColumns = false;
            dgvAccount.AutoGenerateColumns = false;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvAccount.DataSource = await _userService.Get<List<AccountDTO>>(new { text = txtSearch.Text }, "/search");
            }
            catch (Exception ex)
            {
                labelError.Text = "Desila se greska";
            }
        }

        private async void frmTraining_Load(object sender, EventArgs e)
        {
            try
            {
                dgvAccount.DataSource = await _userService.Get<List<AccountDTO>>(null, "/getAll");
            }
            catch (Exception ex)
            {
                labelError.Text = "Desila se greska";
            }
        }

        private async void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            selectedUser = dgvAccount.Rows[index].DataBoundItem as AccountDTO;

            try
            {
                dgvTraining.DataSource = await _service.Get<List<TrainingDTO>>(new { userId = selectedUser.AccountId }, "/getUserTraningPlan");
            }
            catch (Exception ex)
            {
                labelError.Text = "Desila se greska";
            }
        }

        private void btnCreateNewTraining_Click(object sender, EventArgs e)
        {
            if (selectedUser == null)
            {
                labelError.Text = "Morate odabrati korisnika";
                return;
            }
            frmCreateNewTraining frm = new frmCreateNewTraining(selectedUser);
            frm.Show();
            this.Hide();
        }

        private void dgvTraining_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var training = dgvTraining.Rows[index].DataBoundItem as TrainingDTO;

            frmEditTraining frm = new frmEditTraining(training, selectedUser.FirstName + " " + selectedUser.LastName);
            frm.Show();
            this.Hide();
        }
    }
}
