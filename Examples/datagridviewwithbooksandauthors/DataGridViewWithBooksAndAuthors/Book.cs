using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridViewWithBooksAndAuthors
{
    public class Book
    {
        public string Title { get; set; }

        public int NumPages { get; set; }

        public double Price { get; set; }

        public Book(string title, int pages, double price)
        {
            Title = title;
            NumPages = pages;
            Price = price;
        }
    }
}
