using System.Collections.Generic;

namespace RoingCustomersDb.BL
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetCustomers();
        Customer GetCustomerById(int id);
        void AddCustomer(Customer customer);
        void UpdateCustromer(Customer customer);
        void DeleteCustomer(Customer customer);
    }
}
