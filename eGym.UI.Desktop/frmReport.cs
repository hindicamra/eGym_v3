using eGym.BLL.Models;
using eGym.Domain;
using eGym.UI.Desktop.Properties;
using eGym.UI.Desktop.Reports;
using Newtonsoft.Json;

namespace eGym.UI.Desktop
{
    public partial class frmReport : Form
    {
        private readonly APIService _service = new APIService("Report");
        public frmReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormReportEmployeeGetAll fmr = new FormReportEmployeeGetAll();
            fmr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormUsersGetAll fmr = new FormUsersGetAll();
            fmr.Show();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var token = await _service.Get<Token>(null, "/token");


                var client = new HttpClient();

                string getEnv = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
                string APIUrl = "";
                if (getEnv == "Development")
                    APIUrl = Settings.Default.APIUrlLocal;
                if (getEnv == "Production")
                    APIUrl = Settings.Default.APIUrlProduction;

                var request = new HttpRequestMessage(HttpMethod.Get, APIUrl + "Report/finance?token=RSIIeGym");

                var response = await client.SendAsync(request);
                string json = await response.Content.ReadAsStringAsync();
                List<Payment> payments = JsonConvert.DeserializeObject<List<Payment>>(json);

                FormReportPaymentssGetAll frm = new FormReportPaymentssGetAll(payments);
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Desila se greska");
            }
        }
    }
}
