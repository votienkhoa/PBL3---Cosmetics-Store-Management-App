using PBL3___Cosmetics_Store_Management_App.Controllers;
using PBL3___Cosmetics_Store_Management_App.Entities;
using PBL3___Cosmetics_Store_Management_App.Repositories.Unit_of_work;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace PBL3___Cosmetics_Store_Management_App.View
{
    public partial class frmProductAdd : Form
    {
        public Product currentProduct = null;
        public frmProductAdd()
        {
            InitializeComponent();
        }

        private void frmProductAdd_Load(object sender, System.EventArgs e)
        {
            cbbCategory.Items.AddRange(CategoryController.Instance.GetAllName().ToArray());

            if (currentProduct != null)
            {
                lbHeader.Text = "Edit Product";

                txtID.Text = currentProduct.product_id;
                txtName.Text = currentProduct.product_name;
                txtOrigin.Text = currentProduct.product_origin;
                txtUnit.Text = currentProduct.product_unit;
                txtPrice.Text = currentProduct.product_price.ToString();
                cbbCategory.SelectedItem = CategoryController.Instance.GetCategory(currentProduct.category_id).category_name;
            }
        }

        private bool checkValid()
        {
            if (currentProduct == null && txtPath.Text == "")
            {
                return false;
            }
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tmp = c as TextBox;
                    if (tmp.Text == "" && tmp.Name != "txtPath") return false;
                }
            }
            return true;
        }

        private void btnBrowse_Click(object sender, System.EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (checkValid() == false || cbbCategory.SelectedItem == null)
            {
                MessageBox.Show("Do not leave any field empty!");
            }
            else
            {
                string name = txtName.Text;
                string origin = txtOrigin.Text;
                string unit = txtUnit.Text;
                string price = txtPrice.Text;
                string category = cbbCategory.SelectedItem.ToString();
                string imagePath = txtPath.Text;

                ProductController.Instance.AddOrUpdate(currentProduct, name, origin, unit, price, category, imagePath);
                this.Dispose();
                
            }

        }

        
    }
}
