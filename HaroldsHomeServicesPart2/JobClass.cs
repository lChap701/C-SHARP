using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * This is part of a multi-part project. This would be the first part of this project. This part deals with creating an 
 * instaintable class that will use a control class to test it.
 */
namespace HaroldsHomeServices
{
    /// <summary>
    /// Created 9/9/2020 by Lucas Chapman.
    /// This class was created to act as an instaintable class for a person's job information (their job description, hours, 
    /// and hourly rate). This class also implements the IComparable interface for sorting and overloads the "+" operator
    /// for combining two jobs, finding the total hours of the two jobs, and find the average rate of two jobs.
    /// </summary>
    public class Job : IComparable
    {
        string descrip;
        double hours;
        double rate;

        // Properties/getters and setters
        /// <summary>
        /// The property that contains the getter (accessor) and the setter (mutator) for "descrip"
        /// </summary>
        public string Descrip
        {
            get
            {
                return descrip.Trim();  // Trim() used to get rid of any whitespace characters
            }

            set
            {
                // Checks if a value is empty ("") or null or doesn't contain only whitespace characters
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    descrip = "mow yard";
                }
                else
                {
                    descrip = value;
                }
            }
        }

        /// <summary>
        /// The property that contains the getter (accessor) and setter (mutator) for "hours"
        /// </summary>
        public double Hours
        {
            get
            {
                return hours;
            }

            set
            {
                // Checks if a value is greater than 0
                if (value <= 0)
                {
                    hours = 1;
                }
                else
                {
                    hours = value;
                }
            }
        }

        /// <summary>
        /// The property that contains the getter (accessor) and setter (mutator) for "rate"
        /// </summary>
        public double Rate
        {
            get
            {
                return rate;
            }

            set
            {
                // Checks if a value is greater than 0
                if (value <= 0)
                {
                    rate = 10;
                }
                else
                {
                    rate = value;
                }
            }
        }

        /// <summary>
        /// Job's default constructor
        /// </summary>
        public Job()
        {
            descrip = "mow yard";
            hours = 1;
            rate = 10;
        }

        /// <summary>
        /// Overloaded constructor for the Job class that only accepts the job description
        /// </summary>
        /// <param name="d">Represents the job description</param>
        public Job(string d)
        {
            Descrip = d;
            hours = 1;
            rate = 10;
        }

        /// <summary>
        /// Overloaded constructor for the Job class that accepts all fields
        /// </summary>
        /// <param name="d">Represents the job description</param>
        /// <param name="h">Represents the hours</param>
        /// <param name="r">Represents the hourly rate</param>
        public Job(string d, double h, double r)
        {
            Descrip = d;
            Hours = h;
            Rate = r;
        }

        /// <summary>
        /// Implements the CompareTo() method to sort all jobs based on the fee for each job
        /// </summary>
        /// <param name="obj">Represents the Job object that is passed to the method</param>
        /// <returns>Returns either a "0" to show that the two jobs are equal, a "1" to show the 1st job is bigger than the 2nd job, or a "-1" to show that the 1st job is smaller than the 2nd job</returns>
        public int CompareTo(object obj)
        {
            int i = 0; 
            double fee = CalcFee(); // calls CalcFee() using the object that invokes this method
            Job prev = (Job)obj;
            double prevFee = prev.CalcFee();

            // Checks if the fee for the current job is greater than or less than the previous job's fee
            if (fee > prevFee)
            {
                i = 1;
            }
            else if (fee < prevFee)
            {
                i = -1;
            }

            return i;
        }

        /// <summary>
        /// Used to calculate the fee for a specific job
        /// </summary>
        /// <returns>Returns the fee that was calculated</returns>
        public double CalcFee()
        {
            return Hours * Rate;    // uses the "Hours" and "Rate" of the object that invokes this method
        }

        /// <summary>
        /// Overloads the "+" operator to combine two jobs and find the total hours and avgerage rate of two jobs
        /// </summary>
        /// <param name="first">Represents the first job that is being compared</param>
        /// <param name="second">Represents the second job that is being compared</param>
        /// <returns>A new Job object with the combined job descriptions, total hours, and average rate of the two jobs</returns>
        public static Job operator +(Job first, Job second)
        {
            return new Job(first.Descrip + " and " + second.Descrip, first.Hours + second.Hours,
                (first.Rate + second.Rate) / 2);
        }
    }
}