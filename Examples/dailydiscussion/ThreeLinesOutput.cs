using static System.Console;
class ThreeLinesOutput
{
    static void Main()
    {
        /*WriteLine("Line one");
        WriteLine("Line two");
        WriteLine("Line three");
        ReadLine();*/

        double amt = 4444445.67;

        // WriteLine("Amount: " + amt.ToString("c"));  // can pass formaters to ToString()
        WriteLine("{0, 15} {1, 10} {2, -23}", "Amount", " ", "Status"); // {0} and {1} are a placeholder mapped using parameters
                                                                        // commas are used to set the size
                                                                        // dashes set alignment based on the direction it's places
        WriteLine("{0, 15} {1, 10} is {2, -20}", amt.ToString("c"), " ", "ready for retirement");
        ReadLine();

        Student s1 = new Student();
        s1.credits = 4.9;
        s1.stuName = "Name";

        Student s2 = new Student();
        s2.stuName = "Last Name";
        s2.credits = 56.8;
        s2.tuition = s2.CalcTuition();

        // Calc();
    }

    /* static void Calc() {
         int i = 8;
     }*/
}

class Student
{
    public static double rate = 18;
    public string stuName;
    public double credits;
    public double tuition;

    public double CalcTuition()
    {
        return credits * 180;
    }
}