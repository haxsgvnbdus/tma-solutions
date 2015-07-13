using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneStore.Web.ViewModels
{
    public class ProductPictureDetailsModel
    {
        public PictureViewModel main { get; set; }

        public List<PictureViewModel> gallery { get; set; }
    }

    public class PictureViewModel
    {
        public string label { get; set; }

        public string orig { get; set; }

        public string thumb { get; set; }
        
        public string main { get; set; }
    }
}