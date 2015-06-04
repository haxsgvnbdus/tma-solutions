using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using PhoneStore.Model.Catalog;

namespace PhoneStore.Data.Mappings
{
    public class ProductPictureMap : EntityTypeConfiguration<ProductPicture>
    {
        public ProductPictureMap()
        {
            this.ToTable("Product_Picture");
            this.HasKey(pm => pm.ID);

            this.HasRequired(pm => pm.Picture)
                .WithMany()
                .HasForeignKey(pm => pm.PictureId);


            this.HasRequired(pm => pm.Product)
                .WithMany(p => p.ProductPictures)
                .HasForeignKey(pm => pm.ProductId);


        }
    }
}
