using System;
using static System.Console;
using System.IO;
class WriteSequentialFile
{
   static void Main()
   {
      const int END = 999;
      const string DELIM = ",";
      const string FILENAME = "EmployeeData.txt";
      Employee emp = new Employee();
      FileStream outFile = new FileStream(FILENAME,
         FileMode.Create, FileAccess.Write);
      StreamWriter writer = new StreamWriter(outFile);
      Write("Enter employee number or " + END +
         " to quit >> ");
      emp.EmpNum = Convert.ToInt32(ReadLine());
      while(emp.EmpNum != END)
      {
         Write("Enter last name >> ");
         emp.Name = ReadLine();
         Write("Enter salary >> ");
         emp.Salary = Convert.ToDouble(ReadLine());
         writer.WriteLine(emp.EmpNum + DELIM + emp.Name +
            DELIM + emp.Salary);
         Write("Enter next employee number or " +
            END + " to quit >> ");
         emp.EmpNum = Convert.ToInt32(ReadLine());
      }
      writer.Close();
      outFile.Close();
   }
}
class Employee
{

   public int EmpNum {get; set;}
   public string Name {get; set;}
   public double Salary {get; set;}
}
