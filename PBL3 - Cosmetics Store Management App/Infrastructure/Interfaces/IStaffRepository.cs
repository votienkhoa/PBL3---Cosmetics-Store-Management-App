using PBL3___Cosmetics_Store_Management_App.Entities;
using PBL3___Cosmetics_Store_Management_App.Repositories.Implementations;
using PBL3___Cosmetics_Store_Management_App.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Cosmetics_Store_Management_App.Infrastructure.Interfaces
{
    public interface IStaffRepository: IRepository<Staff>
    {
        Staff GetStaffByID(string id);
    }
}
