using RoingCustomersDb.BL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Threading.Tasks;

namespace RoingCustomersDb.DA
{
    public class EFCustomerRepository : ICustomerRepository
    {
        private readonly IDbContextFactory<Context> contextFactory;

        public EFCustomerRepository(IDbContextFactory<Context> contextFactory)
        {
            if (contextFactory is null)
                throw new ArgumentNullException(nameof(contextFactory));

            this.contextFactory = contextFactory;
        }

        public async Task<IEnumerable<Customer>> GetCustomersAsync()
        {
            using (var context = contextFactory.Create())
                return await context.Customers.ToListAsync();
        }

        public async Task<Customer> GetCustomerByIdAsync(int id)
        {
            using (var context = contextFactory.Create())
                return await context.Customers.FindAsync(id);
        }

        public async Task AddCustomerAsync(Customer customer)
        {
            using (var context = contextFactory.Create())
            {
                var newCustomer = new Customer
                {
                    LastName = customer.LastName,
                    FirstName = customer.FirstName,
                    Birthdate = customer.Birthdate
                };
                context.Customers.Add(newCustomer);
                await context.SaveChangesAsync();
            }
        }

        public async Task UpdateCustromerAsync(Customer customer)
        {
            using (var context = contextFactory.Create())
            {
                context.Entry(customer).State = EntityState.Modified;
                await context.SaveChangesAsync();
            }
        }

        public async Task DeleteCustomerAsync(Customer customer)
        {
            using (var context = contextFactory.Create())
            {
                context.Entry(customer).State = EntityState.Deleted;
                await context.SaveChangesAsync();
            }
        }

        public static EFCustomerRepository Create() =>
            new EFCustomerRepository(new ContextFactory());
    }
}
