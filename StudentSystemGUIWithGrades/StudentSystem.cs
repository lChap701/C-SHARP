using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentSystemGUI
{
    /// <summary>
    /// Created 10/19/2020 by Lucas Chapman.
    /// This class is created to be used as a form for saving students and provides buttons to open new forms for
    /// deleting and updating students.
    /// </summary>
    public partial class StudentSystem : Form
    {
        public static List<Student> stuList = new List<Student>();

        /// <summary>
        /// Constructor for the StudentSystem class
        /// </summary>
        public StudentSystem()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Reads the objects in the "students.dat" file (if any) and displays a welcome message when the form is loaded
        /// </summary>
        /// <param name="sender">Represents the form</param>
        /// <param name="e">Represents the event that occurred</param>
        void StudentSystem_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the Student System Form!!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (stuList.Count > 0)
            {
                stuList.Clear();
            }

            try
            {
                // Checks if the file exists
                if (File.Exists("students.dat"))
                {
                    FileStream inFile = new FileStream("students.dat", FileMode.Open, FileAccess.Read);
                    BinaryFormatter bf = new BinaryFormatter();

                    // EOF loop
                    while (inFile.Position < inFile.Length)
                    {
                        object deser = bf.Deserialize(inFile);

                        // Checks if the object is a Student or DormStudent object
                        if (deser.GetType() == typeof(Student))
                        {
                            stuList.Add((Student)deser);
                            stuList = stuList.Distinct().ToList();
                        }
                        else if (deser.GetType() == typeof(DormStudent))
                        {
                            stuList.Add((DormStudent)deser);
                        }
                    }

                    inFile.Close(); // closes file
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Makes only one checkbox able to be selected and enables the dorm and meal plan sections when the "Yes"
        /// checkbox is selected
        /// </summary>
        /// <param name="sender">Represents the form</param>
        /// <param name="e">Represents the event that occurred</param>
        void LiveOnCamp_CheckedChanged(object sender, EventArgs e)
        {
            if (liveOffCamp.Checked && liveOnCamp.Checked)
            {
                liveOffCamp.Checked = false;
            }

            // Enables controls when checked, disables controls when not checked
            if (liveOnCamp.Checked)
            {
                dormSection.Enabled = true;
                mealPlanSection.Enabled = true;
            }
            else
            {
                dormSection.Enabled = false;
                mealPlanSection.Enabled = false;
            }
        }

        /// <summary>
        /// Makes only one checkbox able to be selected
        /// </summary>
        /// <param name="sender">Represents the form</param>
        /// <param name="e">Represents the event that occurred</param>
        void LiveOffCamp_CheckedChanged(object sender, EventArgs e)
        {
            if (liveOnCamp.Checked && liveOffCamp.Checked)
            {
                liveOnCamp.Checked = false;
            }
        }

        /// <summary>
        /// Validates input fields and adds valid students that were entered to the list of students when the "Submit
        /// Student" button was clicked
        /// </summary>
        /// <param name="sender">Represents the form</param>
        /// <param name="e">Represents the event that occurred</param>
        void Submit_Click(object sender, EventArgs e)
        {
            int errctr = 0; // keeps track of all the errors that have been found

            // Array of this form's radio buttons
            RadioButton[] radBtns = { basic, medium, high };

            errctr += StuId();
            errctr += StuName();

            if (liveOnCamp.Checked)
            {
                errctr += Dorm();
                errctr += MealPlan(radBtns);
            }
            else if (!liveOffCamp.Checked && !liveOnCamp.Checked)
            {
                errctr++;
                MessageBox.Show("No checkboxes were selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (errctr == 0)
            {
                char mealPlan = ' ';

                foreach (var radBtn in radBtns)
                {
                    if (radBtn.Checked)
                    {
                        // Gets only the first letter in the text of the selected radio button
                        mealPlan = char.Parse(radBtn.Text.Substring(0, 1));
                        break;
                    }
                }

                if (liveOnCamp.Checked)
                {
                      DormStudent dormStu = new DormStudent(int.Parse(stuId.Text.Trim()), name.Text.Trim(), dorms.Text.Trim(), mealPlan);
                      stuList.Add(dormStu);
                }
                else
                {
                    Student stu = new Student(int.Parse(stuId.Text.Trim()), name.Text.Trim());
                    stuList.Add(stu);
                }

                MessageBox.Show("Student was saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Validates the student ID that was entered
        /// </summary>
        /// <returns>Returns the number of errors that were found</returns>
        int StuId()
        {
            int errs = 0;

            if (!int.TryParse(stuId.Text.Trim(), out int id))
            {
                MessageBox.Show("Student ID should contain only digits and should be filled out", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errs++;
            }
            else if (id <= 0 || stuId.Text.Length != 7)
            {
                MessageBox.Show("Student ID should be 7 digits long and should be geater than 0000000", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errs++;
            }
            
            if (errs == 0)
            {
                // Checks if a new student ID was entered
                foreach (var stu in StudentSystem.stuList)
                {
                    if (stu.Id == id)
                    {
                        MessageBox.Show("The student ID that was entered has already been taken by another student", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errs++;
                        break;
                    }
                }
            }

            return errs;
        }

        /// <summary>
        /// Validates the name that was entered
        /// </summary>
        /// <returns>Returns the number of errors that were found</returns>
        int StuName()
        {
            int errs = 0;

            if (string.IsNullOrEmpty(name.Text.Trim()))
            {
                MessageBox.Show("Name is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errs++;
            }

            return errs;
        }

        /// <summary>
        /// Validates the dorm that the dorm student selected
        /// </summary>
        /// <returns>Returns the number of errors that were found</returns>
        int Dorm()
        {
            int errs = 0;

            // Uses try-catch for validation since the only invalid option would be considered "null"
            try
            {
                dorms.SelectedItem.ToString();  // used to catch the NullReferenceException
            }
            catch (NullReferenceException)
            {
                bool match = false; // checks if the user entered an option in the dropdown menu

                // Checks if the user typed a dorm location
                if (string.IsNullOrEmpty(dorms.Text.Trim()))
                {
                    MessageBox.Show("Dorm was not selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errs++;
                }
                else
                {
                    foreach (var dorm in dorms.Items)
                    {
                        // Checks if the dorm that was entered is in the dropdown menu
                        if (dorms.Text.Trim().Equals(dorm.ToString()))
                        {
                            match = true;
                            break;
                        }
                    }

                    if (!match)
                    {
                        MessageBox.Show("An unknown dorm was selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errs++;
                    }
                }
            }

            return errs;
        }

        /// <summary>
        /// Validates the meal plan that the dorm student selected
        /// </summary>
        /// <param name="radBtns">Represents the array of radio buttons in this form</param>
        /// <returns>Returns the number of errors that were found</returns>
        int MealPlan(RadioButton[] radBtns)
        {
            int errs = 0;
            bool selected = false;

            foreach (var radBtn in radBtns)
            {
                if (radBtn.Checked)
                {
                    selected = true;
                    break;
                }
            }

            if (!selected)
            {
                MessageBox.Show("No meal plan was selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errs++;
            }

            return errs;
        }

        /// <summary>
        /// Displays a new form for finding the student that the user wishes to delete when the "Delete Student" button
        /// is clicked
        /// </summary>
        /// <param name="sender">Represents the form</param>
        /// <param name="e">Represents the event that occurred</param>
        void Delete_Click(object sender, EventArgs e)
        {
            DeleteStudent ds = new DeleteStudent();
            ds.ShowDialog();
        }

        /// <summary>
        /// Displays a new form for finding the student that the user wishes to update when the "Update Student" button
        /// is clicked
        /// </summary>
        /// <param name="sender">Represents the form</param>
        /// <param name="e">Represents the event that occurred</param>
        void Change_Click(object sender, EventArgs e)
        {
            UpdateStudent us = new UpdateStudent();
            us.ShowDialog();
        }

        /// <summary>
        /// Determines if the form should be closed and will serialize objects in the list, if the user choses to do so
        /// when the "Exit" button is clicked
        /// </summary>
        /// <param name="sender">Represents the form</param>
        /// <param name="e">Represents the event that occurred</param>
        void Exit_Click(object sender, EventArgs e)
        {
            bool valid = false;

            // Validation loop
            while (!valid)
            {
                DialogResult result = MessageBox.Show("Do you to close this form?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result != DialogResult.Yes && result != DialogResult.No)
                {
                    MessageBox.Show("Unknown button was pressed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result == DialogResult.Yes)
                {
                    valid = true;

                    // Checks if there are any students that can be saved
                    if (stuList.Count > 0)
                    {
                        SaveStudents();
                    }

                    this.Close();   // closes form
                }
                else
                {
                    valid = true;
                }
            }
        }

        /// <summary>
        /// Asks the user if they want to save the Student and determines if orders should be saved
        /// </summary>
        void SaveStudents()
        {
            bool valid = false;

            // Validation loop
            while (!valid)
            {
                DialogResult result = MessageBox.Show("Do you wish to save your changes?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Checks which button was pressed
                if (result != DialogResult.Yes && result != DialogResult.No)
                {
                    MessageBox.Show("Unknown button was pressed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result == DialogResult.Yes)
                {
                    SerialStudents();
                    valid = true;
                }
                else
                {
                    valid = true;
                }
            }
        }

        /// <summary>
        /// Used to serialize Student objects into the file "students.dat"
        /// </summary>
        void SerialStudents()
        {
            try
            {
                FileStream outFile = new FileStream("students.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();

                // Used to sort each object that will be added to the serialized in the file
                stuList.Sort(); // calls the CompareTo() method

                // Serialization Loop
                foreach (var stu in stuList)
                {
                    bf.Serialize(outFile, stu);
                }
                outFile.Close();    // closes file
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
