using PBL3___Cosmetics_Store_Management_App.Controllers;
using PBL3___Cosmetics_Store_Management_App.View;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void Open_Form(Form frm)
        {
            this.Hide();
            frm.ShowDialog();

            txtPassword.Text = "";
            txtUsername.Text = "";

            this.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string acc = txtUsername.Text;
            string pass = txtPassword.Text;
            Entities.Staff _staff= StaffController.Instance.login(acc, pass);
            if (_staff == null)
            {
                MessageBox.Show("Incorrect password or username!", "Login failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form frm = null;
                switch (_staff.staff_role)
                {
                    case 1:
                        frm = new frmMain() { currentStaff = _staff};
                        break;
                    case 2:
                        frm = new frmPOS() { currentStaff = _staff};
                        break;
                    case 3:
                        frm = new frmStorageView() { currentStaff = _staff};
                        break;
                }
                Open_Form(frm);
            }
        }
    }
}
