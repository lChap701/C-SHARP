// Overloaded method gives bonus points
// whether grade is a number or letter
using static System.Console;
class DebugEight2
{
   static void Main()
   {
      int numericScore = 82;
      string letterScore = B;
      Write("Score was {0}. ", numericScore);
      GiveBonus(ref numericScore);
      WriteLine("Now it is {0}.", numericScore);
      Write("Grade was ", letterScore);
      GiveBonus(ref letterScore);
      WriteLine("Now it is ", letterScore);
   }
   private static void giveBonus(int ref testScore)
   {
      const int BONUS = 5;
      testScore = BONUS;
   }
   private static void GiveBonus(string ref letterScore)
   {
      const string BONUS = "+";
      letterScore = BONUS;
   }
}

