using PBL3___Cosmetics_Store_Management_App.Entities;
using System;
using System.Data.Entity;
using System.Linq;

namespace PBL3___Cosmetics_Store_Management_App.Data_Access
{
    public class DatabaseContext : DbContext
    {
        // Your context has been configured to use a 'DatabaseContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'PBL3___Cosmetics_Store_Management_App.Data_Access.DatabaseContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DatabaseContext' 
        // connection string in the application configuration file.
        public DatabaseContext()
            : base("name=DatabaseContext")
        {
            var init = new MigrateDatabaseToLatestVersion<DatabaseContext, Migrations.Configuration>();
            Database.SetInitializer(init);
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Receipt> Receipts { get; set; }
        public virtual DbSet<ReceiptDetail> ReceiptsDetails { get; set;}
        public virtual DbSet<Staff> Staffs { get; set; }



        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }
}