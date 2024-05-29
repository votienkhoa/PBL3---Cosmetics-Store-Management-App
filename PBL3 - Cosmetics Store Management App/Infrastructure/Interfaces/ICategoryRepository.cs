using PBL3___Cosmetics_Store_Management_App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Cosmetics_Store_Management_App.Repositories.Interfaces
{
    public interface ICategoryRepository : IRepository<Category>
    {
        List<string> GetAllName();
        int GetID(string name);
        Category GetByID(int id);
    }
}
