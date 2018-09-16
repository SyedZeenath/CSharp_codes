using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant("" +
                "Savouries",
                new SouthIndianItem("tea", 20),
                new SouthIndianItem("coffee", 10),
                new NorthIndianItem("friedRice", 50)
                );

            int i = 0;
            Console.WriteLine("Menu of {0} ", restaurant.Name);
            foreach(IMenuItem item in restaurant.TheMenu)
            {
                Console.WriteLine("{0} {1, -20} {2,10} ",++i, item.ItemName, item.Price);
            }
            Console.WriteLine();

           CustomerOrders order = new CustomerOrders("Customer1",
                new Order("milk", 10),
                new Order("manchurian",50)
                );
            int j = 0;
            Console.WriteLine("Order of {0} ", order.Name);
            Console.WriteLine();
            foreach (IMenuItem orders in order.Theorder)
            {
                Console.WriteLine("{0} {1, -20} {2,10} ", ++j, orders.ItemName, orders.Price);
            }
            Console.WriteLine();
        }
    }
}
