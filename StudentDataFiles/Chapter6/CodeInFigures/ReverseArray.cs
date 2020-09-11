using System;
using static System.Console;
class ReverseArray
{
   static void Main()
   {
      string[] names = {"Zach", "Rose",
         "Wendy", "Marcia"};
      int x;
      Array.Reverse(names);
      for(x = 0; x < names.Length; ++x)
         WriteLine(names[x]);
   }
}
