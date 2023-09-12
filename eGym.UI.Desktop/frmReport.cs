using eGym.BLL.Models;
using eGym.Domain;
using eGym.UI.Desktop.Reports;

namespace eGym.UI.Desktop
{
    public partial class frmReport : Form
    {
        private readonly APIService _service = new APIService("Report");
        public frmReport()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (await _service.Get<Token>(null, "/token") != null)
            {
                FormReportEmployeeGetAll fmr = new FormReportEmployeeGetAll();
                fmr.Show();
            }

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (await _service.Get<Token>(null, "/token") != null)
            {
                FormUsersGetAll fmr = new FormUsersGetAll();
                fmr.Show();
            }
        }

        private void frmReport_Load(object sender, EventArgs e)
        {

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var token = await _service.Get<Token>(null, "/token");

                if (token != null)
                {
                    var response = await _service.Get<List<Payment>>(null, $"/finance?token={token.Key}");

                    FormReportPaymentssGetAll frm = new FormReportPaymentssGetAll(response);
                    frm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Desila se greska");
            }
        }
    }
}
