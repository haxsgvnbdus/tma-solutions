using PhoneStore.Model.Customers;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore.Data.Mappings
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            this.ToTable("User");
            this.HasKey(m => m.UserID);
            this.Property(m => m.UserName).IsRequired().HasMaxLength(40); 
        }
    }
}
