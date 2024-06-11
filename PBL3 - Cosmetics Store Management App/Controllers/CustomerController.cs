using PBL3___Cosmetics_Store_Management_App.DTO;
using PBL3___Cosmetics_Store_Management_App.Entities;
using PBL3___Cosmetics_Store_Management_App.Repositories.Unit_of_work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Cosmetics_Store_Management_App.Controllers
{
    internal class CustomerController : SingletonBase <CustomerController>
    {
        private UnitOfWork unitOfWork = new UnitOfWork(new Data_Access.DatabaseContext());
        public Customer GetByID(string ID)
        {
            return unitOfWork.CustomerRepo.Get(ID);
        }
        public Customer GetByPhone(string number)
        {
            return unitOfWork.CustomerRepo.Find(p => p.customer_phone == number).FirstOrDefault();
        }
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
            DialogResult result = MessageBox.Show("Are you sure you want to delete \"" + data.customer_name + "\" customer?", "Delete Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                foreach (var tmp in data.receipts)
                {
                    tmp.customer_phone = null;
                }
                unitOfWork.CustomerRepo.Remove(data);
                unitOfWork.Save();
            }
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
                return unitOfWork.CustomerRepo.Find(p => p.customer_phone.Contains(m) || p.customer_name.Contains(m)).ToList();
            }
        }
        public List <Customer> ffind(Customer data)
        {
            return unitOfWork.CustomerRepo.Find(p => p.customer_phone.Equals(data.customer_phone)).ToList();
        }
    }
}
