using CustomStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace CustomStore.Controllers
{
    //Customers 
    public class CustomersController : ApiController
    {
        Customer[] customers = new Customer[] 
        { 
            new Customer { CustomerId = 1, CustomerName = "Marco Andre Lostaunau", CustomerAddress1 = "305 Miami Ave", CustomerAddress2 = "Apt 402", CustomerCity = "Miami", CustomerState = "FL", CustomerZipCode = 33131 }, 
            new Customer { CustomerId = 2, CustomerName = "Marco Polo De La Vega", CustomerAddress1 = "123 Alton Road", CustomerAddress2 = "", CustomerCity = "Miami", CustomerState = "FL", CustomerZipCode = 33132 },
        };
        // GET api/values
        public IEnumerable<Customer> GetAllCustomers()
        {
            return customers;
        }

        // GET api/values/5
        public string Get(int id)
        {
            var customer = customers.FirstOrDefault((p) => p.CustomerId == id);
            var error = "No Customer was found";
            if (customer != null)
            {
                return customer.CustomerName;
            }
            return error;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}