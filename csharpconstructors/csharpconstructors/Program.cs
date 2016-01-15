using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpconstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Address mikesAddress = new Address()
            {
                Street = "55555 Place Rd",
                City = "Houston",
                State = "TX",
                Zipcode = "77070"
            };

            Customer mike = new Customer()
            {
                FirstName = "Mike",
                LastName = "Harrison",
                BillingAddress = mikesAddress,
                ShippingAddress = mikesAddress
            };

        }
    }
}
