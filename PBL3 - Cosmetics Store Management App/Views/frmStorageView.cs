using PBL3___Cosmetics_Store_Management_App.Controllers;
using PBL3___Cosmetics_Store_Management_App.Entities;
using System;
using System.Data;
using System.Windows.Forms;

namespace PBL3___Cosmetics_Store_Management_App.View
{
    public partial class frmStorageView : Form
    {
        public Staff current_staff { get; set; }
        public frmStorageView()
        {
            InitializeComponent();
            dgvImport.AutoGenerateColumns = false;
        }
        private void frmStorageView_Load(object sender, EventArgs e)
        {
            var x = ImportController.Instance.GetAll();
            x.Reverse();
            dgvImport.DataSource = x;
        }
        private void dgvImport_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvImport.Columns[e.ColumnIndex].Name == "Provider")
            {
                if (e.Value != null)
                {
                    e.Value = ProviderController.Instance.GetByID(e.Value.ToString()).provider_name;
                }
            }
        }
        private void Browse(object sender, EventArgs e)
        {
            frmStorageAdd frmStorageAdd = new frmStorageAdd()
            {
                current_staff = current_staff,
            };
            frmStorageAdd.ShowDialog();
            frmStorageView_Load(sender, e);
        }

        
    }
}
