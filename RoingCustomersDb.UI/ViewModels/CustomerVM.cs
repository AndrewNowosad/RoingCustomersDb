using RoingCustomersDb.BL;
using System;

namespace RoingCustomersDb.UI.ViewModels
{
    class CustomerVM : VM
    {
        private readonly Customer customer;

        public CustomerVM(Customer customer) =>
            this.customer = customer ?? new Customer();

        public int Id => customer.Id;

        public string LastName
        {
            get => customer.LastName;
            set
            {
                var lastName = customer.LastName;
                if (Set(ref lastName, value))
                    customer.LastName = lastName;
            }
        }

        public string FirstName
        {
            get => customer.FirstName;
            set
            {
                var firstName = customer.FirstName;
                if (Set(ref firstName, value))
                    customer.FirstName = firstName;
            }
        }

        public DateTime? Birthdate
        {
            get => customer.Birthdate;
            set
            {
                var birthdate = customer.Birthdate;
                if (Set(ref birthdate, value))
                    customer.Birthdate = birthdate;
            }
        }
    }
}
