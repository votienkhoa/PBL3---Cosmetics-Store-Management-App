using PBL3___Cosmetics_Store_Management_App.DTO;
using PBL3___Cosmetics_Store_Management_App.Presenters;
using System;
using System.Data;
using System.Windows.Forms;

namespace PBL3___Cosmetics_Store_Management_App.View
{
    public partial class frmCategoryView : Form
    {
        public frmCategoryView()
        {
            InitializeComponent();
            
        }
        private void frmLoad()
        {
            dgvCategories.DataSource = Category_Presenter.Instance.ViewCategories();

        }

        private void frmCategoryView_Load(object sender, EventArgs e)
        {
            frmLoad();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCategoryAdd frm = new frmCategoryAdd();
            frm.reload += new frmCategoryAdd.MyDel(frmLoad);
            
            frm.ShowDialog();
        }

        private void dgvCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = Convert.ToInt32(dgvCategories.CurrentRow.Cells["Category_ID"].Value);
            string Name = dgvCategories.CurrentRow.Cells["Category_Name"].Value.ToString();

            Category x = new Category()
            {
                ID = ID,
                Name = Name
            };

            if (dgvCategories.CurrentCell.OwningColumn.Name == "Category_Edit")
            {
                frmCategoryAdd frm = new frmCategoryAdd()
                {
                    currentCategory = x
                };
                frm.reload += new frmCategoryAdd.MyDel(frmLoad);
                frm.Show();
            }

            if (dgvCategories.CurrentCell.OwningColumn.Name == "Category_Del")
            {
                Category_Presenter.Instance.RemoveCategory(x);
                frmLoad();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvCategories.DataSource = Category_Presenter.Instance.SearchCategory(txtSearch.Text);
        }
    }
}
