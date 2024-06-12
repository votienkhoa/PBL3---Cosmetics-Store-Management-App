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
    public partial class frmProviderAdd : Form
    {
        public Provider current_provider = null;
        public frmProviderAdd()
        {
            InitializeComponent();
        }
        private void frmProviderAdd_Load(object sender, EventArgs e)
        {
            if (current_provider != null)
            {
                label1.Text = "Edit Provider";
                txtName.Text = current_provider.provider_name;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter name!");
                return;
            }
            if (current_provider == null)
            {
                ProviderController.Instance.Add(txtName.Text);
            }
            else
            {
                ProviderController.Instance.Update(current_provider.provider_id, txtName.Text);
            }
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        
    }
}
