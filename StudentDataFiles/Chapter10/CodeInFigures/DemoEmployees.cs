using static System.Console;
class DemoEmployees
{
   static void Main()
   {
      Employee accountant = new Employee();
      Employee programmer = new Employee();
      CommissionEmployee salesperson1 = new CommissionEmployee();
      CommissionEmployee salesperson2 = new CommissionEmployee();
      accountant.IdNum = 123;
      accountant.Salary = 30_000.00;
      programmer.IdNum = 234;
      programmer.Salary = 12_000;
      salesperson1.IdNum = 345;
      salesperson1.Salary = 22_500.00;
      salesperson1.CommissionRate = 0.07;
      salesperson2.IdNum = 456;
      salesperson2.Salary = 1_500.00;
      salesperson2.CommissionRate = 0.04;
      WriteLine("\n" + accountant.GetGreeting());
      WriteLine("   Accountant #{0} salary: {1} per year",
         accountant.IdNum, accountant.Salary.ToString("C"));
      WriteLine("\n" + programmer.GetGreeting());
      WriteLine("   Programmer #{0} salary: {1} per year",
         programmer.IdNum, programmer.Salary.ToString("C"));
      WriteLine("\n" + salesperson1.GetGreeting());
      WriteLine("   Salesperson 1 #{0} salary: {1} per year",
         salesperson1.IdNum, salesperson1.Salary.ToString("C"));
      WriteLine("...plus {0} commission on all sales",
         salesperson1.CommissionRate.ToString("P"));
      WriteLine("\n" + salesperson2.GetGreeting());
      WriteLine("   Salesperson 2 #{0} salary: {1} per year",
         salesperson2.IdNum, salesperson2.Salary.ToString("C"));
      WriteLine("...plus {0} commission on all sales",
         salesperson2.CommissionRate.ToString("P"));
   }
}
class Employee
{
   private double salary;
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
   public double CommissionRate {get; set;}
}

