// Finds whether a book dealer carries a requested book
using System;
using static System.Console;
class DebugSix03
{
   static void Main()
   {
      String[] books = {"Catch-22", "Harry Potter",
         "Programming Using C#", "Rich Dad, Poor Dad",
         "The Deep", "Wizard of Oz"};
      int x;
      string entryString;
      Write("What book are you looking for? ");
      entryString = Console.Readline();
      x = Array.BinarySearch(book);
      if(x < 0)
         WriteLine("{0} not found", entry);
      else
         WriteLine("Yes, we carry {0}", entry);   
   }
}
