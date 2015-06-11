using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PhoneStore.Model.Catalog;
using PhoneStore.Model.Media;
using PhoneStore.Model.Discounts;
using PhoneStore.Model.Catalog;


namespace PhoneStore.CMS.ViewModels
{
    public class DetailProductSpec
    {
        //public int ID { get; set; }
        public IndexProductSpec IndexSpec { get; set; }

        public IEnumerable<ProductCategory> ProductCategories { get; set; }
        //public IEnumerable<ProductManufacturer> ProductManufacturers { get; set; }
        //public IEnumerable<ProductPicture> ProductPictures { get; set; }
        //public IEnumerable<ProductComment> ProductComments { get; set; }
        //public IEnumerable<ProductTag> ProductTags { get; set; }
        //public IEnumerable<Discount> Discounts { get; set; 
        
        
    }
}