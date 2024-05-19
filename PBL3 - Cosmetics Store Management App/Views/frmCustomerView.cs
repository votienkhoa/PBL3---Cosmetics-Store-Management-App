using System;
using System.Data;
using System.Windows.Forms;

namespace PBL3___Cosmetics_Store_Management_App.View
{
    public partial class frmCustomerView : Form
    {
        public frmCustomerView()
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
                new DataColumn("Name", typeof(string))
            });

            dt.Rows.Add("KH00001", "Vo Tien Khoa");
            dt.Rows.Add("KH00002", "Tran Duc Huy");

            foreach (DataRow i in dt.Rows)
            {
                dgvStaff.Rows.Add(i.ItemArray);
            }

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            frmCustomerAdd frmCustomerAdd = new frmCustomerAdd();
            frmCustomerAdd.Show();
        }
    }
}
