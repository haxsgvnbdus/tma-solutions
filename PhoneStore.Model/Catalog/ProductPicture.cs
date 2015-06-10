using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneStore.Model.Media;

namespace PhoneStore.Model.Catalog
{
    public partial class ProductPicture : BaseEntity
    {
        public int ProductId { get; set; }

        public int PictureId { get; set; }

        public int DisplayOrder { get; set; }

        public virtual Picture Picture { get; set; }

        public virtual Product Product { get; set; }
        
    }
}

