/*
 * This program shows how to Serialize and De-serialize objects of
 * different type to the same file. Each Employee will also have a Job,
 * and both objects will be persisted to the same file.
*/
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializationOfMultipleObjectTypes
{
    public class SerializationDemo
    {
        public static void Main()
        {
            const int END = 999;
            const string FILENAME = "employee.ser";
            Employee emp = new Employee();
            Job empJob = new Job();
            Object obj = new Object();
            FileStream outFile = new FileStream(FILENAME,
               FileMode.Create, FileAccess.Write);
            BinaryFormatter bFormatter = new BinaryFormatter();
            Console.Write("Enter employee number or " + END +
               " to quit ");
            emp.EmpNum = Convert.ToInt32(Console.ReadLine());
            while (emp.EmpNum != END)
            {
                Console.Write("Enter last name: ");
                emp.Name = Console.ReadLine();
                Console.Write("Enter salary: ");
                emp.Salary = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter job description: ");
                empJob.JobDesc = Console.ReadLine();
                Console.Write("Enter hire date:");
                empJob.JobHireDate = Convert.ToDateTime(Console.ReadLine());

                // Writes employees to the file
                bFormatter.Serialize(outFile, emp);
                bFormatter.Serialize(outFile, empJob);
                Console.Write("Enter employee number or " + END +
                   " to quit ");
                emp.EmpNum = Convert.ToInt32(Console.ReadLine());
            }
            outFile.Close();
            FileStream inFile = new FileStream(FILENAME,
               FileMode.Open, FileAccess.Read);
            Console.WriteLine("\n{0,-5}{1,-12}{2,8}\n",
               "Num", "Name", "Salary");
            while (inFile.Position < inFile.Length)
            {
                obj = bFormatter.Deserialize(inFile);
                //if (obj.GetType() == emp.GetType())
                if (obj is Employee)                
                {
                    emp = (Employee)obj;
                    Console.WriteLine("{0,-5}{1,-12}{2,8}",
                   emp.EmpNum, emp.Name, emp.Salary.ToString("C"));
                }
                else
                {
                    empJob = (Job)obj;
                    Console.WriteLine("{0,-30}{1,10}",
                   empJob.JobDesc, empJob.JobHireDate.ToShortDateString());
                }

            }
            inFile.Close();
            Console.ReadLine();
        }
    }
}





