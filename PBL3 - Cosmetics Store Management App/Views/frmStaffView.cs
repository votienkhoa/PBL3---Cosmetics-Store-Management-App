using PBL3___Cosmetics_Store_Management_App.Controllers;
using PBL3___Cosmetics_Store_Management_App.Entities;
using System;
using System.Data;
using System.Windows.Forms;

namespace PBL3___Cosmetics_Store_Management_App.View
{
    public partial class frmStaffView : Form
    {
        public Staff current_staff {  get; set; }
        public frmStaffView()
        {
            InitializeComponent();
            frmLoad();

        }
        private void frmLoad()
        {
            dtgv_staff.AutoGenerateColumns= false;
            dtgv_staff.DataSource = StaffController.Instance.getData();
        }
       

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            frmStaffAdd frm = new frmStaffAdd(true,false,staff);
            frm.back += new frmStaffAdd.Mydelegate(frmLoad);

            frm.ShowDialog();
        }



        private void dtgv_staff_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtgv_staff.Columns[e.ColumnIndex].Name == "Staff_role")
            {
                if (e.Value != null && int.TryParse(e.Value.ToString(), out int value))
                {
                    if (value == 1)
                    {
                        e.Value = "Manager";
                        e.FormattingApplied = true;
                    }
                    else if (value == 2)
                    {
                        e.Value = "Sales agent";
                        e.FormattingApplied = true;
                    }
                    else if (value == 3)
                    {
                        e.Value = "StoreKeeper";
                        e.FormattingApplied = true;
                    }
                }
            }
        }

        private void dtgv_staff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id_staff = dtgv_staff.SelectedCells[0].Value.ToString();
            Staff staff = StaffController.Instance.getstaff(id_staff);
            if(dtgv_staff.CurrentCell.OwningColumn.Name == "Staff_edit_button") 
            {
                frmStaffAdd frm = new frmStaffAdd(false,false, staff); 
                frm.back += new frmStaffAdd.Mydelegate(frmLoad);
                frm.ShowDialog();
            }
            if (dtgv_staff.CurrentCell.OwningColumn.Name == "Staff_detail_button")
            {
                frmStaffAdd frm = new frmStaffAdd(false, true, staff); 
                frm.back += new frmStaffAdd.Mydelegate(frmLoad);
                frm.ShowDialog();
            }
            if (dtgv_staff.CurrentCell.OwningColumn.Name == "Staff_dele_button")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete staff \"" + staff.staff_id + "\"?" +
                                                  "\nThis can be affect your data!!", "Delete Staff", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (staff.staff_id == current_staff.staff_id)
                    {
                        MessageBox.Show("You can't delete your account", "Invalid operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    StaffController.Instance.Delete(staff);
                    frmLoad();
                }
                
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string m = Searchtxtbox.Text;
            dtgv_staff.DataSource= StaffController.Instance.Search(m);
        }
    }

}
