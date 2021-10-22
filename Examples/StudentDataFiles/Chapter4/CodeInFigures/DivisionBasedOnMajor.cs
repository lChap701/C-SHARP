using System;
using static System.Console;
class DivisionBasedOnMajor
{
   enum Major
   {
      ACCOUNTING = 1, CIS, ENGLISH, MATH, MARKETING
   }
   static void Main()
   {
      int major;
      string message;
      Write("Enter major code >> ");
      major = Convert.ToInt32(ReadLine());
      switch ((Major)major)
      {
         case Major.ACCOUNTING:
         case Major.CIS:
         case Major.MARKETING:
            message = "Major is in the business division";
            break;
         case Major.ENGLISH:
         case Major.MATH:
            message = "Major is in the humanities division";
            break;
         default:
            message = "Department number is invalid";
            break;
      }
      WriteLine(message);
   }
}
