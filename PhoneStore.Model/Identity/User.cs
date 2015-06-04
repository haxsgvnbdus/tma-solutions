using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore.Data.Identity
{
    public class User : BaseEntity
    {
        public int UserID { set; get; }
        public String Name { set; get; }

        public String Password { set; get;  }
    }
}
