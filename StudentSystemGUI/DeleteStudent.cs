using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentSystemGUI
{
    /// <summary>
    /// Created 10/22/2020 by Lucas Chapman.
    /// This class is created to be used as a form for deleting students and provides a button for going back to the
    /// Student System form.
    /// </summary>
    public partial class DeleteStudent : Form
    {
        /// <summary>
        /// Constructor for the DeleteStudent class
        /// </summary>
        public DeleteStudent()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Makes only one checkbox able to be selected
        /// </summary>
        /// <param name="sender">Represents the form</param>
        /// <param name="e">Represents the event that occurred</param>
        void LiveOnCamp_CheckedChanged(object sender, EventArgs e)
        {
            if (liveOffCamp.Checked && liveOnCamp.Checked)
            {
                liveOffCamp.Checked = false;
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
        /// Disables all of the input fields and the "Delete Student" button when a new student ID is being entered
        /// </summary>
        /// <param name="sender">Represents the form</param>
        /// <param name="e">Represents the event that occurred</param>
        void StuId_TextChanged(object sender, EventArgs e)
        {
            delete.Enabled = false;
            nameSection.Enabled = false;
            dormSection.Enabled = false;
            mealPlanSection.Enabled = false;
        }

        /// <summary>
        /// Searches the list for the student ID that was entered when the "Search" button is clicked
        /// </summary>
        /// <param name="sender">Represents the form</param>
        /// <param name="e">Represents the event that occurred</param>
        void Search_Click(object sender, EventArgs e)
        {
            int errctr = 0; // keeps track of all the errors that have been found
            bool found = false;

            errctr += StuId();

            // Check if either the "Yes" or "No" checkbox was selected
            if (!liveOffCamp.Checked && !liveOnCamp.Checked)
            {
                errctr++;
                MessageBox.Show("No checkboxes were selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (errctr == 0)
            {
                foreach (var stu in StudentSystem.stuList)
                {
                    if (liveOffCamp.Checked)
                    {
                        if (stu.GetType() == typeof(Student) && stu.Id == int.Parse(stuId.Text))
                        {
                            MessageBox.Show("The student was found!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Sets the matching input field to the value of the object
                            name.Text = stu.Name;

                            found = true;
                            break;
                        }
                    }
                    else if (liveOnCamp.Checked)
                    {
                        if (stu.GetType() == typeof(DormStudent) && stu.Id == int.Parse(stuId.Text))
                        {
                            DormStudent dormStu = (DormStudent)stu;
                            {
                                MessageBox.Show("Student was found!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Sets the matching input fields to the the values of the object
                                name.Text = dormStu.Name;
                                dorm.Text = dormStu.DormLoc;

                                if (dormStu.MealPlan == 'B')
                                {
                                    mealPlan.Text = "Basic";
                                }
                                else if (dormStu.MealPlan == 'M')
                                {
                                    mealPlan.Text = "Medium";
                                }
                                else
                                {
                                    mealPlan.Text = "High";
                                }

                                found = true;
                                break;
                            }
                        }
                    }
                }

                if (!found)
                {
                    MessageBox.Show("Student was not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    delete.Enabled = true;
                    nameSection.Enabled = true;

                    if (liveOnCamp.Checked)
                    {
                        dormSection.Enabled = true;
                        mealPlanSection.Enabled = true;
                    }
                }
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

            return errs;
        }

        /// <summary>
        /// Deletes the student that was found when the "Delete Student" button is clicked
        /// </summary>
        /// <param name="sender">Represents the form</param>
        /// <param name="e">Represents the event that occurred</param>
        void Delete_Click(object sender, EventArgs e)
        {
            bool valid = false;

            try
            {
                while (!valid)
                {
                    DialogResult result = MessageBox.Show("Do you wish to permanently delete this student?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result != DialogResult.Yes && result != DialogResult.No)
                    {
                        MessageBox.Show("Unknown button was pressed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (result == DialogResult.Yes)
                    {
                        // Attempts to create a new list without the student ID that was entered and stores the result in "stuList"
                        StudentSystem.stuList = StudentSystem.stuList.Where(s => s.Id != int.Parse(stuId.Text)).ToList();
                        valid = true;

                        MessageBox.Show("The student has been successfully removed", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        DisableAndClear();
                    }
                    else
                    {
                        valid = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Disables the sections of the input fields that were originally disabled and the "Delete Student" button and 
        /// clears all previous values that were added in 
        /// </summary>
        void DisableAndClear()
        {
            delete.Enabled = false;
            nameSection.Enabled = false;
            name.Text = "";
            dormSection.Enabled = false;
            dorm.Text = "";
            mealPlanSection.Enabled = false;
            mealPlan.Text = "";
        }

        /// <summary>
        /// Determines if this form should be closed when the "Return" button is clicked
        /// </summary>
        /// <param name="sender">Represents the form</param>
        /// <param name="e">Represents the event that occurred</param>
        void GoBack_Click(object sender, EventArgs e)
        {
            bool valid = false;

            // Validation loop
            while (!valid)
            {
                DialogResult result = MessageBox.Show("Do you wish to close this form?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result != DialogResult.Yes && result != DialogResult.No)
                {
                    MessageBox.Show("Unknown button was pressed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result == DialogResult.Yes)
                {
                    valid = true;
                    this.Close();   // closes form
                }
                else
                {
                    valid = true;
                }
            }
        }
    }
}
