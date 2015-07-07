using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using PhoneStore.Model.Catalog;
using PhoneStore.Model.Discounts;
using PhoneStore.Model.Media;

namespace PhoneStore.CMS.ViewModels
{
    public class CreateProductSpec 
    {

        private ICollection<ProductPicture> _productPictures;
        private ICollection<ProductComment> _productComments;
        private ICollection<Discount> _appliedDiscounts;
        
        public int ID { get; set; }
        public string Name { set; get; }
        
        [UIHint("tinymce_full"), AllowHtml]
        public string Description { set; get; }
        public decimal Price { get; set; }
        public bool IsHot { get; set; }

        [Range(0, 1000, ErrorMessage = "Beyond extension")]
        public int StockQuantity { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }

        public string MetaTitle { get; set; }

        public DateTime? CreatedOnUtc { get; set; }
        public DateTime? UpdatedOnUtc { get; set; }

        public string Sku { get; set; }
        public int ProductTypeId { get; set; }

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

        public virtual ICollection<Discount> AppliedDiscounts
        {
            get { return _appliedDiscounts ?? (_appliedDiscounts = new List<Discount>()); }
            protected set { _appliedDiscounts = value; }
        }


    }
}   