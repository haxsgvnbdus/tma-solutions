using PhoneStore.Model.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore.Model.Catalog
{
   public class ProductTag : BaseEntity 
    {
       private ICollection<Product> products;

       public String Name { set; get; }

       public virtual ICollection<Product> Products
       {
           get { return products ?? (products = new List<Product>()); }
           protected set { products = value; }
       }
    }
}
