using static System.Console;
class DemoEmployeeDestructor
{
   static void Main()
   {
      Employee aWorker = new Employee(101);
      Employee anotherWorker = new Employee(202);
   }
}
class Employee
{
   public int IdNumber {get; set;}
   public Employee(int empID)
   {
      IdNumber = empID;
      WriteLine("Employee object {0} created", IdNumber);
   }
   ~Employee()
   {
      WriteLine("Employee object {0} destroyed!", IdNumber);
   }
}
