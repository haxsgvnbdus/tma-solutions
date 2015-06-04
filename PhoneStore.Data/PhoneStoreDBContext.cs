using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using PhoneStore.Data.Customers;
using PhoneStore.Data.Catalog;
using PhoneStore.Data.Media;
using PhoneStore.Data.Discounts;
using PhoneStore.Data.Mappings;

namespace PhoneStore.Data
{
    public class PhoneStoreDBContext : DbContext
    {

        public PhoneStoreDBContext() : base("PhoneStoreWebData")
        {
            Database.SetInitializer<PhoneStoreDBContext>(new PhoneStoreDBInitializer()); 
        }
        
        public DbSet<Category> Categories { set; get; }
        public DbSet<Manufacturer> Manufacturers { set; get; }
        public DbSet<Product> Products { set; get; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet <ProductComment> ProductComments { get; set; }
        public DbSet<ProductManufacturer> ProductManufacturers { get; set; }
        public DbSet<ProductPicture> ProductPictures { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ProductTag> ProductTags { set; get; }


        public DbSet<Customer> Customers { get; set; }

        
        public DbSet<Picture> Pictures { set; get; }

        
        public DbSet<Discount> Discounts { get; set; }

        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new ManufactureMap());
            modelBuilder.Configurations.Add(new ProductCategoryMap());
            modelBuilder.Configurations.Add(new ProductCommentMap());
            modelBuilder.Configurations.Add(new ProductManufacturerMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new ProductPictureMap());
            modelBuilder.Configurations.Add(new ProductTagMap()); 
             
        }
      
    }
}
