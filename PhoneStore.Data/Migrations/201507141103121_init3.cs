namespace PhoneStore.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 400),
                        Description = c.String(),
                        PriceRanges = c.String(maxLength: 400),
                        MetaKeywords = c.String(),
                        MetaDescription = c.String(maxLength: 400),
                        MetaTitle = c.String(maxLength: 400),
                        ParentCategoryId = c.Int(nullable: false),
                        PictureId = c.Int(nullable: false),
                        DisplayOrder = c.Int(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        ShowOnHomePage = c.Boolean(nullable: false),
                        IncludeInTopMenu = c.Boolean(nullable: false),
                        HasDiscountsApplied = c.Boolean(nullable: false),
                        CreatedOnUtc = c.DateTime(nullable: false),
                        UpdatedOnUtc = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Discounts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DiscountTypeId = c.Int(nullable: false),
                        UsePercentage = c.Boolean(nullable: false),
                        DiscountPercentage = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiscountAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StartDateUtc = c.DateTime(),
                        EndDateUtc = c.DateTime(),
                        DiscountType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 400),
                        Description = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 4),
                        IsHot = c.Boolean(nullable: false),
                        ShowOnHomePage = c.Boolean(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        StockQuantity = c.Int(nullable: false),
                        MetaKeywords = c.String(maxLength: 400),
                        MetaDescription = c.String(),
                        MetaTitle = c.String(maxLength: 400),
                        Sku = c.String(maxLength: 400),
                        CreatedOnUtc = c.DateTime(),
                        UpdatedOnUtc = c.DateTime(),
                        ProductTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Product_Category",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProductID = c.Int(nullable: false),
                        CategoryID = c.Int(nullable: false),
                        DisplayOrder = c.Int(nullable: false),
                        IsFeaturedProduct = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Category", t => t.CategoryID, cascadeDelete: true)
                .ForeignKey("dbo.Product", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.ProductID)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.ProductComments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProductID = c.Int(nullable: false),
                        CustomerID = c.String(),
                        IsApproved = c.Boolean(nullable: false),
                        Title = c.String(),
                        ReviewText = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Product", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Product_Manufacturer",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        ManufacturerId = c.Int(nullable: false),
                        IsFeaturedProduct = c.Boolean(nullable: false),
                        DisplayOrder = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Manufacturer", t => t.ManufacturerId, cascadeDelete: true)
                .ForeignKey("dbo.Product", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.ManufacturerId);
            
            CreateTable(
                "dbo.Manufacturer",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 400),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Product_Picture",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        PictureId = c.Int(nullable: false),
                        DisplayOrder = c.Int(nullable: false),
                        Picture_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Picture", t => t.Picture_ID)
                .ForeignKey("dbo.Picture", t => t.PictureId, cascadeDelete: true)
                .ForeignKey("dbo.Product", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.PictureId)
                .Index(t => t.Picture_ID);
            
            CreateTable(
                "dbo.Picture",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PictureLink = c.String(nullable: false),
                        MimeType = c.String(),
                        SeoFilename = c.String(),
                        IsNew = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ProductTag",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 400),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.DiscountCategories",
                c => new
                    {
                        Discount_ID = c.Int(nullable: false),
                        Category_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Discount_ID, t.Category_ID })
                .ForeignKey("dbo.Discounts", t => t.Discount_ID, cascadeDelete: true)
                .ForeignKey("dbo.Category", t => t.Category_ID, cascadeDelete: true)
                .Index(t => t.Discount_ID)
                .Index(t => t.Category_ID);
            
            CreateTable(
                "dbo.ProductDiscounts",
                c => new
                    {
                        Product_ID = c.Int(nullable: false),
                        Discount_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Product_ID, t.Discount_ID })
                .ForeignKey("dbo.Product", t => t.Product_ID, cascadeDelete: true)
                .ForeignKey("dbo.Discounts", t => t.Discount_ID, cascadeDelete: true)
                .Index(t => t.Product_ID)
                .Index(t => t.Discount_ID);
            
            CreateTable(
                "dbo.Product_ProductTag_Mapping",
                c => new
                    {
                        Product_ID = c.Int(nullable: false),
                        ProductTag_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Product_ID, t.ProductTag_ID })
                .ForeignKey("dbo.Product", t => t.Product_ID, cascadeDelete: true)
                .ForeignKey("dbo.ProductTag", t => t.ProductTag_ID, cascadeDelete: true)
                .Index(t => t.Product_ID)
                .Index(t => t.ProductTag_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product_ProductTag_Mapping", "ProductTag_ID", "dbo.ProductTag");
            DropForeignKey("dbo.Product_ProductTag_Mapping", "Product_ID", "dbo.Product");
            DropForeignKey("dbo.Product_Picture", "ProductId", "dbo.Product");
            DropForeignKey("dbo.Product_Picture", "PictureId", "dbo.Picture");
            DropForeignKey("dbo.Product_Picture", "Picture_ID", "dbo.Picture");
            DropForeignKey("dbo.Product_Manufacturer", "ProductId", "dbo.Product");
            DropForeignKey("dbo.Product_Manufacturer", "ManufacturerId", "dbo.Manufacturer");
            DropForeignKey("dbo.ProductComments", "ProductID", "dbo.Product");
            DropForeignKey("dbo.Product_Category", "ProductID", "dbo.Product");
            DropForeignKey("dbo.Product_Category", "CategoryID", "dbo.Category");
            DropForeignKey("dbo.ProductDiscounts", "Discount_ID", "dbo.Discounts");
            DropForeignKey("dbo.ProductDiscounts", "Product_ID", "dbo.Product");
            DropForeignKey("dbo.DiscountCategories", "Category_ID", "dbo.Category");
            DropForeignKey("dbo.DiscountCategories", "Discount_ID", "dbo.Discounts");
            DropIndex("dbo.Product_ProductTag_Mapping", new[] { "ProductTag_ID" });
            DropIndex("dbo.Product_ProductTag_Mapping", new[] { "Product_ID" });
            DropIndex("dbo.ProductDiscounts", new[] { "Discount_ID" });
            DropIndex("dbo.ProductDiscounts", new[] { "Product_ID" });
            DropIndex("dbo.DiscountCategories", new[] { "Category_ID" });
            DropIndex("dbo.DiscountCategories", new[] { "Discount_ID" });
            DropIndex("dbo.Product_Picture", new[] { "Picture_ID" });
            DropIndex("dbo.Product_Picture", new[] { "PictureId" });
            DropIndex("dbo.Product_Picture", new[] { "ProductId" });
            DropIndex("dbo.Product_Manufacturer", new[] { "ManufacturerId" });
            DropIndex("dbo.Product_Manufacturer", new[] { "ProductId" });
            DropIndex("dbo.ProductComments", new[] { "ProductID" });
            DropIndex("dbo.Product_Category", new[] { "CategoryID" });
            DropIndex("dbo.Product_Category", new[] { "ProductID" });
            DropTable("dbo.Product_ProductTag_Mapping");
            DropTable("dbo.ProductDiscounts");
            DropTable("dbo.DiscountCategories");
            DropTable("dbo.ProductTag");
            DropTable("dbo.Picture");
            DropTable("dbo.Product_Picture");
            DropTable("dbo.Manufacturer");
            DropTable("dbo.Product_Manufacturer");
            DropTable("dbo.ProductComments");
            DropTable("dbo.Product_Category");
            DropTable("dbo.Product");
            DropTable("dbo.Discounts");
            DropTable("dbo.Category");
        }
    }
}
