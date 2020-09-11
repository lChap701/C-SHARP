using static System.Console;
class CreateSomeEmployees
{
   static void Main()
   {
      Employee aWorker = new Employee();
      Employee anotherWorker = new Employee(234);
      Employee theBoss = new Employee('A');
      WriteLine("{0, 4}{1, 14}", aWorker.IdNumber,
         aWorker.Salary.ToString("C"));
      WriteLine("{0, 4}{1, 14}", anotherWorker.IdNumber,
         anotherWorker.Salary.ToString("C"));
      WriteLine("{0, 4}{1, 14}", theBoss.IdNumber,
         theBoss.Salary.ToString("C"));
   }
}
public class Employee
{
   public int IdNumber {get; set;}

   public double Salary {get; set;}
   public Employee()
   {
      IdNumber = 999;
      Salary = 0;
   }
   public Employee(int empId)
   {
      IdNumber = empId;
      Salary = 0;
   }
   public Employee(int empId, double sal)
   {
      IdNumber = empId;
      Salary = sal;
   }
   public Employee(char code)
   {
      IdNumber = 111;
      Salary = 100000;
   }
}
