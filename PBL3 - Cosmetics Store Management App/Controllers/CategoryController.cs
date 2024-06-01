using PBL3___Cosmetics_Store_Management_App.DTO;
using PBL3___Cosmetics_Store_Management_App.Entities;
using PBL3___Cosmetics_Store_Management_App.Repositories.Unit_of_work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace PBL3___Cosmetics_Store_Management_App.Controllers
{
    internal class CategoryController : SingletonBase<CategoryController>
    {
        private UnitOfWork unitOfWork = new UnitOfWork(new Data_Access.DatabaseContext());

        public List<Category> GetData()
        {
            return unitOfWork.CategoryRepo.GetAll().ToList();
        }
        public List<string> GetAllName()
        {
            return unitOfWork.CategoryRepo.GetAllName();
        }
        public Category GetCategory(int id)
        {
            return unitOfWork.CategoryRepo.GetByID(id);
        }
        public List<Category> Search(string txt)
        {
            if (txt == "")
            {
                return unitOfWork.CategoryRepo.GetAll().ToList();
            }
            else
            {
                return unitOfWork.CategoryRepo.Find(p => p.category_name.Contains(txt)
                                                      || p.category_id.ToString().Contains(txt)
                                                      ).ToList();  
            }
        }

        public void Add(string name)
        {
            Category category = new Category()
            {
                category_name = name,
            };
            unitOfWork.CategoryRepo.Add(category);
            unitOfWork.Save();
        }
        
        public void Update(Category category, string name)
        {
            category.category_name = name;
            unitOfWork.CategoryRepo.Update(category);
            unitOfWork.Save();
        }
        
        public void Delete(Category category)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete \"" + category.category_name + "\" category?", "Delete Category", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                unitOfWork.CategoryRepo.Remove(category);
                unitOfWork.Save();
            }
        }
    }
}
