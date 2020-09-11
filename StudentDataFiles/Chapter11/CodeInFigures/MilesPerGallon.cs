using System;
using static System.Console;
class MilesPerGallon
{
   static void Main()
   {
      int milesDriven;
      int gallonsOfGas;
      int mpg;
      Write("Enter miles driven ");
      milesDriven = Convert.ToInt32(ReadLine());
      Write("Enter gallons of gas purchased ");
      gallonsOfGas = Convert.ToInt32(ReadLine());
      mpg = milesDriven / gallonsOfGas;
      WriteLine("You got {0} miles per gallon", mpg);
   }
}
