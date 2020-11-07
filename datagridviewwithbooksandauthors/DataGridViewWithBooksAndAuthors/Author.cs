/* this is an example of Composition - 
 * one class contains an object of another class 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridViewWithBooksAndAuthors
{
    public class Author : ITotalable
    {
        public string AuthID { get; set; }

        public string AuthName { get; set; }

        public List<Book> AuthBooks { get; set; }
              

        public Author(string id, string name)
        {
            AuthID = id;
            AuthName = name;
        }

        public Author(string id, string name, List<Book> b)
        {
            AuthID = id;
            AuthName = name;
            AuthBooks = b;
        }

        //interface method implemented
        public double CalcTotal()
        {
            // Language Integreated Query (LINQ)
            double total = (from books in AuthBooks
                            select books.Price).Sum();

            return total;
        }

       
    }
}
