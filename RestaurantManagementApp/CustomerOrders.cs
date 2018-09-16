using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementApp
{
    class CustomerOrders
    {
        public string Name { get; private set; }
        
       
        public Customer Theorder { get; private set; }

        public int Quantity { get; set; }

        public CustomerOrders(string name, Order order, int quantity, params IMenuItem[] orderItems)
        {
            this.Name = name;
            this.Quantity = quantity;
            this.Theorder = new Customer();


            //IMenuItem obj1 = new Order("idli", 12);
            //IMenuItem obj2 = new Order("Rajma Rice", 250);
            //this.Theorder.Add(obj1);
            //this.Theorder.Add(obj2);

            foreach (IMenuItem item in orderItems)
            {
                this.Theorder.Add(item);
            }
        }
    }
}
