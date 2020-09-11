using System;
using static System.Console;
using System.Diagnostics;
class PrefixPostfixComparison
{
   static void Main()
   {
       int LOOPS = 100000000;
       Stopwatch sw = Stopwatch.StartNew();
       for (int x = 0; x < LOOPS; ++x);
       sw.Stop();
       Stopwatch sw2 = Stopwatch.StartNew();
       for (int x = 0; x < LOOPS; x++);
       sw2.Stop();
       WriteLine("Time with prefix increment: {0} ms",
          sw.Elapsed.TotalMilliseconds);
       WriteLine("Time with postfix increment: {0} ms",
          sw2.Elapsed.TotalMilliseconds);
   }
}
