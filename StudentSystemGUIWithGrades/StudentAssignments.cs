using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * This project revises Project 4 (StudentSystemGUI) to include a form for adding, deleting, and updating assignments using
 * a DataGridView
 */
namespace StudentSystemGUI
{
    public partial class StudentAssignments : Form
    {
        public static List<Student> stuList = new List<Student>();
        public bool displayed = false;  // used to determine if the "No assignments to display" message was displayed
        public bool saved = true;     // used to determine if changes were saved
        public bool formLoaded = false;     // used to determine if the form was loaded
        public string orgValue;

        /// <summary>
        /// Constructor for the StudentAssignments class
        /// </summary>
        public StudentAssignments()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Deserailizes the data in "students.dat", adds the student IDs in the list box and displays a 
        /// welcome message
        /// </summary>
        /// <param name="sender">Represents the form</param>
        /// <param name="e">Represents the event that occurred</param>
        void StudentAssignments_Load(object sender, EventArgs e)
        {
            try
            {
                // Clears the list when it is is not empty
                if (stuList.Count > 0)
                {
                    stuList.Clear();
                }

                // Checks if the file exists
                if (File.Exists("students.dat"))
                {
                    FileStream inFile = new FileStream("students.dat", FileMode.Open, FileAccess.Read);
                    BinaryFormatter bf = new BinaryFormatter();

                    // EOF loop
                    while (inFile.Position < inFile.Length)
                    {
                        object deser = bf.Deserialize(inFile);
                        stuList.Add((Student)deser);
                    }

                    inFile.Close(); // closes file

                    // Checks if student IDs can be added to stuListBox
                    if (stuList.Count > 0)
                    {
                        foreach (Student stu in stuList)
                        {
                            stuListBox.Items.Add(stu.Id.ToString().PadLeft(7, '0'));    // pads IDs with 0s
                        }

                        stuListBox.SelectedIndex = 0;
                        MessageBox.Show("Welcome to the Student Assignment Form!!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Nothing to display, please use the Student System Form to add students", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Close();    // closes the form
                    }
                }

                formLoaded = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Displays new data when a new student ID is selected
        /// </summary>
        /// <param name="sender">Represents the form</param>
        /// <param name="e">Represents the event that occurred</param>
        void StuListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 0;
            dgvAssign.Rows.Clear();

            try
            {
                foreach (var assign in stuList[stuListBox.SelectedIndex].Assignments)
                {
                    dgvAssign.Rows.Add();
                    dgvAssign.Rows[i].Cells[0].Value = assign.AssignName;
                    dgvAssign.Rows[i].Cells[1].Value = assign.PointsEarned;
                    dgvAssign.Rows[i].Cells[2].Value = assign.PointsPossible;
                    i++;
                }
            }
            catch (NullReferenceException)
            {
                // Displays the message below once when the form is loaded
                if (!displayed && stuListBox.SelectedIndex == 0)
                {
                    MessageBox.Show("No assignments to display", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    displayed = true;
                }
            }
        }

        /// <summary>
        /// Validates and adds the assignment that was added/updated to the list
        /// </summary>
        /// <param name="sender">Represents the form</param>
        /// <param name="e">Represents the event that occurred</param>
        void Save_Click(object sender, EventArgs e)
        {
            int errctr = 0;

            // Loops through all the rows in the DataGridView to find the new data that was entered
            foreach (DataGridViewRow row in dgvAssign.Rows)
            {
                // Avoids checking the last row
                if (!row.IsNewRow)
                {
                    errctr += Validation(row);
                }
            }

            // Checks if data in
            if (errctr == 0)
            {
                AddData();
                MessageBox.Show("All changes were saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                saved = true;
            }
        }

        /// <summary>
        /// Validates the data that was entered
        /// </summary>
        /// <param name="row">Represents the current row in the DataGridView</param>
        /// <returns>Returns the total number of errors found</returns>
        int Validation(DataGridViewRow row)
        {
            // Used to show the row where the error was found
            int rowNum = row.Index + 1;  // offsets by 1 since the index starts at 0
            int errctr = 0;

            try
            {
                errctr += AssignName(row.Cells[0].Value.ToString(), rowNum);
                errctr += PtsEarned(row.Cells[1].Value.ToString(), rowNum);
                errctr += PtsPossible(row.Cells[2].Value.ToString(), rowNum, row.Cells[1].Value.ToString());
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Data is missing in row " + rowNum, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errctr++;
            }

            return errctr;
        }

        /// <summary>
        /// Validates the assignment name that was entered
        /// </summary>
        /// <param name="assignName">Represents the name that was entered</param>
        /// <param name="rowNum">Represents the number of the current row</param>
        /// <returns>Returns the number of errors that were found</returns>
        int AssignName(string assignName, int rowNum)
        {
            int errs = 0;

            if (string.IsNullOrEmpty(assignName.Trim()))
            {
                MessageBox.Show("No assignment was found in row " + rowNum.ToString("#,##0"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errs++;
            }

            return errs;
        }

        /// <summary>
        /// Validates the points that were earned
        /// </summary>
        /// <param name="ptsEarned">Represents the string value of the points that were earned</param>
        /// <param name="rowNum">Represents the number of the current row</param>
        /// <returns>Represents the errors that were found</returns>
        int PtsEarned(string ptsEarned, int rowNum)
        {
            int errs = 0;

            if (!double.TryParse(ptsEarned, out double earned))
            {
                MessageBox.Show("The points earned in row " + rowNum.ToString("#,##0") + " should be numeric and this cell should not be left blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errs++;
            }
            else if (earned < 0)
            {
                MessageBox.Show("The points earned in row " + rowNum.ToString("#,##0") + " should be greater than or equal to 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errs++;
            }

            return errs;
        }

        /// <summary>
        /// Validates that maxium amount of points possible
        /// </summary>
        /// <param name="ptsPossible">Represents the string value of the maxium amount of points possible</param>
        /// <param name="rowNum">Represents the number of the current row</param>
        /// <returns>Returns the number of errors that were found</returns>
        int PtsPossible(string ptsPossible, int rowNum, string ptsEarned)
        {
            int errs = 0;
            bool maxValid = false;

            if (!double.TryParse(ptsPossible, out double max))
            {
                MessageBox.Show("The maximum amount of points possible in row " + rowNum.ToString("#,##0") + " should be numeric and this cell should not be left blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errs++;
            }
            else if (max > 100 || max <= 0)
            {
                MessageBox.Show("The maxium amount of points possible in row " + rowNum.ToString("#,##0") + " should be less than or equal to 100 and greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errs++;
            }
            else
            {
                maxValid = true;
            }

            // Checks if both the maxium amount of points possible and points earned is valid
            if (maxValid && double.TryParse(ptsEarned, out double earned))
            {
                if (earned > max && earned >= 0)
                {
                    MessageBox.Show("The maxium amount of points possible in row " + rowNum.ToString("#,##0") + " should be greater than or equal to the amounts of points earned", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errs++;
                }
            }

            return errs;
        }

        /// <summary>
        /// Adds the assignment data in stuList to the rows in the DataGridView and adds the assignment
        /// data to stuList
        /// </summary>
        void AddData()
        {
            bool isNull = true;

            // Clears the assignments in stuList if any values are present
            if (stuList[stuListBox.SelectedIndex].Assignments != null)
            {
                stuList[stuListBox.SelectedIndex].Assignments.Clear();
                isNull = false;
            }

            // Saves all assignment data for each row in stuList
            foreach (DataGridViewRow row in dgvAssign.Rows)
            {
                // Checks if the current row is not the last row
                if (!row.IsNewRow)
                {
                    string ptsEarned = row.Cells[1].Value.ToString();
                    string ptsPossible = row.Cells[2].Value.ToString();

                    // Creates an Assignment object using the data in the current row
                    Assignment assignment = new Assignment(row.Cells[0].Value.ToString(), double.Parse(ptsEarned), double.Parse(ptsPossible));

                    if (!isNull)
                    {
                        // Adds the assignment to the end of the list
                        stuList[stuListBox.SelectedIndex].Assignments.Add(assignment);
                    }
                    else
                    {
                        // Initailizes the list with an assignment
                        stuList[stuListBox.SelectedIndex].Assignments = new List<Assignment>() { assignment };
                    }
                }
            }
        }

        /// <summary>
        /// Checks if the key that was pressed is the "Delete" key and calls DeleteMsg() when this key is
        /// pressed
        /// </summary>
        /// <param name="sender">Represents the form</param>
        /// <param name="e">Represents the key that was pressed</param>
        void DgvAssign_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteMsg();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DgvAssign_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvAssign.CurrentCell.Value.ToString() != orgValue && formLoaded)
                {
                    saved = false;
                }
            }
            catch (NullReferenceException)
            {
                saved = true;
            }
        }

        /// <summary>
        /// Gets the original value that was entered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DgvAssign_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                orgValue = dgvAssign[e.ColumnIndex, e.RowIndex].Value.ToString();
            }
            catch (NullReferenceException)
            {
                orgValue = "";
            }
        }

        /// <summary>
        /// Prompts the user if they want to delete a row in the DataGridView
        /// </summary>
        void DeleteMsg()
        {
            bool valid = false;
            int rowNum = dgvAssign.CurrentCell.RowIndex + 1;

            try
            {
                // Validation loop
                while (!valid)
                {
                    DialogResult result = MessageBox.Show("Do you wish to delete the assignment in row " + rowNum + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result != DialogResult.Yes && result != DialogResult.No)
                    {
                        MessageBox.Show("Unknown button was pressed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (result == DialogResult.Yes)
                    {
                        // Checks if the row that is selected is not the last row of the DataGridView
                        if (!dgvAssign.Rows[dgvAssign.CurrentCell.RowIndex].IsNewRow)
                        {
                            DeleteRow();
                            AddData();
                            MessageBox.Show("The assignment has been successfully removed", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            saved = false;
                        }
                        else
                        {
                            MessageBox.Show("This row cannot be deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

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
        /// Deletes a row in the DataGridView and removes data of the row that was deleted from stuList
        /// </summary>
        void DeleteRow()
        {
            try
            {
                string ptsEarned = dgvAssign.Rows[dgvAssign.CurrentCell.RowIndex].Cells[1].Value.ToString();
                string ptsPossible = dgvAssign.Rows[dgvAssign.CurrentCell.RowIndex].Cells[2].Value.ToString();

                // Creates an Assignment object with the data of the row that was deleted
                Assignment delAssign = new Assignment(dgvAssign.Rows[dgvAssign.CurrentCell.RowIndex].Cells[0].Value.ToString(), double.Parse(ptsEarned), double.Parse(ptsPossible));

                // Creates a list without the row that was deleted (delAssign)
                stuList[stuListBox.SelectedIndex].Assignments = stuList[stuListBox.SelectedIndex].Assignments.Where(a => !a.AssignName.Equals(delAssign.AssignName) && a.PointsEarned != delAssign.PointsEarned && a.PointsPossible != delAssign.PointsPossible).ToList();

                // Deletes the row
                dgvAssign.Rows.RemoveAt(dgvAssign.CurrentCell.RowIndex);
            }
            catch (NullReferenceException)
            {
                // Deletes an empty row
                dgvAssign.Rows.RemoveAt(dgvAssign.CurrentCell.RowIndex);
            }

        }

        /// <summary>
        /// Calls DeleteMsg() when the "Delete Assignment" button is clicked
        /// </summary>
        /// <param name="sender">Represents the forms</param>
        /// <param name="e">Represents the event that occurred</param>
        void Delete_Click(object sender, EventArgs e)
        {
            DeleteMsg();
        }

        /// <summary>
        /// Prompts the user if they wish to close the form, closes the form when the users chooses to do
        /// so, and calls SerialAssignments()
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
                    bool errors = false;

                    // Checks if there are any students that can be saved
                    if (stuList.Count > 0)
                    {
                        if (!saved)
                        {
                            errors = SaveBeforeExit();
                        }
                        else
                        {
                            SerialAssignments();
                        }
                    }

                    if (!errors)
                    {
                        Close();   // closes form
                    }

                    valid = true;
                }
                else
                {
                    valid = true;
                }
            }
        }

        /// <summary>
        /// Saves the changes that were made when none of the changes have been saved
        /// </summary>
        /// <returns></returns>
        bool SaveBeforeExit()
        {
            bool valid = false;
            bool errors = false;

            // Validation loop
            while (!valid)
            {
                DialogResult result = MessageBox.Show("Do you wish to save your changes?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result != DialogResult.Yes && result != DialogResult.No)
                {
                    MessageBox.Show("Unknown button was pressed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result == DialogResult.Yes)
                {
                    int errctr = 0;

                    foreach (DataGridViewRow row in dgvAssign.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            errctr += Validation(row);
                        }
                    }

                    if (errctr == 0)
                    {
                        AddData();
                        SerialAssignments();
                    }
                    else
                    {
                        errors = true;
                    }

                    valid = true;
                }
                else
                {
                    valid = true;
                }
            }

            return errors;
        }

        /// <summary>
        /// Used to serialize Student objects into the file "students.dat"
        /// </summary>
        void SerialAssignments()
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