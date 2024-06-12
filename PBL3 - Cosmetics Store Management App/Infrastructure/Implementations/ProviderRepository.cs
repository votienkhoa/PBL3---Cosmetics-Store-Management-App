using PBL3___Cosmetics_Store_Management_App.Data_Access;
using PBL3___Cosmetics_Store_Management_App.Entities;
using PBL3___Cosmetics_Store_Management_App.Infrastructure.Interfaces;
using PBL3___Cosmetics_Store_Management_App.Repositories.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Cosmetics_Store_Management_App.Infrastructure.Implementations
{
    public class ProviderRepository : Repository<Provider>, IProviderRepository
    {
        public ProviderRepository(DatabaseContext context)
            : base(context)
        {

        }
        public DatabaseContext DatabaseContext
        {
            get { return Context as DatabaseContext; }
        }

        public List<string> GetAllName()
        {
            return DatabaseContext.Providers.Select(p => p.provider_name).ToList();
        }

        public Provider GetByName(string name)
        {
            return Find(p => p.provider_name == name).FirstOrDefault();
        }
    }
}
