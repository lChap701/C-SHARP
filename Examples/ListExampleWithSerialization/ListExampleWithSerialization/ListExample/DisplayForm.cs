using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ListExample
{
    public partial class DisplayForm : Form
    {
        public DisplayForm()
        {
            InitializeComponent();
        }

        private void DisplayForm_Load(object sender, EventArgs e)
        {
            List<Book> sortedBooks = new List<Book>();

            foreach (var item in Form1.bookList)
            {
                sortedBooks.Add((Book)item);              
            }

            sortedBooks.Sort();
            sortedBooks.Reverse();

            foreach (var item in sortedBooks)
            {
                displayLabel.Text +=
                    item.Title.PadRight(20) +
                    item.NumPages.ToString().PadLeft(4) +
                    item.Price.ToString("c").PadLeft(10) +
                    Environment.NewLine;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
