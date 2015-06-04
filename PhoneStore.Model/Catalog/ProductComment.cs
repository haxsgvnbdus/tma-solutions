using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore.Data.Catalog
{
    public partial class ProductComment : BaseEntity
    {
        public int ProductID { get; set;  }
        public int CustomerID { get; set; }

        public bool IsApproved { get; set; }

        public string Title { get; set; }

        public string ReviewText { get; set; }
        
    }
}
