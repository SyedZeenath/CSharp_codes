using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementApp
{
    class Restaurant
    {
        public string Name { get; private set; }
        public Menu TheMenu { get; private set; }

        public Restaurant(string name, params IMenuItem[] menuItems)
        {
            this.Name = name;
            this.TheMenu = new Menu();

            IMenuItem obj1 = new SouthIndianItem("idli", 30);
            IMenuItem obj2 = new NorthIndianItem("Rajma Rice", 150);
            this.TheMenu.Add(obj1);
            this.TheMenu.Add(obj2);

            foreach(IMenuItem item in menuItems)
            {
                this.TheMenu.Add(item);
            }
        }
    }
}
