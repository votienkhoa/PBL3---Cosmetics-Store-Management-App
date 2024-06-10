using PBL3___Cosmetics_Store_Management_App.Controllers;
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
            dgvReceipts.DataSource = ReceiptController.Instance.GetData();
        }

        private void dgvReceipts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ID = dgvReceipts.CurrentRow.Cells[0].Value.ToString(); 
            if (dgvReceipts.CurrentCell.OwningColumn.Name == "Receipt_Detail")
            {
                frmReceipt frm = new frmReceipt()
                {
                    listReceipt = ReceiptController.Instance.GetList_ReceiptPrint(ID),
                    receipt = ReceiptController.Instance.GetByID(ID)
                };
                frm.Show();
            }
        }
    }
}
