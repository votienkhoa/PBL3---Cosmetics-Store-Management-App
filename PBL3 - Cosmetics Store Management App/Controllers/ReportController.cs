﻿using PBL3___Cosmetics_Store_Management_App.Data_Access;
using PBL3___Cosmetics_Store_Management_App.DTO;
using PBL3___Cosmetics_Store_Management_App.Entities;
using PBL3___Cosmetics_Store_Management_App.Repositories.Implementations;
using PBL3___Cosmetics_Store_Management_App.Repositories.Unit_of_work;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Cosmetics_Store_Management_App.Controllers
{
    internal class ReportController : SingletonBase<ReportController>
    {
        UnitOfWork unitOfWork = new UnitOfWork(new DatabaseContext());

        public DataTable SellByCategory(DateTime start, DateTime end, out double subtotal, out double discount)
        {
            DataTable Dt = new DataTable();
            Dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("category_name", typeof(string)),
                new DataColumn("product_quantity", typeof(int)),
                new DataColumn("amount", typeof(double))
            });
            List<Receipt> valid_receipt = unitOfWork.ReceiptRepo.Find(p => p.receipt_date >= start && p.receipt_date <= end).ToList();
            subtotal = 0;
            discount = 0;
            foreach (Category current_category in unitOfWork.CategoryRepo.GetAll())
            {
                int current_quantity = 0;
                double current_amount = 0;
                foreach (Receipt current_receipt in valid_receipt)
                {
                    foreach (ReceiptDetail current_receiptdetail in current_receipt.receiptdetails)
                    {
                        Product current_product = unitOfWork.ProductRepo.Get(current_receiptdetail.product_id);
                        if (current_product.category_id == current_category.category_id)
                        {
                            current_quantity += current_receiptdetail.product_quantity;
                            current_amount += (current_receiptdetail.product_quantity * current_receiptdetail.product.product_price);         
                            discount += (current_receiptdetail.product_quantity * current_receiptdetail.product.product_price) * current_receipt.receipt_discount / 100;
                        }
                    }
                }
                subtotal += current_amount;

                Dt.Rows.Add(current_category.category_name, current_quantity, current_amount);
            }

            return Dt;
        }
    }
}
