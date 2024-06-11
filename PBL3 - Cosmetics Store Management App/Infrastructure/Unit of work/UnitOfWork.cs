using PBL3___Cosmetics_Store_Management_App.Data_Access;
using PBL3___Cosmetics_Store_Management_App.Infrastructure.Implementations;
using PBL3___Cosmetics_Store_Management_App.Infrastructure.Interfaces;
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
        private IReceiptRepository _ReceiptRepo;
        private IReceiptDetailRepository _ReceiptDetailRepo;
        private IStaffRepository _StaffRepo;
        private ICustomerRepository _CustomerRepo;
        private IImportRepository _ImportRepo;
        private IImportDetailRepository _ImportDetailRepo;


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
        public IReceiptRepository ReceiptRepo
        {
            get
            {
                if (_ReceiptRepo == null)
                {
                    _ReceiptRepo = new ReceiptRepository(Context);
                }
                return _ReceiptRepo;
            }
        }

        public IReceiptDetailRepository ReceiptDetailRepo
        {
            get
            {
                if (_ReceiptDetailRepo == null)
                {
                    _ReceiptDetailRepo = new ReceiptDetailRepository(Context);
                }
                return _ReceiptDetailRepo;
            }
        }
        public IStaffRepository StaffRepo
        {
            get
            {
                if (_StaffRepo == null)
                {
                    _StaffRepo = new StaffRepository(Context);
                }
                return _StaffRepo;
            }
        }
        public ICustomerRepository CustomerRepo
        {
            get
            {
                if (_CustomerRepo == null) 
                {
                    _CustomerRepo = new CustomerRepository(Context);
                }
                return _CustomerRepo;
            }
        }
        public IImportRepository ImportRepo
        {
            get
            {
                if (_ImportRepo == null)
                {
                    _ImportRepo = new ImportRepository(Context);
                }
                return _ImportRepo;
            }
        }
        public IImportDetailRepository ImportDetailRepo
        {
            get
            {
                if (_ImportDetailRepo == null)
                {
                    _ImportDetailRepo = new ImportDetailRepository(Context);
                }
                return _ImportDetailRepo;
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
