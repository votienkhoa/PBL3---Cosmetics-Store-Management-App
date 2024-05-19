using System;
using System.Data;
using System.Windows.Forms;

namespace PBL3___Cosmetics_Store_Management_App.View
{
    public partial class frmStaffView : Form
    {
        public frmStaffView()
        {
            InitializeComponent();
            dgvLoad();
        }

        public void dgvLoad()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("IDD", typeof(string)),
                new DataColumn("Name", typeof(string)),
                new DataColumn("Role", typeof (string))
            });

            dt.Rows.Add("NV0002", "Vo Tien Khoa", "Sales");
            dt.Rows.Add("NV0001", "Tran Duc Huy", "Manager");
            dt.Rows.Add("NV0003", "Nguyen Van Thuong", "Storekeeper");
            dt.Rows.Add("NV0004", "Nguyen Huu Hung Dung", "Sales");

            foreach (DataRow i in dt.Rows)
            {
                dgvStaff.Rows.Add(i.ItemArray);
            }

        }

        private void dgvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            frmStaffAdd test = new frmStaffAdd();
            test.Show();
        }
    }

}
