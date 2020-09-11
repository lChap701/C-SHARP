using static System.Console;
class ParamsDemo
{
   static void Main()
   {
      string[] names = {"Mark", "Paulette", "Carol", "James"};
      DisplayStrings("Ginger");
      DisplayStrings("George", "Maria", "Thomas");
      DisplayStrings(names);
   }
   private static void DisplayStrings(params string[] people)
   {
      foreach(string person in people)
         Write("{0} ", person);
      WriteLine("\n----------------");
   }
}
