using System;
using static System.Console;
class TestTryParse
{   
   static void Main()
   {
      int number;
      Write("Enter an integer >> ");
      if(TryParse(ReadLine(), out number))
         WriteLine("Success!");
      else 
         WriteLine("Failure");  
      WriteLine("The number is " + number);
   }
   public static bool TryParse(string inputString, out int number)
   {
      bool wasSuccessful = true;
      try
      {
         number = Convert.ToInt32(inputString);
      }
      catch(FormatException e)
      {
         wasSuccessful = false;
         number = 0;
      }
      return wasSuccessful;
   }
}