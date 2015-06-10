using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using PhoneStore.Data;
using PhoneStore.Model.Customers;
using PhoneStore.Model.Catalog;
using PhoneStore.Model.Media;

namespace PhoneStore.Data
{
    public class PhoneStoreDBInitializer : DropCreateDatabaseIfModelChanges<PhoneStoreDBContext>
    {
        protected override void Seed(PhoneStoreDBContext context)
        {
            IList<Category> Categories = new List<Category>();

            Categories.Add(new Category
            {
                Name = "IPhone2",
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
            Categories.Add(new Category 
            {
                Name = "IPhone3",
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

            foreach (Category cat in Categories)
                context.Categories.Add(cat);
            context.SaveChanges();

            IList<Customer> Customers = new List<Customer>();
            Customers.Add(new Customer() { Name = "Han" });
            Customers.Add(new Customer() { Name = "Duy Anh" });
            Customers.Add(new Customer() { Name = "Hanh" });
            Customers.Add(new Customer() { Name = "Quyen Do" }); 
            Customers.Add(new Customer() { Name = "Nhan" }); 
            Customers.Add(new Customer() { Name = "Loi" });

            foreach (Customer cus in Customers)
                context.Customers.Add(cus);
            context.SaveChanges();


            IList<Tag> Tags = new List<Tag>();
            Tags.Add(new Tag() { Tagline = "dumb like a hub" });
            Tags.Add(new Tag() { Tagline = "cool like a pool" });
            Tags.Add(new Tag() { Tagline = "goodie-tootsy" });

            foreach (Tag tag in Tags)
                context.Tags.Add(tag);
                context.SaveChanges();

            IList<Picture> Pictures = new List<Picture>();
            Pictures.Add(new Picture() { PictureLink = "/Images/w595-detail.jpg", MimeType = "", IsNew = true, SeoFilename = ""  });
            Pictures.Add(new Picture() { PictureLink = "/Images/zxs.jpg", MimeType = "", IsNew = true, SeoFilename = "" });
            Pictures.Add(new Picture() { PictureLink = "/Images/zxs.jpg", MimeType = "", IsNew = true, SeoFilename = "" });
            Pictures.Add(new Picture() { PictureLink = "/Images/zxs.jpg", MimeType = "", IsNew = true, SeoFilename = "" });
            
            foreach (Picture picture in Pictures)
                context.Pictures.Add(picture);
            context.SaveChanges();


            IList<Manufacturer> Manufacturers = new List<Manufacturer>();
            Manufacturers.Add(new Manufacturer() { Name = "Apple" });
            Manufacturers.Add(new Manufacturer() { Name = "Samsung" });
            Manufacturers.Add(new Manufacturer() { Name = "LG" });
            Manufacturers.Add(new Manufacturer() { Name = "BPhone" }); 
            Manufacturers.Add(new Manufacturer() { Name = "Sony" });
            Manufacturers.Add(new Manufacturer() { Name = "Nokia" });

            foreach (Manufacturer manu in Manufacturers)
                context.Manufacturers.Add(manu);
            context.SaveChanges();

            IList<Product> Products = new List<Product>();
            Products.Add(new Product()
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
                Sku = "19d212",
                CreatedOnUtc = DateTime.UtcNow,
                UpdatedOnUtc = DateTime.UtcNow,
                ProductTypeId = 1,
                ProductType = ProductType.GroupedProduct
            });
            Products.Add(new Product()
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
                CreatedOnUtc = DateTime.UtcNow,
                UpdatedOnUtc = DateTime.UtcNow,
                ProductTypeId = 1,
                ProductType = ProductType.GroupedProduct
            });
            Products.Add(new Product()
            {
                Name = "Iphone3S",
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
                CreatedOnUtc = DateTime.UtcNow,
                UpdatedOnUtc = DateTime.UtcNow,
                ProductTypeId = 1,
                ProductType = ProductType.GroupedProduct
            });

            foreach (Product pro in Products)
                context.Products.Add(pro);
            context.SaveChanges();

            

            base.Seed(context);
        }
    }
}
