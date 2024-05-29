using PBL3___Cosmetics_Store_Management_App.Controllers;
using PBL3___Cosmetics_Store_Management_App.Entities;
using System.Drawing;
using System.Windows.Forms;

namespace PBL3___Cosmetics_Store_Management_App.View
{
    public partial class frmProductDetails : Form
    {
        public Product currentProduct = null;
        public frmProductDetails()
        {
            InitializeComponent();
        }

        private void frmProductDetails_Load(object sender, System.EventArgs e)
        {
            lbID.Text = currentProduct.product_id;
            lbName.Text = currentProduct.product_name;
            lbOrigin.Text = currentProduct.product_origin;
            lbUnit.Text = currentProduct.product_unit;
            lbPrice.Text = currentProduct.product_price.ToString();
            lbCategory.Text = CategoryController.Instance.GetCategory(currentProduct.category_id).category_name;
            imgProduct.Image = FileHelper.BytesToBitmap(currentProduct.product_image);
        }
    }
}
