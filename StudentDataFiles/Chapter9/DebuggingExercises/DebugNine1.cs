// Creates a HomeworkAssignment class
// instantiates two objects
// and prompts the user for infromation about two courses
using static System.Console;
class DebugNine1
{
   static void Main()
   {
      HomeworkAssignment course1 = new HomeworkAssignment();
      HomeworkAssignment course2 = new HomeworkAssignment();
      string entryString;
      int exercises;

      // Get info for first class
      Write("What class do you have homework for? ");
      entry = ReadLine();
      course1.className = entryString;
      Write("How many exercises must you complete? ");
      entryString = ReadLine(entry);
      int.TryParse(entryString, exercises);
      exercises = course1.NumberOfExercises;
      
      // Get info for another class
      Write("What class do you have homework for? ");
      entryString = ReadLine();
      course2.className = entrystring;
      Write("How many exercises must you complete? ");
      entryString = ReadLine();
      char.TryParse(entryString, exercises);
      course2.NumberOfExercises = exercises;

      WriteLine("You have {0} minutes of homework for {1}",
            course1.timeToComplete, course1.ClassName);      
      WriteLine("and {0} more minutes for {1}",
            course2.timeToComplete,course2.ClassName);
   }
}
class HomeworkAssignment
{
   private int numberOfExercises;
   private int timeToComplete;
   // 10 minutes to complete each exercise
   private const int TIME_PER_EXERCISE = 10;
   public ClassName {get; set};
   public int NumberOfExercises
   {
      get
      {
         return numberOfexercises;
      }
      set
      {
         numberOfExercises = number;
         CalcCompletionTime();
      }
   }
   public double TimeToComplete
   {
      get
      {
         return timeToComplete;
      }
   }
   private void CalcCompletionTime()
   {
      timeToComplete = numberOfExercises * TIME_PER_EXERCISE;      
   }
}