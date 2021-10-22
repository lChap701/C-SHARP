using static System.Console;
class TestHashCode
{
   static void Main()
   {
      Employee first = new Employee();
      Employee second = new Employee();
      WriteLine("First hash code " + first.GetHashCode());
      WriteLine("Second hash code " + second.GetHashCode());
   }
}
class Employee
{
   public int EmpNum {get; set;}
   public double EmpSal {get; set;}
   public string GetGreeting()
   {
      string greeting = "Hello. I am employee #" + EmpNum;
      return greeting;
   }
}
