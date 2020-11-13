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
    public partial class Menu : Form
    {
        /// <summary>
        /// Constructor for the Menu class
        /// </summary>
        public Menu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Displays a welcome message
        /// </summary>
        /// <param name="sender">Represents the form</param>
        /// <param name="e">Represents the event that occurred</param>
        void Menu_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome! Please push a button to open up a new form!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Opens up to the Student System form when the "Student System Form" button is clicked
        /// </summary>
        /// <param name="sender">Represents the form</param>
        /// <param name="e">Represents the event that occurred</param>
        void StudentSystem_Click(object sender, EventArgs e)
        {
            StudentSystem ss = new StudentSystem();
            ss.ShowDialog();
        }

        /// <summary>
        /// Opens up to the Student Assignment form when the "Student Assignment Form" button is clicked
        /// </summary>
        /// <param name="sender">Represents the form</param>
        /// <param name="e">Represents the event that occurred</param>
        void StudentAssignment_Click(object sender, EventArgs e)
        {
            StudentAssignments sa = new StudentAssignments();
            sa.ShowDialog();
        }
    }
}
