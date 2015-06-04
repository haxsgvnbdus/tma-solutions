using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using PhoneStore.Model.Catalog;

namespace PhoneStore.Data.Mappings
{
    public class ProductCommentMap : EntityTypeConfiguration<ProductComment>
    {
      public ProductCommentMap() {
          this.ToTable("Product_Comment");
          this.HasKey(pt => pt.ID);
          this.Property(pt => pt.CustomerID).IsRequired();
          this.Property(pt => pt.ProductID).IsRequired();
          this.Property(pt => pt.IsApproved).IsRequired();
          this.Property(pt => pt.Title).IsRequired();
          this.Property(pt => pt.ReviewText).IsRequired(); 


      }
    }
}
