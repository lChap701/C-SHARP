using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            cars.Add(new Car("Wrangler"));
            cars.Add(new Car("Magnum", 25));

            WriteLine(cars[0].Model + " " + cars[0].MPG);
            cars[0] = (cars[0]++);
            WriteLine(cars[0].Model + " " + cars[0].MPG);
            
            WriteLine(cars[1].Model + " " + cars[1].MPG);
            cars[1] = (cars[1]++);
            WriteLine(cars[1].Model + " " + cars[1].MPG);
            ReadLine();
        }
    }
}
