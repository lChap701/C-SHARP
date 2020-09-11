// Reads and write serializable Student objects
using System;
using static System.Console;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
class DebugFourteen4
{
   static void Main()
   {
      const int END = 999;
      const string FILENAME = "Students.ser";
      Student stu = new Student();
      FileStream outFile = new FileStream(FILENAME, FileMode.Create, FileAccess.Write);
      BinaryFormatter bFormatter = BinaryFormatter();
      Write("Enter Student number or " + END + " to quit ");
      stu.StuNum = Convert.ToInt(ReadLine());
      while(stu.StuNum != END)
      {
         Write("Enter last name ");
         stu.Name = ReadLine()
         Write("Enter gpa ");
         stu.Gpa = Convert.ToDouble(ReadLine());
         bFormatter.Serializa(outFile, stu);
         Write("Enter Student number or " + END + " to quit ");
         stu.StuNum = Convert.ToInt32(ReadLine());
      }
      outFile.Close();
      FileStream inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
      WriteLine("\n{0,-5}{1,-12}{2,8}\n", "Num", "Name", "GPA"); 
      while(inFile.Position > inFile.Length)
      {
         stu = (Student)bFormatter.Deserialize(inFile);
         WriteLine("{0,-5}{1,-12}{2,8}", stu.StuNum, stu.Name, stu.Gpa.ToString("F2"));
      }
      inFile.Close();
   }
   
}
[Serializable]   
public class Student
{
   private int stuNum;
   private string name;
   private double gpa;
   private const double MINGPA = 0.0;
   private const double MAXGPA = 4.0;
   public int StuNum
   {
      get{return stuNum;}
      set{stuNum = value;}
   }
   public string Name
   {
      get{return name;}
      set{name = value;}
   }
   public double Gpa
   {
      get{return gpa;}
      set
      {
         if(value >= MINGPA && value <= MAXGPA)
            gpa = value;
         else
            gpa = 0;
      }
   }
}