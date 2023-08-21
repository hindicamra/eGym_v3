using eGym.BLL.Models;
using eGym.BLL.Models.Requests;

namespace eGym.UI.Desktop
{
    public partial class frmReservationsOverview : Form
    {
        private readonly APIService _service = new APIService("Reservation");
        private readonly APIService _employeeService = new APIService("Employee");
        private readonly APIService _accountService = new APIService("Account");
        private ReservationDTO selectedReservation;
        private EmployeeDTO logedEmployee;

        public frmReservationsOverview()
        {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvTrainings.DataSource = await _service.Get<List<ReservationDTO>>(new { employeeId = logedEmployee.EmployeeId, date = dtpSearchTime.Value }, "/GetPaidReservation");
                dgvTrainings.Columns["ReservationId"].Visible= false;
                dgvTrainings.Columns["AccountId"].Visible= false;
                dgvTrainings.Columns["EmployeeId"].Visible= false;
            }
            catch (Exception ex)
            {
                labelError.Text = "Desila se greska";
                //MessageBox.Show("Desila se greska");
            }
        }

        private async void frmReservationsOverview_Load(object sender, EventArgs e)
        {
            dtpSearchTime.Value = DateTime.Now;

            var request = new LoginRequest()
            {
                Username = APIService.Username,
                Password = APIService.Password
            };

            try
            {
                logedEmployee = await _employeeService.Login<EmployeeDTO>(request, "/login");

                dgvTrainings.DataSource = await _service.Get<List<ReservationDTO>>(new { employeeId = logedEmployee.EmployeeId, date = dtpSearchTime.Value }, "/GetPaidReservation");
            }
            catch (Exception ex)
            {
                labelError.Text = "Desila se greska";
                //MessageBox.Show("Desila se greska");
            }
        }

        private async void dgvTrainings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            selectedReservation = dgvTrainings.Rows[index].DataBoundItem as ReservationDTO;

            try
            {
                var account = await _accountService.GetById<AccountDTO>(selectedReservation.AccountId);

                txtClient.Text = account.FirstName + " " + account.LastName;
                dtpFrom.Value = selectedReservation.From;
                dtpTo.Value = selectedReservation.To;
                cmbType.SelectedIndex = (int)selectedReservation.ReservationType;
                rtxbDescription.Text = selectedReservation.Description;
            }
            catch (Exception ex)
            {
                labelError.Text = "Desila se greska";
                //MessageBox.Show("Desila se greska");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
