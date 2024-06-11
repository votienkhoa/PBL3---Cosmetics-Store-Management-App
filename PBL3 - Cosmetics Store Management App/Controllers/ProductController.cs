using PBL3___Cosmetics_Store_Management_App.DTO;
using PBL3___Cosmetics_Store_Management_App.Entities;
using PBL3___Cosmetics_Store_Management_App.Repositories.Unit_of_work;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Cosmetics_Store_Management_App.Controllers
{
    internal class ProductController : SingletonBase<ProductController>
    {
        private UnitOfWork unitOfWork = new UnitOfWork(new Data_Access.DatabaseContext());

        public List<Product> GetData()
        {
            return unitOfWork.ProductRepo.GetAll().ToList();
        }

        public Product GetByID(string id)
        {
            return unitOfWork.ProductRepo.Get(id);
        }

        public List<Product> GetByCategory(string category)
        {
            if (category == "") return unitOfWork.ProductRepo.GetAll().ToList();
            return unitOfWork.ProductRepo.Find(p => p.category.category_name == category).ToList();
        }

        public List<Product> Search(string txt)
        {
            if (txt == "")
            {
                return unitOfWork.ProductRepo.GetAll().ToList();
            }
            else
            {
                return unitOfWork.ProductRepo.Find(p => p.product_name.Contains(txt)
                                                     || p.product_id.Contains(txt)
                                                   ).ToList();
            }
        }

        public void AddOrUpdate(Product oldProduct, string name, string id, string origin, string unit, string price, string category, string image)
        {
            double tmp;
            if (!double.TryParse(price, out tmp))
            {
                MessageBox.Show("Please input a valid Price!");
                return;
            }
            //-------------------------------------
            Product product = new Product()
            {
                product_name = name,
                product_id = id,
                product_origin = origin,
                product_unit = unit,
                product_price = tmp,
                category_id = unitOfWork.CategoryRepo.GetID(category)
            };
            if (image == "" && oldProduct != null)
            {
                product.product_image = oldProduct.product_image;
            }
            else
            {
                product.product_image = FileHelper.PathToBytes(image);
            }

            unitOfWork.ProductRepo.Update(product);
            unitOfWork.Save();
        }

        public void Delete(Product product)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete \"" + product.product_name + "\" category?", "Delete Category", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                unitOfWork.ProductRepo.Remove(product);
                unitOfWork.Save();
            }
        }


    }
}
