using Carservice.WinForm.Reports;
using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace Carservice.WinForm.Views
{
    public partial class ReportView : Form
    {
        private int orderId;
        public ReportView(int id)
        {
            orderId = id;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OrderReportBuilder builder = new OrderReportBuilder();
            var model = builder.Build(orderId);
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            var report = reportViewer1.LocalReport;
            report.ReportPath = "Reports\\OrderReport.rdlc";
            report.DataSources.Add(new ReportDataSource("OrderHeaderDataSet", new[] { model.Header }));
            report.DataSources.Add(new ReportDataSource("OrderItemDataSet", model.Items));
            reportViewer1.RefreshReport();

        }
    }
}
