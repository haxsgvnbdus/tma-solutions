using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using PhoneStore.Model.Identity;

namespace PhoneStore.Data.Mappings
{
    class IdentityMap : EntityTypeConfiguration<User>
    {
        public IdentityMap()
        {
            this.ToTable("Identity");
            this.HasKey(c => c.ID);
            this.Property(c => c.Name).IsRequired().HasMaxLength(100);
            this.Property(c => c.Password).IsRequired();
            this.Property(c => c.Roles).IsRequired();

        }
    }
}
