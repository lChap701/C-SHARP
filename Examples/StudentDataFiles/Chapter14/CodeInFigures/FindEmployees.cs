using System;
using static System.Console;
using System.IO;
class FindEmployees
{
   static void Main()
   {
      const char DELIM = ',';
      const int END = 999;
      const string FILENAME = "EmployeeData.txt";
      Employee emp = new Employee();
      FileStream inFile = new FileStream(FILENAME,
         FileMode.Open, FileAccess.Read);
      StreamReader reader = new StreamReader(inFile);
      string recordIn;
      string[] fields;
      double minSalary;
      Write("Enter minimum salary to find or " +
         END + " to quit >> ");
      minSalary = Convert.ToDouble(Console.ReadLine());
      while(minSalary != END)
      {
         WriteLine("\n{0,-5}{1,-12}{2,8}\n",
            "Num", "Name", "Salary");
         inFile.Seek(0, SeekOrigin.Begin);
         recordIn = reader.ReadLine();
         while(recordIn != null)
         {
            fields = recordIn.Split(DELIM);
            emp.EmpNum = Convert.ToInt32(fields[0]);
            emp.Name = fields[1];
            emp.Salary = Convert.ToDouble(fields[2]);
            if(emp.Salary >= minSalary)
               WriteLine("{0,-5}{1,-12}{2,8}", emp.EmpNum,
                  emp.Name, emp.Salary.ToString("C"));
            recordIn = reader.ReadLine();
         }
         Write("\nEnter minimum salary to find or " +
            END + " to quit >> ");
         minSalary = Convert.ToDouble(Console.ReadLine());
      }
      reader.Close();  // Error occurs if
      inFile.Close(); //these two statements are reversed
   }
}
class Employee
{

   public int EmpNum {get; set;}
   public string Name {get; set;}
   public double Salary {get; set;}
}