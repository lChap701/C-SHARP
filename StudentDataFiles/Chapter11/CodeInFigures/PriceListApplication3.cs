using System;
using static System.Console;
class PriceListApplication3
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
      catch(Exception e)
      {
         WriteLine(e.StackTrace);
      }
   }
}
class PriceList
{
   private static double[] price = {15.99, 27.88, 34.56, 45.89};
   public static void DisplayPrice(int item)
   {
      double tax;
      double total;
      double pr;
      pr = price[item];
      tax = pr * Tax.DetermineTaxRate(pr);
      total =  pr + tax;
      WriteLine("The total price is " +
         total.ToString("C"));
   }
}
class Tax
{
   private static double[] taxRate = {0.06, 0.07};
   private static double CUTOFF = 20.00;
   public static double DetermineTaxRate(double price)
   {
      int subscript;
      double rate;
      if(price <= CUTOFF)
         subscript = 0;
      else
         subscript = 2;
      rate = taxRate[subscript];
      return rate;
   }
}
