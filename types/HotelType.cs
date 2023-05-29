using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zachet_1_Shaidullin.types
{
    internal class HotelType
    {
        public HotelType (string title, int count, double price)
        {
            this.title = title;
            this.count = count;
            this.price = price;
        }
        public string title { set; get; }
        public int count { set; get; }
        public double price { set; get; }
    }
}
