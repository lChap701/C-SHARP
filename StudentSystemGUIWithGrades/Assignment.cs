using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystemGUI
{
    /// <summary>
    /// Created 11/2/2020 by Lucas Chapman.
    /// This class  was created to be used to create Assignment objects.
    /// </summary>
    [Serializable]
    public class Assignment
    {
        string assignName;
        double pointsEarned;
        double pointsPossible;

        /// <summary>
        /// The property for the "assignName" field
        /// </summary>
        public string AssignName
        {
            get
            {
                return assignName;
            }

            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    assignName = value;
                }
            }
        }

        /// <summary>
        /// The property for the "pointsEarned" field
        /// </summary>
        public double PointsEarned { 
            get { 
                return pointsEarned; 
            }

            set {
                if (value >= 0)
                {
                    pointsEarned = value;
                }
            }
        }

        /// <summary>
        /// The property for the "pointsPossible" field
        /// </summary>
        public double PointsPossible {
            get
            {
                return pointsPossible;
            }

            set
            {
                if (value <= 100 && value > 0)
                {
                    pointsPossible = value;
                }
            }
        }

        /// <summary>
        /// The default constructor for the Assignment class
        /// </summary>
        public Assignment() : base()
        {
            AssignName = "Project 5";
            pointsEarned = 0;
            pointsPossible = 100;
        }

        /// <summary>
        /// The overloaded constructor for the Assignment class
        /// </summary>
        /// <param name="an">Represents the name of an assignment</param>
        /// <param name="pe">Represents the amount of points a student earned for an assignment</param>
        /// <param name="pp">Represents the total number of points that can be earned for an assignment</param>
        public Assignment(string an, double pe, double pp)
        {
            AssignName = an;
            PointsEarned = pe;
            PointsPossible = pp;
        }
    }
}