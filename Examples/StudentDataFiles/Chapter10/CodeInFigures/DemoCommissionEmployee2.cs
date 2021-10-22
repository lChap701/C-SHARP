using static System.Console;
class DemoCommissionEmployee2
{
   static void Main()
   {
      CommissionEmployee salesperson = new CommissionEmployee();
      salesperson.IdNum = 345;
      WriteLine(salesperson.GetGreeting());
   }
}
class Employee
{
   protected double salary;
   public int IdNum {get; set;}
   public double Salary
   {
      get
      {
         return salary;
      }
      set
      {
         const double MIN = 15_000;
         if(value < MIN)
            salary = MIN;
         else
            salary = value;
      }
   }
   public string GetGreeting()
   {
      string greeting = "Hello. I am employee #" + IdNum;
      return greeting;
   }
}

class CommissionEmployee : Employee
{
   private double commissionRate;
   public double CommissionRate
   {
      get
      {
         return commissionRate;
      }
      set
      {
         commissionRate = value;
         salary = 0;
      }
   }
   new public string GetGreeting()
   {
      string greeting = base.GetGreeting();
      greeting += "\nI work on commission.";
      return greeting;
   }
}
