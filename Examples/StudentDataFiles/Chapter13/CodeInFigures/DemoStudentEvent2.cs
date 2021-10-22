using System;
using static System.Console;
class Student
{
   private int idNum;
   private double gpa;
   public event EventHandler Changed;
   public int IdNum
   {
      get
      {
         return idNum;
      }
      set
      {
         idNum = value;
         OnChanged(EventArgs.Empty);
      }
   }
   public double Gpa
   {
      get
      {
         return gpa;
      }
      set
      {
         gpa = value;
         OnChanged(EventArgs.Empty);
      }
   }
   private void OnChanged(EventArgs e)
   {
      Changed(this, e);
   }
}
class EventListener
{
   private Student stu;
   public EventListener(Student student)
   {
      stu = student;
      stu.Changed += new EventHandler(StudentChanged);
   }
   private void StudentChanged(object sender, EventArgs e)
   {
      WriteLine("The student has changed.");
      WriteLine("   ID# {0}  GPA {1}",
        stu.IdNum, stu.Gpa);
   }
}
class DemoStudentEvent2
{
   static void Main()
   {
      Student oneStu = new Student();
      EventListener listener = new EventListener(oneStu);
      oneStu.IdNum = 2345;
      oneStu.IdNum = 4567;
      oneStu.Gpa = 3.2;
   }
}
