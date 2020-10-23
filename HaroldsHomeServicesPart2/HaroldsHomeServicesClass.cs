using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

/*
 * This is part of a multi-part project. This would be the second part of this project. This part deals with creating a 
 * console application for entering jobs, displaying jobs, and combining jobs.
 */
namespace HaroldsHomeServices
{
    /// <summary>
    /// Created 9/29/2020 by Lucas Chapman.
    /// This class acts as a console-based application that create Job objects and store it in a list of 5 
    /// Job objects.
    /// </summary>
    public class HaroldsHomeServices
    {
        static void Main(string[] args)
        {
            // "(5)" is used to set the capacity (how many objects this list can contain)
            List<Job> jobs = new List<Job>(5);

            WriteLine("Welcome to the Harold's Home Services program!!\n");
            
            char close = 'N';

            while (close == 'N')
            {
                int opt = Opt();

                switch (opt) {
                    case 1:
                        EnterJobs(jobs);
                        break;
                    case 2:
                        if (jobs.Count() > 0)
                        {
                            DispAllJobs(jobs);
                        } else
                        {
                            WriteLine("No jobs have been entered yet, please consider entering a job" +
                                "\nPress Enter to try continue");
                            ReadLine();
                        }
                        break;
                    case 3:
                        if (jobs.Count() == 5)
                        {
                            CombTwoJobs(jobs);
                        } else
                        {
                            WriteLine("Only " + jobs.Count() + " job(s) have/has been entered, you need to have " +
                                "5 jobs to be able to use this option\nPress Enter to continue");
                            ReadLine();
                        }
                        break;
                    case 4:
                        close = CloseProgram();

                        // Determines if the program should be closed
                        if (Char.ToUpper(close) == 'Y')
                        {
                            System.Environment.Exit(1);
                        }
                        break;
                    default:
                        WriteLine("Unknown option \"" + opt + "\" was selected, press Enter to try again");
                        ReadLine();
                        break;
                }
            }
        }

        /// <summary>
        /// Gets the option that the user selected
        /// </summary>
        /// <returns>Returns a valid option</returns>
        static int Opt()
        {
            int opt = 0;
            string data = "";
            bool valid = false;

            while (!valid) {
                try
                {
                    WriteLine("Select an option:\n1 - Enter Jobs\n2 - Display All Jobs\n3 - Combine Two Jobs\n" +
                    "4 - Exit");
                    data = ReadLine();
                    opt = Int32.Parse(data);

                    valid = true;
                } catch
                {
                    WriteLine("Error, unknown option \"" + data + "\" was se result press Enter to try again");
                    ReadLine();
                }     
            }

            return opt;
        }      
        
        /// <summary>
        /// Allows the user to enter enough inforamtion to be used to create Job objects
        /// </summary>
        /// <param name="jobs">Represents the list of jobs</param>
        static void EnterJobs(List<Job> jobs)
        {
            char cont = 'Y';

            while (cont == 'Y' && jobs.Count() < 5)
            {
                string desc = JobDesc();
                double hours = JobHours();
                double rate = HourlyRate();

                // Note: The setter in each of the property in the constructor already validates each field
                Job job = new Job(desc, hours, rate);   // will default invalid values using the properties
                jobs.Add(job);

                // Determines if there is enough room in the list to enter another job
                if (jobs.Count() < 5)
                {
                    cont = Cont();
                } else
                {
                    WriteLine("No more jobs can be entered\nPress Enter to select another option");
                    ReadLine();
                }
            }
        }

        /// <summary>
        /// Prompts user for the job description
        /// </summary>
        /// <returns>Returns a job description</returns>
        static string JobDesc()
        {
            string jobDesc = "";
            bool valid = false;

            while (!valid) {
                WriteLine("Enter the job description:");
                jobDesc = ReadLine();

                // Checks if no characters or only whitespace characters were entered
                if (String.IsNullOrEmpty(jobDesc.Trim()))
                {
                    WriteLine("Nothing was entered, press Enter to try again");
                    ReadLine();
                } else
                {
                    valid = true;
                }
            }

            return jobDesc;
        }

        /// <summary>
        /// Prompts the user for entering the number of hours it will take to complete a job
        /// </summary>
        /// <returns>Returns the number of hours that was entered</returns>
        static double JobHours()
        {
            double jobHours = 0;
            bool valid = false;

            while (!valid)
            {
                WriteLine("Enter the number of hours it takes to complete this job:");
                bool result = Double.TryParse(ReadLine(), out jobHours);

                // Checks if the opt that was entered is numeric
                if (result)
                {
                    if (jobHours <= 0)
                    {
                        WriteLine("Error, hours should be greater than 0\nPress Enter to try again");
                        ReadLine();
                    } else
                    {
                        valid = true;
                    }
                }
                else
                {
                    WriteLine("Error, hours must be numeric\nPress Enter to try again");
                    ReadLine();
                }
            }

            return jobHours;
        }

