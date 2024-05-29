using PBL3___Cosmetics_Store_Management_App.Data_Access;
using PBL3___Cosmetics_Store_Management_App.Entities;
using PBL3___Cosmetics_Store_Management_App.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Cosmetics_Store_Management_App.Repositories.Implementations
{
    public class CategoryRepository : Repository<Category> , ICategoryRepository
    {
        public CategoryRepository(DatabaseContext context)
            : base(context)
        { }

        public DatabaseContext DatabaseContext
        {
            get { return Context as DatabaseContext; }
        }

        public List<string> GetAllName()
        {
            var data = DatabaseContext.Categories.Select(p => p.category_name.ToString()).ToList();
            return data;
        }

        public int GetID(string name)
        {
            var data = DatabaseContext.Categories.Where(p => p.category_name == name).Select(p => p.category_id).FirstOrDefault();
            return Convert.ToInt32(data);
        }

        public Category GetByID(int id)
        {
            return DatabaseContext.Categories.Find(id);
        }
    }
}
