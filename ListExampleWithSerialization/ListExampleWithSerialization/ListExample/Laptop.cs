using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample
{
    [Serializable]
    public class Laptop
    {
        public Laptop(double screenSize, double price, string brand)
        {
            ScreenSize = screenSize;
            Price = price;
            Brand = brand;
        }

        double ScreenSize { get; set; }

        double Price { get; set; }

        string Brand { get; set; }
    }
}
