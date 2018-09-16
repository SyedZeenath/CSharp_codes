using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementApp
{
    class NorthIndianItem : IMenuItem
    {
        public string ItemName { get; private set; }
        public int Price { get; private set; }

        public NorthIndianItem(string item, int price)
        {
            this.ItemName = item;
            this.Price = price;
        }
    }
}
