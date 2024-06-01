using PBL3___Cosmetics_Store_Management_App.Data_Access;
using PBL3___Cosmetics_Store_Management_App.DTO;
using PBL3___Cosmetics_Store_Management_App.Entities;
using PBL3___Cosmetics_Store_Management_App.Repositories.Unit_of_work;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Cosmetics_Store_Management_App.Controllers
{
    public class ReceiptController : SingletonBase<ReceiptController>
    {
        private UnitOfWork unitOfWork = new UnitOfWork(new DatabaseContext());

        public string GenerateID()
        {
            int max = unitOfWork.ReceiptRepo.GetMaxID();
            string date = DateTime.Now.ToString("yyMMdd");

            return "RC" + date + max.ToString("D4");
        }

        public void Receipt_Pay(DataTable receipt, string total)
        {
            string receipt_id = GenerateID();
            Receipt cur = new Receipt()
            {
                receipt_id = receipt_id,
                receipt_date = DateTime.Now,
                receipt_discount = 0,
                receipt_total = Double.Parse(total, System.Globalization.NumberStyles.AllowThousands)
            };
            unitOfWork.ReceiptRepo.Add(cur);

            foreach (DataRow row in receipt.Rows)
            {
                ReceiptDetail detail = new ReceiptDetail()
                {
                    receipt_id = receipt_id,
                    product_id = row[1].ToString(),
                    product_quantity = row[3].ToString()
                };
                unitOfWork.ReceiptDetailRepo.Add(detail);
            }
            
            unitOfWork.Save();
        }
    }
}
