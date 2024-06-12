using PBL3___Cosmetics_Store_Management_App.DTO;
using PBL3___Cosmetics_Store_Management_App.Entities;
using PBL3___Cosmetics_Store_Management_App.Repositories.Unit_of_work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace PBL3___Cosmetics_Store_Management_App.Controllers
{
    public class ProviderController : SingletonBase<ProviderController>
    {
        UnitOfWork unitOfWork = new UnitOfWork(new Data_Access.DatabaseContext());
        public List<Provider> GetAll()
        {
            return unitOfWork.ProviderRepo.GetAll().ToList();
        }
        public Provider GetByID(int ID)
        {
            return unitOfWork.ProviderRepo.Find(p => p.provider_id == ID).FirstOrDefault();
        }
        public List<string> GetAllName()
        {
            return unitOfWork.ProviderRepo.GetAllName();
        }

        public void Add(string name)
        {
            Provider tmp = new Provider()
            {
                provider_name = name,
            };
            unitOfWork.ProviderRepo.Add(tmp);
            unitOfWork.Save();
        }
        public void Update(int id, string name)
        {
            Provider tmp = new Provider()
            {
                provider_id = id,
                provider_name = name
            };
            unitOfWork.ProviderRepo.Update(tmp);
            unitOfWork.Save();
        }

        public void Delete(int id)
        {
            unitOfWork.ProviderRepo.Remove(GetByID(id));
            unitOfWork.Save();
        }
        public int ProvideCount(int provider_id)
        {
            int cnt = 0;
            foreach (Import import in unitOfWork.ImportRepo.GetAll())
            {
                if (import.provider_id == provider_id) cnt++;
            }
            return cnt;
        }
    }
}
