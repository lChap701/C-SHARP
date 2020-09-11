using static System.Console;
class PassArrayElement
{
   static void Main()
   {
      int[] someNums = {10, 12, 22, 35};
      int x;
      Write("\nAt beginning of Main() method...");
      for(x = 0; x < someNums.Length; ++x)
         Write("{0,6}", someNums[x]);
      WriteLine();
      for(x = 0; x < someNums.Length; ++x)
         MethodGetsOneInt(someNums[x]);
      Write("At end of Main() method..........");
      for(x = 0; x < someNums.Length; ++x)
         Write("{0,6}", someNums[x]);
   }
   private static void MethodGetsOneInt(int oneVal)
   {
      Write("In MethodGetsOneInt() {0}", oneVal);
      oneVal = 999;
      WriteLine("     After change {0}", oneVal);
   }
}
