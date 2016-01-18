using addressandcustomermodel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace addressandcustomermodel.Controllers
{
    public class CustomersController : ApiController
    {
        static IList<Customer> _customers = new List<Customer>()
        {
            new Customer()
            {
                Id = 0,
                Firstname = "First",
                LastName = "Last",
                ShippingAddress = new Address()
                {
                    Id = 0,
                    Street = "Street",
                    City = "City"
                },
                BillingAddress = new Address()
                {
                    Id = 0,
                    Street = "Street",
                    City = "City"
                }

            }


        };


        public IEnumerable<Customer> Get()
        {
            return _customers;
        }
        
        public IHttpActionResult Post(Customer customer)
        {
            _customers.Add(customer);
            return Ok();

        }
    }
}

