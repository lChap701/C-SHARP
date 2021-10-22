using System;

namespace ClassLibraryWithUnitTest
{
    public class Car : LessThanZeroOrEqualToException
    {
        double mileage;
        string color;

        public double Mileage
        {
            get { 
                return mileage; 
            }
            set {
                if (value > 0)
                {
                    mileage = value;
                }
                else
                {
                    mileage = 20;
                    throw (new LessThanZeroOrEqualToException());
                }
            }
        }
        public string Color { get => color; set => color = value; }

        public Car()
        {
            Mileage = 20;
            Color = "Green";
        }

        public Car(double m, string c)
        {
            Mileage = m;
            Color = c;
        }

        public override string ToString()
        {
            return "Mileage: " + Mileage + " Color: " + Color;
        }
    }
}
