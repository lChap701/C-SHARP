using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

/*
 * This is part of a multi-part project. This would be the first part of this project. This part deals with creating an 
 * instaintable class that will use a control class to test it.
 */
namespace HaroldsHomeServices
{
    /// <summary>
    /// Created 9/9/2020 by Lucas Chapman.
    /// This class acts as a control class for testing the Job class.
    /// </summary>
    public class TestJobs
    {
        static void Main(string[] args)
        {
            // Array for storing 5 Job objects
            Job[] jobs = new Job[5];

            Default(jobs);
            OverloadCon(jobs);
            GetAndSet(jobs);
            OverloadOp(jobs);
            SortJobs(jobs);
        }

        /// <summary>
        /// Tests the default constructor in the Job class
        /// </summary>
        /// <param name="job">Represents the jobs array</param>
        static void Default(Job[] job)
        {
            Job test1 = new Job();

            // ToString("c") is used to display the rate in US dollars
            WriteLine("Test 1: Default Constructor\n\nJob Description: {0}\nHours: {1} hour\nHourly Rate: {2}" +
                "\n\nPress Enter to continue", test1.Descrip, test1.Hours, test1.Rate.ToString("c"));
            ReadLine();

            job[0] = test1; // stores the job object in the job array
        }

        /// <summary>
        /// Tests both overloaded constructors from the Job class
        /// </summary>
        /// <param name="job">Represents the jobs array</param>
        static void OverloadCon(Job[] job)
        {
            const string MsgFormat = "\nJob Description: {0}\nHours: {1} hour\nHourly Rate: {2}";

            // Tests the overloaded constructor for job description
            WriteLine("Test 2: Overloaded Constructor For Job Description");

            // Valid data test
            Job test2 = new Job("trim hedges");
            WriteLine(MsgFormat, test2.Descrip, test2.Hours, test2.Rate.ToString("c"));
            job[1] = test2;

            // Invalid data test
            test2 = new Job("");
            WriteLine(MsgFormat, test2.Descrip, test2.Hours, test2.Rate.ToString("c"));
            job[2] = test2; // stores the object in the array

            WriteLine("\nPress Enter to continue");
            ReadLine();

            // Tests the overloaded constructor for all fields
            WriteLine("Test 3: Overloaded Constructor For All Fields");

            // Valid data test
            Job test3 = new Job("paint fence", 2.5, 15.25);
            WriteLine(MsgFormat, test3.Descrip, test3.Hours, test3.Rate.ToString("c"));
            job[3] = test3;

            // Invalid data test
            test3 = new Job("", 0, -1);
            WriteLine(MsgFormat, test3.Descrip, test3.Hours, test3.Rate.ToString("c"));
            job[4] = test3;

            WriteLine("\nPress Enter to continue");
            ReadLine();
        }

        /// <summary>
        /// Tests the properties (the getters (accessors) and the setters (mutators)) of the Job class
        /// </summary>
        /// <param name="jobs">Represents the jobs array</param>
        static void GetAndSet(Job[] jobs)
        {
            // Contains the format for all messages that are displayed
            const string MsgFormat = "\nJob Description: {0}\nHours: {1} hour(s)\nHourly Rate: {2}";

            WriteLine("Test 4: Getters and Setters\n");

            // Displays the original values
            WriteLine("Original Values");

            WriteLine(MsgFormat, jobs[2].Descrip, jobs[2].Hours, jobs[2].Rate.ToString("c"));
            WriteLine(MsgFormat, jobs[4].Descrip, jobs[4].Hours, jobs[4].Rate.ToString("c"));

            // Sets and display new values
            WriteLine("\nNew Values");

            // Tests only the the job description field's property
            jobs[2].Descrip = "build birdhouse";
            WriteLine(MsgFormat, jobs[2].Descrip, jobs[2].Hours, jobs[2].Rate.ToString("c"));

            // Tests all 3 fields' properties
            jobs[4].Descrip = "wash cars";
            jobs[4].Hours = 4.1;
            jobs[4].Rate = 20.25;
            WriteLine(MsgFormat, jobs[4].Descrip, jobs[4].Hours, jobs[4].Rate.ToString("c"));

            WriteLine("\nPress Enter to continue");
            ReadLine();
        }

        /// <summary>
        /// Tests the overloaded "+" operator to see if it properly combines jobs and find the total hours and average 
        /// rate of the jobs.
        /// </summary>
        /// <param name="jobs">Represents the jobs array</param>
        static void OverloadOp(Job[] jobs)
        {
            WriteLine("Test 5: Overloaded \"+\" operator");

            // Uses the "+" operator on all objects in the array
            for (int i = 0; i < 4; i++)
            {
                Job test5 = jobs[i] + jobs[i + 1];

                WriteLine("\nJob Description: {0}\nHours: {1} hour(s)\nAverage Hourly Rate: {2}",
                    test5.Descrip, test5.Hours, test5.Rate.ToString("c"));
            }

            WriteLine("\nPress Enter to continue");
            ReadLine();
        }

        /// <summary>
        /// Tests the CompareTo() method using the Array.Sort() method for sorting jobs 
        /// </summary>
        /// <param name="jobs">Represents the jobs array</param>
        static void SortJobs(Job[] jobs)
        {
            WriteLine("Test 6: Sorting");

            Array.Sort(jobs);   // sorts the jobs based on the total fee

            // Displays all of the jobs that have been sorted in the array
            foreach (Job test6 in jobs)
            {
                WriteLine("\nJob Description: {0}\nHours: {1} hour(s)\nHourly Rate: {2}\nTotal Fee: {3}",
                    test6.Descrip, test6.Hours, test6.Rate.ToString("c"), test6.CalcFee().ToString("c"));
            }

            WriteLine("\nPress Enter to exit");
            ReadLine();
        }
    }
}
