using eGym.BLL.Models;

namespace eGym.UI.Desktop
{
    public partial class frmDiet : Form
    {
        private readonly APIService _service = new APIService("Diet");
        private readonly APIService _userService = new APIService("Account");
        private AccountDTO selectedUser;

        public frmDiet()
        {
            InitializeComponent();
            dgvAccount.AutoGenerateColumns = false;
            dgvDiet.AutoGenerateColumns = false;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text =="")
                {
                    dgvAccount.DataSource = await _userService.Get<List<AccountDTO>>(null, "/getAll");
                }
                else
                {
                    dgvAccount.DataSource = await _userService.Get<List<AccountDTO>>(new { text = txtSearch.Text }, "/search");
                }
            }
            catch (Exception ex)
            {
                labelError.Text = "Desila se greska";
            }
        }

        private async void frmDiet_Load(object sender, EventArgs e)
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
            selectedUser = (AccountDTO)dgvAccount.Rows[index].DataBoundItem;

            try
            {
                dgvDiet.DataSource = await _service.Get<List<DietDTO>>(new { userId = selectedUser.AccountId }, "/getByUserId");
            }
            catch (Exception ex)
            {
                labelError.Text = "Desila se greska";
            }
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            if (selectedUser == null)
            {
                labelError.Text = "Morate odabrati korisnika";
                return;
            };
            frmCreateNewDiet frm = new frmCreateNewDiet(selectedUser);
            frm.Show();
            this.Hide();
        }

        private void dgvDiet_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var diet = dgvDiet.Rows[index].DataBoundItem as DietDTO;

            frmEditDiet frm = new frmEditDiet(diet, selectedUser.FirstName + " " + selectedUser.LastName);
            frm.Show();
            this.Hide();
        }
    }
}
