using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneStore.Data;
using PhoneStore.Data.Catalog;

namespace PhoneStore.Data.Discounts
{
    public partial class Discount : BaseEntity
    {
        private ICollection<Category> appliedToCategories;
        private ICollection<Product> appliedToProducts;

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the discount type identifier
        /// </summary>
        public int DiscountTypeId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to use percentage
        /// </summary>
        public bool UsePercentage { get; set; }

        /// <summary>
        /// Gets or sets the discount percentage
        /// </summary>
        public decimal DiscountPercentage { get; set; }

        /// <summary>
        /// Gets or sets the discount amount
        /// </summary>
        public decimal DiscountAmount { get; set; }

        /// <summary>
        /// Gets or sets the discount start date and time
        /// </summary>
        public DateTime? StartDateUtc { get; set; }

        /// <summary>
        /// Gets or sets the discount end date and time
        /// </summary>
        public DateTime? EndDateUtc { get; set; }

        /// <summary>
        /// Gets or sets the discount type
        /// </summary>
        public DiscountType DiscountType
        {
            get
            {
                return (DiscountType)this.DiscountTypeId;
            }
            set
            {
                this.DiscountTypeId = (int)value;
            }
        }

        /// <summary>
        /// Gets or sets the categories
        /// </summary>
        public virtual ICollection<Category> AppliedToCategories
        {
            get { return appliedToCategories ?? (appliedToCategories = new List<Category>()); }
            protected set { appliedToCategories = value; }
        }

        /// <summary>
        /// Gets or sets the products 
        /// </summary>
        public virtual ICollection<Product> AppliedToProducts
        {
            get { return appliedToProducts ?? (appliedToProducts = new List<Product>()); }
            protected set { appliedToProducts = value; }
        }
    }
}
