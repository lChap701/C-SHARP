using System;
using static System.Console;
class FindPriceWithWhileLoop
{
   static void Main()
   {
      int x;
      string inputString;
      int itemOrdered;
      double itemPrice = 0;
      bool isValidItem = false;
      int[] valItems =  {101,  108,  201,  213,  266,
         304,  311,  409,  411,  412};
      double[] prices = {0.89, 1.23, 3.50, 0.69, 5.79,
         3.19, 0.99, 0.89, 1.26, 8.00};
      Write("Enter item number ");
      inputString = ReadLine();
      itemOrdered = Convert.ToInt32(inputString);
      x = 0;
      while(x < valItems.Length && itemOrdered != valItems[x])
         ++x;
      if(x != valItems.Length)
      {
         isValidItem = true;
         itemPrice = prices[x];
      }
      if(isValidItem)
         WriteLine("Item {0} sells for {1}",
            itemOrdered, itemPrice.ToString("C"));
      else
            WriteLine("No such item as {0}", itemOrdered);
   }
}
