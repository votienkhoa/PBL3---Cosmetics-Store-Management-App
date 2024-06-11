using PBL3___Cosmetics_Store_Management_App.Controllers;
using PBL3___Cosmetics_Store_Management_App.Entities;
using PBL3___Cosmetics_Store_Management_App.View;
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
    public partial class frmCustomerChoose : Form
    {
        public Customer current_customer {  get; set; }
        public frmCustomerChoose()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            Customer tmp = CustomerController.Instance.GetByPhone(txtPhone.Text);
            if (tmp != null)
            {
                current_customer = tmp;
                txtName.Text = tmp.customer_name;
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Can't find customer with that phone nummber! Do you want to create new customer ?",
                                "Customer not found!",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Error);
                if (dialog == DialogResult.Yes)
                {
                    frmCustomerAdd frm = new frmCustomerAdd();
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        current_customer = frm.current_customer;
                        txtPhone.Text = frm.current_customer.customer_phone;
                        txtName.Text = frm.current_customer.customer_name;
                    }
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
