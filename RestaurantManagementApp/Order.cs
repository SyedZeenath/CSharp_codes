using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementApp
{
    class Order :IMenuItem
    {
        public string ItemName { get; private set; }
        public int Price { get; }
        public int Quantity { get; private set; }

        public Order(string item, int quantity)
        {
            this.ItemName = item;
            //this.Price = price;
            this.Quantity = quantity;
        }
    }
}
