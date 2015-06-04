using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using PhoneStore.Model.Catalog;

namespace PhoneStore.Data.Mappings
{
    public class ProductTagMap :EntityTypeConfiguration<ProductTag>
    {
        public ProductTagMap()
        {
            this.ToTable("Product_Tag");
            this.HasKey(pt => pt.ID);
            //this.Property(pt => pt.Product).IsRequired();
            this.HasRequired(pt => pt.Product)
                .WithMany(p => p.ProductTags)
                .HasForeignKey(pt => pt.ProductId);

            this.HasRequired(pt => pt.Tag)
                .WithMany(t => t.ProductTags)
                .HasForeignKey(pm => pm.TagId);


        }
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              