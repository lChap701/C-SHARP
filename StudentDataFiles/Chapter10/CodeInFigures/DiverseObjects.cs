using System;
using static System.Console;
class DiverseObjects
{
   static void Main()
   {
      Student payingStudent = new Student();
      ScholarshipStudent freeStudent = new ScholarshipStudent();
      Employee clerk = new Employee();
      Write("Using Student: ");
      DisplayObjectMessage(payingStudent);
      Write("Using ScholarshipStudent: ");
      DisplayObjectMessage(freeStudent);
      Write("Using Employee: ");
      DisplayObjectMessage(clerk);
   }
   public static void DisplayObjectMessage(Object o)
   {
      WriteLine("Method successfully called");
   }
}

class Employee
{
   public int IdNum {get; set;}
   public double Salary{get; set;}
   public string GetGreeting()
   {
      string greeting = "Hello. I am employee #" + IdNum;
      return greeting;
   }
}

class Student
{
   private const double RATE = 55.75;
   protected int credits;
   protected double tuition;
   public string Name {get; set;}
   public int Credits
   {
      get
      {
         return credits;
      }
      set
      {
          credits = value;
          tuition = credits * RATE;
      }
   }
   public double Tuition
   {
      get
      {
         return tuition;
      }
   }
}

class ScholarshipStudent : Student
{
    new public int Credits
    {
      set
      {
         credits = value;
         tuition = 0;
      }
    }
}
