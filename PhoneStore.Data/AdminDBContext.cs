using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using PhoneStore.Data.Identity;

namespace PhoneStore.Data
{
    public class AdminDBContext : DbContext
    {
        public AdminDBContext()
            : base("PhoneStoreWebData")
        {

        }

        public DbSet<User> Users { set; get; }
        
    }

    
}
