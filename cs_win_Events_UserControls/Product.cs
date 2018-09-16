using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_win_Events_UserControls
{
    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public DateTime ExpiresOn { get; set; }

        public override string ToString()
        {
            return string.Format("{0} [{1:C}]", this.Name, this.Price);
        }
    }
}
