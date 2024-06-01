using Guna.UI2.WinForms;
using PBL3___Cosmetics_Store_Management_App.Controllers;
using PBL3___Cosmetics_Store_Management_App.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PBL3___Cosmetics_Store_Management_App
{
    public partial class frmPOS : Form
    {
        DataTable Dt;
        
        public frmPOS()
        {
            InitializeComponent();
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


        public void Product_Click(object sender, Product e)
        {
            Update_Total(e.product_price);
            //-----------------------------
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
                        i[5] = Convert.ToInt32(i[5]) * Convert.ToInt32(i[3]);
                        break;
                    }
                }
            }
        }
        private void Update_Total(double price)
        {
            double current_total = Convert.ToDouble(lbTotal.Text);
            lbTotal.Text = (current_total + price).ToString("N0");
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            Dt.Rows.Clear();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (Dt.Rows.Count == 0) MessageBox.Show("The receipt is empty. Please add products before payment!", "Empty Receipt", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else
            {
                ReceiptController.Instance.Receipt_Pay(Dt, lbTotal.Text);
                Dt.Rows.Clear();
            }
        }

        
    }
}
