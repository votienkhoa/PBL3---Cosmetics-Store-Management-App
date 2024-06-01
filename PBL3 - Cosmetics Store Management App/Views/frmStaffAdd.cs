using PBL3___Cosmetics_Store_Management_App.Entities;
using PBL3___Cosmetics_Store_Management_App.Controllers;
using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace PBL3___Cosmetics_Store_Management_App
{
    public partial class frmStaffAdd : Form
    {
        public delegate void Mydelegate();
        
        public Mydelegate back { get; set; }
        Staff _staff = new Staff();
        bool Check;
        public frmStaffAdd(bool check, bool checkfrm, Staff staff)
        {
            InitializeComponent();
            setCBBRole();
            Check = check;
            if(check == false)
            {
                staff_id.Text = staff.staff_id;
                staff_id.ReadOnly = true;
                staff_name.Text = staff.staff_name;
                staff_address.Text = staff.staff_address;
                staff_birthday.Value = staff.staff_birthday;
                staff_pass.Text = staff.staff_password;
                staff_phonenumber.Text = staff.staff_PhoneNumber;
                if(staff.staff_role == 1)
                {
                    CbbRole.SelectedItem = "Manager";
                }
                if (staff.staff_role == 2)
                {
                    CbbRole.SelectedItem = "Sales agent";
                }
                if (staff.staff_role == 3)
                {
                    CbbRole.SelectedItem = "StoreKeeper";
                }
            }
            if( checkfrm )
            {
                label1.Text = "Information Staff"; btnSave.Enabled = false;  btnCancel.Text = "Exit";
                staff_id.Text = staff.staff_id;                 staff_id.ReadOnly = true;
                staff_name.Text = staff.staff_name;             staff_name.ReadOnly = true;
                staff_address.Text = staff.staff_address;       staff_address.ReadOnly = true;
                staff_birthday.Value = staff.staff_birthday;    staff_birthday.Enabled = false;
                staff_pass.Text = staff.staff_password;         staff_pass.ReadOnly=true;
                staff_phonenumber.Text = staff.staff_PhoneNumber;   staff_phonenumber.ReadOnly= true;
                if (staff.staff_role == 1)                          CbbRole.Enabled=false;
                {
                    CbbRole.SelectedItem = "Manager";
                }
                if (staff.staff_role == 2)
                {
                    CbbRole.SelectedItem = "Sales agent";
                }
                if (staff.staff_role == 3)
                {
                    CbbRole.SelectedItem = "StoreKeeper";
                }
            }
        }
        public void setCBBRole()
        {
            CbbRole.Items.Add("Manager");
            CbbRole.Items.Add("Sales agent");
            CbbRole.Items.Add("StoreKeeper");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _staff.staff_id = staff_id.Text.ToString();
                _staff.staff_name = staff_name.Text.ToString();
                _staff.staff_birthday = staff_birthday.Value;
                _staff.staff_address = staff_address.Text.ToString();
                _staff.staff_password = staff_pass.Text.ToString();
                _staff.staff_PhoneNumber = staff_phonenumber.Text.ToString();
                if (CbbRole.SelectedItem.ToString() == "Manager")
                    _staff.staff_role = 1;
                if (CbbRole.SelectedItem.ToString() == "Sales agent")
                    _staff.staff_role = 2;
                if (CbbRole.SelectedItem.ToString() == "StoreKeeper")
                    _staff.staff_role = 3;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            if (Check)
            {
                StaffController.Instance.add(_staff);
                back();
                this.Dispose(true);
            }
            else
            {
                StaffController.Instance.update(_staff);
                back();
                this.Dispose();
            }
        }
    }
}
