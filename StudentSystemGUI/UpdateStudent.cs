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
    public partial class UpdateStudent : Form
    {
        public bool nameChanged = false;   // used to determine if a student's name changed

        /// <summary>
        /// Constructor for the UpdateStudent class
        /// </summary>
        public UpdateStudent()
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
        /// Sets the "nameChange" to "true" to indicate that a students name had change when a new name is being entered
        /// and the "Update Student" button is enabled
        /// </summary>
        /// <param name="sender">Represents the form</param>
        /// <param name="e">Represents the event that occurred</param>
        void Name_TextChanged(object sender, EventArgs e)
        {
            if (update.Enabled)
            {
                nameChanged = true;
            }
            else
            {
                nameChanged = false;
            }
        }

        /// <summary>
        /// Searches the list for the student ID that was entered and will enable certain fields based on which checkbox
        /// was selected and displays the student that was found when the "Search" button is clicked
        /// </summary>
        /// <param name="sender">Represents the form</param>
        /// <param name="e">Represents the event that occurred</param>
        void Search_Click(object sender, EventArgs e)
        {
            int errctr = 0; // keeps track of all the errors that have been found
            bool clicked = true;    // used to show that the "Search" button was clicked 
            bool found = false;  // determines if a dorm student was found

            errctr += StuId(clicked);

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
                            // Sets the matching input field to the value of the object
                            name.Text = stu.Name;

                            // Clears any leftover values in the dorm student fields (dorm location and meal plan)
                            dorms.Text = "";
                            RadioButton[] radBtns = { basic, medium, high };

                            foreach (var radbtn in radBtns)
                            {
                                if (radbtn.Checked)
                                {
                                    radbtn.Checked = false;
                                }
                            }

                            MessageBox.Show("The student was found!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                                // Sets the matching input fields to the the values of the object
                                name.Text = dormStu.Name;
                                dorms.Text = dormStu.DormLoc;

                                if (dormStu.MealPlan == 'B')
                                {
                                    basic.Checked = true;
                                }
                                else if (dormStu.MealPlan == 'M')
                                {
                                    medium.Checked = true;
                                }
                                else
                                {
                                    high.Checked = true;
                                }

                                MessageBox.Show("The student was found!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    update.Enabled = true;
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
        /// <param name="searchClick">Determines if the "Search" button was clicked</param>
        /// <returns>Returns the number of errors that were found</returns>
        int StuId(bool searchClick)
        {
            int errs = 0;
            int matches = 0;    // finds how many students have the same student ID that was entered

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

            if (!searchClick && errs == 0)
            {
                // Checks if a new student ID was entered or if the current student ID is being reused 
                foreach (var stu in StudentSystem.stuList)
                {
                    if (!nameChanged)
                    {
                        if (stu.Id == id && name.Text != stu.Name)
                        {
                            matches++;
                        }
                    }
                    else
                    {
                        if (stu.Id == id)
                        {
                            matches++;
                        }
                    }
                }

                // Detemines if the user entered another student's student ID 
                if ((matches > 1 && nameChanged) || (matches > 0 && !nameChanged))
                {
                    MessageBox.Show("The student ID that was entered has already been taken by another student", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errs++;
                }
            }

            return errs;
        }

        /// <summary>
        /// Updates the student that was found when the "Update Student" button is clicked
        /// </summary>
        /// <param name="sender">Represents the form</param>
        /// <param name="e">Represents the event that occurred</param>
        void Update_Click(object sender, EventArgs e)
        {
            bool valid = false;

            try
            {
                while (!valid)
                {
                    DialogResult result = MessageBox.Show("Do you wish to update this student?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result != DialogResult.Yes && result != DialogResult.No)
                    {
                        MessageBox.Show("Unknown button was pressed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (result == DialogResult.Yes)
                    {
                        UpdateStu();
                        valid = true;
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
        /// Validates the data that was entered and adds an updated Student/DormStudent object to the list
        /// </summary>
        void UpdateStu()
        {
            int errctr = 0;
            bool clickedSearch = false; // used to show that the "Search" button was not clicked
            // Array of this form's radio buttons
            RadioButton[] radBtns = { basic, medium, high };

            errctr += StuId(clickedSearch);
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
                    // Attempts to create a new list without the student ID that was entered and stores the result in "stuList"
                    StudentSystem.stuList = StudentSystem.stuList.Where(s => s.Id != int.Parse(stuId.Text)).ToList();

                    // Creates the object that was submitted and adds it to the list
                    DormStudent dormStu = new DormStudent(int.Parse(stuId.Text.Trim()), name.Text.Trim(), dorms.Text.Trim(), mealPlan);
                    StudentSystem.stuList.Add(dormStu);
                }
                else
                {
                    // Attempts to create a new list without the student ID that was entered and stores the result in "stuList"
                    StudentSystem.stuList = StudentSystem.stuList.Where(s => s.Id != int.Parse(stuId.Text)).ToList();

                    // Creates the object that was submitted and adds it to the list
                    Student stu = new Student(int.Parse(stuId.Text.Trim()), name.Text.Trim());
                    StudentSystem.stuList.Add(stu);
                }

                MessageBox.Show("This student has been updated!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DisableAndClear();
            }
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
        /// Disables the sections of the input fields that were originally disabled and the "Update Student" button and 
        /// clears all previous values that were added in 
        /// </summary>
        void DisableAndClear()
        {
            update.Enabled = false;
            nameSection.Enabled = false;
            name.Text = "";
            dormSection.Enabled = false;
            dorms.Text = "";
            mealPlanSection.Enabled = false;

            // Array of all the radio buttons in this form
            RadioButton[] radbtns = { basic, medium, high };

            foreach (var radbtn in radbtns)
            {
                if (radbtn.Checked)
                {
                    radbtn.Checked = false;
                }
            }
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
