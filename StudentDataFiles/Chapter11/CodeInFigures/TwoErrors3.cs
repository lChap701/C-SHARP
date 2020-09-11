using System;
using static System.Console;
class TwoErrors3
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
      catch(Exception error)
      {
         WriteLine(error.Message);
      }
   }
}
