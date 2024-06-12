using IronXL;
using PBL3___Cosmetics_Store_Management_App.Controllers;
using PBL3___Cosmetics_Store_Management_App.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace PBL3___Cosmetics_Store_Management_App.View
{
    public partial class frmStorageAdd : Form
    {
        public Staff current_staff {  get; set; }
        public frmStorageAdd()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
        }

        private void btnBrowse_Click(object sender, System.EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                openFileDialog.Title = "Select an Excel file";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (FileHelper.IsFileLocked(openFileDialog.FileName))
                    {
                        MessageBox.Show("The file is already open by another process!");
                    }
                    else
                    {
                        txtPath.Text = openFileDialog.FileName;
                    }
                }
            }
        }

        private void frmStorageAdd_Load(object sender, System.EventArgs e)
        {
            cbbProvider.Items.AddRange(ProviderController.Instance.GetAllName().ToArray());

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPath.Text == "" || cbbProvider.SelectedItem == null)
            {
                MessageBox.Show("Do not leave any field empty!", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ImportController.Instance.Import(txtPath.Text, cbbProvider.SelectedItem.ToString(), current_staff.staff_id);
                Close();
            }
        }

        private void btnInstruction_Click(object sender, EventArgs e)
        {
            MessageBox.Show("*INSTRUCTION:  The correct format for the Excel file to be submitted is as follows:" +
                            "\r\n\n- The file must contain exactly 4 columns." +
                            "\r\n- The first column should be the product code (which already exists in the system).\r\n- The second column should be the quantity of the product." +
                            "\r\n- The third and fourth columns should be the production date and the expiry date, respectively." +
                            "\r\n- System will read from the second row (first row is header)",
                            "Instruction"
                            );
        }
    }
}
