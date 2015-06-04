using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneStore.Data;

namespace PhoneStore.Data.Catalog
{
    /// <summary>
    /// Represents a product category mapping
    /// </summary>
    public partial class ProductCategory : BaseEntity
    {
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsFeaturedProduct { get; set; }
        public virtual Product Product { get; set;  }
        public virtual Category Category { get; set;  }

        



       

    }
}
