namespace PhoneStore.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Product_Comment", newName: "ProductComments");
            RenameTable(name: "dbo.ProductTagProducts", newName: "Product_ProductTag_Mapping");
            DropPrimaryKey("dbo.Product_ProductTag_Mapping");
            AlterColumn("dbo.ProductComments", "Title", c => c.String());
            AlterColumn("dbo.ProductComments", "ReviewText", c => c.String());
            AddPrimaryKey("dbo.Product_ProductTag_Mapping", new[] { "Product_ID", "ProductTag_ID" });
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
            
            DropPrimaryKey("dbo.Product_ProductTag_Mapping");
            AlterColumn("dbo.ProductComments", "ReviewText", c => c.String(nullable: false));
            AlterColumn("dbo.ProductComments", "Title", c => c.String(nullable: false));
            AddPrimaryKey("dbo.Product_ProductTag_Mapping", new[] { "ProductTag_ID", "Product_ID" });
            RenameTable(name: "dbo.Product_ProductTag_Mapping", newName: "ProductTagProducts");
            RenameTable(name: "dbo.ProductComments", newName: "Product_Comment");
        }
    }
}
