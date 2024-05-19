using System;
using System.Windows.Forms;

namespace PBL3___Cosmetics_Store_Management_App.View
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
