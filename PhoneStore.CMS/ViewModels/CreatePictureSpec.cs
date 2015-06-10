using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneStore.CMS.ViewModels
{
    public class CreatePictureSpec
    {
        public int ID { set; get; }
        public string PictureLink { get; set; }
        public string MimeType { get; set; }
        public string SeoFilename { get; set; }
        public bool IsNew { get; set; }

    }
}