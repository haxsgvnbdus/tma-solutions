using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;

namespace PhoneStore.CMS.Models
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            this.ToTable("Admin");
            this.HasKey(c => c.ID);
            this.Property(c => c.Password).IsRequired();
            this.Property(c => c.Roles).IsRequired(); 
        }
    }
}