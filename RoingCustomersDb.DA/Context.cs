using RoingCustomersDb.BL;
using System.Data.Entity;

namespace RoingCustomersDb.DA
{
    public class Context : DbContext
    {
        static Context()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<Context>());
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>());
        }

        public Context() : base("name=Context") { }

        public DbSet<Customer> Customers { get; set; }
    }
}