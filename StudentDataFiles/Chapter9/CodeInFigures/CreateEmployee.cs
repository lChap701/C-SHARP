using static System.Console;
class CreateEmployee
{
   static void Main()
   {
      Employee myAssistant = new Employee();
      myAssistant.WelcomeMessage();
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
