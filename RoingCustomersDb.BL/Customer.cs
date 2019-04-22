using System;

namespace RoingCustomersDb.BL
{
    public class Customer
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime? Birthdate { get; set; }
    }
}
