using System;
using static System.Console;
class BinarySearchDemo
{
   static void Main()
   {
      int[] idNumbers = {122, 167, 204, 219, 345};
      int x;
      string entryString;
      int entryId;
      Write("Enter an Employee ID ");
      entryString = ReadLine();
      entryId = Convert.ToInt32(entryString);
      x = Array.BinarySearch(idNumbers, entryId);
      if(x < 0)
         WriteLine("ID {0} not found", entryId);
      else
         WriteLine("ID {0} found at position {1} ", 
            entryId, x);
   }
}
