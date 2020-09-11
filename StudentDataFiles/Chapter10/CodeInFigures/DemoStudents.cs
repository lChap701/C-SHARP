using static System.Console;
class DemoStudents
{
   static void Main()
   {
      Student payingStudent = new Student();
      ScholarshipStudent freeStudent = new ScholarshipStudent();
      payingStudent.Name = "Megan";
      payingStudent.Credits = 15;
      freeStudent.Name = "Luke";
      freeStudent.Credits = 15;
      WriteLine("{0}'s tuition for {1} credits is {2}",
         payingStudent.Name, payingStudent.Credits,
            payingStudent.Tuition.ToString("C"));
      WriteLine("{0}'s tuition for {1} credits is {2}",
         freeStudent.Name, freeStudent.Credits,
            freeStudent.Tuition.ToString("C"));
   }
}
class Student
{
   private const double RATE = 55.75;
   protected int credits;
   protected double tuition;
   public string Name {get; set;}
   public virtual int Credits
   {
      get
      {
         return credits;
      }
      set
      {
          credits = value;
          tuition = credits * RATE;
      }
   }
   public double Tuition
   {
      get
      {
         return tuition;
      }
   }
}
class ScholarshipStudent : Student
{
    public override int Credits
    {
      set
      {
         credits = value;
         tuition = 0;
      }
    }
}
