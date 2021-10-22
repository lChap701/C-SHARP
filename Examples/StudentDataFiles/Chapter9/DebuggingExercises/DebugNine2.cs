// Creates a Breakfast class
// and instantiates an object
// Displays Breakfast special information
using static System.Console;
class FixedDebugNine2
{
   static void Main()
   {
      Breakfast special = new Breakfast("French toast, 4.99);
      //Display the info about breakfast
      WriteLine(INFO);
      // then display today's special
      WriteLine("Today we are having {1} for {1}",
         special.name, special.Price.ToString("C2"));
  }
}
class Breakfast
{
   public string INFO = 
      "Breakfast is the most important meal of the day.";
   private string name;
   private double Price;
   // Breakfast constructor requires a
   // name, e.g "French toast", and a price
   public Breakfast(string name, double price)
   {
       name = name;
       price = price;
   }
   public string Name {get; set}
   public double Price {get; set}
}