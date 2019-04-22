using System.Collections.Generic;
using System.Threading.Tasks;

namespace RoingCustomersDb.BL
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetCustomersAsync();
        Task<Customer> GetCustomerByIdAsync(int id);
        Task AddCustomerAsync(Customer customer);
        Task UpdateCustromerAsync(Customer customer);
        Task DeleteCustomerAsync(Customer customer);
    }
}
