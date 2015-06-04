using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneStore.Data.Discounts;
using PhoneStore.Data;

namespace PhoneStore.Data.Catalog
{
    public partial class Category : BaseEntity, ISoftDeleteable
    {
        private ICollection<Discount> appliedDiscounts;

        public string Name { get; set; }

        public string Description { get; set; }

        public string PriceRanges { get; set; }

        public string MetaKeywords { get; set; }

        public string MetaDescription { get; set; }

        public string MetaTitle { get; set; }

        public int ParentCategoryId { get; set; }

        public int PictureId { get; set; }

        public int DisplayOrder { get; set; }

        public bool Deleted { get; set; }

        public bool ShowOnHomePage { get; set; }

        public bool IncludeInTopMenu { get; set; }

        public bool HasDiscountsApplied { get; set; }

        public DateTime CreatedOnUtc { get; set; }

        public DateTime UpdatedOnUtc { get; set; }

        public virtual ICollection<Discount> AppliedDiscounts
        {
            get { return appliedDiscounts ?? (appliedDiscounts = new List<Discount>()); }
            set { appliedDiscounts = value; }
        }
    }
}
