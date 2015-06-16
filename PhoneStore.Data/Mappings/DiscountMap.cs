using PhoneStore.Model.Discounts;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore.Data.Mappings
{
    public class DiscountMap : EntityTypeConfiguration<Discount>
    {
        public DiscountMap()
        {
            this.ToTable("Discount");
            this.HasKey(d => d.ID);
            this.Property(d => d.Name).IsRequired().HasMaxLength(200);
            this.Property(d => d.DiscountPercentage).HasPrecision(18, 4);
            this.Property(d => d.DiscountAmount).HasPrecision(18, 4);

            this.Ignore(d => d.DiscountType);

            this.HasMany(dr => dr.AppliedToCategories)
                .WithMany(c => c.AppliedDiscounts)
                .Map(m => m.ToTable("Discount_AppliedToCategories"));

            this.HasMany(dr => dr.AppliedToProducts)
                .WithMany(p => p.AppliedDiscounts)
                .Map(m => m.ToTable("Discount_AppliedToProducts"));
        }
    }
}
