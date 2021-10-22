using static System.Console;
class UseCalcPay
{
   static void Main()
   {
      double myHours = 37.5;
      double myRate = 12.75;
      double grossPay;
      grossPay = CalcPay(myHours, myRate);
      WriteLine("I worked {0} hours at {1} per hour",
         myHours, myRate);
      WriteLine("My gross pay is {0}", grossPay.ToString("C"));
   }
   private static double CalcPay(double hours, double rate)
   {
      double gross;
      gross = hours * rate;
      return gross;
   }
}
