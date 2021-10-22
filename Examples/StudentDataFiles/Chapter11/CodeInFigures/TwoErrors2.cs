using System;
using static System.Console;
class TwoErrors2
{
   static void Main()
   {
      int num = 13, denom = 0, result;
      int[] array = {22, 33, 44};
      try
      {
          result = array[num];
          result = num / denom;
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
