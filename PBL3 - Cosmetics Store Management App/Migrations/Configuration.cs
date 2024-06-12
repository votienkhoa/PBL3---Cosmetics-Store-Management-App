namespace PBL3___Cosmetics_Store_Management_App.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PBL3___Cosmetics_Store_Management_App.Data_Access.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(PBL3___Cosmetics_Store_Management_App.Data_Access.DatabaseContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Staffs.AddOrUpdate(new Entities.Staff()
            {
                staff_id = "MNG-000",
                staff_name = "Admin",
                staff_PhoneNumber = "0905599024",
                staff_birthday = DateTime.Now,
                staff_address = "Da Nang",
                staff_password = "admin",
                staff_role = 1
            });

        }
    }
}
