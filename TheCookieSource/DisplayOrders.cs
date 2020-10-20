using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheCookieSource
{
    public partial class DisplayOrders : Form
    {
        /// <summary>
        /// Constructor for the DisplayOrder class
        /// </summary>
        public DisplayOrders()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Displays all the orders that were saved to the file
        /// </summary>
        /// <param name="sender">Represents the "DisplayOrders" form</param>
        /// <param name="e">Represents the event that occured</param>
        void DisplayOrders_Load(object sender, EventArgs e)
        {
            // Puts the data in ordList in a new list for sorting
            List<Order> sortList = new List<Order>(CookieSource.ordList);

            // Sorts the list of order objects from oldest delivery date to newest
            sortList.Sort();    // calls the CompareTo()

            foreach (var ord in sortList)
            {
                orders.Text += ord.ToString() + "\n\n";
            }
        }

        /// <summary>
        /// Displays a message box that is used to determine if the form should be closed when the "Return" button  
        /// is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Return_Click(object sender, EventArgs e)
        {
            bool valid = false;

            while (!valid)
            {
                DialogResult result = MessageBox.Show("Do you wish to return to The Cookie Source form?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

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