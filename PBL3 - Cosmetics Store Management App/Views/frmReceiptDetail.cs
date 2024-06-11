using Microsoft.Reporting.WinForms;
using PBL3___Cosmetics_Store_Management_App.Controllers;
using PBL3___Cosmetics_Store_Management_App.Data_Access;
using PBL3___Cosmetics_Store_Management_App.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Cosmetics_Store_Management_App.Views
{
    public partial class frmReceiptDetail : Form
    {
        public List<ReceiptPrint> listReceipt {  get; set; }
        public Receipt receipt { get; set; }

        public frmReceiptDetail()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double subtotal = receipt.receipt_total / (100 - receipt.receipt_discount) * 100;
            string staff_name = StaffController.Instance.GetByID(receipt.staff_id).staff_name;
            Customer current_customer = CustomerController.Instance.GetByID(receipt.customer_phone);
            string customer_name = (current_customer != null) ? current_customer.customer_name : "None";

            ReportParameter[] param = new ReportParameter[8];
            param[0] = new ReportParameter("receipt_id", receipt.receipt_id);
            param[1] = new ReportParameter("receipt_date", receipt.receipt_date.ToString("d/M/yyyy"));
            param[2] = new ReportParameter("receipt_time", receipt.receipt_date.ToString("HH:mm:ss"));
            param[3] = new ReportParameter("total", receipt.receipt_total.ToString("N0"));
            param[4] = new ReportParameter("discount", receipt.receipt_discount.ToString() + "%");
            param[5] = new ReportParameter("sell_agent", staff_name);
            param[6] = new ReportParameter("subtotal", subtotal.ToString("N0"));
            param[7] = new ReportParameter("customer", customer_name);


            var source = new ReportDataSource("DataSet1", listReceipt);

            reportViewer1.LocalReport.ReportPath = "Views\\rptReceipt.rdlc";
            reportViewer1.LocalReport.SetParameters(param);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(source);

            this.reportViewer1.RefreshReport();
        }
    }
}
