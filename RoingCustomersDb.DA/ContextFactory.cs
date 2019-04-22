using System.Data.Entity.Infrastructure;

namespace RoingCustomersDb.DA
{
    public class ContextFactory : IDbContextFactory<Context>
    {
        public Context Create() => new Context();
    }
}
