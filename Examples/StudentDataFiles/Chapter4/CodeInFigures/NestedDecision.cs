using System;
using static System.Console;
class NestedDecision
{
   static void Main()
   {
      const int HIGH = 10, LOW = 5;
      string numberString;
      int number;
      Write("Enter an integer ");
      numberString = ReadLine();
      number = Convert.ToInt32(numberString);
       if(number > LOW)
          if(number < HIGH)
            WriteLine("{0} is between {1} and {2}",
               number, LOW, HIGH);
   }
}
