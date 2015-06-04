namespace PhoneStore.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db : DbMigration
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
                        CreatedOnUtc = c.DateTime(nullable: false),
                        UpdatedOnUtc = c.DateTime(nullable: false),
                        ProductTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Product_Category_Mapping",
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
                "dbo.Product_Manufacturer_Mapping",
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
                        Product_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Pictures", t => t.Picture_ID)
                .ForeignKey("dbo.Pictures", t => t.PictureId, cascadeDelete: true)
                .ForeignKey("dbo.Product", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Product", t => t.Product_ID)
                .Index(t => t.ProductId)
                .Index(t => t.PictureId)
                .Index(t => t.Picture_ID)
                .Index(t => t.Product_ID);
            
            CreateTable(
                "dbo.Pictures",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PictureBinary = c.Binary(),
                        MimeType = c.String(),
                        SeoFilename = c.String(),
                        IsNew = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Product_Comment",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProductID = c.Int(nullable: false),
                        CustomerID = c.Int(nullable: false),
                        IsApproved = c.Boolean(nullable: false),
                        Title = c.String(nullable: false),
                        ReviewText = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Product", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Product_Tag",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        TagId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Product", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Tags", t => t.TagId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.TagId);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Tagline = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product_Tag", "TagId", "dbo.Tags");
            DropForeignKey("dbo.Product_Tag", "ProductId", "dbo.Product");
            DropForeignKey("dbo.Product_Comment", "ProductID", "dbo.Product");
            DropForeignKey("dbo.Product_Picture", "Product_ID", "dbo.Product");
            DropForeignKey("dbo.Product_Picture", "ProductId", "dbo.Product");
            DropForeignKey("dbo.Product_Picture", "PictureId", "dbo.Pictures");
            DropForeignKey("dbo.Product_Picture", "Picture_ID", "dbo.Pictures");
            DropForeignKey("dbo.Product_Manufacturer_Mapping", "ProductId", "dbo.Product");
            DropForeignKey("dbo.Product_Manufacturer_Mapping", "ManufacturerId", "dbo.Manufacturer");
            DropForeignKey("dbo.Product_Category_Mapping", "ProductID", "dbo.Product");
            DropForeignKey("dbo.Product_Category_Mapping", "CategoryID", "dbo.Category");
            DropForeignKey("dbo.ProductDiscounts", "Discount_ID", "dbo.Discounts");
            DropForeignKey("dbo.ProductDiscounts", "Product_ID", "dbo.Product");
            DropForeignKey("dbo.DiscountCategories", "Category_ID", "dbo.Category");
            DropForeignKey("dbo.DiscountCategories", "Discount_ID", "dbo.Discounts");
            DropIndex("dbo.ProductDiscounts", new[] { "Discount_ID" });
            DropIndex("dbo.ProductDiscounts", new[] { "Product_ID" });
            DropIndex("dbo.DiscountCategories", new[] { "Category_ID" });
            DropIndex("dbo.DiscountCategories", new[] { "Discount_ID" });
            DropIndex("dbo.Product_Tag", new[] { "TagId" });
            DropIndex("dbo.Product_Tag", new[] { "ProductId" });
            DropIndex("dbo.Product_Comment", new[] { "ProductID" });
            DropIndex("dbo.Product_Picture", new[] { "Product_ID" });
            DropIndex("dbo.Product_Picture", new[] { "Picture_ID" });
            DropIndex("dbo.Product_Picture", new[] { "PictureId" });
            DropIndex("dbo.Product_Picture", new[] { "ProductId" });
            DropIndex("dbo.Product_Manufacturer_Mapping", new[] { "ManufacturerId" });
            DropIndex("dbo.Product_Manufacturer_Mapping", new[] { "ProductId" });
            DropIndex("dbo.Product_Category_Mapping", new[] { "CategoryID" });
            DropIndex("dbo.Product_Category_Mapping", new[] { "ProductID" });
            DropTable("dbo.ProductDiscounts");
            DropTable("dbo.DiscountCategories");
            DropTable("dbo.Customers");
            DropTable("dbo.Tags");
            DropTable("dbo.Product_Tag");
            DropTable("dbo.Product_Comment");
            DropTable("dbo.Pictures");
            DropTable("dbo.Product_Picture");
            DropTable("dbo.Manufacturer");
            DropTable("dbo.Product_Manufacturer_Mapping");
            DropTable("dbo.Product_Category_Mapping");
            DropTable("dbo.Product");
            DropTable("dbo.Discounts");
            DropTable("dbo.Category");
        }
    }
}
