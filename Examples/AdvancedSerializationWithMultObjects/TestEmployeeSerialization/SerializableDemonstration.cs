/*
This program demonstrates the serialization/deserialization of 
    multiple object types to the same file.
First, the user enters and stores the department data (number and name) to the file.
Second, the user enters and stores employee data (employee number, name, salary,
    department number and a list of dependents (name and birthdate to the file.
After data entry is complete, the output file is then closed.
The file is then re-opened as input, and the departments are read into a list.
Notice the file is then closed and re-opened to re-position the file pointer at the top.
The employee/dependent information is then read and displayed.
The department name is also retrieved from the department list by using the
list.Find() method with a lamda expression.
*/
using System;
using static System.Console;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;

namespace TestEmployeeSerialization
{
    class SerializableDemonstration
    {
        static void Main()
        {
            const int END = 999;
            const string FILENAME = "Data.ser";
            Employee emp = new Employee();
            Department dept = new Department();
            FileStream outFile = new FileStream(FILENAME,
                  FileMode.Create, FileAccess.Write);
            BinaryFormatter bFormatter = new BinaryFormatter();

            //enter department information
            Write("Enter department number or " + END +
                 " to quit >> ");
            dept.DeptNum = Convert.ToInt32(ReadLine());
            while (dept.DeptNum != END)
            {
                Write("Enter department name >> ");
                dept.DeptName = ReadLine();
                bFormatter.Serialize(outFile, dept);
                Write("Enter department number or " + END +
                    " to quit >> ");
                dept.DeptNum = Convert.ToInt32(ReadLine());
            }

            //enter employee information
            Write("Enter employee number or " + END +
               " to quit >> ");
            emp.EmpNum = Convert.ToInt32(ReadLine());
            while (emp.EmpNum != END)
            {
                Write("Enter last name >> ");
                emp.Name = ReadLine();
                Write("Enter salary >> ");
                emp.Salary = Convert.ToDouble(ReadLine());
                Write("Enter department number >> ");
                emp.DeptNum = Convert.ToInt32(ReadLine());
                //enter dependent information for this employee
                List<Dependents> deps = new List<Dependents>();
                Write("Enter dependent's name or just press enter if no dependents >> ");
                string dName = ReadLine();
                while (dName != String.Empty)
                {
                    Write("Enter dependents birthdate >> ");
                    DateTime bDate = Convert.ToDateTime(ReadLine());
                    deps.Add(new Dependents(dName, bDate));
                    Write("Enter dependent's name or just press enter if no dependents >> ");
                    dName = ReadLine();
                }
                emp.Depend = deps;
                bFormatter.Serialize(outFile, emp);
                Write("Enter employee number or " + END +
                   " to quit >> ");
                emp.EmpNum = Convert.ToInt32(ReadLine());
            }

            outFile.Close();

            //display all department information first
            FileStream inFile = new FileStream(FILENAME,
                FileMode.Open, FileAccess.Read);
            List<Department> depts = new List<Department>();

            while (inFile.Position < inFile.Length)
            {
                Object obj = bFormatter.Deserialize(inFile);
                if (obj.GetType() == typeof(Department))
                {
                    dept = (Department)obj;
                    depts.Add(dept);
                    WriteLine("Dept Num: " + dept.DeptNum);
                    WriteLine("Dept Name: " + dept.DeptName);
                }

            }

            inFile.Close();

            //display all employee information next
            inFile = new FileStream(FILENAME,
                FileMode.Open, FileAccess.Read);

            while (inFile.Position < inFile.Length)
            {
                Object obj = bFormatter.Deserialize(inFile);
                if (obj.GetType() == typeof(Employee))
                {
                    emp = (Employee)obj;
                    WriteLine("Emp Num: " + emp.EmpNum);
                    WriteLine("Emp Name: " + emp.Name);
                    WriteLine("Emp Salary: " + emp.Salary.ToString("C"));
                    WriteLine("Emp Department: " +
                        depts.Find(item => item.DeptNum == emp.DeptNum).DeptName);
                    WriteLine("Dependents:");
                    foreach (var dep in emp.Depend)
                    {
                        WriteLine("\t" + dep.DependName + " --- " + dep.DependBdate.ToShortDateString());
                    }
                }

            }

            inFile.Close();
            Console.ReadLine();
        }
    }
}




