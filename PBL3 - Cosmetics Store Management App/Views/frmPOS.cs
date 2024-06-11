using Guna.UI2.WinForms;
using PBL3___Cosmetics_Store_Management_App.Controllers;
using PBL3___Cosmetics_Store_Management_App.Entities;
using PBL3___Cosmetics_Store_Management_App.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PBL3___Cosmetics_Store_Management_App
{
    public partial class frmPOS : Form
    {
        private DataTable Dt;
        public Staff currentStaff = null;


        public frmPOS()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        #region Load Form
        private void frmPOS_Load(object sender, EventArgs e)
        {
            CategoryButtonLoad();
            DtCreate();

            dgvReceipt.AutoGenerateColumns = false;
            dgvReceipt.DataSource = Dt;
        }

        private void CategoryButtonLoad()
        {
            List<string> data = CategoryController.Instance.GetAllName();
            data.Insert(0, "All");

            foreach (string name in data)
            {
                Guna2Button tmp = new Guna2Button();
                tmp.Text = name;
                tmp.BorderRadius = 15;
                tmp.Animated = true;
                tmp.Font = new System.Drawing.Font("Segoe UI Semibold", 8.765218F, System.Drawing.FontStyle.Bold);
                tmp.Size = new System.Drawing.Size(182, 49);
                tmp.FillColor = System.Drawing.Color.FromArgb(79, 111, 82);
                tmp.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                tmp.CheckedChanged += new EventHandler(btnCategory_CheckChange);

                pnCategories.Controls.Add(tmp);
            }
        }

        public void DtCreate()
        {
            Dt = new DataTable();
            Dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("No", typeof(int)),
                new DataColumn("ID", typeof(string)),
                new DataColumn("Name", typeof(string)),
                new DataColumn("Qty", typeof(int)),
                new DataColumn("Price", typeof(int)),
                new DataColumn("Amount", typeof(int))

            });
        }

        private void btnCategory_CheckChange(object sender, EventArgs e)
        {
            Guna2Button button = (Guna2Button)sender;
            if (button.Checked == true)
            {
                if (button.Text == "All") Product_Load("");
                else Product_Load(button.Text);
            }
        }
        
        private void Product_Load(string category)
        {
            pnProduct.Controls.Clear();
            var productList = ProductController.Instance.GetByCategory(category);
            foreach (var product in productList)
            {
                usProduct usProduct = new usProduct()
                {
                    product = product
                };
                usProduct.UserControlClick += Product_Click;
                pnProduct.Controls.Add(usProduct);
            }
        }
        #endregion

        #region Events
        public void Product_Click(object sender, Product e)
        {
            bool check = false;
            foreach (DataRow i in Dt.Rows)
            {
               if (i[2].ToString() == e.product_name)
               {
                    check = true;
                    break;
               }
            }
            if (!check)
            {
                Dt.Rows.Add(Dt.Rows.Count + 1,e.product_id, e.product_name, 1, e.product_price, e.product_price);
            }
            else
            {
                foreach (DataRow i in Dt.Rows)
                {
                    if (i[2].ToString() == e.product_name)
                    {
                        i[3] = Convert.ToInt32(i[3]) + 1;
                        i[5] = Convert.ToInt32(i[4]) * Convert.ToInt32(i[3]);
                        break;
                    }
                }
            }
            //-----------------------------
            Update_Total();
        }
        private void dgvReceipt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvReceipt.CurrentCell.OwningColumn.Name == "POS_Del")
            {
                string name = dgvReceipt.CurrentRow.Cells[1].Value.ToString();
                foreach (DataRow i in Dt.Rows)
                {
                    if (i[2].ToString() == name)
                    {
                        if (Convert.ToInt32(i[3]) == 1) Dt.Rows.Remove(i);
                        else
                        {
                            i[3] = Convert.ToInt32(i[3]) - 1;
                            i[5] = Convert.ToInt32(i[4]) * Convert.ToInt32(i[3]);
                        }
                        break;
                    }
                }
                int index = 1;
                foreach (DataRow i in Dt.Rows)
                {
                    i[0] = index;
                    index++;
                }
                Update_Total();
            }
        }

        private void Update_Total()
        {
            double new_subtotal, new_total;
            ReceiptController.Instance.Calculate(Dt, txtDiscount.Text, out new_subtotal, out new_total);

            lbSubtotal.Text = new_subtotal.ToString("N0");
            lbTotal.Text = new_total.ToString("N0");
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            Dt.Rows.Clear();

            lbSubtotal.Text = 0.ToString(); 
            lbTotal.Text = 0.ToString();
            txtDiscount.Text = 0.ToString();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (Dt.Rows.Count == 0) MessageBox.Show("The receipt is empty. Please add products before payment!", "Empty Receipt", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else
            {
                DialogResult confirmation = MessageBox.Show(
                    "Are you sure you want to proceed with payment and print the receipt?",
                    "Payment Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (confirmation == DialogResult.Yes)
                {
                    Receipt new_receipt = ReceiptController.Instance.Receipt_Pay(Dt, lbSubtotal.Text, currentStaff.staff_id, txtDiscount.Text);
                    frmReceiptDetail frm = new frmReceiptDetail()
                    {
                        listReceipt = ReceiptController.Instance.GetList_ReceiptPrint(new_receipt.receipt_id),
                        receipt = new_receipt
                    };
                    frm.ShowDialog();
                    Dt.Rows.Clear();
                }
                
            }
        }

        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            double subtotal = Convert.ToDouble(lbSubtotal.Text);
            if (!ReceiptController.Instance.DiscountValidataion(txtDiscount.Text))
            {
                MessageBox.Show("The discount value is invalid!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiscount.Text = "";
            }
            else
            {
                Update_Total();
            }
        }
        private void txtDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDiscount_Leave(sender, new EventArgs());
                this.ActiveControl = null;
            }
        }

        #endregion


    }
}
