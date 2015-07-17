namespace PhoneStore.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.ProductComments", "Customer_ID", c => c.Int());
            CreateIndex("dbo.ProductComments", "Customer_ID");
            AddForeignKey("dbo.ProductComments", "Customer_ID", "dbo.Customers", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductComments", "Customer_ID", "dbo.Customers");
            DropIndex("dbo.ProductComments", new[] { "Customer_ID" });
            DropColumn("dbo.ProductComments", "Customer_ID");
            DropTable("dbo.Customers");
        }
    }
}
