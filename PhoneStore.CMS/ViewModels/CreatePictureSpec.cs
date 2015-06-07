using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneStore.CMS.ViewModels
{
    public class CreatePictureSpec
    {
        public byte[] PictureBinary { get; set; }
        public string MimeType { get; set; }
        public string SeoFilename { get; set; }
        public bool IsNew { get; set; }

    }
}