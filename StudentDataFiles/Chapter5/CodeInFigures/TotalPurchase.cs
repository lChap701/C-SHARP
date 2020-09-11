using System;
using static System.Console;
class TotalPurchase
{
   static void Main()
   {
      double purchase;
      double total = 0;
      string inputString;
      const double QUIT = 0;
      Write("Enter purchase amount >> ");
      inputString = ReadLine();
      purchase = Convert.ToDouble(inputString);
      while(purchase != QUIT)
      {
         total += purchase;
         Write("Enter next purchase amount, or " +
            QUIT + " to quit >> ");
         inputString = ReadLine();
         purchase = Convert.ToDouble(inputString);
      }
      WriteLine("Your total is {0}", total.ToString("C"));
   }
}
