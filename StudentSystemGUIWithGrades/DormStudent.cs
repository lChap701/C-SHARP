using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentSystemGUI
{
    /// <summary>
    /// Created 10/19/2020 by Lucas Chapman.
    /// The child class of the Student class that is used to create Student and DormStudent objects with the DormStudent
    /// objects being able to be serialized and deserialized with a ToString() method being used as well.
    /// </summary>
    [Serializable]
    public class DormStudent : Student
    {
        string dormLoc;
        char mealPlan;

        /// <summary>
        /// The property for the "dormLoc"
        /// </summary>
        public string DormLoc
        {
            get
            {
                return dormLoc;
            }

            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    switch (value.Trim())
                    {
                        case "Oak":
                        case "Trustee":
                        case "Wapello":
                        case "Appanoose":
                        case "Mahaska":
                            dormLoc = value;
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// The property for the "mealPlan" field
        /// </summary>
        public char MealPlan
        {
            get
            {
                return mealPlan;
            }

            set
            {
                if (value == 'M' || value == 'B' || value == 'H')
                {
                    mealPlan = char.ToUpper(value);
                }
            }
        }

        /// <summary>
        /// The default constructor of the DormStudent class
        /// </summary>
        public DormStudent() : base()
        {
            DormLoc = "Oak";
            MealPlan = 'B';
        }

        /// <summary>
        /// The overload constructor for the DormStudent class
        /// </summary>
        /// <param name="i">Represents the student ID</param>
        /// <param name="n">Represents the student's name</param>
        /// <param name="dl">Represent the dorm location</param>
        /// <param name="mp">Represents the meal plan</param>
        public DormStudent(int i, string n, string dl, char mp) : base(i, n)
        {
            DormLoc = dl;
            MealPlan = mp;
        }

        /// <summary>
        /// The ToString() method of the DormStudent class
        /// </summary>
        /// <returns>Returns a combined message</returns>
        public override string ToString()
        {
            string mealPlanFull;

            if (MealPlan == 'B')
            {
                mealPlanFull = "Basic";
            } else if (MealPlan == 'M')
            {
                mealPlanFull = "Medium";
            } else
            {
                mealPlanFull = "High";
            }

            return base.ToString() + "Dorm Location: " + DormLoc + "\n" + "Meal Plan: " + mealPlanFull;
        }
    }
}