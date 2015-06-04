using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneStore.Model.Catalog;
using System.Data.Entity.ModelConfiguration;

namespace PhoneStore.Data.Mappings
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap() 
        {
            this.ToTable("Product");
            this.HasKey(p => p.ID);
            this.Property(p => p.Name).IsRequired().HasMaxLength(400);
            this.Property(p => p.MetaKeywords).HasMaxLength(400);
            this.Property(p => p.MetaTitle).HasMaxLength(400);
            this.Property(p => p.Sku).HasMaxLength(400);
            this.Property(p => p.Price).HasPrecision(18, 4);
            this.Ignore(p => p.ProductType);
        }
    }
}
