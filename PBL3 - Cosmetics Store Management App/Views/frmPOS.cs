using Guna.UI2.WinForms;
using PBL3___Cosmetics_Store_Management_App.Controllers;
using PBL3___Cosmetics_Store_Management_App.Entities;
using System;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PBL3___Cosmetics_Store_Management_App
{
    public partial class frmPOS : Form
    {
        public frmPOS()
        {
            InitializeComponent();
            dgvLoad();
            CategoryButtonLoad();
        }

        private void CategoryButtonLoad()
        {
            Guna2Button All = new Guna2Button();
            All.Text = "All";
            All.BorderRadius = 10;
            All.Animated = true;
            All.Font = new System.Drawing.Font("Segoe UI Semibold", 8.765218F, System.Drawing.FontStyle.Bold);
            All.Size = new System.Drawing.Size(170, 49);
            All.FillColor = System.Drawing.Color.FromArgb(79, 111, 82);
            All.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            All.CheckedChanged += new EventHandler(btnCategory_CheckChange);

            pnCategories.Controls.Add(All);

            foreach (string name in CategoryController.Instance.GetAllName())
            {
                Guna2Button tmp = new Guna2Button();
                tmp.Text = name;
                tmp.BorderRadius = 10;
                tmp.Animated = true;
                tmp.Font = new System.Drawing.Font("Segoe UI Semibold", 8.765218F, System.Drawing.FontStyle.Bold);
                tmp.Size = new System.Drawing.Size(170, 49);
                tmp.FillColor = System.Drawing.Color.FromArgb(79, 111, 82);
                tmp.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                tmp.CheckedChanged += new EventHandler(btnCategory_CheckChange);

                pnCategories.Controls.Add(tmp);
            }
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

        public void dgvLoad()
        {


            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("No", typeof(int)),
                new DataColumn("Name", typeof(string)),
                new DataColumn("Qty", typeof(int)),
                new DataColumn("Price", typeof(int)),
                new DataColumn("Amount", typeof(int))

            });

            dt.Rows.Add(1, "Sữa rửa mặt Innisfree", 1, 150000, 150000);
            dt.Rows.Add(2, "Kem chống nắng Anessa", 2, 130000, 260000);

            foreach (DataRow i in dt.Rows)
            {
                dgvBill.Rows.Add(i.ItemArray);
            }

        }

        public void Product_Click(object sender, Product e)
        {
            MessageBox.Show(e.product_name);
        }

    }
}
