using static System.Console;
delegate void GreetingHandler(string s);
class Greeting2
{
   public static void Hello(string s)
   {
      WriteLine("Hello, {0}!", s);
   }
   public static void Goodbye(string s)
   {
      WriteLine("Goodbye, {0}!", s);
   }
   static void Main()
   {
      GreetingHandler firstDel, secondDel;
      firstDel = new GreetingHandler(Hello);
      secondDel = new GreetingHandler(Goodbye);
      firstDel += secondDel;
      GreetMethod(firstDel, "Cathy");
      GreetMethod(secondDel, "Bob");
   }
   public static void GreetMethod(GreetingHandler gd, string name)
   {
      WriteLine("The greeting is:");
      gd(name);
   }
}
