using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore.Model.Catalog
{
    public partial class ProductComment : BaseEntity
    {
        public int ProductID { get; set;  }
        public string CustomerID { get; set; }

        public bool IsApproved { get; set; }

        public string Title { get; set; }

        public string ReviewText { get; set; }
        
    }
}
