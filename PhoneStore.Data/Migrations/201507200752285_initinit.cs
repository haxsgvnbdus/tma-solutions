namespace PhoneStore.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initinit : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductComments", "Customer_ID", "dbo.Customers");
            DropIndex("dbo.ProductComments", new[] { "Customer_ID" });
            RenameColumn(table: "dbo.ProductComments", name: "Customer_ID", newName: "UserID");
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 20),
                        Email = c.String(maxLength: 50),
                        Password = c.String(maxLength: 50),
                        Privilege = c.Int(),
                    })
                .PrimaryKey(t => t.UserID);
            
            AlterColumn("dbo.ProductComments", "UserID", c => c.Int(nullable: false));
            CreateIndex("dbo.ProductComments", "UserID");
            AddForeignKey("dbo.ProductComments", "UserID", "dbo.Users", "UserID", cascadeDelete: true);
            DropColumn("dbo.ProductComments", "CustomerID");
            DropTable("dbo.Customers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.ProductComments", "CustomerID", c => c.String());
            DropForeignKey("dbo.ProductComments", "UserID", "dbo.Users");
            DropIndex("dbo.ProductComments", new[] { "UserID" });
            AlterColumn("dbo.ProductComments", "UserID", c => c.Int());
            DropTable("dbo.Users");
            RenameColumn(table: "dbo.ProductComments", name: "UserID", newName: "Customer_ID");
            CreateIndex("dbo.ProductComments", "Customer_ID");
            AddForeignKey("dbo.ProductComments", "Customer_ID", "dbo.Customers", "ID");
        }
    }
}
