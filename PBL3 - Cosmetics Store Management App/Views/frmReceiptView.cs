using Guna.UI2.WinForms;
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
        public Staff current_staff = null;
        public frmReceiptView()
        {
            InitializeComponent();
            dgvReceipts.AutoGenerateColumns = false;
        }

        private void frmReceiptView_Load(object sender, EventArgs e)
        {
            frmLoad();
            if (current_staff != null) Change();
        }
        private void Change()
        {
            Guna2ControlBox controlBox1 = new Guna2ControlBox();
            controlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            controlBox1.Animated = true;
            controlBox1.BorderRadius = 5;
            controlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            controlBox1.HoverState.FillColor = System.Drawing.Color.Red;
            controlBox1.IconColor = System.Drawing.Color.White;
            controlBox1.Location = new System.Drawing.Point(1030, 8);
            controlBox1.Name = "guna2ControlBox1";
            controlBox1.Size = new System.Drawing.Size(45, 29);
            controlBox1.TabIndex = 0;
            pnTop.Controls.Add(controlBox1);

            this.BackColor = Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(223)))), ((int)(((byte)(202)))));


        }

        private void frmLoad()
        {
            List<Receipt> data = ReceiptController.Instance.GetData();
            
            if (current_staff != null) data = ReceiptController.Instance.GetByStaff(current_staff.staff_id);
            else data = ReceiptController.Instance.GetData();

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
