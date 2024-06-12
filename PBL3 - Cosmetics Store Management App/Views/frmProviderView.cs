using PBL3___Cosmetics_Store_Management_App.Controllers;
using PBL3___Cosmetics_Store_Management_App.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Cosmetics_Store_Management_App.Views
{
    public partial class frmProviderView : Form
    {
        public frmProviderView()
        {
            InitializeComponent();
            dgvProviders.AutoGenerateColumns = false;
        }

        private void frmProviderView_Load(object sender, EventArgs e)
        {
            frmLoad();
        }
        private void frmLoad()
        {
            dgvProviders.DataSource = ProviderController.Instance.GetAll();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmProviderAdd frm = new frmProviderAdd();
            frm.ShowDialog();

            frmLoad();
        }

        private void dgvProviders_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            if (dgvProviders.Columns[e.ColumnIndex].Name == "provide_times")
            {
                var row = dgvProviders.Rows[e.RowIndex];
                e.Value = ProviderController.Instance.ProvideCount(Convert.ToInt32(row.Cells[0].Value));
            }
        }

        private void dgvProviders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = Convert.ToInt32(dgvProviders.CurrentRow.Cells[0].Value);
            Provider tmp = ProviderController.Instance.GetByID(ID);
            if (dgvProviders.CurrentCell.OwningColumn.Name == "Provider_Edit")
            {
                frmProviderAdd frm = new frmProviderAdd()
                {
                    current_provider = tmp
                };
                frm.ShowDialog();
            }
            if (dgvProviders.CurrentCell.OwningColumn.Name == "Provider_Delete")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete provider \"" + tmp.provider_name + "\"?", "Delete Provider", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    ProviderController.Instance.Delete(ID);
                }
            }
            frmLoad();
        }
    }
}
