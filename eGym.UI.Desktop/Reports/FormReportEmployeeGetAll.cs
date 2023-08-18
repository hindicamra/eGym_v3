using eGym.BLL.Models;
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
    public partial class FormReportEmployeeGetAll : Form
    {
        private readonly APIService _service = new APIService("Employee");
        public FormReportEmployeeGetAll()
        {
            InitializeComponent();
        }

        private async void FormReportEmployeeGetAll_Load(object sender, EventArgs e)
        {
            //reportViewer1.LocalReport.ReportEmbeddedResource = "eGym.UI.Desktop.Reports.ReportEmployeeGetAll.rdlc";
            reportViewer1.LocalReport.ReportEmbeddedResource = "eGym.UI.Desktop.Reports.ReportUpsolenici.rdl";

            List<EmployeeDTO> employees = new List<EmployeeDTO>();
            //employees.Add(new EmployeeDTO() {BirthDate= new DateTime(), Email="a@a.a", EmployeeId=1, FirstName="a", Gender=0, LastName="a", Password="a", Role=BLL.Models.Enums.Role.Admin, Username="a" });

            try
            {
                employees = await _service.Get<List<EmployeeDTO>>(null, "/getAll");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Desila se greska");
            }

            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet", employees));
            reportViewer1.RefreshReport();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //reportViewer1.LocalReport.ReportEmbeddedResource = "eGym.UI.Desktop.Reports.ReportEmployeeGetAll.rdlc";
            reportViewer1.LocalReport.ReportEmbeddedResource = "eGym.UI.Desktop.Reports.ReportUpsolenici.rdl";

            List<EmployeeDTO> employees = new List<EmployeeDTO>();
            //employees.Add(new EmployeeDTO() {BirthDate= new DateTime(), Email="a@a.a", EmployeeId=1, FirstName="a", Gender=0, LastName="a", Password="a", Role=BLL.Models.Enums.Role.Admin, Username="a" });

            try
            {
                employees = await _service.Get<List<EmployeeDTO>>(null, "/getAll");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Desila se greska");
            }

            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet", employees));
            reportViewer1.RefreshReport();
        }
    }
}
