using System;
using System.Data;
using System.Windows.Forms;

namespace PBL3___Cosmetics_Store_Management_App.View
{
    public partial class frmStorageView : Form
    {
        public frmStorageView()
        {
            InitializeComponent();
            dgvLoad();
        }

        public void dgvLoad()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Name", typeof(string)),
                new DataColumn("Quantity", typeof(int)),
                new DataColumn("MFG", typeof (DateTime)),
                new DataColumn("EXP", typeof (DateTime))
            });

            dt.Rows.Add("Sữa rửa mặt Innisfree", 30, new DateTime(2023, 6, 30).Date, new DateTime(2025, 6, 30));
            dt.Rows.Add("Sữa rửa mặt Innisfree", 20, new DateTime(2024, 5, 12), new DateTime(2026, 5, 12));
            dt.Rows.Add("Kem chống nắng Annesa", 50, new DateTime(2022, 2, 28), new DateTime(2025, 8, 28));
            dt.Rows.Add("Kem chống nắng Annesa", 20, new DateTime(2024, 1, 17), new DateTime(2027, 6, 17));
            dt.Rows.Add("Serum Ordinary B5", 100, new DateTime(2024, 3, 26), new DateTime(2025, 3, 26));

            foreach (DataRow i in dt.Rows)
            {
                dgvStaff.Rows.Add(i.ItemArray);
            }

        }

        private void Browse(object sender, EventArgs e)
        {
            frmStorageAdd frmStorageAdd = new frmStorageAdd();
            frmStorageAdd.Show();
        }
    }
}