        /// <summary>
        /// Prompts the user for the hourly rate for a job
        /// </summary>
        /// <returns>Returns a valid hourly rate</returns>
        static double HourlyRate()
        {
            double hourlyRate = 0;
            bool valid = false;

            while (!valid)
            {
                WriteLine("Enter the hourly rate for that job:");
                bool result = Double.TryParse(ReadLine(), out hourlyRate);

                // Checks if the opt that was entered is numeric
                if (result)
                {
                    if (hourlyRate <= 0)
                    {
                        WriteLine("Error, hourly rate should be greater than 0\nPress Enter to try again");
                        ReadLine();
                    } else 
                    {
                        valid = true;
                    }
                    
                }
                else
                {
                    WriteLine("Error, houly rate must be numeric\nPress Enter to try again");
                    ReadLine();
                }
            }

            return hourlyRate;
        }

        /// <summary>
        /// Determines if the user wants to continue entering jobs
        /// </summary>
        /// <returns>Returns either a "Y" or a "N"</returns>
        static char Cont()
        {
            char opt = ' ';
            bool valid = false;

            while (!valid)
            {
                WriteLine("Do you wish to enter another job?\nY - Yes\nN - No");
                opt = Char.Parse(ReadLine());

                if (Char.ToUpper(opt) != 'Y' && Char.ToUpper(opt) != 'N')
                {
                    WriteLine("Error, unexpected opt \"" + opt + "\" was entered\nPress Enter to try again");
                    ReadLine();
                }
                else
                {
                    valid = true;
                }
            }

            return Char.ToUpper(opt);
        }

        /// <summary>
        /// Displays all of the jobs
        /// </summary>
        /// <param name="jobs">Represents the list of jobs</param>
        static void DispAllJobs(List<Job> jobs)
        {
            // Prints the column headings
            WriteLine("Job Description{0, 5}Hours{1, 5}Hourly Rate{2, 7}Total Fee\n", " ", " ", " ");

            // Sorts the job using the CompareTo() method in the Jobs class
            jobs.Sort();

            // Used to format the columns for each of the column headings
            const string optFormat = "{0, -15}     {1, 5}     {2, 11}     {3, 11}";

            foreach (Job job in jobs)
            {
                WriteLine(optFormat, job.Descrip, job.Hours, job.Rate.ToString("c"), job.CalcFee().ToString("c"));
            }

            WriteLine("\nPress Enter to return to the menu");
            ReadLine();
        }

        /// <summary>
        /// Combines two jobs
        /// </summary>
        /// <param name="jobs">Represents the list of jobs</param>
        static void CombTwoJobs(List<Job> jobs)
        {
            // Intializes an int array for holding the selected jobs
            int[] indexes = new int[2];
            int i = 0;

            // while loop used instead of for loop so "i" doesn't increment when invalid opt is entered
            while (i < 2)
            {
               WriteLine("Select one of two job you want to combine:\n1 - " + jobs[0].Descrip + "\n2 - " + 
                   jobs[1].Descrip + "\n3 - " + jobs[2].Descrip + "\n4 - " + jobs[3].Descrip + "\n5 - " + 
                   jobs[4].Descrip);
                bool result = Int32.TryParse(ReadLine(), out int jobOpt);

                // Checks if numeric opt was not entered
                if (!result)
                {
                    WriteLine("Unknown option was entered, press Enter to try again");
                    ReadLine();
                } else
                {
                    // Offsets the opt that was entered by 1 and adds the result to the array
                    indexes[i] = jobOpt - 1;
                    i++;
                }
            }

            // Uses the first and second element in the array of indexes as an index for the jobs list
            Job combJob = jobs[indexes[0]] + jobs[indexes[1]];
            const string MsgFormat = "Combined Job\n\nCombined Job Description: {0}\nTotal Hours: {1}\nAverage " +
                "Rate: {2}\n\nPress Enter to return to the menu";

            WriteLine(MsgFormat, combJob.Descrip, combJob.Hours, combJob.Rate.ToString("c"));
            ReadLine();
        }

        /// <summary>
        /// Determines if the program should be closed
        /// </summary>
        /// <returns>Returns either a "Y" or a "N"</returns>
        static char CloseProgram()
        {
            char close = 'N';
            bool valid = false;
            
            while (!valid)
            {
                WriteLine("You have chosen to exit this program, do you wish to continue?\nY - Yes\nN - No");
                close = Char.Parse(ReadLine());

                // Validates the close that was entered
                if (Char.ToUpper(close) != 'Y' && Char.ToUpper(close) != 'N')
                {
                    WriteLine("Error, unknown opt \"" + close + "\" was entered, press Enter to try again");
                    ReadLine();
                } else
                {
                    valid = true;
                }
            }
            return Char.ToUpper(close);
        }
    }
}