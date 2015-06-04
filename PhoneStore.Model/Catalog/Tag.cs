using PhoneStore.Model.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore.Model.Media
{
   public class Tag : BaseEntity 
    {
       private ICollection<ProductTag> productTags;

       public String Tagline { set; get; }
       public virtual ICollection<ProductTag> ProductTags
       {
           get { return productTags ?? (productTags = new List<ProductTag>()); }
           protected set { productTags = value; }
       }
    }
}
