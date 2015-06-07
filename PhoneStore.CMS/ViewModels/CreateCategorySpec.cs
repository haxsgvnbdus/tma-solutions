using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneStore.CMS.ViewModels
{
    public class CreateCategorySpec
    {
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
    }
}