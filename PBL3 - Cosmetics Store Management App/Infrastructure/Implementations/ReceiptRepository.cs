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
    public class ReceiptRepository : Repository<Receipt>, IReceiptRepository
    {
        public ReceiptRepository(DatabaseContext context)
            : base(context) 
        { }

        public DatabaseContext DatabaseContext
        {
            get { return Context as DatabaseContext; }
        }

        public int GetMaxID()
        {
            int max = 1;

            if (DatabaseContext.Receipts.Any())
            {
                var current_max = DatabaseContext.Receipts.Select(p => p.receipt_id)
                                                          .OrderByDescending(id => id)
                                                          .FirstOrDefault();
                max = int.Parse(current_max.Substring(8)) + 1;
            }
            return max;
        }
    }
}
