using eGym.BLL.Models.Requests;
using System.ComponentModel;
using System.Windows.Forms;

namespace eGym.UI.Desktop
{
    public partial class frmLogin : Form
    {
        private readonly APIService _apiService = new APIService("Employee");

        public frmLogin()
        {
            InitializeComponent();
            txbPassword.Text = "test";
            txbUsername.Text = "desktop";
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (txbUsername.Text== "" || txbPassword.Text == "")
            {
                labelError.Text = "Morate unijete username i/ili password";
                return;
            }

            APIService.Username = txbUsername.Text;
            APIService.Password = txbPassword.Text;

            try
            {
                var request = new LoginRequest() 
                {
                    Username = txbUsername.Text,
                    Password = txbPassword.Text
                };
                var result = await _apiService.Login<dynamic>(request, "/login");

                frmMain frm = new frmMain();
                frm.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                labelError.Text = "Pogresan username ili password";
            }
        }
    }
}
