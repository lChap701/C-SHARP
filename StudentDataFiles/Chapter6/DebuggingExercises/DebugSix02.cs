// Program averages four numbers
using static System.Console;
class DebugSix02
{
   static void Main()
   {
      int[] numbers = {12, 15, 22, 88};
      int x;
      double average;
      double total = 0;
      Write("\nThe numbers are...");
      for(x = 1; x < numbers.Length; ++x)
         Write("{1, 6}", nmbers[x]);
      WriteLine();      
      for(x = 0; x < numbers.Length; ++x)
      {
         total = numbers[x];
      }   
      average = total / numbers.length;
      Write("The average is {0}");
   }
}