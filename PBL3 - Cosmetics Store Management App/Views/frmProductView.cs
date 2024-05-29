using PBL3___Cosmetics_Store_Management_App.Controllers;
using PBL3___Cosmetics_Store_Management_App.Entities;
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
            dgvProducts.AutoGenerateColumns = false;
        }
        private void frmProductView_Load(object sender, EventArgs e)
        {
            frmLoad();
        }

        private void frmLoad()
        {
            dgvProducts.DataSource = ProductController.Instance.GetData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmProductAdd frm = new frmProductAdd();
            frm.ShowDialog();
            frmLoad();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ID = dgvProducts.CurrentRow.Cells[0].Value.ToString();
            Product cur = ProductController.Instance.GetByID(ID);

            if (dgvProducts.CurrentCell.OwningColumn.Name == "Product_Detail")
            {
                frmProductDetails frm = new frmProductDetails()
                {
                    currentProduct = cur
                };
                frm.ShowDialog();
            }
            if (dgvProducts.CurrentCell.OwningColumn.Name == "Product_Edit")
            {
                frmProductAdd frm = new frmProductAdd()
                {
                    currentProduct = cur
                };
                frm.ShowDialog();
            }
            if (dgvProducts.CurrentCell.OwningColumn.Name == "Product_Delete")
            {
                ProductController.Instance.Delete(cur);
            }

            frmLoad();
        }
    }
}
