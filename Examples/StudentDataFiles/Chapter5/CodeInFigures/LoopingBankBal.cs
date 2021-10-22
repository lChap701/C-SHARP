using System;
using static System.Console;
class LoopingBankBal
{
   static void Main()
   {
      double bankBal = 1000;
      const double INT_RATE = 0.04;
      string inputString;
      char response;
      Write("Do you want to see your balance? Y or N ...");
      inputString = ReadLine();
      response = Convert.ToChar(inputString);
      while(response == 'Y')
      {
         WriteLine("Bank balance is {0}", bankBal.ToString("C"));
         bankBal = bankBal + bankBal * INT_RATE;
         Write("Do you want to see next year’s balance? Y or N ...");
         inputString = ReadLine();
         response = Convert.ToChar(inputString);
      }
      WriteLine("Have a nice day!");
   }
}
