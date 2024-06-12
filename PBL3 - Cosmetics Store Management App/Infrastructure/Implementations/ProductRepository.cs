using PBL3___Cosmetics_Store_Management_App.Data_Access;
using PBL3___Cosmetics_Store_Management_App.Entities;
using PBL3___Cosmetics_Store_Management_App.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Cosmetics_Store_Management_App.Repositories.Implementations
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(DatabaseContext context)
            : base(context)
        { }
        public DatabaseContext DatabaseContext
        {
            get { return Context as DatabaseContext; }
        }
        public int GetMaxID()
        {
            int max = 1;

            if (DatabaseContext.Products.Any())
            {
                string tmp_id = "SP" + "0000";
                var current_max = DatabaseContext.Products.Where(i => string.Compare(i.product_id, tmp_id) == 1)
                                                          .Select(p => p.product_id)
                                                          .OrderByDescending(id => id)
                                                          .FirstOrDefault();

                if (current_max == null)
                {
                    return 1;
                }
                max = int.Parse(current_max.Substring(2)) + 1;
            }
            return max;
        }
    }
}
