using CustomStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace CustomStore.Controllers
{

    public class OrdersController : ApiController
    {
        //Orders 
        Order[] orders = new Order[] 
        { 
            new Order { Id = 1, OrderNumber = "123-ZXZ-345", OrderDate = "05/12/2015", OrderCustomerID = 1, OrderModifiedDate = "12/05/2015", OrderStatus = "Not Shipped" }, 
            new Order { Id = 1, OrderNumber = "123-SDC-345", OrderDate = "05/13/2015", OrderCustomerID = 1, OrderModifiedDate = "12/05/2015", OrderStatus = "Shipped" }, 
            new Order { Id = 1, OrderNumber = "123-XXC-345", OrderDate = "05/14/2014", OrderCustomerID = 2, OrderModifiedDate = "12/05/2015", OrderStatus = "Not Shipped" },  
        };

        public IEnumerable<Order> GetAllOrders()
        {
            return orders;
        }

        public string Get(int id)
        {
            var order = orders.FirstOrDefault((p) => p.Id == id);
            var error = "No Order was found";
            if (order != null)
            {
                return order.OrderNumber;
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
