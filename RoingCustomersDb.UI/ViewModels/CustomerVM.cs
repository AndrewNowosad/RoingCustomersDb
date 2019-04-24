using RoingCustomersDb.BL;
using System;

namespace RoingCustomersDb.UI.ViewModels
{
    public class CustomerVM : VM
    {
        public Customer Customer { get; }

        public CustomerVM(Customer customer = null) =>
            Customer = customer ?? new Customer();

        public int Id => Customer.Id;

        public string LastName
        {
            get => Customer.LastName;
            set
            {
                var lastName = Customer.LastName;
                if (Set(ref lastName, value))
                    Customer.LastName = lastName;
            }
        }

        public string FirstName
        {
            get => Customer.FirstName;
            set
            {
                var firstName = Customer.FirstName;
                if (Set(ref firstName, value))
                    Customer.FirstName = firstName;
            }
        }

        public DateTime? Birthdate
        {
            get => Customer.Birthdate;
            set
            {
                var birthdate = Customer.Birthdate;
                if (Set(ref birthdate, value))
                    Customer.Birthdate = birthdate;
            }
        }
    }
}
