using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore.Data
{
    public class Purchase
    {
        public int CustomerID { get; set; }
        public int ProductID { get; set; }

        public DateTime PurchaseTime { get; set; }
    }
}
