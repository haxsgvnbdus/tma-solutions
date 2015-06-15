using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PhoneStore.CMS.ViewModels
{
    public class IndexCategorySpec
    {
        
        public int ID { set; get; }

        [Display(Name="Category Name")]
        public string Name { get; set; }

        public string Description { get; set; }

        public string PriceRanges { get; set; }

        public string MetaKeywords { get; set; }

        public string MetaDescription { get; set; }

        public string MetaTitle { get; set; }

        public int ParentCategoryId { get; set; }

        public int PictureId { get; set; }

        public int DisplayOrder { get; set; }

        public bool IncludeInTopMenu { get; set; }

        public bool HasDiscountsApplied { get; set; }

        public DateTime? CreatedOnUtc { get; set; }

        public DateTime? UpdatedOnUtc { get; set; }

    }
}