using static System.Console;
class ConversionWithParse
{
   static void Main()
   {
      string entryString;
      int score;
      Write("Enter your test score >> ");
      entryString = ReadLine();
      score = int.Parse(entryString);
      WriteLine("You entered {0}", score);
   }
}
