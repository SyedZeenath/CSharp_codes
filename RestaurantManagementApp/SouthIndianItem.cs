using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementApp
{
    class SouthIndianItem : IMenuItem
    {
        public bool IsSpicy { get; private set; }
        public string ItemName { get; private set; }
        public int Price { get; private set; }

        public SouthIndianItem(string item, int price, bool isspicy = false)
        {
            this.ItemName = item;
            this.Price = price;
            this.IsSpicy = isspicy;
        }
    }
}
