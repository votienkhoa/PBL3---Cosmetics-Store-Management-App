using PBL3___Cosmetics_Store_Management_App.Data_Access;
using PBL3___Cosmetics_Store_Management_App.Repositories.Implementations;
using PBL3___Cosmetics_Store_Management_App.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Cosmetics_Store_Management_App.Repositories.Unit_of_work
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext Context;
        private ICategoryRepository _CategoryRepo;
        private IProductRepository _ProductRepo;

        public UnitOfWork(DatabaseContext context)
        {
            Context = context;
        }

        #region Constructor
        public ICategoryRepository CategoryRepo
        {
            get
            {
                if (_CategoryRepo == null)
                {
                    _CategoryRepo = new CategoryRepository(Context);
                }
                return _CategoryRepo;
            }
        }
        public IProductRepository ProductRepo
        {
            get
            {
                if (_ProductRepo == null)
                {
                    _ProductRepo = new ProductRepository(Context);
                }
                return _ProductRepo;
            }
        }
        #endregion

        #region Method
        public void Save()
        {
            if (Context.SaveChanges() > 0) MessageBox.Show("Successfully");
            else MessageBox.Show("Failed");
        }

        public void Dispose()
        {
            Context.Dispose();
        }
        #endregion
    }
}
