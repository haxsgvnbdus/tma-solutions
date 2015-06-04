using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneStore.Data.Media;

namespace PhoneStore.Data.Catalog
{
    public partial class ProductTag : BaseEntity
    {


        public int ProductId { get; set; }
        public int TagId { get; set; }

        public virtual Product Product { get; set; }

        public virtual Tag Tag { get; set; }
    }
}
