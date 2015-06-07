using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using PhoneStore.CMS.Models;

namespace PhoneStore.CMS
{
   public class DBInitializer : DropCreateDatabaseAlways<AdminDBContext>
    {
        protected override void Seed(AdminDBContext context)
        {
            IList<User> Users = new List<User>();
            Users.Add(new User
            {
                Name = "nda1291",
                Roles = "boss"
            });
            Users.Add(new User
            {
                Name = "hanngo2911",
                Roles = "unpaid osin"
            });

            foreach (User u in Users)
                context.Users.Add(u);

            base.Seed(context);
        }
    }
}
