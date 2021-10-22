using static System.Console;
class ConversionWithTryParse
{
   static void Main()
   {
      string entryString;
      int score;
      Write("Enter your test score >> ");
      entryString = ReadLine();
      int.TryParse(entryString, out score);
      WriteLine("You entered {0}", score);
   }
}
