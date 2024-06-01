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
    public class ReceiptDetailRepository : Repository<ReceiptDetail>, IReceiptDetailRepository
    {
        public ReceiptDetailRepository(DatabaseContext context)
            : base(context)
        { }

        public DatabaseContext DatabaseContext
        {
            get { return Context as DatabaseContext; }
        }
    }
}
