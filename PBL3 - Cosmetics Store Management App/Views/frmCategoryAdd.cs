using PBL3___Cosmetics_Store_Management_App.Controllers;
using PBL3___Cosmetics_Store_Management_App.DTO;
using PBL3___Cosmetics_Store_Management_App.Entities;
using System.Windows.Forms;

namespace PBL3___Cosmetics_Store_Management_App.View
{
    public partial class frmCategoryAdd : Form
    {
        public Category currentCategory = null;
        public frmCategoryAdd()
        {
            InitializeComponent();
        }

        private void frmCategoryAdd_Load(object sender, System.EventArgs e)
        {
            if (currentCategory != null)
            {
                label1.Text = "Edit Category";
                txtName.Text = currentCategory.category_name;
            }
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter name!");
                return;
            }
            if (currentCategory == null)
            {
                CategoryController.Instance.Add(txtName.Text);
            }
            else
            {
                CategoryController.Instance.Update(currentCategory, txtName.Text);
            }
            this.Dispose();
        }
        
    }
}
