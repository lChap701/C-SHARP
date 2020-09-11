using static System.Console;
class BorderDemo2
{
   static void Main()
   {
      DisplayWithBorder("Ed");
      DisplayWithBorder(3);
      DisplayWithBorder(456);
      DisplayWithBorder(897654);
      DisplayWithBorder("Veronica");
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
   private static void DisplayWithBorder(int number)
   {
      const int EXTRA_STARS = 4;
      const string SYMBOL = "*";
      int size  = EXTRA_STARS + 1;
      int leftOver = number;
      int x;
      while(leftOver >= 10)
      {
         leftOver = leftOver / 10;
         ++size;
      }
      for(x = 0; x < size; ++x)
         Write(SYMBOL);
      WriteLine();
      WriteLine(SYMBOL + " " + number + " " + SYMBOL);
      for(x = 0; x < size; ++x)
         Write(SYMBOL);
      WriteLine("\n\n");
   }
}
