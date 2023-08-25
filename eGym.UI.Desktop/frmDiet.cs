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
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvAccount.DataSource = await _userService.Get<List<AccountDTO>>(new { text = txtSearch.Text }, "/search");
                dgvAccount.Columns["AccountId"].Visible = false;
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
                dgvAccount.Columns["AccountId"].Visible= false;
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
                dgvDiet.DataSource = await _service.Get<List<DietDTO>>(new { userId = selectedUser.AccountId }, "/getByUserId");
                dgvDiet.Columns["DietId"].Visible = false;
                dgvDiet.Columns["AccountId"].Visible = false;
            }
            catch(Exception ex)
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
