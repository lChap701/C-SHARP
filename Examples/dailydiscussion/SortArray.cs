using System;
using static System.Console;
class SortArray
{
    static void Main()
    {
        string[] names = {"Olive", "Patty",
         "Richard", "Ned", "Mindy"};
        int x;
        Array.Sort(names);
        for (x = 0; x < names.Length; ++x)
            WriteLine(names[x]);

        // Ways to compare string
        /*if (names[0] == names[4])
        {

        }*/
        /*if (names[0].Equals(names[4]))
        {

        }*/
        if (names[0].CompareTo(names[4]) == 0)  // "0" means their equal
        {                                       // greater than 0 means names[0] is greater than names[4] alphabetically
                                                // less than 0 means names[0] is less than names[4] alphabetically
        }
        ReadLine();
    }
}
/* What the interface with CompareTo() looks like by default */
/*interface ICompareable
{
    int CompareTo(Object o);    // known as an abstract method since it has no body in the interface, only in the classes implementing it
}*/