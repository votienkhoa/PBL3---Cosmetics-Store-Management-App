using System;
using System.Data;
using System.Windows.Forms;

namespace PBL3___Cosmetics_Store_Management_App
{
    public partial class frmPOS : Form
    {
        public frmPOS()
        {
            InitializeComponent();
            dgvLoad();
            AddSample();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        public void AddSample()
        {
            usProduct userControl1 = new usProduct()
            {
                Name = "Nước tẩy trang Bioderma",
                PImage = PBL3___Cosmetics_Store_Management_App.Properties.Resources.bioderma
            };


            usProduct userControl7 = new usProduct()
            {
                Name = "Nước tẩy trang L'Oreal",
                PImage = PBL3___Cosmetics_Store_Management_App.Properties.Resources.loreal
            };

            usProduct userControl3 = new usProduct()
            {
                Name = "Kem chống nắng Anessa",
                PImage = PBL3___Cosmetics_Store_Management_App.Properties.Resources.anessa
            };

            usProduct userControl4 = new usProduct()
            {
                Name = "Kem dưỡng La Roche-Posay",
                PImage = PBL3___Cosmetics_Store_Management_App.Properties.Resources.laroche
            };

            usProduct userControl5 = new usProduct()
            {
                Name = "Kem Obagi Retinol 0.5%",
                PImage = PBL3___Cosmetics_Store_Management_App.Properties.Resources.obagi
            };

            usProduct userControl6 = new usProduct()
            {
                Name = "Mặt nạ Naruko tràm trà",
                PImage = PBL3___Cosmetics_Store_Management_App.Properties.Resources.naruko
            };

            usProduct userControl2 = new usProduct()
            {
                Name = "Sữa rửa mặt Innisfree Trà xanh",
                PImage = PBL3___Cosmetics_Store_Management_App.Properties.Resources.innisfree
            };


            flowLayoutPanel2.Controls.Add(userControl1);
            flowLayoutPanel2.Controls.Add(userControl2);
            flowLayoutPanel2.Controls.Add(userControl3);
            flowLayoutPanel2.Controls.Add(userControl4);
            flowLayoutPanel2.Controls.Add(userControl5);
            flowLayoutPanel2.Controls.Add(userControl6);
            flowLayoutPanel2.Controls.Add(userControl7);

        }

        public void dgvLoad()
        {


            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("No", typeof(int)),
                new DataColumn("Name", typeof(string)),
                new DataColumn("Qty", typeof(int)),
                new DataColumn("Price", typeof(int)),
                new DataColumn("Amount", typeof(int))

            });

            dt.Rows.Add(1, "Sữa rửa mặt Innisfree", 1, 150000, 150000);
            dt.Rows.Add(2, "Kem chống nắng Anessa", 2, 130000, 260000);

            foreach (DataRow i in dt.Rows)
            {
                dgvBill.Rows.Add(i.ItemArray);
            }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {

        }
    }
}
