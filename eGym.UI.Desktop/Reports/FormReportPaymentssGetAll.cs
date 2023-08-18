using eGym.BLL.Models;
using eGym.Domain;
using Microsoft.Reporting.WinForms;
using Stripe;
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
    public partial class FormReportPaymentssGetAll : Form
    {
        List<Payment> payments = new List<Payment>();
        public FormReportPaymentssGetAll(List<Payment> _payments)
        {
            InitializeComponent();
            payments = _payments;
        }

        private void FormReportPaymentssGetAll_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "eGym.UI.Desktop.Reports.ReportPlacanja.rdl";
            try
            {
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet", payments));
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Desila se greska");
            }
        }
    }
}
