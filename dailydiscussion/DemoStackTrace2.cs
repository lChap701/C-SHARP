using System;
using static System.Console;

public class DemoStackTrace2
{
    public static void Main(string[] args)
    {
        MethodA();
        ReadLine();
    }

    public static void MethodA()
    {
        WriteLine("In MethodA");

        try
        {
            MethodB();
        }
        catch (IndexOutOfRangeException error)
        {
            WriteLine(error.Message + " " + error.StackTrace);
        }
    }

    public static void MethodB()
    {
        WriteLine("In MethodB");
        MethodC();
    }

    public static void MethodC()
    {
        WriteLine("In MethodC");
        int[] array = { 5, 6, 227 };
        WriteLine(array[3]);
    }
}