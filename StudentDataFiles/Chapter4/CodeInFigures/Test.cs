using System;
using static System.Console;
class Test
{
   static void Main()
   {
      int testScore = 50;
      WriteLine($"{(testScore >= 60 ? "Pass" : "Fail")}");
      WriteLine((testScore >= 60) ? "Pass" : "Fail");
//      WriteLine("\{testScore >= 60 ? "Pass" : "Fail"}");
double someMoney = 39.45;
string mySentence = String.Format("The money is ${0} exactly", someMoney);
WriteLine(mySentence);
string yourSentence = $"The money is ${someMoney} exactly";
WriteLine(yourSentence);
WriteLine($"The last money is ${someMoney} for sure");

double someMoney2 = 42.56;
int myAge = 29;
WriteLine($"Money is {someMoney2} and age is {myAge}");

   }
}
