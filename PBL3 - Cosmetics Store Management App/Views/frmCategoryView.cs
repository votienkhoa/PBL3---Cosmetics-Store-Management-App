using PBL3___Cosmetics_Store_Management_App.Controllers;
using PBL3___Cosmetics_Store_Management_App.Data_Access;
using PBL3___Cosmetics_Store_Management_App.DTO;
using PBL3___Cosmetics_Store_Management_App.Entities;
using System;
using System.Data;
using System.Linq;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace PBL3___Cosmetics_Store_Management_App.View
{
    public partial class frmCategoryView : Form
    {
        public frmCategoryView()
        {
            InitializeComponent();
        }
        private void frmCategoryView_Load(object sender, EventArgs e)
        {
            frmLoad();
        }


        private void frmLoad()
        {
            dgvCategories.DataSource = CategoryController.Instance.GetData();
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
            
            Category cur = CategoryController.Instance.GetCategory(ID);

            if (dgvCategories.CurrentCell.OwningColumn.Name == "Category_Edit")
            {
                frmCategoryAdd frm = new frmCategoryAdd()
                {
                    currentCategory = cur
                };
                frm.reload += new frmCategoryAdd.MyDel(frmLoad);
                frm.ShowDialog ();
            }

            if (dgvCategories.CurrentCell.OwningColumn.Name == "Category_Del")
            {
                CategoryController.Instance.Delete(cur);
            }

            frmLoad();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvCategories.DataSource = CategoryController.Instance.Search(txtSearch.Text);
        }
    }
}
