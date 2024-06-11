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
    public class ImportRepository : Repository<Import>, IImportRepository
    {
        public ImportRepository(DatabaseContext context)
            : base(context)
        { }

        public DatabaseContext DatabaseContext
        {
            get { return Context as DatabaseContext; }
        }

        public int GetMaxID()
        {
            string date = DateTime.Now.ToString("yyMM");
            string tmp_id = "IP" + date + "00";
            
            string current_max = DatabaseContext.Imports.Where(p => string.Compare(p.import_id, tmp_id) == 1)
                                                         .Select(i => i.provider_id)
                                                         .OrderByDescending(id => id)
                                                         .FirstOrDefault();

            if (current_max == null) return 1;
            return Convert.ToInt32(current_max.Substring(6)) + 1;
        }
    }
}
