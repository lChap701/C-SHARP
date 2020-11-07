using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewWithBooksAndAuthors
{
    public partial class Form1 : Form
    {        

        public static List<Author> authList = new List<Author>();

        public Form1()
        {
            InitializeComponent();           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //build a list of Authors and their Books
            //Stephen King
            authList.Add(new Author("111", "Stephen King"));
            authList[0].AuthBooks = new List<Book>();
            authList[0].AuthBooks.Add(new Book("Cujo", 300, 25.99));
            authList[0].AuthBooks.Add(new Book("Christine", 350, 19.00));

            //John Steinbeck
            authList.Add(new Author("222", "John Steinbeck"));
            authList[1].AuthBooks = new List<Book>() {new Book("Of Mice and Men", 200, 5.99),
                                                      new Book("East of Eden", 150, 7.50),
                                                    new Book("West of Eden", 150, 7.50),
                                                    new Book("North of Eden", 150, 7.50),
                                                    new Book("South of Eden", 150, 7.50) };

            //John Grisham
            List<Book> grishamList = new List<Book>();
            grishamList.Add(new Book("The Firm", 210, 6.99));
            grishamList.Add(new Book("The Testament", 320, 8.99));

            authList.Add(new Author("333", "John Grisham", grishamList));
            

            //add the Author ID's to the listbox on the form
            foreach (var item in authList)
            {
                listAuthors.Items.Add(item.AuthID);
            }

            listAuthors.SelectedIndex = 0;
           
        }



        //each time a different author is selected:
        //  1. Clear the rows of the DataGridView
        //  2. Build rows for the DataGridView for each of the author's books
        private void lstAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 0;
            dgvBooks.Rows.Clear();

            foreach (var item in authList[listAuthors.SelectedIndex].AuthBooks)
            {
                dgvBooks.Rows.Add();
                dgvBooks.Rows[i].Cells[0].Value = item.Title;
                dgvBooks.Rows[i].Cells[1].Value = item.NumPages;
                dgvBooks.Rows[i].Cells[2].Value = item.Price.ToString("f2");
                i++;
            }

            //calculate total and display for each author's list of books
            txtPriceTotal.Text = authList[listAuthors.SelectedIndex].CalcTotal().ToString("c");
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ////when user saves changes to the Book data for an Author
        //// 1. Clear the Book data currently for that Author (or instantiate a new empty list)
        //// 2. Re-create the Book data for that Author from the DataGridView 
        private void btnSave_Click(object sender, EventArgs e)
        {
            //authList[listAuthors.SelectedIndex].AuthBooks.Clear();            //either remove the books from the selected author, OR
            authList[listAuthors.SelectedIndex].AuthBooks = new List<Book>();   //allocate a new book list for that author

            foreach (DataGridViewRow dr in dgvBooks.Rows)
            {
                if (dr.Cells[0].Value != null)  //to avoid processing past the last datagridview row
                {
                    string t = dr.Cells[0].Value.ToString();
                    int n = Convert.ToInt32(dr.Cells[1].Value);
                    double p = Convert.ToDouble(dr.Cells[2].Value);
                    Book b = new Book(t, n, p);

                    authList[listAuthors.SelectedIndex].AuthBooks.Add(b);
                }

            }

        }


    }
}
