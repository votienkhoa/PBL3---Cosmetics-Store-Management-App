using PBL3___Cosmetics_Store_Management_App.Infrastructure.Interfaces;
using PBL3___Cosmetics_Store_Management_App.Repositories.Implementations;
using PBL3___Cosmetics_Store_Management_App.Data_Access;
using PBL3___Cosmetics_Store_Management_App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PBL3___Cosmetics_Store_Management_App.Infrastructure.Implementations
{
    internal class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(DbContext context) : base(context)
        {
        }
        public DatabaseContext DatabaseContext
        {
            get { return Context as DatabaseContext; }
        }
        List<Receipt> GetReceitps(string customerId)
        {
            var data = DatabaseContext.Receipts.Where(p => p.customer_id == customerId).ToList();
            return data;
        }

        List<Receipt> ICustomerRepository.GetReceitps(string customerId)
        {
            throw new NotImplementedException();
        }
    }
}
