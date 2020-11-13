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
    /// This class was created to be inherited from and serialize and deserialize Student objects with the CompareTo() 
    /// and ToString() methods being used.
    /// </summary>
    [Serializable]
    public class Student : IComparable
    {
        int id;
        string name;

        /// <summary>
        /// The property for the "id" field
        /// </summary>
        public int Id { 
            get
            {
                return id;
            }
            set
            {
                if (value < 10000000 && value > 0)
                {
                    id = value;
                }
            }
        }

        /// <summary>
        /// The property for the "name" field
        /// </summary>
        public string Name {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    MessageBox.Show("Name is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    name = value.Trim();
                }
            }
        }

        /// <summary>
        /// The default constructor of the base/Student class
        /// </summary>
        public Student()
        {
            Id = 1234567;
            Name = "Lucas Chapman";
        }

        /// <summary>
        /// The overloaded constructor for the base/Student class
        /// </summary>
        public Student(int i, string n)
        {
            Id = i;
            Name = n;
        }

        /// <summary>
        /// Sorts each Student object by their student ID
        /// </summary>
        /// <param name="obj">Represents the second Student object</param>
        /// <returns>Returns either a "0" for when the two objects are equal, "1" for when the second object is the smallest, or "-1" for when the second object is the biggest</returns>
        public int CompareTo(object obj)
        {
            int i = 0;
            Student sec = (Student)obj;

            if (Id < sec.Id)
            {
                i = -1;
            } else if (Id > sec.Id)
            {
                i = 1;
            }

            return i; 
        }

        /// <summary>
        /// The ToString() method of the base/Student class
        /// </summary>
        /// <returns>Returns a message</returns>
        public override string ToString()
        {
            return "Student ID: " + Id + "\n" + "Name: " + Name + "\n";
        }
    }
}
