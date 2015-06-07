namespace PhoneStore.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using PhoneStore.Data;
    using PhoneStore.Model.Customers;
    using PhoneStore.Model.Catalog;
    using PhoneStore.Model.Media;
    using System.Collections.Generic;
    using PhoneStore.Data.Migrations;
    
    internal sealed class Configuration : DbMigrationsConfiguration<PhoneStore.Data.PhoneStoreDBContext>
    {
        protected override void Seed(PhoneStore.Data.PhoneStoreDBContext context)
        {
            context.Categories.AddOrUpdate(p => p.Name,
                new Category
                {
                    Name = "Phone",
                    Description = "Product from Apple Co.",
                    PriceRanges = "300-2000",
                    MetaKeywords = "Ipad, Iphone, Ipod",
                    MetaDescription = "Expensive, Wall-sticking, sucks",
                    MetaTitle = "Iphone 5S",
                    ParentCategoryId = 1,
                    PictureId = 2,
                    DisplayOrder = 4,
                    Deleted = false,
                    ShowOnHomePage = true,
                    IncludeInTopMenu = false,
                    HasDiscountsApplied = true,
                    CreatedOnUtc = DateTime.Now,
                    UpdatedOnUtc = DateTime.Now
                },
                new Category
                {
                    Name = "IPhone",
                    Description = "Product from Apple Co.",
                    PriceRanges = "300-2000",
                    MetaKeywords = "Ipad, Iphone, Ipod",
                    MetaDescription = "Expensive, Wall-sticking, sucks",
                    MetaTitle = "Iphone 5S",
                    ParentCategoryId = 1,
                    PictureId = 2,
                    DisplayOrder = 4,
                    Deleted = false,
                    ShowOnHomePage = true,
                    IncludeInTopMenu = false,
                    HasDiscountsApplied = true,
                    CreatedOnUtc = DateTime.Now,
                    UpdatedOnUtc = DateTime.Now
                },
                new Category
                {
                    Name = "Lap",
                    Description = "Product from Apple Co.",
                    PriceRanges = "300-2000",
                    MetaKeywords = "Ipad, Iphone, Ipod",
                    MetaDescription = "Expensive, Wall-sticking, sucks",
                    MetaTitle = "Iphone 5S",
                    ParentCategoryId = 1,
                    PictureId = 2,
                    DisplayOrder = 4,
                    Deleted = false,
                    ShowOnHomePage = true,
                    IncludeInTopMenu = false,
                    HasDiscountsApplied = true,
                    CreatedOnUtc = DateTime.Now,
                    UpdatedOnUtc = DateTime.Now
                },
                new Category
                {
                    Name = "Tablet",
                    Description = "Product from Apple Co.",
                    PriceRanges = "300-2000",
                    MetaKeywords = "Ipad, Iphone, Ipod",
                    MetaDescription = "Expensive, Wall-sticking, sucks",
                    MetaTitle = "Iphone 5S",
                    ParentCategoryId = 1,
                    PictureId = 2,
                    DisplayOrder = 4,
                    Deleted = false,
                    ShowOnHomePage = true,
                    IncludeInTopMenu = false,
                    HasDiscountsApplied = true,
                    CreatedOnUtc = DateTime.Now,
                    UpdatedOnUtc = DateTime.Now
                },
                new Category
                {
                    Name = "Wearables",
                    Description = "Product from Apple Co.",
                    PriceRanges = "300-2000",
                    MetaKeywords = "Ipad, Iphone, Ipod",
                    MetaDescription = "Expensive, Wall-sticking, sucks",
                    MetaTitle = "Iphone 5S",
                    ParentCategoryId = 1,
                    PictureId = 2,
                    DisplayOrder = 4,
                    Deleted = false,
                    ShowOnHomePage = true,
                    IncludeInTopMenu = false,
                    HasDiscountsApplied = true,
                    CreatedOnUtc = DateTime.Now,
                    UpdatedOnUtc = DateTime.Now
                });
            context.SaveChanges();



            //    context.Customers.AddOrUpdate(p => p.ID,
            //        new Customer { Name = "Han" },
            //        new Customer { Name = "Duy Anh" },
            //        new Customer { Name = "Hanh" });
            //    context.SaveChanges();

            context.Manufacturers.AddOrUpdate(p => p.Name,
                new Manufacturer { Name = "apple" },
                new Manufacturer { Name = "samsung" },
                new Manufacturer { Name = "LG" },
                new Manufacturer { Name = "Nokia" },
                new Manufacturer { Name = "BPhone" });
            context.SaveChanges();

            context.Tags.AddOrUpdate(p => p.ID,
                new Tag { Tagline = "Fun to be around" },
                new Tag { Tagline = "Makes me mad" },
                new Tag { Tagline = "Cool like a pool" });
            context.SaveChanges();

            //context.ProductComments.AddOrUpdate(p => p.ID,
            //    new ProductComment { ProductID = 1, CustomerID = 4, IsApproved = true, Title = "Iphone 5S", ReviewText = "New features of Iphone 6S" },
            //    new ProductComment { ProductID = 1, CustomerID = 4, IsApproved = true, Title = "Iphone 5S", ReviewText = "New features of Iphone 6S" },
            //    new ProductComment { ProductID = 1, CustomerID = 4, IsApproved = true, Title = "Iphone 5S", ReviewText = "New features of Iphone 6S" },
            //    new ProductComment { ProductID = 1, CustomerID = 4, IsApproved = true, Title = "Iphone 5S", ReviewText = "New features of Iphone 6S" },
            //    new ProductComment { ProductID = 1, CustomerID = 4, IsApproved = true, Title = "Iphone 5S", ReviewText = "New features of Iphone 6S" });
            //context.SaveChanges();

            context.Products.AddOrUpdate(p => p.Sku,
                new Product
                {
                    Name = "Iphone",
                    Description = "Get new features of iCloud and PhotoLibrary",
                    Price = 1.200M,
                    IsHot = true,
                    ShowOnHomePage = true,
                    Deleted = false,
                    StockQuantity = 12,
                    MetaKeywords = "Iphone 5S",
                    MetaDescription = "eye-wide",
                    MetaTitle = "Iphone 5S",
                    Sku = "19d2123",
                    CreatedOnUtc = DateTime.UtcNow,
                    UpdatedOnUtc = DateTime.UtcNow,
                    ProductTypeId = 1,
                    ProductType = ProductType.GroupedProduct
                },
                new Product
                {
                    Name = "Iphone2",
                    Description = "Get new features of iCloud and PhotoLibrary",
                    Price = 1.200M,
                    IsHot = true,
                    ShowOnHomePage = true,
                    Deleted = false,
                    StockQuantity = 12,
                    MetaKeywords = "Iphone 5S",
                    MetaDescription = "eye-wide",
                    MetaTitle = "Iphone 5S",
                    Sku = "19d212",
                    CreatedOnUtc = DateTime.Now,
                    UpdatedOnUtc = DateTime.Now,
                    ProductTypeId = 1,
                    ProductType = ProductType.GroupedProduct
                },
                new Product
                {
                    Name = "Iphone3",
                    Description = "Max wifi bandwidth",
                    Price = 1.200M,
                    IsHot = true,
                    ShowOnHomePage = true,
                    Deleted = false,
                    StockQuantity = 12,
                    MetaKeywords = "Iphone 5S",
                    MetaDescription = "eye-wide",
                    MetaTitle = "Iphone 5S",
                    Sku = "19d2122",
                    CreatedOnUtc = DateTime.Now,
                    UpdatedOnUtc = DateTime.Now,
                    ProductTypeId = 1,
                    ProductType = ProductType.GroupedProduct
                });
            context.SaveChanges();

            var productTags = new List<ProductTag> {
                new ProductTag { ProductId = 1, TagId = 1},
                new ProductTag { ProductId = 2, TagId = 2},
                new ProductTag { ProductId = 3, TagId = 3}
            };

            foreach (ProductTag pt in productTags)
            {
                var ProductTagInDatabase = context.ProductTags.Where(
                    s =>
                    s.Product.ID == pt.ProductId &&
                    s.Tag.ID == pt.TagId).SingleOrDefault();
                if (ProductTagInDatabase == null)
                    context.ProductTags.Add(pt);
                context.SaveChanges();
            }

            var productCategories = new List<ProductCategory> {
                    new ProductCategory { ProductID = 1, CategoryID = 1, DisplayOrder = 2, IsFeaturedProduct = true},
                    new ProductCategory { ProductID = 2, CategoryID = 1, DisplayOrder = 2, IsFeaturedProduct = true},
                    new ProductCategory { ProductID = 3, CategoryID = 1, DisplayOrder = 2, IsFeaturedProduct = true},
                    new ProductCategory { ProductID = 2, CategoryID = 1, DisplayOrder = 2, IsFeaturedProduct = true},
                    new ProductCategory { ProductID = 1, CategoryID = 1, DisplayOrder = 2, IsFeaturedProduct = true},
                };

            foreach (ProductCategory pc in productCategories)
            {
                var ProductCategoryInDatabase = context.ProductCategories.Where(
                        s =>
                             s.Product.ID == pc.ProductID &&
                             s.Category.ID == pc.CategoryID).SingleOrDefault();
                if (ProductCategoryInDatabase == null)
                {
                    context.ProductCategories.Add(pc);
                }
                context.SaveChanges();
            }

            var productManufacturers = new List<ProductManufacturer> {
                    new ProductManufacturer { ProductId = 1, ManufacturerId = 1, IsFeaturedProduct = true, DisplayOrder = 1},
                    new ProductManufacturer { ProductId = 2, ManufacturerId = 3, IsFeaturedProduct = false, DisplayOrder = 2},
                    new ProductManufacturer { ProductId = 3, ManufacturerId = 5, IsFeaturedProduct = true, DisplayOrder = 3},
                };

            foreach (ProductManufacturer e in productManufacturers)
            {
                var ProductManuInDataBase = context.ProductManufacturers.Where(
                    s =>
                         s.Product.ID == e.ProductId &&
                         s.Manufacturer.ID == e.ManufacturerId).FirstOrDefault();
                if (ProductManuInDataBase == null)
                {
                    context.ProductManufacturers.Add(e);
                }
            }
            context.SaveChanges();




        }









     
    }
}
