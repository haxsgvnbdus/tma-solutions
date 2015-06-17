using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhoneStore.CMS.ViewModels
{
    public class IndexProductSpec
    {
        
        public int ID { get; set; }
        public string Name { set; get; }

        [UIHint("tinymce_full"), AllowHtml]
        public string Description { set; get; }
        public decimal Price { get; set; }
        public bool IsHot { get; set; }
        public int StockQuantity { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }

        public string MetaTitle { get; set; }

        public string Sku { get; set; }
        public int ProductTypeId { get; set; }

        public DateTime? CreatedOnUtc { get; set; }

        public DateTime? UpdatedOnUtc { get; set; }


    }
}