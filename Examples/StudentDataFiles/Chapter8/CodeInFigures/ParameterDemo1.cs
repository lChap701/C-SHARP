using static System.Console;
class ParameterDemo1
{
   static void Main()
   {
      int x = 4;
      WriteLine("In Main x is {0}", x);
      DisplayValueParameter(x);
      WriteLine("In Main x is {0}", x);
   }
   private static void DisplayValueParameter(int x)
   {
      x = 777;
      WriteLine("In method, x is {0}", x);
   }
}

