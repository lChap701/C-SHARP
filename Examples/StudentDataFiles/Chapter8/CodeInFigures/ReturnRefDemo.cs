using System;
using static System.Console;
class ReturnRefDemo
{
   static void Main()
   {
      int itemToFind;
      int x;
      int[] items = {123, 241, 375, 410, 555};
      WriteLine("Before replacement: ");
      for(x = 0; x < items.Length; ++x)
         Write("   " + items[x]);
      Write("\n     Enter the value to find >> ");
      itemToFind = Convert.ToInt32(ReadLine());
      ref int soldItem = ref FindItem(itemToFind, items);
      soldItem = 0;
      WriteLine("After replacement: ");
      for(x = 0; x < items.Length; ++x)
         Write("   " + items[x]);
      WriteLine();
   }
   public static ref int FindItem(int findValue, int[] elements)
   {
      int x;
      int position = -1;
      for(x = 0; x < elements.Length; ++x)
      {
         if(findValue == elements[x])
            position = x;
      }
      return ref elements[position];
   }
}
