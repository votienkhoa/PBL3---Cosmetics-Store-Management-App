using PBL3___Cosmetics_Store_Management_App.Controllers;
using PBL3___Cosmetics_Store_Management_App.Entities;
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
    public partial class frmReceiptView : Form
    {
        public frmReceiptView()
        {
            InitializeComponent();
            dgvReceipts.AutoGenerateColumns = false;
        }

        private void frmReceiptView_Load(object sender, EventArgs e)
        {
            frmLoad();
        }

        private void frmLoad()
        {
            List<Receipt> data = ReceiptController.Instance.GetData();
            data.Reverse();
            dgvReceipts.DataSource = data;
        }

        private void dgvReceipts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ID = dgvReceipts.CurrentRow.Cells[0].Value.ToString(); 
            if (dgvReceipts.CurrentCell.OwningColumn.Name == "Receipt_Detail")
            {
                frmReceiptDetail frm = new frmReceiptDetail()
                {
                    listReceipt = ReceiptController.Instance.GetList_ReceiptPrint(ID),
                    receipt = ReceiptController.Instance.GetByID(ID)
                };
                frm.Show();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvReceipts.DataSource = ReceiptController.Instance.Search(txtSearch.Text);
        }
    }
}
