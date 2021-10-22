using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDemo
{
    public class Car : IComparable
    {
        public string Model { get; set; }
        public double MPG { get; set; }

        public Car(string model, double mpg)
        {
            Model = model;
            MPG = mpg;
        }

        public Car(string model)
        {
            Model = model;
            MPG = 20;
        }

        public static Car operator ++(Car c)
        {
            ++c.MPG;
            return c;
        }

        public int CompareTo(object obj)
        {
            return MPG.CompareTo(obj);
            /* 
             MPG.CompareTo(obj) is the same as writing:

            Car temp = (Car)obj;
            if (this.MPG > temp.MPG) {
                return 1;
            } 
            else if (this.MPG < temp.MPG) {
                return -1;
            } 
            else {
                return 0;
            }
            */
        }
    }
}
