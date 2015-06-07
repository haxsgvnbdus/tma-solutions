using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneStore.CMS.ViewModels
{
    public class CreateDiscountSpec
    {
        public string Name { get; set; }
        public int DiscountTypeId { get; set; }
        public bool UsePercentage { get; set; }
        public decimal DiscountPercentage { get; set; }
        public decimal DiscountAmount { get; set; }
        public DateTime? StartDateUtc { get; set; }
        public DateTime? EndDateUtc { get; set; }
    }
}