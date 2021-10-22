using static System.Console;
class OptionalParameterDemo
{
   static void Main()
   {
      Write("Using 2 arguments: ");
      DisplaySize(4, 6);
      Write("Using 3 arguments: ");
      DisplaySize(4, 6, 8);
   }
   private static void DisplaySize(int length, int width, int height = 1)
   {
      int area = length * width * height;
      WriteLine("Size is {0}", area);
   }
}
