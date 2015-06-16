namespace PhoneStore.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_ProductMap : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ProductTagProducts", newName: "Product_ProductTag_Mapping");
            DropPrimaryKey("dbo.Product_ProductTag_Mapping");
            AddPrimaryKey("dbo.Product_ProductTag_Mapping", new[] { "Product_ID", "ProductTag_ID" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Product_ProductTag_Mapping");
            AddPrimaryKey("dbo.Product_ProductTag_Mapping", new[] { "ProductTag_ID", "Product_ID" });
            RenameTable(name: "dbo.Product_ProductTag_Mapping", newName: "ProductTagProducts");
        }
    }
}
