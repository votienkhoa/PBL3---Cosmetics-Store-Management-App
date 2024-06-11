using IronXL;
using PBL3___Cosmetics_Store_Management_App.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace PBL3___Cosmetics_Store_Management_App.View
{
    public partial class frmStorageAdd : Form
    {
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
                    
                }
            }
        }

        private void frmStorageAdd_Load(object sender, System.EventArgs e)
        {

        }

        private List<ImportDetail> ReadExcelFile(string filePath)
        {
            WorkBook workbook = WorkBook.Load(filePath);
            WorkSheet sheet = workbook.WorkSheets[0];

            int row = sheet.RowCount;
            int column = sheet.ColumnCount;

            List<ImportDetail> list = new List<ImportDetail>();
            for (int i = 0; i < row; i++)
            {
                ImportDetail tmp = new ImportDetail()
                {
                    product_id = sheet.GetCellAt(i, 0).Text,
                    product_quantity = Convert.ToInt32(sheet.GetCellAt(i,1).Text),
                    product_MFG = Convert.ToDateTime(sheet.GetCellAt(i,2).Text),
                    product_EXP = Convert.ToDateTime(sheet.GetCellAt(i, 3).Text),
                };
                list.Add(tmp);
            }
            return list;
        }
    }
}
