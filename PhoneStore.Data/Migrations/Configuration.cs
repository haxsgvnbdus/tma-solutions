namespace PhoneStore.Data.Migrations
{
    using PhoneStore.Model.Catalog;
    using PhoneStore.Model.Media;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PhoneStore.Data.PhoneStoreDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PhoneStore.Data.PhoneStoreDBContext context)
        {
            #region Categories
            IList<Category> Categories = new List<Category>();
            Categories.Add(new Category
            {
                Name = "Phone",
                Description = "The Nokia Lumia Series, being the more expensive of the two Nokia Windows Phone offerings (the other being the £299 SIM-free/£199 PAYG Nokia Lumia 710) shares the Nokia N9's 16-bit AMOLED ClearBlack display whereas the Nokia Lumia 710 sports a 24-bit ClearBlack TFT.",
                PriceRanges = "700-900",
                MetaKeywords = "Lumia, Nokia, Smartphone",
                MetaDescription = "Touchscreen, Quadband, Micro-sim",
                MetaTitle = "Nokia Lumia",
                ParentCategoryId = 1,
                PictureId = 2,
                DisplayOrder = 1,
                Deleted = false,
                ShowOnHomePage = true,
                IncludeInTopMenu = false,
                HasDiscountsApplied = true,
                CreatedOnUtc = DateTime.Now,
                UpdatedOnUtc = DateTime.Now
            });
            Categories.Add(new Category
            {
                Name = "Tablet",
                Description = "Product from Apple Co.",
                PriceRanges = "600-1200",
                MetaKeywords = "Ipad, Iphone, Ipod",
                MetaDescription = "Simple, Well-connected with Cloud Library, iDrop",
                MetaTitle = "Iphone 5S",
                ParentCategoryId = 1,
                PictureId = 2,
                DisplayOrder = 2,
                Deleted = false,
                ShowOnHomePage = true,
                IncludeInTopMenu = false,
                HasDiscountsApplied = true,
                CreatedOnUtc = DateTime.Now,
                UpdatedOnUtc = DateTime.Now
            });
            Categories.Add(new Category
            {
                Name = "Laptop",
                Description = "Product from Apple Co.",
                PriceRanges = "1200-2000",
                MetaKeywords = "Ipad, Iphone, Ipod",
                MetaDescription = "Expensive, Prolonged Battery usage",
                MetaTitle = "Iphone 7",
                ParentCategoryId = 1,
                PictureId = 2,
                DisplayOrder = 3,
                Deleted = false,
                ShowOnHomePage = true,
                IncludeInTopMenu = false,
                HasDiscountsApplied = true,
                CreatedOnUtc = DateTime.Now,
                UpdatedOnUtc = DateTime.Now
            });
            Categories.Add(new Category
            {
                Name = "Wearable",
                Description = "Headquarter used to be in the States but wholly handed over to China. Be careful.",
                PriceRanges = "300-2000",
                MetaKeywords = "Lenovo",
                MetaDescription = "Made in China",
                MetaTitle = "Lenovo",
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

            Categories.Add(new Category
            {
                Name = "Camera",
                Description = "Product from Apple Co.",
                PriceRanges = "300-2000",
                MetaKeywords = "Ipad, Iphone, Ipod",
                MetaDescription = "Expensive, Wall-sticking, Small Screen, updated IOS 8.1 and 9",
                MetaTitle = "Iphone 5S",
                ParentCategoryId = 1,
                PictureId = 2,
                DisplayOrder = 5,
                Deleted = false,
                ShowOnHomePage = true,
                IncludeInTopMenu = false,
                HasDiscountsApplied = true,
                CreatedOnUtc = DateTime.UtcNow,
                UpdatedOnUtc = DateTime.UtcNow
            });


            foreach (Category cat in Categories)
                context.Categories.AddOrUpdate(c => c.Name, cat);

            context.SaveChanges();
            #endregion

            #region Customers
            //IList<Customer> Customers = new List<Customer>();
            //Customers.Add(new Customer() { Name = "Han" });
            //Customers.Add(new Customer() { Name = "Duy Anh" });
            //Customers.Add(new Customer() { Name = "Hanh" });
            //Customers.Add(new Customer() { Name = "Quyen Do" }); 
            //Customers.Add(new Customer() { Name = "Nhan" }); 
            //Customers.Add(new Customer() { Name = "Loi" });

            //foreach (Customer cus in Customers)
            //    context.Customers.Add(cus);
            //context.SaveChanges();
            #endregion

            #region ProductComments
            //IList<ProductComment> ProductComments = new List<ProductComment>();
            //ProductComments.Add(new ProductComment() { ReviewText = "suck like a bug", CustomerID = 1, IsApproved = true, ProductID = 1, Title = "Sucks" });
            //ProductComments.Add(new ProductComment() { ReviewText = "so perfect", CustomerID = 2, IsApproved = true, ProductID = 2, Title = "Awesome" });
            //ProductComments.Add(new ProductComment() { ReviewText = "dumb like a hub", CustomerID = 2, IsApproved = true, ProductID = 3, Title = "Stupid" });
            //ProductComments.Add(new ProductComment() { ReviewText = "cool like a pool", CustomerID = 3, IsApproved = true, ProductID = 1, Title = "Coollies" });
            //ProductComments.Add(new ProductComment() { ReviewText = "goodie-tootsy", CustomerID = 1, IsApproved = false, ProductID = 5, Title = "Amazing" });

            //foreach (ProductComment pc in ProductComments)
            //    context.ProductComments.Add(pc);
            //context.SaveChanges();
            #endregion

            #region Pictures
            IList<Picture> Pictures = new List<Picture>();
            Pictures.Add(new Picture() { PictureLink = "/Images/w595-detail.jpg", MimeType = "", IsNew = true, SeoFilename = "" });
            Pictures.Add(new Picture() { PictureLink = "/Images/zxs.jpg", MimeType = "", IsNew = true, SeoFilename = "" });
            //Pictures.Add(new Picture() { PictureLink = "/Images/zxs.jpg", MimeType = "", IsNew = true, SeoFilename = "" });
            //Pictures.Add(new Picture() { PictureLink = "/Images/zxs.jpg", MimeType = "", IsNew = true, SeoFilename = "" });
            //Pictures.Add(new Picture() { PictureLink = "/Images/w595-detail.jpg", MimeType = "", IsNew = true, SeoFilename = ""  });

            foreach (Picture picture in Pictures)
                context.Pictures.AddOrUpdate(p => p.PictureLink, picture);

            context.SaveChanges();
            #endregion

            #region Manufacturers
            IList<Manufacturer> Manufacturers = new List<Manufacturer>();
            Manufacturers.Add(new Manufacturer() { Name = "Apple" });
            Manufacturers.Add(new Manufacturer() { Name = "Samsung" });
            Manufacturers.Add(new Manufacturer() { Name = "LG" });
            Manufacturers.Add(new Manufacturer() { Name = "BKAV" });
            Manufacturers.Add(new Manufacturer() { Name = "Sony" });
            Manufacturers.Add(new Manufacturer() { Name = "Nokia" });

            foreach (Manufacturer manu in Manufacturers)
                context.Manufacturers.AddOrUpdate(m => m.Name, manu);

            context.SaveChanges();
            #endregion

            #region Products
            IList<Product> Products = new List<Product>();
            Products.Add(new Product()
            {
                Name = "Iphone4S",
                Description = "Fixed 16GB local storage",
                Price = 500,
                IsHot = true,
                ShowOnHomePage = true,
                Deleted = false,
                StockQuantity = 12,
                MetaKeywords = "Iphone 4S",
                MetaDescription = "smooth touchscreen, multitouch",
                MetaTitle = "Iphone 4S",
                Sku = "19d2123",
                CreatedOnUtc = DateTime.UtcNow,
                UpdatedOnUtc = DateTime.UtcNow, //db load thgian len, index cho vo hien obj thanhviewmodel index, bam edit la lay entity cua db load len
                ProductTypeId = 1,
                ProductType = ProductType.SimpleProduct
            });
            Products.Add(new Product()
            {
                Name = "Nikon 3200D",
                Description = "Mirror or Mirrorless, 18-55mm ",
                Price = 3000,
                IsHot = true,
                ShowOnHomePage = true,
                Deleted = false,
                StockQuantity = 12,
                MetaKeywords = "Nikon",
                MetaDescription = "eye-wide",
                MetaTitle = "Digital Camera Nikon",
                Sku = "193f212",
                CreatedOnUtc = DateTime.UtcNow,
                UpdatedOnUtc = DateTime.UtcNow,
                ProductTypeId = 1,
                ProductType = ProductType.SimpleProduct
            });
            Products.Add(new Product()
            {
                Name = "IPad Air 2",
                Description = "Get new features of iCloud and PhotoLibrary",
                Price = 800,
                IsHot = true,
                ShowOnHomePage = true,
                Deleted = false,
                StockQuantity = 12,
                MetaKeywords = "IPad",
                MetaDescription = "eye-wide",
                MetaTitle = "IPad",
                Sku = "19d212",
                CreatedOnUtc = DateTime.UtcNow,
                UpdatedOnUtc = DateTime.UtcNow,
                ProductTypeId = 1,
                ProductType = ProductType.SimpleProduct
            });
            Products.Add(new Product()
            {
                Name = "BPhone",
                Description = "First phone ever in Vietnam",
                Price = 500,
                IsHot = true,
                ShowOnHomePage = true,
                Deleted = false,
                StockQuantity = 12,
                MetaKeywords = "BPhone",
                MetaDescription = "eye-wide",
                MetaTitle = "BPhone",
                Sku = "20d212",
                CreatedOnUtc = DateTime.UtcNow,
                UpdatedOnUtc = DateTime.UtcNow,
                ProductTypeId = 1,
                ProductType = ProductType.SimpleProduct
            });

            foreach (Product pro in Products)
                context.Products.AddOrUpdate(p => p.Name, pro);

            context.SaveChanges();
            #endregion

            #region ProductTags

            IList<ProductTag> Tags = new List<ProductTag>();

            Tags.Add(new ProductTag() { Name = "iphone" });
            Tags.Add(new ProductTag() { Name = "bphone" });
            Tags.Add(new ProductTag() { Name = "nokia" });
            Tags.Add(new ProductTag() { Name = "awesome" });
            Tags.Add(new ProductTag() { Name = "icloud" });

            foreach (ProductTag tag in Tags)
                context.ProductTags.AddOrUpdate(t => t.Name, tag);

            context.SaveChanges();

            #endregion

            #region Seeding Relationships

            #region ProductCategory

            //IList<ProductCategory> ProductCategories = new List<ProductCategory>();

            //ProductCategories.Add(
            //    new ProductCategory()
            //    {
            //        ProductID = Products.Single(p => p.Name.ToLower().Contains("4s")).ID,
            //        CategoryID = Categories.Single(c => c.Name.Equals("Phone")).ID,
            //        DisplayOrder = 2,
            //        IsFeaturedProduct = true
            //    });

            //ProductCategories.Add(
            //     new ProductCategory()
            //     {
            //         ProductID = Products.Single(p => p.Name.ToLower().Contains("Nikon")).ID,
            //         CategoryID = Categories.Single(c => c.Name.Equals("Camera")).ID,
            //         DisplayOrder = 2,
            //         IsFeaturedProduct = false
            //     });

            //ProductCategories.Add(
            //     new ProductCategory()
            //     {
            //         ProductID = Products.Single(p => p.Name.ToLower().Contains("ipad")).ID,
            //         CategoryID = Categories.Single(c => c.Name.Equals("Tablet")).ID,
            //         DisplayOrder = 1,
            //         IsFeaturedProduct = false
            //     });

            //foreach (ProductCategory pc in ProductCategories)
            //    context.ProductCategories.AddOrUpdate(pc);

            //context.SaveChanges();

            #endregion

            #region ProductManufacturers

            IList<ProductManufacturer> ProductManufacturers = new List<ProductManufacturer>();

            //ProductManufacturers.Add(
            //                new ProductManufacturer()
            //                {
            //                    ProductId = Products.Single(p => p.Name.Equals("Iphone4S")).ID,
            //                    ManufacturerId = Categories.Single(c => c.Name.Equals("Apple")).ID,
            //                    DisplayOrder = 1,
            //                    IsFeaturedProduct = false
            //                });

            //ProductManufacturers.Add(
            //                new ProductManufacturer()
            //                {
            //                    ProductId = Products.Single(p => p.Name.ToLower().Contains("bphone")).ID,
            //                    ManufacturerId = Categories.Single(c => c.Name.Equals("BKAV")).ID,
            //                    DisplayOrder = 1,
            //                    IsFeaturedProduct = false
            //                });

            //foreach (ProductManufacturer pm in ProductManufacturers)
            //    context.ProductManufacturers.AddOrUpdate(pm);

            //context.SaveChanges();

            #endregion

            #region ProductPicture

            IList<ProductPicture> ProductPictures = new List<ProductPicture>();

            ProductPictures.Add(new ProductPicture() { ProductId = 1, PictureId = 1, DisplayOrder = 1 });
            ProductPictures.Add(new ProductPicture() { ProductId = 2, PictureId = 2, DisplayOrder = 3 });
            ProductPictures.Add(new ProductPicture() { ProductId = 3, PictureId = 1, DisplayOrder = 2 });
            ProductPictures.Add(new ProductPicture() { ProductId = 4, PictureId = 2, DisplayOrder = 4 });
            //ProductPictures.Add(new ProductPicture() { ProductId = 5, PictureId = 1, DisplayOrder = 5 });

            foreach (ProductPicture pp in ProductPictures)
                context.ProductPictures.AddOrUpdate(pp);

            context.SaveChanges();

            #endregion

            #region ProductTag Mapping

            Products.Where(p => p.Name.ToLower().Contains("iphone")).ToList().ForEach(i =>
            {
                var iphoneTag = Tags.SingleOrDefault(t => t.Name.Equals("iphone"));
                i.ProductTags.Add(iphoneTag);
            });

            Products.Where(p => p.Name.ToLower().Contains("bphone")).ToList().ForEach(i =>
            {
                var bphoneTag = Tags.SingleOrDefault(t => t.Name.Equals("bphone"));
                i.ProductTags.Add(bphoneTag);
            });

            Products.Where(p => p.Description.ToLower().Contains("icloud")).ToList().ForEach(i =>
            {
                var icloudTag = Tags.SingleOrDefault(t => t.Name.Equals("icloud"));
                i.ProductTags.Add(icloudTag);
            });

            // add bphone/etc tag to those phones whose manufacutrer is bphone/etc
            //var phonesWithBphoneTag = Products.Where(p =>
            //                         p.ProductManufacturers.Any(pm => pm.Manufacturer.Name.ToLower().Contains("bphone")));
            //phonesWithBphoneTag.ToList().ForEach(b =>
            //{
            //    var bphoneTag = Tags.SingleOrDefault(t => t.Name.Equals("bphone"));
            //    b.ProductTags.Add(bphoneTag);
            //});

            var phonesWithIPhoneTag = Products.Where(p =>
                                     p.ProductManufacturers.Any(pm => pm.Manufacturer.Name.ToLower().Contains("iphone")));
            phonesWithIPhoneTag.ToList().ForEach(b =>
            {
                var iphoneTag = Tags.SingleOrDefault(t => t.Name.Equals("iphone"));
                b.ProductTags.Add(iphoneTag);
            });

            var phonesWithLGTag = Products.Where(p =>
                                      p.ProductManufacturers.Any(pm => pm.Manufacturer.Name.ToLower().Contains("lg")));
            phonesWithLGTag.ToList().ForEach(b =>
            {
                var lgTag = Tags.SingleOrDefault(t => t.Name.Equals("lg"));
                b.ProductTags.Add(lgTag);
            });

            // add bphone tag to those phone whose name contains bphone
            //Products.Where(p => p.Name.ToLower().Contains("bphone")).ToList().ForEach(i =>
            //{
            //    var bphoneTag = Tags.SingleOrDefault(t => t.Name.Equals("bphone"));
            //    i.ProductTags.Add(bphoneTag);
            //});

            context.SaveChanges();

            #endregion

            #endregion

            base.Seed(context);
        }
    }
}
