using static System.Console;
class PassEntireArray
{
   static void Main()
   {
      int[] someNums = {10, 12, 22, 35};
      int x;
      Write("\nAt beginning of Main() method...");
      for(x = 0; x < someNums.Length; ++x)
         Write("{0, 6}", someNums[x]);
      WriteLine();
      MethodGetsArray(someNums);
      Write("At end of Main() method..........");
      for(x = 0; x < someNums.Length; ++x)
         Write("{0, 6}", someNums[x]);
   }
   private static void MethodGetsArray(int[] vals)
   {
      int x;
      Write("In MethodGetsArray() ");
      for(x = 0; x < vals.Length; ++x)
         Write(" {0}", vals[x]);
      WriteLine();
      for(x = 0; x < vals.Length; ++x)
         vals[x] = 888;
      Write("After change");
      for(x = 0; x < vals.Length; ++x)
         Write(" {0}", vals[x]);
      WriteLine();
   }
}
