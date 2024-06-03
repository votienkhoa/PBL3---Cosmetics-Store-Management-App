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
    internal class CustomerController : SingletonBase <CustomerController>
    {
        private UnitOfWork unitOfWork = new UnitOfWork(new Data_Access.DatabaseContext());
        public List <Customer> getData()
        {
            return unitOfWork.CustomerRepo.GetAll().ToList();
        } 
        public void add(Customer data)
        {
            unitOfWork.CustomerRepo.Add(data);
            unitOfWork.Save();
        }
        public void delete(Customer data)
        {
            unitOfWork.CustomerRepo.Remove(data);
            unitOfWork.Save();
        }
        public void update(Customer data)
        {
            unitOfWork.CustomerRepo.Update(data);
            unitOfWork.Save();
        }
        public List <Customer> Search(string m)
        {
            if (m == "")
                return unitOfWork.CustomerRepo.GetAll().ToList();
            else
            {
                return unitOfWork.CustomerRepo.Find(p => p.customer_id.Contains(m) || p.customer_name.Contains(m)).ToList();
            }
        }
    }
}
