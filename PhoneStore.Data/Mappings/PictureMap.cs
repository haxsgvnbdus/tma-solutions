using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using PhoneStore.Model.Media;


namespace PhoneStore.Data.Mappings
{
    class PictureMap : EntityTypeConfiguration<Picture>
    {
        public PictureMap() 
        { 
            this.ToTable("Picture");
            this.HasKey(c => c.ID);
            this.Property(c => c.IsNew).IsOptional();
            this.Property(c => c.SeoFilename).IsOptional();
            this.Property(c => c.MimeType).IsOptional();
            this.Property(c => c.PictureLink).IsRequired();
        }         
    }
}
