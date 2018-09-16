using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementApp
{
    class Menu : System.Collections.IEnumerable
    {
        private List<IMenuItem> items;

        public Menu()
        {
            this.items = new List<IMenuItem>();
        }
        public void Add(IMenuItem item)
        {
            this.items.Add(item);
        }
        public IEnumerator GetEnumerator()
        {
            foreach(IMenuItem item in this.items )
            {
                yield return item;
            }
        }
    }
}
