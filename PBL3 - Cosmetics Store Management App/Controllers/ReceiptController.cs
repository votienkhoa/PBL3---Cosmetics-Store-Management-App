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

        public Receipt GetByID(string id)
        {
            return unitOfWork.ReceiptRepo.Get(id);
        }
        public string GenerateID()
        {
            int max = unitOfWork.ReceiptRepo.GetMaxID();
            string date = DateTime.Now.ToString("yyMMdd");

            return "RC" + date + max.ToString("D4");
        }

        public Receipt Receipt_Pay(DataTable receipt, string subtotal, string staff_id, string txt_discount)
        {
            string receipt_id = GenerateID();
            double discount = (txt_discount == "") ? 0 : Convert.ToDouble(txt_discount);
            Receipt cur = new Receipt()
            {
                receipt_id = receipt_id,
                receipt_date = DateTime.Now,
                receipt_discount = discount,
                receipt_total = Double.Parse(subtotal, System.Globalization.NumberStyles.AllowThousands) * (100 - discount) / 100,       
                staff_id = staff_id,
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
            return cur;
        }

        public void Calculate(DataTable receipt, string txt_discount, out double new_subtotal, out double new_total)
        {
            double discount = (txt_discount == "") ? 0 : Convert.ToDouble(txt_discount);
            double tmp = 0;
            foreach (DataRow row in receipt.Rows)
            {
                tmp += Convert.ToDouble(row[5]);
            }
            new_subtotal = tmp;
            new_total = tmp * (100 - discount) / 100;
        }

        public bool DiscountValidataion(string txt_discount)
        {
            if (txt_discount == "") return true;
            if (Double.TryParse(txt_discount, out double tmp) == false) return false;
            if (tmp > 100 || tmp < 0) return false;
            return true;         
        }

        public List<ReceiptPrint> GetListReceiptPrint(DataTable dt)
        {
            List<ReceiptPrint> receipt_list = new List<ReceiptPrint>();

            foreach (DataRow row in  dt.Rows)
            {
                ReceiptPrint receipt = new ReceiptPrint()
                {
                    number = Convert.ToInt32(row[0]),
                    name = row[2].ToString(),
                    quantity = Convert.ToInt32(row[3]),
                    price = Convert.ToDouble(row[4]),
                    amount = Convert.ToDouble(row[5]),
                };
                receipt_list.Add(receipt);
            }

            return receipt_list;
        } 
    }
}
