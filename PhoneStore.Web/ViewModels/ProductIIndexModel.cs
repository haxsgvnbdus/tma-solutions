using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PhoneStore.Model.Catalog;

namespace PhoneStore.Web.ViewModels
{
    public class ProductIndexModel
    {

        public string Name { set; get; }
        public decimal Price { get; set; }

        public ICollection<ProductPicture> _productPictures;

        //public virtual ICollection<ProductPicture> ProductPictures
        //{
        //    get { return _productPictures ?? (_productPictures = new List<ProductPicture>()); }
        //    protected set { _productPictures = value; }
        //}

    }
}