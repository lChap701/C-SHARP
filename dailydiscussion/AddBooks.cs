using static System.Console;
class AddBooks
{
    static void Main()
    {
        Book book1 = new Book("Silas Marner", 350, 15.95);
        Book book2 = new Book("Moby Dick", 250, 16.00);
        // Book book3;   // creates a refrence to use
        //Book book3 = book1 + book2;
        Book book3 = book1 - book2;
        WriteLine("The new book is \"{0}\"", book3.Title);
        WriteLine("It has {0} pages and costs {1}",
           book3.NumPages, book3.Price.ToString("C"));
        ReadLine();
    }
}
class Book
{
    public Book(string title, int pages, double price)
    {
        Title = title;
        NumPages = pages;
        Price = price;
    }
    public static Book operator +(Book first, Book second)  // overloading operators
    {
        // Book newBook;
        const double EXTRA = 10.00;
        string newTitle = first.Title + " and " +
           second.Title;
        int newPages = first.NumPages + second.NumPages;
        double newPrice;
        if (first.Price > second.Price)
            newPrice = first.Price + EXTRA;
        else
            newPrice = second.Price + EXTRA;
        // newBook = new Book(newTitle, newPages, newPrice);
        return (new Book(newTitle, newPages, newPrice));
    }
    /// <summary>
    /// Example of creating rules for overloading "-" operator. In this case, it returns the a new book with the first 
    /// book's title and price, and then the pages minus the second book
    /// </summary>
    /// <param name="first"></param>
    /// <param name="second"></param>
    /// <returns>Book</returns>
    public static Book operator -(Book first, Book second)  // overloading operators
    {
        return (new Book(first.Title, first.NumPages - second.NumPages, first.Price));
    }
    public string Title { get; set; }

    public int NumPages { get; set; }

    public double Price { get; set; }
}
