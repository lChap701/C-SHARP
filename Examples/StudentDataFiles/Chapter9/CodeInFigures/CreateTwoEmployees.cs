using static System.Console;
class CreateTwoEmployees
{
   static void Main()
   {
      Employee aWorker = new Employee();
      Employee anotherWorker = new Employee();
      DisplayEmployeeData("First", aWorker);
      DisplayEmployeeData("Second", anotherWorker);
   }
   static void DisplayEmployeeData(string order, Employee emp)
   {
      WriteLine("\n{0} employee's message:", order);
      emp.WelcomeMessage();
   }
}

class Employee
{
   private int idNumber;
   public void WelcomeMessage()
   {
       WriteLine("Welcome from Employee #{0}", idNumber);
       WriteLine("How can I help you?");
   }
}
