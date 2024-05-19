using PBL3___Cosmetics_Store_Management_App.DTO;
using PBL3___Cosmetics_Store_Management_App.Presenters;
using System.Windows.Forms;

namespace PBL3___Cosmetics_Store_Management_App.View
{
    public partial class frmCategoryAdd : Form
    {
        public Category currentCategory = null;
        public delegate void MyDel();
        public MyDel reload { get; set; }
        public frmCategoryAdd()
        {
            InitializeComponent();
        }

        private void frmCategoryAdd_Load(object sender, System.EventArgs e)
        {
            if (currentCategory != null)
            {
                label1.Text = "Edit Category";
                txtName.Text = currentCategory.Name;
            }
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            string name = txtName.Text;
            Category_Presenter.Instance.AddOrEditCategory(currentCategory, name);

            reload();
            this.Dispose();
        }
        
    }
}
