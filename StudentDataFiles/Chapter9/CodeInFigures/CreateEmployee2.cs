using static System.Console;
class CreateEmployee2
{
   static void Main()
   {
      Employee myChef = new Employee();
      myChef.IdNumber = 2345;
      WriteLine("ID number is {0}", myChef.IdNumber);
      myChef.WelcomeMessage();
   }
}
class Employee
{
   private int idNumber;
   public int IdNumber
   {
      get
      {
         return idNumber;
      }
      set
      {
         idNumber = value;
      }
   }
   public void WelcomeMessage()
   {
      WriteLine("Welcome from Employee #{0}", IdNumber);
      WriteLine("How can I help you?");
   }
}
