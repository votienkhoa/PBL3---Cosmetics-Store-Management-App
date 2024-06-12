using IronXL;
using PBL3___Cosmetics_Store_Management_App.Data_Access;
using PBL3___Cosmetics_Store_Management_App.DTO;
using PBL3___Cosmetics_Store_Management_App.Entities;
using PBL3___Cosmetics_Store_Management_App.Repositories.Unit_of_work;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Cosmetics_Store_Management_App.Controllers
{
    internal class ImportController : SingletonBase<ImportController>
    {
        private UnitOfWork unitOfWork = new UnitOfWork(new DatabaseContext());

        public Import GetByID(string id)
        {
            return unitOfWork.ImportRepo.Get(id);
        }
        public List<Import> GetAll()
        {
            return unitOfWork.ImportRepo.GetAll().ToList();
        }

        public string GenerateID()
        {
            int m = unitOfWork.ImportRepo.GetMaxID();
            string date = DateTime.Now.ToString("yyMM");

            return "IP" + date + m.ToString("D2");
        }

        public List<ImportDetail> ReadExcelFile(string filePath, out int error)
        {
            List<ImportDetail> list = new List<ImportDetail>();
            error = 0;
            WorkBook workbook = WorkBook.Load(filePath);
            WorkSheet sheet = workbook.WorkSheets[0];

            int row = sheet.RowCount;
            string current_id = GenerateID();

            for (int i = 1; i < row; i++)
            {
                if (unitOfWork.ProductRepo.Get(sheet.GetCellAt(i, 0).Text) == null)
                {
                    error++;
                    continue;
                }
                ImportDetail tmp = new ImportDetail()
                {
                    import_id = current_id,
                    product_id = sheet.GetCellAt(i, 0).Text,
                    product_quantity = Convert.ToInt32(sheet.GetCellAt(i, 1).Text),
                    product_MFG = Convert.ToDateTime(sheet.GetCellAt(i, 2).Text),
                    product_EXP = Convert.ToDateTime(sheet.GetCellAt(i, 3).Text),
                };
                list.Add(tmp);
            }
            return list;
        }

        public void Import(string filePath, string name, string staff_id)
        {
            Import import = new Import()
            {
                import_id= GenerateID(),
                provider_id = unitOfWork.ProviderRepo.GetByName(name).provider_id,
                import_date = DateTime.Now,
                staff_id = staff_id
            };
            unitOfWork.ImportRepo.Add(import);

            int error;
            foreach (ImportDetail x in ReadExcelFile(filePath, out error))
            {
                unitOfWork.ImportDetailRepo.Add(x);

                Product current_product = unitOfWork.ProductRepo.Get(x.product_id);
                current_product.product_stock += x.product_quantity;
                unitOfWork.ProductRepo.Update(current_product);
            }

            if (error > 0)
            {
                DialogResult res =MessageBox.Show("There are " + error.ToString() + " undefined products in your file. Do you want to skip it ?" +
                                                  "\n*Note: If you click cancel, this will be not proceed!",
                                                  "Invalid input",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Error
                                                  );
                if (res == DialogResult.OK)
                {
                    unitOfWork.Save();
                }
            }
            else unitOfWork.Save();
        }
    }
}
