using PBL3___Cosmetics_Store_Management_App.Controllers;
using PBL3___Cosmetics_Store_Management_App.Entities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PBL3___Cosmetics_Store_Management_App
{
    public partial class usProduct : UserControl
    {
        public Product product { get; set; }
        public event EventHandler<Product> UserControlClick;

        public usProduct()
        {
            InitializeComponent();
            RegisterClick(this);
        }

        private void usProduct_Load(object sender, EventArgs e)
        {
            lbName.Text = product.product_name;
            picProduct.Image = FileHelper.BytesToBitmap(product.product_image);
        }

        private void RegisterClick(Control control)
        {
            control.Click += new EventHandler(RaiseProductClick);
            
            foreach (Control c in control.Controls)
            {
                RegisterClick(c);
            }
        }

        private void RaiseProductClick(object sender, EventArgs e)
        {
            UserControlClick?.Invoke(this, product);
        }        
    }
}
