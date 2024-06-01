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
    internal class StaffController : SingletonBase<StaffController>
    {
        private UnitOfWork unitOfWork = new UnitOfWork(new Data_Access.DatabaseContext());
        public List<Staff> getData()
        {
            return unitOfWork.StaffRepo.GetAll().ToList();
        }
        public void add(Staff data) 
        {
            unitOfWork.StaffRepo.Add(data);
            unitOfWork.Save();
        }
        public Staff getstaff(string id)
        {
            return unitOfWork.StaffRepo.Get(id);
        }
        public void update(Staff data) 
        {
            unitOfWork.StaffRepo.Update(data);
            unitOfWork.Save();
        }
        public void Delete(Staff data)
        {
            unitOfWork.StaffRepo.Remove(data);
            unitOfWork.Save();
        }
        public List<Staff> Search(string m)
        {
            if( m == "")
                return unitOfWork.StaffRepo.GetAll().ToList();
            else
            {
                return unitOfWork.StaffRepo.Find(p => p.staff_name.Contains(m)|| p.staff_id.Contains(m)).ToList() ;
            } 
                
        }
        public Staff login(string username, string password)
        {
            return unitOfWork.StaffRepo.Find(p => p.staff_id == username && p.staff_password== password).FirstOrDefault();
        }
    }
}
