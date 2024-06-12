using PBL3___Cosmetics_Store_Management_App.DTO;
using PBL3___Cosmetics_Store_Management_App.Entities;
using PBL3___Cosmetics_Store_Management_App.Repositories.Unit_of_work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Cosmetics_Store_Management_App.Controllers
{
    public class ProviderController : SingletonBase<ProviderController>
    {
        UnitOfWork unitOfWork = new UnitOfWork(new Data_Access.DatabaseContext());

        public Provider GetByID(string ID)
        {
            return unitOfWork.ProviderRepo.Get(ID);
        }
        public List<string> GetAllName()
        {
            return unitOfWork.ProviderRepo.GetAllName();
        }
    }
}
