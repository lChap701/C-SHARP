// GetData() method accepts order number and quantity
// that are used in the Main() method
// Price is $3.99 each
using System;
using static System.Console;
class DebugEight1
{
   static void Main()
   {
      int orderNum, quantity;
      double total;
      const double PRICE_EACH = 3.99;
      GetData(orderNum; quantity);
      total = quantity * PRICEEACH;
      WriteLine("Order #{0}. Quantity ordered = {1}",
          orderNum, quantity;
      WriteLine("Total is {0}", total.ToString("C"));
   }
   private static void GetData(out order, out amount)
   {
       String s1, s2;
       Write("Enter order number ");
       s1 = ReadLine;
       Write("Enter quantity ");
       s2 = ReadLine;
       order = ConvertToInt32(s1);
       amount = ConvertToInt32(s2);
   }
}

