using Guna.UI2.WinForms;
using PBL3___Cosmetics_Store_Management_App.Views;
using System;
using System.Windows.Forms;

namespace PBL3___Cosmetics_Store_Management_App.View
{
    public partial class frmReportView : Form
    {
        public frmReportView()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, System.EventArgs e)
        {
            string type = ((Guna2Button)sender).Name.Substring(3);
            using (frmDateTimePicker frm = new frmDateTimePicker())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    frmReportDetail report = new frmReportDetail()
                    {
                        startDate = frm.StartDate.Date,
                        endDate = frm.EndDate.AddDays(1),
                        report_type = type
                    };
                    report.ShowDialog();
                }
            }
        }
    }
}
