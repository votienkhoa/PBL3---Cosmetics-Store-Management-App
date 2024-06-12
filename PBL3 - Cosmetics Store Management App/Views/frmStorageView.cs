using PBL3___Cosmetics_Store_Management_App.Controllers;
using PBL3___Cosmetics_Store_Management_App.Entities;
using PBL3___Cosmetics_Store_Management_App.Views;
using System;
using System.Data;
using System.Windows.Forms;

namespace PBL3___Cosmetics_Store_Management_App.View
{
    public partial class frmStorageView : Form
    {
        public Staff currentStaff { get; set; }
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
                    e.Value = ProviderController.Instance.GetByID(Convert.ToInt32(e.Value)).provider_name;
                }
            }
        }
        private void Browse(object sender, EventArgs e)
        {
            frmStorageAdd frmStorageAdd = new frmStorageAdd()
            {
                current_staff = currentStaff
            };
            frmStorageAdd.ShowDialog();
            frmStorageView_Load(sender, e);
        }

        private void dgvImport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvImport.CurrentCell.OwningColumn.Name == "Import_Detail")
            {
                string id = dgvImport.CurrentRow.Cells[0].Value.ToString();
                frmReportDetail frm = new frmReportDetail()
                {
                    import_id = id,
                    report_type = "Import"
                };
                frm.Show();
            }
        }
    }
}
