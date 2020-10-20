using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheCookieSource
{
    public partial class CookieSource : Form
    {
        public static List<Order> ordList = new List<Order>();

        /// <summary>
        /// Constructor for the CookieSource class
        /// </summary>
        public CookieSource()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Deserializes the objects in the file "orders.ser" and displays a welcome message when the form is loaded
        /// </summary>
        /// <param name="sender">Represents the "CookieSource" form</param>
        /// <param name="e">Represents the event that occured</param>
        void CookieSource_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to The Cookie Source form!!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                // Checks if the file exists
                if (File.Exists("orders.ser"))
                {
                    FileStream inFile = new FileStream("orders.ser", FileMode.Open, FileAccess.Read);
                    BinaryFormatter bf = new BinaryFormatter();

                    // EOF loop
                    while (inFile.Position < inFile.Length)
                    {
                        Order ord = (Order)bf.Deserialize(inFile);  // calls the deserialization Order() constructor
                        ordList.Add(ord);
                        Order.curOrdnum++;
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
        /// Method for validating data when the "Submit Order" button is clicked and add objects to the order list
        /// </summary>
        /// <param name="sender">Represents the "CookieSource" form</param>
        /// <param name="e">Represents the event that occured</param>
        void Submit_Click(object sender, EventArgs e)
        {
            int errctr = 0; // keeps track of all the errors that have been found
            // Array of this form's radio buttons
            RadioButton[] radBtns = { c, o, s };
            errctr += Custname();
            errctr += Pnum();
            errctr += Ctype(radBtns);
            errctr += Qty();
            errctr += Delivdate();

            if (errctr == 0)
            {
                char ctype = ' ';   // used to represent the selected radio button

                // Retrieves the selected radio button
                foreach (var radBtn in radBtns)
                {
                    if (radBtn.Checked)
                    {
                        ctype = char.Parse(radBtn.Text);
                        break;
                    }
                }

                Order ord = new Order(name.Text, phoneNumber.Text, ctype, int.Parse(quantity.Text), deliveryDate.Value);
                ordList.Add(ord);
                MessageBox.Show("Order was saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Customer name validation
        /// </summary>
        /// <returns>Returns the number of errors that were found</returns>
        int Custname()
        {
            int errs = 0;   // keeps track of errors that were found

            // Checks if name was entered and trims extra whitespace characters
            if (String.IsNullOrEmpty(name.Text.Trim()))
            {
                MessageBox.Show("Name is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errs++;
            }

            return errs;
        }

        /// <summary>
        /// Phone number validation
        /// </summary>
        /// <returns>Returns the number of errors that were found</returns>
        int Pnum()
        {
            int errs = 0;

            // Regex Pattern for validating phone numbers
            string pnumFormat = "^([(][\\d]{3}[)][\\s][\\d]{3}[-][\\d]{4})$";

            if (String.IsNullOrEmpty(phoneNumber.Text.Trim()))
            {
                MessageBox.Show("Phone number is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errs++;
            }
            else if (!Regex.IsMatch(phoneNumber.Text.Trim(), pnumFormat))
            {
                MessageBox.Show("Phone number should be in this format: (123) 123-1234", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errs++;
            }

            return errs;
        }

        /// <summary>
        /// Cookie type validation
        /// </summary>
        /// <returns>Returns the number of errors that were found</returns>
        int Ctype(RadioButton[] radBtns)
        {
            int errs = 0;   // keeps track of all the errors that have been found
            bool selected = false; // used to determined if any radio buttons were selected 

            // Loop for checking if any radio button was selected
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
                MessageBox.Show("No cookie type was selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errs++;
            }
            return errs;
        }

        /// <summary>
        /// Quantity validation
        /// </summary>
        /// <returns>Returns the nthe number of errors that were found</returns>
        int Qty()
        {
            int errs = 0;   // keeps track of all the errors that have been found

            // Checks if the value entered is an integer and stores it in "num"
            if (int.TryParse(quantity.Text, out int num))
            {
                try
                {
                    if (num <= 0)
                    {
                        errs++;
                        throw new QuantityIsTooLowException();
                    }
                }
                catch (QuantityIsTooLowException e)
                {
                    MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                errs++;
                MessageBox.Show("Quantity should be filled out and be an integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return errs;
        }

        /// <summary>
        /// Delivery date validation
        /// </summary>
        /// <returns>Returns the number of errors that were found</returns>
        int Delivdate()
        {
            int errs = 0;   // keeps track of the errors that were found

            // Checks if the selected date is less than the current date
            if (deliveryDate.Value < DateTime.Now.Date)
            {
                errs++;
                MessageBox.Show("Delivery date should be greater than or equal to the current date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return errs;
        }

        /// <summary>
        /// Displays a new form for displaying all of the objects that have been serialized when the "Display
        /// Orders" button
        /// </summary>
        /// <param name="sender">Represents the "CookieSource" form</param>
        /// <param name="e">Represents the event that occured</param>
        void Display_Click(object sender, EventArgs e)
        {
            // Checks if there are any orders to display
            if (ordList.Count > 0)
            {
                DisplayOrders disord = new DisplayOrders
                {
                    Height = 750
                };
                disord.ShowDialog();    // displays the new form
            }
            else
            {
                MessageBox.Show("There are currently no orders to display", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Displays a message box that is used to determine if the form should be closed when the "Exit" button is 
        /// clicked
        /// </summary>
        /// <param name="sender">Represents the form that contains the "Exit" button</param>
        /// <param name="e">Represents the event that occured</param>
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
                    
                    // Checks if there are any orders that can be saved
                    if (ordList.Count > 0)
                    {
                        SaveOrders();
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
        /// Asks the user if they want to save the orders and determines if orders should be saved
        /// </summary>
        void SaveOrders()
        {
            bool valid = false;

            // Validation loop
            while (!valid)
            {
                DialogResult result = MessageBox.Show("Do you wish to save orders?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Checks which button was pressed
                if (result != DialogResult.Yes && result != DialogResult.No)
                {
                    MessageBox.Show("Unknown button was pressed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result == DialogResult.Yes)
                {
                    SerialOrders();
                    valid = true;
                }
                else
                {
                    valid = true;
                }
            }
        }

        /// <summary>
        /// Used to serialize Order objects into the file "orders.ser"
        /// </summary>
        void SerialOrders()
        {
            try
            {
                FileStream outFile = new FileStream("orders.ser", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();

                // Serialization Loop
                foreach (var ord in ordList)
                {
                    bf.Serialize(outFile, ord); // calls the GetObjectData() method in the Order class
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