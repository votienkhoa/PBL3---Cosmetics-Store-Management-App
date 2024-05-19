using System;
using System.Drawing;
using System.Windows.Forms;

namespace PBL3___Cosmetics_Store_Management_App
{
    public partial class usProduct : UserControl
    {
        public usProduct()
        {
            InitializeComponent();
        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

        public string Name
        {
            get { return lbName.Text; }
            set { lbName.Text = value; }
        }

        public Image PImage
        {
            get { return picProduct.Image; }
            set { picProduct.Image = value; }
        }
    }
}
