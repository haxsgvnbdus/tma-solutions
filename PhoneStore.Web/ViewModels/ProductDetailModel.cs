using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PhoneStore.Model.Catalog;
using PhoneStore.Model.Discounts;

namespace PhoneStore.Web.ViewModels
{

    public class ProductDetailModel
    {

        
        private ICollection<ProductPicture> _productPictures;
        private ICollection<ProductComment> _productComments;
        private ICollection<ProductTag> _productTags;
        private ICollection<Discount> _appliedDiscounts;
        public string Name { set; get; }

        public string Description { set; get; }
        public decimal Price { get; set; }
        public string Sku { get; set; }

        public virtual ICollection<ProductPicture> ProductPictures
        {
            get { return _productPictures ?? (_productPictures = new List<ProductPicture>()); }
            protected set { _productPictures = value; }
        }

        public virtual ICollection<ProductComment> ProductComments
        {
            get { return _productComments ?? (_productComments = new List<ProductComment>()); }
            protected set { _productComments = value; }
        }

        public virtual ICollection<ProductTag> ProductTags
        {
            get { return _productTags ?? (_productTags = new List<ProductTag>()); }
            protected set { _productTags = value; }
        }

        public virtual ICollection<Discount> AppliedDiscounts
        {
            get { return _appliedDiscounts ?? (_appliedDiscounts = new List<Discount>()); }
            protected set { _appliedDiscounts = value; }
        }
    }
}