﻿using PBL3___Cosmetics_Store_Management_App.Controllers;
using PBL3___Cosmetics_Store_Management_App.Entities;
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
            dtgv_customer.AutoGenerateColumns = false;

            dtgv_customer.DataSource = CustomerController.Instance.getData();

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            frmCustomerAdd frmCustomerAdd = new frmCustomerAdd();
            frmCustomerAdd.Show();
        }

        private void frmCustomerView_Load(object sender, EventArgs e)
        {

        }

        private void dtgv_customer_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string phone_number = dtgv_customer.CurrentRow.Cells[0].Value.ToString();
            Customer cur = CustomerController.Instance.GetByPhone(phone_number);
            if (dtgv_customer.CurrentCell.OwningColumn.Name == "Customer_Del")
            {
                CustomerController.Instance.delete(cur);
            }
            dgvLoad();
        }
    }
}
