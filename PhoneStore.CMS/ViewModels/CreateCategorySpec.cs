using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace PhoneStore.CMS.ViewModels
{
    public class CreateCategorySpec
    {
        public int ID { set; get; }
        [Required(ErrorMessage = "Category name is required")]
        [StringLength(25)]
        public string Name { get; set; }

        [UIHint("tinymce_full"), AllowHtml]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [RegularExpression("(([0-9]{2,4})-([0-9]{3,4}))?", ErrorMessage = "Price range format should be #-#")] 
        [Required(ErrorMessage = "Price Ranges is required")]
        public string PriceRanges { get; set; }

        public string MetaKeywords { get; set; }

        public string MetaDescription { get; set; }

        public string MetaTitle { get; set; }

        public int ParentCategoryId { get; set; }

        public int PictureId { get; set; }

        [Required(ErrorMessage = "Display order is required")]
        public int DisplayOrder { get; set; }

        [Required(ErrorMessage = "Confirmation on menu inclusion is required")]
        public bool IncludeInTopMenu { get; set; }

        [Required(ErrorMessage = "Does the product apply any discount?")]
        public bool HasDiscountsApplied { get; set; }

        public DateTime CreatedOnUtc { get; set; }

        public DateTime UpdatedOnUtc { get; set; }
    }
}