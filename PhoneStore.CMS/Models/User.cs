using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore.Model.Identity
{
    public class User : BaseEntity
    {
        public string Name { set; get; }

        public string Roles { set; get; }

        public string Password { set; get;  }
    }
}
