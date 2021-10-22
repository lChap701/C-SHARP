using static System.Console;
class BorderDemo1
{
   static void Main()
   {
      DisplayWithBorder("Ed");
      DisplayWithBorder("Theodore");
      DisplayWithBorder("Jennifer Ann");
   }
   private static void DisplayWithBorder(string word)
   {
      const int EXTRA_STARS = 4;
      const string SYMBOL = "*";
      int size = word.Length + EXTRA_STARS;
      int x;
      for(x = 0; x < size; ++x)
         Write(SYMBOL);
      WriteLine();
      WriteLine(SYMBOL + " " + word + " " + SYMBOL);
      for(x = 0; x < size; ++x)
         Write(SYMBOL);
      WriteLine("\n\n");
   }
}
