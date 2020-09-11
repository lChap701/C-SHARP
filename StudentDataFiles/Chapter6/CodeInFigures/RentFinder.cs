using System;
using static System.Console;
class RentFinder
{
   static void Main()
   {
      int[ , ] rents = { {400, 450, 510},
                         {500, 560, 630},
                         {625, 676, 740},
                         {1000, 1250, 1600} };
      int floor;
      int bedrooms;
      string inputString;
      Write("Enter the floor on which you want to live ");
      inputString = ReadLine();
      floor = Convert.ToInt32(inputString);
      Write("Enter the number of bedrooms you need ");
      inputString = ReadLine();
      bedrooms = Convert.ToInt32(inputString);
      WriteLine("The rent is {0}", rents[floor, bedrooms]);
   }
}
