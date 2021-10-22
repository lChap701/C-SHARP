using System;
using static System.Console;
class IfElseDecision
{
   static void Main()
   {
      const int HIGH = 10;
      string numberString;
      int number;
      Write("Enter an integer ");
      numberString = ReadLine();
      number = Convert.ToInt32(numberString);
      if(number > HIGH)
         WriteLine("{0} is greater than {1}",
            number, HIGH);
      else
         WriteLine("{0} is not greater than {1}",
            number, HIGH);
   }
}
