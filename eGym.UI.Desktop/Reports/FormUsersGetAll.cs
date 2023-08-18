using eGym.BLL.Models;
using eGym.Domain;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eGym.UI.Desktop.Reports
{
    public partial class FormUsersGetAll : Form
    {
        private readonly APIService _service = new APIService("Account");
        List<AccountDTO> accounts = new List<AccountDTO>();
        public FormUsersGetAll()
        {
            InitializeComponent();
        }

        private async void FormUsersGetAll_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "eGym.UI.Desktop.Reports.ReportKorisnici.rdl";

            try
            {
                accounts = await _service.Get<List<AccountDTO>>(null, "/getAll");

                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet", accounts));
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Desila se greska");
            }


        }
    }
}
