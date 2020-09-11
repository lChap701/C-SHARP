using System;
using static System.Console;
class PriceListApplication2
{
   static void Main()
   {
      int item = 0;
      bool isGoodItem = false;
      while(!isGoodItem)
      {
         try
         {
            Write("Enter an item number >> ");
            item = Convert.ToInt32(ReadLine());
            PriceList.DisplayPrice(item);
            isGoodItem = true;
         }
         catch(IndexOutOfRangeException e)
         {
            WriteLine("You must enter a number less " +
               "than 4.");
            WriteLine("Please reenter item number ");
         }
      }
      WriteLine("Thank you");
   }
}

class PriceList
{
   private static double[] price = {15.99, 27.88, 34.56, 45.89};
   public static void DisplayPrice(int item)
   {
      WriteLine("The price is " +
         price[item].ToString("C"));
   }
}
