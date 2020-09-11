using System;
using static System.Console;
class SortArray
{
   static void Main()
   {
      string[] names = {"Olive", "Patty",
         "Richard", "Ned", "Mindy"};
      int x;
      Array.Sort(names);
      for(x = 0; x < names.Length; ++x)
         WriteLine(names[x]);
   }
}
