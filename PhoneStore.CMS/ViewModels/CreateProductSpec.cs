using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneStore.CMS.ViewModels
{
    public class CreateProductSpec
    {
        public string Name { set; get; }
        public string Description { set; get; }
        public decimal Price { get; set; }
        public bool IsHot { get; set; }
        public int StockQuantity { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }

        public string MetaTitle { get; set; }

        public string Sku { get; set; }
        public int ProductTypeId { get; set; }

    }
}