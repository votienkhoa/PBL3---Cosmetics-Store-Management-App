using PBL3___Cosmetics_Store_Management_App.Infrastructure.Interfaces;
using PBL3___Cosmetics_Store_Management_App.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Cosmetics_Store_Management_App.Repositories.Unit_of_work
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository CategoryRepo { get; }
        IProductRepository ProductRepo { get; }
        IReceiptRepository ReceiptRepo { get; }
        IReceiptDetailRepository ReceiptDetailRepo { get; }
        IStaffRepository StaffRepo { get; }

        void Save();

    }
}
