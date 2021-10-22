using System;
using static System.Console;
class ReThrowDemo
{
   static void Main()
   {
      try
      {
         WriteLine("Trying in Main() method");
         MethodA();
      }
      catch(Exception ae)
      {
         WriteLine("Caught in Main() method --\n   {0}",
            ae.Message);
      }
      WriteLine("Main() method is done");
   }
   public static void MethodA()
   {
      try
      {
         WriteLine("Trying in method A");
         MethodB();
      }
      catch(Exception)
      {
         WriteLine("Caught in method A");
         throw;
      }
   }
   public static void MethodB()
   {
      try
      {
         WriteLine("Trying in method B");
         MethodC();
      }
      catch(Exception)
      {
         WriteLine("Caught in method B");
         throw;
      }
   }
   public static void MethodC()
   {
      WriteLine("In method C");
      throw(new Exception("This came from method C"));
   }
}
