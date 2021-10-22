// Prevents non-numeric data entry
// Then prevents division by 0
using System;
using static System.Console;
class DebugEleven02
{
   static void Main()
   {
      int num = 0, denom = 0;
      double result;
      bool dataEntryIsValid;
      while(!dataEntryIsValid)
      {
         try
         {
            DataEntry(num, denom);
            dataEntryIsValid = true;
         }
         catch(FormatException e)
         {
            WriteLine("Invalid entry - please enter numbers.");
         }
      }
      try 
      {
         result = num * 1.0 / denom;
         WriteLine("Division is successful");
      }
      catch(DivideByZeroException e)
      {
         WriteLine("Division failed")
         result = 0;
      }
      WriteLine("Result is {0}", result);
   }
   public static void DataEntry(out int num, out int denom)
   {
      Write("Enter a number ");
      if(!int.TryParse(ReadLine, out num))
         Console.WriteLine("Numerator was set to 0");
      Write("Enter a number to divide into the first ");
      if(int.TryParse(ReadLine(), out denom))
         WriteLine("Denominator was set to 0");
   }
}
