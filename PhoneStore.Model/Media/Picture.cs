using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneStore.Data.Catalog;
using PhoneStore.Data;

namespace PhoneStore.Data.Media
{
    public partial class Picture : BaseEntity
    {
        private ICollection<ProductPicture> productPictures;
        /// <summary>
        /// Gets or sets the picture binary
        /// </summary>
        public byte[] PictureBinary { get; set; }

        /// <summary>
        /// Gets or sets the picture mime type
        /// </summary>
        public string MimeType { get; set; }

        /// <summary>
        /// Gets or sets the SEO friednly filename of the picture
        /// </summary>
        public string SeoFilename { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the picture is new
        /// </summary>
        public bool IsNew { get; set; }

        /// <summary>
        /// Gets or sets the product pictures
        /// </summary>
        public virtual ICollection<ProductPicture> ProductPictures
        {
            get { return productPictures ?? (productPictures = new List<ProductPicture>()); }
            protected set { productPictures = value; }
        }
    }
}
