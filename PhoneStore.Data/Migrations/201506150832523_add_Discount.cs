namespace PhoneStore.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_Discount : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Discounts", newName: "Discount");
            RenameTable(name: "dbo.Product_Comment", newName: "ProductComments");
            RenameTable(name: "dbo.DiscountCategories", newName: "Discount_AppliedToCategories");
            RenameTable(name: "dbo.ProductDiscounts", newName: "Discount_AppliedToProducts");
            DropPrimaryKey("dbo.Discount_AppliedToProducts");
            AlterColumn("dbo.Discount", "Name", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Discount", "DiscountPercentage", c => c.Decimal(nullable: false, precision: 18, scale: 4));
            AlterColumn("dbo.Discount", "DiscountAmount", c => c.Decimal(nullable: false, precision: 18, scale: 4));
            AlterColumn("dbo.ProductComments", "Title", c => c.String());
            AlterColumn("dbo.ProductComments", "ReviewText", c => c.String());
            AddPrimaryKey("dbo.Discount_AppliedToProducts", new[] { "Discount_ID", "Product_ID" });
            DropColumn("dbo.Discount", "DiscountType");
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
            
            AddColumn("dbo.Discount", "DiscountType", c => c.Int(nullable: false));
            DropPrimaryKey("dbo.Discount_AppliedToProducts");
            AlterColumn("dbo.ProductComments", "ReviewText", c => c.String(nullable: false));
            AlterColumn("dbo.ProductComments", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Discount", "DiscountAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Discount", "DiscountPercentage", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Discount", "Name", c => c.String());
            AddPrimaryKey("dbo.Discount_AppliedToProducts", new[] { "Product_ID", "Discount_ID" });
            RenameTable(name: "dbo.Discount_AppliedToProducts", newName: "ProductDiscounts");
            RenameTable(name: "dbo.Discount_AppliedToCategories", newName: "DiscountCategories");
            RenameTable(name: "dbo.ProductComments", newName: "Product_Comment");
            RenameTable(name: "dbo.Discount", newName: "Discounts");
        }
    }
}
