using static System.Console;
class AmbiguousMethods
{
   static void Main()
   {
      int iNum = 20;
      double dNum = 4.5;
      SimpleMethod(iNum, dNum);  // calls first version
      SimpleMethod(dNum, iNum);  // calls second version
      SimpleMethod(iNum, iNum);  // error! Call is ambiguous.
   }
   private static void SimpleMethod(int i, double d)
   {
      WriteLine("Method receives int and double");
   }
   private static void SimpleMethod(double d, int i)
   {
      WriteLine("Method receives double and int");
   }
}
