using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using PhoneStore.CMS.Models;


namespace PhoneStore.CMS
{
    public class AdminDBContext : DbContext
    {
        public AdminDBContext()
            : base("PhoneStoreWebData")
        {
            Database.SetInitializer<AdminDBContext>(new DBInitializer());
        }

        public DbSet<User> Users { set; get; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new UserMap());
        }

    }

    
}
