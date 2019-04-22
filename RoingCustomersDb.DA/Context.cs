using RoingCustomersDb.BL;
using System.Data.Entity;

namespace RoingCustomersDb.DA
{
    public class Context : DbContext
    {
        public Context() : base("name=Context") { }

        public DbSet<Customer> Customers { get; set; }
    }
}