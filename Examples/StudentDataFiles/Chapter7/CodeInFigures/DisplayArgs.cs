using static System.Console;
class DisplayArgs
{
   static void Main(string[] args)
   {
      for(int x = 0; x < args.Length; ++x)
         WriteLine("Argument {0} is {1}", x, args[x]);
   }
}