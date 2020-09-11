using static System.Console;
class DemoCommissionEmployee
{
   static void Main()
   {
      CommissionEmployee salesperson = new CommissionEmployee();
      salesperson.IdNum = 567;
      salesperson.Salary = 20_000.00;
      salesperson.CommissionRate = 0.06;
      WriteLine("   Salesperson #{0} salary: {1} per year",
         salesperson.IdNum, salesperson.Salary.ToString("C"));
      WriteLine("...plus {0} commission on all sales",
         salesperson.CommissionRate.ToString("P"));
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
}

