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

        private void btnCategory_Click(object sender, System.EventArgs e)
        {
            using (frmDateTimePicker frm =  new frmDateTimePicker())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    DateTime startDate = frm.StartDate.Date;
                    DateTime endDate = frm.EndDate.Date;

                    frmSellByCategory report = new frmSellByCategory()
                    {
                        startDate = startDate,
                        endDate = endDate.AddDays(1)
                    };
                    report.ShowDialog();
                }
            }
        }
    }
}
