using System;
using static System.Console;
class PriceListApplication1
{
   static void Main()
   {
      int item;
      try
      {
         Write("Enter an item number >> ");
         item = Convert.ToInt32(ReadLine());
         PriceList.DisplayPrice(item);
      }
      catch(IndexOutOfRangeException e)
      {
         WriteLine(e.Message + " The price is $0");
      }
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
