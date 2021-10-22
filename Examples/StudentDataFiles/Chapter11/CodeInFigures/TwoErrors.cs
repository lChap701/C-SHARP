using System;
using static System.Console;
class TwoErrors
{
   static void Main()
   {
      int num = 13, denom = 0, result;
      int[] array = {22, 33, 44};
      try
      {
         result = num / denom;
         result = array[num];
      }
      catch(DivideByZeroException error)
      {
         WriteLine("In first catch block: ");
         WriteLine(error.Message);
      }
      catch(IndexOutOfRangeException error)
      {
         WriteLine("In second catch block: ");
         WriteLine(error.Message);
      }
   }
}
