using System;
using System.Data;
using System.Windows.Forms;

namespace PBL3___Cosmetics_Store_Management_App.View
{
    public partial class frmProductView : Form
    {
        public frmProductView()
        {
            InitializeComponent();
            dgvLoad();
        }

        public void dgvLoad()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("ID", typeof(string)),
                new DataColumn("Name", typeof(string)),
                new DataColumn("Price", typeof(int))
            });

            dt.Rows.Add("SP0001", "Sữa rửa mặt Innisfree", 150000);
            dt.Rows.Add("SP0002", "Kem chống nắng", 120000);

            foreach (DataRow i in dt.Rows)
            {
                dgvStaff.Rows.Add(i.ItemArray);
            }

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            frmProductAdd frmProductAdd = new frmProductAdd();
            frmProductAdd.Show();
        }
    }
}
