using eGym.BLL.Models;
using eGym.BLL.Models.Requests;

namespace eGym.UI.Desktop
{
    public partial class frmReservation : Form
    {
        private readonly APIService _service = new APIService("Reservation");
        private readonly APIService _employeeService = new APIService("Employee");
        private readonly APIService _accountService = new APIService("Account");
        private ReservationDTO selectedReservation;
        private EmployeeDTO logedEmployee;

        public frmReservation()
        {
            InitializeComponent();
            this.cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            //dgvReservations.AutoGenerateColumns = false;
        }

        private async void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedReservation == null)
                {
                    labelError.Text = "Morate odabrati rezervaciju";
                    return;
                }

                await _service.Put<ReservationDTO>(selectedReservation.ReservationId, "/confirm");
                dgvReservations.DataSource = await _service.Get<List<ReservationDTO>>(new { employeeId = logedEmployee.EmployeeId, date = dtpDate.Value }, "/GetPendingReservation");
                labelError.Text = "Reservacija potvrdjena";
            }
            catch (Exception ex)
            {
                labelError.Text = "Desila se greska";
            }
        }

        private async void frmReservation_Load(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Now;

            var request = new LoginRequest()
            {
                Username = APIService.Username,
                Password = APIService.Password
            };

            try
            {
                logedEmployee = await _employeeService.Login<EmployeeDTO>(request, "/login");

                dgvReservations.DataSource = await _service.Get<List<ReservationDTO>>(new { employeeId = logedEmployee.EmployeeId, date = dtpDate.Value }, "/GetPendingReservation");
            }
            catch (Exception ex)
            {
                labelError.Text = "Desila se greska";
            }
        }

        private async void btnDecline_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedReservation == null)
                {
                    labelError.Text = "Morate odabrati rezervaciju";
                    return;
                }

                await _service.Put<ReservationDTO>(selectedReservation.ReservationId, "/decline");
                dgvReservations.DataSource = await _service.Get<List<ReservationDTO>>(new { employeeId = logedEmployee.EmployeeId, date = dtpDate.Value }, "/GetPendingReservation");
                labelError.Text = "Reservacija odbijena";

            }
            catch (Exception)
            {
                labelError.Text = "Desila se greska";
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvReservations.DataSource = await _service.Get<List<ReservationDTO>>(new { employeeId = logedEmployee.EmployeeId, date = dtpDate.Value }, "/GetPendingReservation");
                //dgvReservations.Columns["ReservationId"].Visible = false;
                //dgvReservations.Columns["AccountId"].Visible = false;
                //dgvReservations.Columns["EmployeeId"].Visible = false;
                //dgvReservations.Columns["EmployeeName"].Visible = false;

            }
            catch (Exception ex)
            {
                labelError.Text = "Desila se greska";
            }
        }

        private async void dgvReservations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            selectedReservation = dgvReservations.Rows[index].DataBoundItem as ReservationDTO;

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
            }
        }
    }
}
