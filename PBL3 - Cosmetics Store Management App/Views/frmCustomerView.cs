using PBL3___Cosmetics_Store_Management_App.Controllers;
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
            // dtgv_customer.AutoGenerateColumns = false;
            //dtgv_customer.DataSource = CustomerController.Instance.getData();

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            frmCustomerAdd frmCustomerAdd = new frmCustomerAdd();
            frmCustomerAdd.Show();
        }


        private void dtgv_customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
