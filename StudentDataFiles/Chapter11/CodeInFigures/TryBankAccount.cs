using System;
using static System.Console;
class TryBankAccount
{
   static void Main()
   {
      BankAccount acct = new BankAccount();
      try
      {
         acct.AccountNum = 1234;
         acct.Balance = -1000;
      }
      catch(NegativeBalanceException e)
      {
         WriteLine(e.Message);
         WriteLine(e.StackTrace);
      }
   }
}
class BankAccount
{
   private double balance;
   public int AccountNum {get; set;}
   public double Balance
   {
      get
      {
         return balance;
      }
      set
      {
         if(value < 0)
         {
            NegativeBalanceException nbe =
               new NegativeBalanceException();
            throw(nbe);
         }
         balance = value;
      }
   }
}
class NegativeBalanceException : Exception
{
   private static string msg = "Bank balance is negative. ";
   public NegativeBalanceException() : base(msg)
   {
   }
}
