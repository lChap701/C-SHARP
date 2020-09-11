using static System.Console;
class LocalVariableDemo
{
   static void Main()
   {
      int a = 12;
      WriteLine("In Main() a is {0}", a);
      MethodWithItsOwnA();
      WriteLine("In Main() a is {0}", a);
   }
   private static void MethodWithItsOwnA()
   {
      int a = 354;
      WriteLine("In method a is {0}", a);
   }
}
