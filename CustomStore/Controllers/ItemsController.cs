using CustomStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;


namespace CustomStore.Controllers
{
    class ItemsController : ApiController
    {
        //Items 
        Item[] items = new Item[] 
        { 
            new Item { ItemId = 1, ItemSKU = "THEREALDEAL", ItemImage = "05/12/2015", ItemWeight = 15, OrderID = 1}, 
            new Item { ItemId = 2, ItemSKU = "THENOTSOREALDEAL", ItemImage = "05/13/2015", ItemWeight = 12, OrderID = 1 }, 
            new Item { ItemId = 3, ItemSKU = "THEONECHOSENBYHIM", ItemImage = "05/14/2014", ItemWeight = 72, OrderID = 2 },  
            new Item { ItemId = 4, ItemSKU = "THEREALDEAL", ItemImage = "05/12/2015", ItemWeight = 15, OrderID = 2}, 
            new Item { ItemId = 5, ItemSKU = "THENOTSOREALDEAL", ItemImage = "05/13/2015", ItemWeight = 12, OrderID = 3 }, 
            new Item { ItemId = 6, ItemSKU = "THEONECHOSENBYHIM", ItemImage = "05/14/2014", ItemWeight = 72, OrderID = 3 },  
        };

        public IEnumerable<Item> GetAllOrders()
        {
            return items;
        }

        public string Get(int id)
        {
            var item = items.FirstOrDefault((p) => p.ItemId == id);
            var error = "No Order was found";
            if (item != null)
            {
                return item.ItemSKU;
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
