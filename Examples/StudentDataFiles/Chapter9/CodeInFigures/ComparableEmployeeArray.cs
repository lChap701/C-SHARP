using System;
using static System.Console;
class ComparableEmployeeArray
{
   static void Main()
   {
      Employee[] empArray = new Employee[5];
      int x;
      for(x = 0; x < empArray.Length; ++x)
         empArray[x] = new Employee();
      empArray[0].IdNumber = 333;
      empArray[1].IdNumber = 444;
      empArray[2].IdNumber = 555;
      empArray[3].IdNumber = 111;
      empArray[4].IdNumber = 222;
      Employee seekEmp = new Employee();
      seekEmp.IdNumber = 222;
      Array.Sort(empArray);
      WriteLine("Sorted employees:");
      for(x = 0; x < empArray.Length; ++x)
        WriteLine("Employee #{0}: {1} {2}",
           x, empArray[x].IdNumber, empArray[x].Salary.ToString("C"));
      x = Array.BinarySearch(empArray, seekEmp);
      WriteLine("Employee #{0} was found at position {1}",
         seekEmp.IdNumber, x);
   }
}
class Employee : IComparable
{
   public int IdNumber {get; set;}
   public double Salary {get; set;}

   int IComparable.CompareTo(Object o)
   {
      int returnVal;
      Employee temp = (Employee)o;
      if(this.IdNumber > temp.IdNumber)
         returnVal = 1;
      else
         if(this.IdNumber < temp.IdNumber)
            returnVal = -1;
         else
            returnVal = 0;
      return returnVal;
   }
}