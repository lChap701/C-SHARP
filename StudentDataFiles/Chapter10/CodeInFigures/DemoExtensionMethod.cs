using static System.Console;
static class DemoExtensionMethod
{
   static void Main()
   {
      int acctNum = 49;
      int revisedAcctNum = acctNum.AddCheckDigit();
      WriteLine("Original account number was {0}", acctNum);
      WriteLine("Revised account number is {0}", revisedAcctNum);
   }
   public static int AddCheckDigit(this int num)
   {
      int first = num / 10;
      int second = num % 10;
      int third = (first + second) % 10;
      int result = num * 10 + third;
      return result;
   }
}
