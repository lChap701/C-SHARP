using System;
class Payroll2
{
   static void Main()
   {
      double hours = 40;
      double rate = 10.00;
      double bonus = 0;
      double totalPay;
      totalPay = ComputeTotalPay(bonus: bonus, gross: ComputeGross(hours, rate, out bonus));
      Console.WriteLine("Total pay is {0}", totalPay);
   }
   private static double ComputeGross(double hours, double rate, out double bonus)
   {
       double gross = hours * rate;
       if(hours >= 40)
          bonus = 100;
       else
          bonus = 50;
       return gross;
   }
   private static double ComputeTotalPay(double gross, double bonus)
   {
      double total = gross + bonus;
      return total;
   }
}
