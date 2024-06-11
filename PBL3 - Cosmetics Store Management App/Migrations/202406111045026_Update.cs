namespace PBL3___Cosmetics_Store_Management_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.receipts", "customer_id", "dbo.Customer");
            RenameColumn(table: "dbo.receipts", name: "customer_id", newName: "customer_phone");
            RenameIndex(table: "dbo.receipts", name: "IX_customer_id", newName: "IX_customer_phone");
            DropPrimaryKey("dbo.customer");
            AlterColumn("dbo.customer", "customer_phone", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.customer", "customer_phone");
            AddForeignKey("dbo.receipts", "customer_phone", "dbo.customer", "customer_phone");
            DropColumn("dbo.customer", "customer_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.customer", "customer_id", c => c.String(nullable: false, maxLength: 128));
            DropForeignKey("dbo.receipts", "customer_phone", "dbo.customer");
            DropPrimaryKey("dbo.customer");
            AlterColumn("dbo.customer", "customer_phone", c => c.String());
            AddPrimaryKey("dbo.customer", "customer_id");
            RenameIndex(table: "dbo.receipts", name: "IX_customer_phone", newName: "IX_customer_id");
            RenameColumn(table: "dbo.receipts", name: "customer_phone", newName: "customer_id");
            AddForeignKey("dbo.receipts", "customer_id", "dbo.Customer", "customer_id");
        }
    }
}
