// Declare a Student
// ID must be an integer and gpa must be a double to continue
using System;
using static System.Console;
class DebugEleven04
{
   static void Main()
   {
      Student stu = new Student();
      bool areNumbersGood = false;
      while(!areNumbersGood)
      {
         try
         {
            stu.setID();
            stu.setGPA();
         }
         catch (FormatException e)
         {
            WriteLine(e.Message);
            WriteLine("(Either the student ID or the GPA");
            WriteLine(" was not in the correct format.)");
            WriteLine("You will have to re-enter the student data.");
         }
      }
      WriteLine("Valid student");      }
}
public class Student
{
   private int stuId;
   private double stuGpa;
   public void setID()
   {
      string stuNumber;
      try
      {
         Write("Enter student ID ");
         stuNumber = ReadLine;
         stuId = Convert.ToInt32(stuNumber);
      }
      catch(FormatException fe)
         throw(fe);
   }
   public void setGPA()
   {
      string stuGPAString;
      try
      {
         Write("Enter student GPA ");
         stuGPAString = ReadLine();
         stuGpa = Convert.ToDouble(stuGPAString);
      }
      catch(FormatException fe)
      {
         throw(fe);
      }
   }
}   

   