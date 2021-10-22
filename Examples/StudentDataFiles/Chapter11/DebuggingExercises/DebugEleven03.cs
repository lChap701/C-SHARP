// Employee's salary should not be negative
// Include stack trace when exception occurs
using System;
using static System.Console;
class FDebugEleven03
{
   static void Main()
   {
      Employee emp = new Employee();
      try
      {
         emp.IdNum = 234;
         emp.Salary = -12;
      }
      catch (NegativeSalaryException e)
      {
         WriteLine(e.Message);
         WriteLine(e.StackTrace);
      }
   }
}
public class NegativeSalaryException :
{
   private static string msg =
     "Employee salary is negative.";
   public NegativeSalaryException() : base(msg)
   {
   }
}

public class Employee
{
   private int idNum;
   private double salary;
   public int IdNum
   {
      get
        return idNum;
      set 
        idNum = value;
   }
   public double Salary
   {
      get
      {
         return salary;
      }
      set
      {
        if(value < 0)
        {
           NegativeSalaryException salExcep =
              new NegativeSalaryException();
           throw(sal);
        }
        salary = value;
      }
   }

}
   