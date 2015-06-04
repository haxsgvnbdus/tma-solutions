using PhoneStore.Data.Catalog;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PhoneStore.Data.Mappings
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            this.ToTable("Category");
            this.HasKey(c => c.ID);
            this.Property(c => c.Name).IsRequired().HasMaxLength(400);
            this.Property(c => c.MetaDescription).HasMaxLength(400);
            this.Property(c => c.MetaTitle).HasMaxLength(400);
            this.Property(c => c.PriceRanges).HasMaxLength(400);

        }
    }
}
