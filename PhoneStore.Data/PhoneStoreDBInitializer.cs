using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using PhoneStore.Data;
using PhoneStore.Data.Customers;
using PhoneStore.Data.Catalog;
using PhoneStore.Data.Media;

namespace PhoneStore.Data
{
    public class PhoneStoreDBInitializer : DropCreateDatabaseAlways<PhoneStoreDBContext>
    {
        protected override void Seed(PhoneStoreDBContext context)
        {
            IList<Category> Categories = new List<Category>();

            Categories.Add(new Category
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
            });
            Categories.Add(new Category 
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
            });

            foreach (Category cat in Categories)
                context.Categories.Add(cat);

            IList<Customer> Customers = new List<Customer>();
            Customers.Add(new Customer() { Name = "Han" });
            Customers.Add(new Customer() { Name = "Duy Anh" });
            Customers.Add(new Customer() { Name = "Hanh" });
            Customers.Add(new Customer() { Name = "Quyen Do" }); 
            Customers.Add(new Customer() { Name = "Nhan" }); 
            Customers.Add(new Customer() { Name = "Loi" });

            foreach (Customer cus in Customers)
                context.Customers.Add(cus);

            IList<Manufacturer> Manufacturers = new List<Manufacturer>();
            Manufacturers.Add(new Manufacturer() { Name = "Apple" });
            Manufacturers.Add(new Manufacturer() { Name = "Samsung" });
            Manufacturers.Add(new Manufacturer() { Name = "LG" });
            Manufacturers.Add(new Manufacturer() { Name = "BPhone" }); 
            Manufacturers.Add(new Manufacturer() { Name = "Sony" });
            Manufacturers.Add(new Manufacturer() { Name = "Nokia" });

            foreach (Manufacturer manu in Manufacturers)
                context.Manufacturers.Add(manu);

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
                Products.Add(pro);

            base.Seed(context);
        }
    }
}
