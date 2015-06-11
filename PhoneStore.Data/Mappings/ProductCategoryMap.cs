using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneStore.Model.Catalog;
using System.Data.Entity.ModelConfiguration;

namespace PhoneStore.Data.Mappings
{
    public class ProductCategoryMap : EntityTypeConfiguration<ProductCategory> 
    {
        public ProductCategoryMap () 
        {
            this.ToTable("Product_Category");
            this.HasKey(pc => pc.ID);
            
            this.HasRequired(pc => pc.Category)
                .WithMany()
                .HasForeignKey(pc => pc.CategoryID);

            this.HasRequired(pc => pc.Product)
                .WithMany(p => p.ProductCategories)
                .HasForeignKey(pc => pc.ProductID);
        }
    }
}
