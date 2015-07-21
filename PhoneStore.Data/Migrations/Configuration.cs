namespace PhoneStore.Data.Migrations
{
    using PhoneStore.Model.Catalog;
    using PhoneStore.Model.Customers;
    using PhoneStore.Model.Discounts;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using PhoneStore.Data;
    using PhoneStore.Model.Media;

    internal sealed class Configuration : DbMigrationsConfiguration<PhoneStore.Data.PhoneStoreDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PhoneStore.Data.PhoneStoreDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

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
                context.Categories.Add(cat);

            context.SaveChanges();

            #endregion

            #region Discount
            IList<Discount> Discounts = new List<Discount>();
            Discounts.Add(new Discount() { Name = "SALE50", DiscountTypeId = 1, UsePercentage = true, DiscountAmount = 0.5M });
            Discounts.Add(new Discount() { Name = "MIDSEASON", DiscountTypeId = 2, UsePercentage = true, DiscountAmount = 0.2M });
            Discounts.Add(new Discount() { Name = "BLACKFRIDAY", DiscountTypeId = 5, UsePercentage = true, DiscountAmount = 0.4M });
            Discounts.Add(new Discount() { Name = "CYBERMONDAY", DiscountTypeId = 10, UsePercentage = false, DiscountAmount = 0.4M });
            Discounts.Add(new Discount() { Name = "THANKSGIVING", DiscountTypeId = 10, UsePercentage = true, DiscountAmount = 0.75M });

            foreach (Discount dis in Discounts)
                context.Discounts.Add(dis);

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
            Pictures.Add(new Picture() { PictureLink = "w595-detail.jpg", MimeType = "", IsNew = true, SeoFilename = "" });
            Pictures.Add(new Picture() { PictureLink = "zxs.jpg", MimeType = "", IsNew = true, SeoFilename = "" });
            Pictures.Add(new Picture() { PictureLink = "HTC1.jpg", MimeType = "", IsNew = true, SeoFilename = "" });
            Pictures.Add(new Picture() { PictureLink = "HTC12.jpg", MimeType = "", IsNew = true, SeoFilename = "" });
            Pictures.Add(new Picture() { PictureLink = "HTC13.jpg", MimeType = "", IsNew = true, SeoFilename = "" });
            Pictures.Add(new Picture() { PictureLink = "SamsungGalS51.jpg", MimeType = "", IsNew = true, SeoFilename = "" });
            Pictures.Add(new Picture() { PictureLink = "SamsungGalS52.jpg", MimeType = "", IsNew = true, SeoFilename = "" });
            Pictures.Add(new Picture() { PictureLink = "SamsungGalS5.jpg", MimeType = "", IsNew = true, SeoFilename = "" });
            Pictures.Add(new Picture() { PictureLink = "1-iphone4india-1402331615422.jpg", MimeType = "", IsNew = true, SeoFilename = "" });
            Pictures.Add(new Picture() { PictureLink = "665_lumia 730 1.jpg", MimeType = "", IsNew = true, SeoFilename = "" });
            Pictures.Add(new Picture() { PictureLink = "nikon-d3200-a-good-camera.jpg", MimeType = "", IsNew = true, SeoFilename = "" });
            Pictures.Add(new Picture() { PictureLink = "orig-nikon-d3200-main-2.jpg", MimeType = "", IsNew = true, SeoFilename = "" });



            foreach (Picture picture in Pictures)
                context.Pictures.Add(picture);
            //context.SaveChanges();
            #endregion

            #region Manufacturers
            IList<Manufacturer> Manufacturers = new List<Manufacturer>();
            Manufacturers.Add(new Manufacturer() { Name = "Apple" });
            Manufacturers.Add(new Manufacturer() { Name = "Samsung" });
            Manufacturers.Add(new Manufacturer() { Name = "HTC" });
            Manufacturers.Add(new Manufacturer() { Name = "BPhone" });
            Manufacturers.Add(new Manufacturer() { Name = "Microsoft" });
            Manufacturers.Add(new Manufacturer() { Name = "Nikon" });

            foreach (Manufacturer manu in Manufacturers)
                context.Manufacturers.Add(manu);
            context.SaveChanges();
            #endregion

            #region Products
            IList<Product> Products = new List<Product>();
            Products.Add(new Product()
            {
                Name = "Iphone 4S",
                Description = "3.5in Retina (960 x 640) LCD display; 8 megapixel camera with 1080p video; Dual core A5 processor; Dual antennae for better signal; Same chassis design as iPhone 4",
                Price = 700,
                IsHot = true,
                ShowOnHomePage = true,
                Deleted = false,
                StockQuantity = 12,
                MetaKeywords = "Iphone 4S",
                MetaDescription = "smooth touchscreen, multitouch, retina",
                MetaTitle = "Iphone 4S",
                Sku = "19d2123",
                CreatedOnUtc = DateTime.UtcNow,
                UpdatedOnUtc = DateTime.UtcNow, //db load thgian len, index cho vo hien obj thanhviewmodel index, bam edit la lay entity cua db load len
                ProductTypeId = 1,
                ProductType = ProductType.SimpleProduct
            });
            Products.Add(new Product()
            {
                Name = "Nikon D3200",
                Description = "The D3200 represents the latest generation of Nikon's entry-level DSLR offering. The camera's headline feature is inevitably the new 24MP CMOS sensor which makes it equal to Sony's Alpha SLT-A65, A77 and NEX-7 in offering the highest pixel count we've yet seen at the APS-C sensor size, and in terms of output resolution, second only to the full-frame professional-grade D800 in Nikon's entire range.",
                Price = 2000,
                IsHot = true,
                ShowOnHomePage = true,
                Deleted = false,
                StockQuantity = 12,
                MetaKeywords = "Iphone 5S",
                MetaDescription = "eye-wide",
                MetaTitle = "Iphone 5",
                Sku = "193f212",
                CreatedOnUtc = DateTime.UtcNow,
                UpdatedOnUtc = DateTime.UtcNow,
                ProductTypeId = 1,
                ProductType = ProductType.SimpleProduct
            });
            Products.Add(new Product()
            {
                Name = "Nokia Lumia 730",
                Description = "The Nokia Lumia 730 is part of Microsoft’s 2014 fall lineup of Windows Phone devices, and one of the last smartphones to carry the Nokia brand. An affordable handset with a 4.7” 720p AMOLED display, it comes with a quad-core Snapdragon 400 system chip, 1GB of RAM and 8 gigs of internal storage.",
                Price = 1.200M,
                IsHot = true,
                ShowOnHomePage = true,
                Deleted = false,
                StockQuantity = 12,
                MetaKeywords = "Iphone 5S",
                MetaDescription = "eye-wide",
                MetaTitle = "Iphone 5S",
                Sku = "19d212",
                CreatedOnUtc = DateTime.UtcNow,
                UpdatedOnUtc = DateTime.UtcNow,
                ProductTypeId = 1,
                ProductType = ProductType.SimpleProduct
            });
            Products.Add(new Product()
            {
                Name = "HTC One X",
                Description = "HTC's latest flagship is the company's best yet. Its beautiful design, great display and solid performance make it among the finest phones available.",
                Price = 800,
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
            Products.Add(new Product()
            {
                Name = "Samsung Tab 4",
                Description = "The quad-core processor is clocked at a reasonable 1.2GHz and backed by 1.5GB RAM. Our AnTuTu benchmark test gave it a score of 18,498, roughly half the Tab S's mark. Despite its middling however, components it delivers a bit above middling performance, transitioning smoothly between apps and even running HD games without any obvious hiccups.",
                Price = 800,
                IsHot = true,
                ShowOnHomePage = true,
                Deleted = false,
                StockQuantity = 12,
                MetaKeywords = "Samsung Tab",
                MetaDescription = "Quad-core processor",
                MetaTitle = "Samsung Tab",
                Sku = "19d212",
                CreatedOnUtc = DateTime.UtcNow,
                UpdatedOnUtc = DateTime.UtcNow,
                ProductTypeId = 1,
                ProductType = ProductType.SimpleProduct
            });

            foreach (Product pro in Products)
                context.Products.Add(pro);
            context.SaveChanges();
            #endregion

            #region ProductCategory
            IList<ProductCategory> ProductCategories = new List<ProductCategory>();
            ProductCategories.Add(
                new ProductCategory()
                {
                    ProductID = Products.Single(p => p.Name.ToLower().Contains("phone")).ID,
                    CategoryID = Categories.Single(c => c.Name.Equals("Phone")).ID,
                    DisplayOrder = 2,
                    IsFeaturedProduct = true
                });

            ProductCategories.Add(
                new ProductCategory()
                {
                    ProductID = Products.Single(p => p.Name.ToLower().Contains("htc")).ID,
                    CategoryID = Categories.Single(c => c.Name.Equals("Phone")).ID,
                    DisplayOrder = 2,
                    IsFeaturedProduct = true
                });

            ProductCategories.Add(
                new ProductCategory()
                {
                    ProductID = Products.Single(p => p.Name.ToLower().Contains("nokia")).ID,
                    CategoryID = Categories.Single(c => c.Name.Equals("Phone")).ID,
                    DisplayOrder = 1,
                    IsFeaturedProduct = false
                });
            ProductCategories.Add(
                 new ProductCategory()
                 {
                     ProductID = Products.Single(p => p.Name.ToLower().Contains("tab")).ID,
                     CategoryID = Categories.Single(c => c.Name.Equals("Tablet")).ID,
                     DisplayOrder = 1,
                     IsFeaturedProduct = false
                 });
            ProductCategories.Add(
                 new ProductCategory()
                 {
                     ProductID = Products.Single(p => p.Name.ToLower().Contains("nikon")).ID,
                     CategoryID = Categories.Single(c => c.Name.Equals("Camera")).ID,
                     DisplayOrder = 1,
                     IsFeaturedProduct = false
                 });

            foreach (ProductCategory pc in ProductCategories)
                context.ProductCategories.Add(pc);
            context.SaveChanges();
            #endregion

            #region ProductTags
            IList<ProductTag> Tags = new List<ProductTag>();

            //name
            Tags.Add(new ProductTag() { Name = "iphone" });
            Tags.Add(new ProductTag() { Name = "nikon" });
            Tags.Add(new ProductTag() { Name = "nokia" });
            Tags.Add(new ProductTag() { Name = "htc" });
            Tags.Add(new ProductTag() { Name = "samsung tab" });

            //manufacturer
            Tags.Add(new ProductTag() { Name = "apple" });
            Tags.Add(new ProductTag() { Name = "microsoft" });
            Tags.Add(new ProductTag() { Name = "samsung" });


            //category
            Tags.Add(new ProductTag() { Name = "tablet" });
            Tags.Add(new ProductTag() { Name = "phone" });
            Tags.Add(new ProductTag() { Name = "laptop" });
            Tags.Add(new ProductTag() { Name = "camera" });
            Tags.Add(new ProductTag() { Name = "wearable" });



            foreach (ProductTag t in Tags)
                context.ProductTags.Add(t);
            context.SaveChanges();
            #endregion


            #region ProductManufacturers
            IList<ProductManufacturer> ProductManufacturers = new List<ProductManufacturer>();
            ProductManufacturers.Add(
                            new ProductManufacturer()
                            {
                                ProductId = Products.Single(p => p.Name.ToLower().Contains("iphone")).ID,
                                ManufacturerId = Manufacturers.Single(c => c.Name.Equals("Apple")).ID,
                                DisplayOrder = 1,
                                IsFeaturedProduct = false
                            });

            ProductManufacturers.Add(
                            new ProductManufacturer()
                            {
                                ProductId = Products.Single(p => p.Name.ToLower().Contains("nokia")).ID,
                                ManufacturerId = Manufacturers.Single(c => c.Name.Equals("Microsoft")).ID,
                                DisplayOrder = 2,
                                IsFeaturedProduct = false
                            });

            ProductManufacturers.Add(

                            new ProductManufacturer()
                            {
                                ProductId = Products.Single(p => p.Name.ToLower().Contains("htc")).ID,
                                ManufacturerId = Manufacturers.Single(c => c.Name.Equals("HTC")).ID,
                                DisplayOrder = 2,
                                IsFeaturedProduct = false
                            });

            ProductManufacturers.Add(
                            new ProductManufacturer()
                            {
                                ProductId = Products.Single(p => p.Name.ToLower().Contains("samsung")).ID,
                                ManufacturerId = Manufacturers.Single(c => c.Name.Equals("Samsung")).ID,
                                DisplayOrder = 2,
                                IsFeaturedProduct = false
                            });

            ProductManufacturers.Add(
                            new ProductManufacturer()
                            {
                                ProductId = Products.Single(p => p.Name.ToLower().Contains("nikon")).ID,
                                ManufacturerId = Manufacturers.Single(c => c.Name.Equals("Nikon")).ID,
                                DisplayOrder = 2,
                                IsFeaturedProduct = false
                            });
            foreach (ProductManufacturer pm in ProductManufacturers)
                context.ProductManufacturers.Add(pm);
            context.SaveChanges();
            #endregion

            #region ProductPicture
            IList<ProductPicture> ProductPictures = new List<ProductPicture>();

            ProductPictures.Add(new ProductPicture() { ProductId = 1, PictureId = 9, DisplayOrder = 1 });
            ProductPictures.Add(new ProductPicture() { ProductId = 2, PictureId = 11, DisplayOrder = 3 });
            ProductPictures.Add(new ProductPicture() { ProductId = 2, PictureId = 12, DisplayOrder = 2 });
            ProductPictures.Add(new ProductPicture() { ProductId = 3, PictureId = 10, DisplayOrder = 2 });
            ProductPictures.Add(new ProductPicture() { ProductId = 4, PictureId = 3, DisplayOrder = 4 });
            ProductPictures.Add(new ProductPicture() { ProductId = 4, PictureId = 4, DisplayOrder = 4 });
            ProductPictures.Add(new ProductPicture() { ProductId = 4, PictureId = 5, DisplayOrder = 4 });
            ProductPictures.Add(new ProductPicture() { ProductId = 5, PictureId = 6, DisplayOrder = 5 });
            ProductPictures.Add(new ProductPicture() { ProductId = 5, PictureId = 7, DisplayOrder = 5 });
            ProductPictures.Add(new ProductPicture() { ProductId = 5, PictureId = 8, DisplayOrder = 5 });

            foreach (ProductPicture pp in ProductPictures)
                context.ProductPictures.Add(pp);
            context.SaveChanges();

            //Products.Where(p => p.ProductPictures.Any(pm => pm.Picture.PictureLink.ToLower().Contains("htc1"))).ToList().ForEach(b =>
            //{
            //    var linkimg = Pictures.SingleOrDefault(t => t.PictureLink.Equals("htc1"));
            //    b.ProductPictures.Add(linkimg);
            //});

            #endregion


            #region ProductTag Mapping

            // add name tag to those phones whose name is e.g.
            Products.Where(p => p.Name.ToLower().Contains("iphone")).ToList().ForEach(i =>
            {
                var iphoneTag = Tags.SingleOrDefault(t => t.Name.Equals("iphone"));
                i.ProductTags.Add(iphoneTag);
            });

            Products.Where(p => p.Name.ToLower().Contains("nokia")).ToList().ForEach(i =>
            {
                var nokiaTag = Tags.SingleOrDefault(t => t.Name.Equals("nokia"));
                i.ProductTags.Add(nokiaTag);
            });

            Products.Where(p => p.Name.ToLower().Contains("samsung")).ToList().ForEach(i =>
            {
                var samsungTag = Tags.SingleOrDefault(t => t.Name.Equals("samsung"));
                i.ProductTags.Add(samsungTag);
            });

            Products.Where(p => p.Name.ToLower().Contains("htc")).ToList().ForEach(i =>
            {
                var htcTag = Tags.SingleOrDefault(t => t.Name.Equals("htc"));
                i.ProductTags.Add(htcTag);
            });

            Products.Where(p => p.Name.ToLower().Contains("nikon")).ToList().ForEach(i =>
            {
                var nikonTag = Tags.SingleOrDefault(t => t.Name.Equals("nikon"));
                i.ProductTags.Add(nikonTag);
            });

            // add category tag to phones 
            Products.Where(p => p.ProductCategories.Any(pm => pm.Category.Name.ToLower().Contains("phone"))).ToList().ForEach(b =>
            {
                var phoneTag = Tags.SingleOrDefault(t => t.Name.Equals("phone"));
                b.ProductTags.Add(phoneTag);
            });

            Products.Where(p => p.ProductCategories.Any(pm => pm.Category.Name.ToLower().Contains("camera"))).ToList().ForEach(b =>
            {
                var cameraTag = Tags.SingleOrDefault(t => t.Name.Equals("camera"));
                b.ProductTags.Add(cameraTag);
            });

            Products.Where(p => p.ProductCategories.Any(pm => pm.Category.Name.ToLower().Contains("wearable"))).ToList().ForEach(b =>
            {
                var wearableTag = Tags.SingleOrDefault(t => t.Name.Equals("wearable"));
                b.ProductTags.Add(wearableTag);
            });

            Products.Where(p => p.ProductCategories.Any(pm => pm.Category.Name.ToLower().Contains("tablet"))).ToList().ForEach(b =>
            {
                var tabletTag = Tags.SingleOrDefault(t => t.Name.Equals("tablet"));
                b.ProductTags.Add(tabletTag);
            });

            Products.Where(p => p.ProductCategories.Any(pm => pm.Category.Name.ToLower().Contains("laptop"))).ToList().ForEach(b =>
            {
                var laptopTag = Tags.SingleOrDefault(t => t.Name.Equals("laptop"));
                b.ProductTags.Add(laptopTag);
            });

            //add manufacturer tag to phones 
            Products.Where(p => p.ProductManufacturers.Any(pm => pm.Manufacturer.Name.ToLower().Contains("apple"))).ToList().ForEach(b =>
            {
                var appleTag = Tags.SingleOrDefault(t => t.Name.Equals("apple"));
                b.ProductTags.Add(appleTag);
            });

            Products.Where(p => p.ProductManufacturers.Any(pm => pm.Manufacturer.Name.ToLower().Contains("microsoft"))).ToList().ForEach(b =>
            {
                var microsoftTag = Tags.SingleOrDefault(t => t.Name.Equals("microsoft"));
                b.ProductTags.Add(microsoftTag);
            });

            //IList<ProductTag> ProductTags = new List<ProductTag>();
            //ProductTags.Add(new ProductTag() { ProductId = 1, TagId = 1 });
            //ProductTags.Add(new ProductTag() { ProductId = 2, TagId = 2 });
            //ProductTags.Add(new ProductTag() { ProductId = 3, TagId = 3 });
            //ProductTags.Add(new ProductTag() { ProductId = 4, TagId = 4 });
            //ProductTags.Add(new ProductTag() { ProductId = 5, TagId = 5 });

            //foreach (ProductTag pt in ProductTags)
            //context.ProductTags.Add(pt);

            context.SaveChanges();
            #endregion

            #region User
            IList<User> Users = new List<User>();
            Users.Add(new User() { UserName = "admin", Password = "admin", Privilege = 0, Email = "Email" });
            Users.Add(new User() { UserName = "user", Password = "user" });

            foreach (User user in Users)
                context.Users.Add(user);
            context.SaveChanges();
            #endregion


        }
    }
}


