using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using PhoneStore.Model.Catalog;

namespace PhoneStore.Data.Mappings
{
    public class ManufactureMap : EntityTypeConfiguration<Manufacturer> 
    {
        public ManufactureMap()
        {
            this.ToTable("Manufacturer");
            this.HasKey(m => m.ID);
            this.Property(m => m.Name).IsRequired().HasMaxLength(400);

        }        
    
    }
}
