using static System.Console;
class CreateEmployee3
{
   static void Main()
   {
      Employee aWorker = new Employee();
      aWorker.IdNumber = 3872;
      aWorker.Salary = 22.11;
      WriteLine("Employee #{0} makes {1}",
         aWorker.IdNumber, aWorker.Salary.ToString("C"));
   }
}
class Employee
{
   public int IdNumber {get; set;}
   public double Salary {get; set;}
}
