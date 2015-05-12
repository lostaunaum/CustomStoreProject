using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomStore.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string ItemSKU { get; set; }
        public decimal ItemWeight { get; set; }
        public string ItemImage { get; set; }
        public int OrderID { get; set; }
    }
}