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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string acc = txtUsername.Text;
            string pass = txtPassword.Text;
            Entities.Staff _staff= StaffController.Instance.login(acc, pass);
            if (_staff == null)
            {
                MessageBox.Show("Incorrect password or username!", "Login failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (_staff.staff_role == 1)
            {
                frmMain frm = new frmMain()
                {
                    currentStaff = _staff
                };
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
            else if (_staff.staff_role == 2)
            {
                MessageBox.Show("called1");
                this.Hide();
                frmPOS frmMain = new frmPOS();
                frmMain.ShowDialog();
                this.Close();
            }
            else if (_staff.staff_role == 3)
            {
                MessageBox.Show("called2");
                this.Hide();
                frmStorageView frmMain = new frmStorageView();
                frmMain.ShowDialog();
                this.Close();
            }
        }
    }
}
