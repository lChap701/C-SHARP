using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace ListExample
{
    public partial class Form1 : Form
    {
        public static List<Object> bookList = new List<Object>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Book b = new Book(txtTitle.Text,
                              Convert.ToInt32(txtPages.Text),
                              Convert.ToDouble(txtPrice.Text));
            bookList.Add(b);
            txtTitle.Focus();
            txtTitle.SelectAll();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you wish write these books to the file", 
                "Write To File", MessageBoxButtons.YesNo, MessageBoxIcon.Hand, 
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    FileStream outFile = new FileStream("booklist.ser",
                         FileMode.Create, FileAccess.Write);
                    BinaryFormatter bf = new BinaryFormatter();

                    foreach (var item in bookList)
                    {
                        bf.Serialize(outFile, item);
                    }
                    outFile.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error writing list to file " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("New items not written");
            }
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpPubDate.MinDate = DateTime.Now;
            try
            {
                if (File.Exists("booklist.ser"))
                {
                    FileStream inFile = new FileStream("booklist.ser",
                        FileMode.Open, FileAccess.Read);
                    BinaryFormatter bFormatter = new BinaryFormatter();                    

                    //copy invoices from the file to the invoiceList
                    while (inFile.Position < inFile.Length)
                    {
                        /* use this logic if only a single object type is in the file                        
                        Book book = (Book)bFormatter.Deserialize(inFile);
                        Form1.bookList.Add(book);                        
                        */
                        //use this logic if multiple object types are in the file
                        object obj = bFormatter.Deserialize(inFile);
                        if (obj.GetType() == typeof(Book))
                        {
                            Form1.bookList.Add((Book)obj);
                        }
                        else
                        {
                            //additional logic if other types of objects are involved
                        }
                    }
                    inFile.Close();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening file, program terminating" + ex.Message);
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            DisplayForm df = new DisplayForm();
            df.ShowDialog();
        }

        private void txtPages_KeyPress(object sender, KeyPressEventArgs e)
       {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && 
                (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        //private void dtpPubDate_ValueChanged(object sender, EventArgs e)
        //{
        //    DateTime newDate;
        //    newDate = dtpPubDate.Value.AddDays(3);

        //    MessageBox.Show(newDate.ToShortDateString());
        //}
    }
}
