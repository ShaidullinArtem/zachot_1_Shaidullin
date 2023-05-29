using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zachet_1_Shaidullin.types
{
    internal class TourType
    {
        public TourType (string id, string country, string hotelTitle, int count, double price)
        {
            this.id = id;
            this.country = country;
            this.hotelTitle = hotelTitle;
            this.count = count;
            this.price = price;
        }

        public string id { set; get; }
        public string country { set; get; }
        public string hotelTitle { set; get; }
        public int count { set; get; }
        public double price { set; get; }
    }
}
