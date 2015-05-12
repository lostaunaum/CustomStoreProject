using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomStore.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public string OrderDate { get; set; }
        public string OrderStatus { get; set; }
        public string OrderModifiedDate { get; set; }
        public int OrderCustomerID { get; set; }
    }
}