using Microsoft.Reporting.WinForms;
using PBL3___Cosmetics_Store_Management_App.Controllers;
using PBL3___Cosmetics_Store_Management_App.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Cosmetics_Store_Management_App.Views
{
    public partial class frmReportDetail : Form
    {
        public DateTime startDate {  get; set; }
        public DateTime endDate { get; set; }
        public string import_id { get; set; }
        public string report_type { get; set; }
        private string report_path;
        private DataTable report_data;
        private double discount = 0, subtotal = 0;
        
        public frmReportDetail()
        {
            InitializeComponent();
            reportViewer1.Dock = DockStyle.Fill;
            reportViewer1.ZoomMode = ZoomMode.PageWidth;
        }

        private void frmSellByCategory_Load(object sender, EventArgs e)
        {
            if (report_type == "Category")
            {

                report_path = "Views/rptSellByCategory.rdlc";
                report_data = ReportController.Instance.SellByCategory(startDate.Date, endDate.Date, out subtotal, out discount);
                Generate_Report();
            }
            if (report_type == "Product")
            {
                report_path = "Views/rptSellByProduct.rdlc";
                report_data = ReportController.Instance.SellByProduct(startDate.Date, endDate.Date, out subtotal, out discount);
                Generate_Report();
            }
            if (report_type == "Import")
            {
                report_path = "Views/rptImport.rdlc";
                report_data = ReportController.Instance.ImportReport(import_id);
                Generate_Import();
            }
        }
        public void Generate_Report()
        {
            var source = new ReportDataSource("DataSet1", report_data);

            ReportParameter[] param = new ReportParameter[5];
            param[0] = new ReportParameter("start", startDate.ToString("dd/MM/yyyy  HH:mm"));
            param[1] = new ReportParameter("end", endDate.ToString("dd/MM/yyyy  HH:mm"));
            param[2] = new ReportParameter("subtotal", subtotal.ToString("N0"));
            param[3] = new ReportParameter("discount", discount.ToString("N0"));
            param[4] = new ReportParameter("total", (subtotal - discount).ToString("N0"));

            reportViewer1.LocalReport.ReportPath = report_path;
            reportViewer1.LocalReport.SetParameters(param);
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();
        }

        public void Generate_Import()
        {
            var source = new ReportDataSource("DataSet1", report_data);
            Import import = ImportController.Instance.GetByID(import_id);
            Provider provider = ProviderController.Instance.GetByID(import.provider_id);

            ReportParameter[] param = new ReportParameter[4];
            param[0] = new ReportParameter("import_id", import.import_id);
            param[1] = new ReportParameter("import_date", import.import_date.ToString());
            param[2] = new ReportParameter("provider_name", provider.provider_name);
            param[3] = new ReportParameter("staff_name", StaffController.Instance.GetByID(import.staff_id).staff_name);

            reportViewer1.LocalReport.ReportPath = report_path;
            reportViewer1.LocalReport.SetParameters(param);
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();
        }
    }
}
