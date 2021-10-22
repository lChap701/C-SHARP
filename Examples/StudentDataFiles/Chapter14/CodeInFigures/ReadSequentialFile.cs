using System;
using static System.Console;
using System.IO;
class ReadSequentialFile
{
   static void Main()
   {
      const char DELIM = ',';
      const string FILENAME = "EmployeeData.txt";
      Employee emp = new Employee();
      FileStream inFile = new FileStream(FILENAME,
         FileMode.Open, FileAccess.Read);
      StreamReader reader = new StreamReader(inFile);
      string recordIn;
      string[] fields;
      WriteLine("\n{0,-5}{1,-12}{2,8}\n",
         "Num", "Name", "Salary");
      recordIn = reader.ReadLine();
      while(recordIn != null)
      {
         fields = recordIn.Split(DELIM);
         emp.EmpNum = Convert.ToInt32(fields[0]);
         emp.Name = fields[1];
         emp.Salary = Convert.ToDouble(fields[2]);
         WriteLine("{0,-5}{1,-12}{2,8}",
            emp.EmpNum, emp.Name, emp.Salary.ToString("C"));
         recordIn = reader.ReadLine();
      }
      reader.Close();
      inFile.Close();
   }
}
class Employee
{
   public int EmpNum {get; set;}
   public string Name {get; set;}
   public double Salary {get; set;}
}
