using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore.Model.Customers
{
    public partial class Customer : BaseEntity
    {
        //private ICollection<ExternalAuthenticationRecord> _externalAuthenticationRecords;
        //private ICollection<CustomerRole> _customerRoles;
        //private ICollection<Address> _addresses;

        public string Name { get; set; }
    }
}
