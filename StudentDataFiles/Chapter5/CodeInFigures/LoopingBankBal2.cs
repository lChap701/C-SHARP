using static System.Console;
class LoopingBankBal2
{
   static void Main()
   {
      double bankBal;
      double rate;
      int year;
      const double START_BAL = 1000;
      const double START_INT = 0.04;
      const double INT_INCREASE = 0.02;
      const double LAST_INT = 0.08;
      const int END_YEAR = 5;
      for(rate = START_INT; rate <= LAST_INT; rate += INT_INCREASE)
      {
         bankBal = START_BAL;
         WriteLine("Starting bank balance is {0}",
             bankBal.ToString("C"));
         WriteLine("  Interest Rate: {0}", rate.ToString("P"));
         for(year = 1; year <= END_YEAR; ++year)
         {
            bankBal = bankBal + bankBal * rate;
            WriteLine("   After year {0}, bank balance is {1}",
                year, bankBal.ToString("C"));
         }
      }
   }
}
